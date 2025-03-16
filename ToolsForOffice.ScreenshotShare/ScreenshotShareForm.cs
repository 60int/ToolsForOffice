using Sunny.UI;
using System.Text;
using ToolsForOffice.Shared;
using System.Runtime.InteropServices;
using ToolsForOffice.ScreenshotShare.Forms;

namespace ToolsForOffice.ScreenshotShare
{
    public partial class ScreenshotShareForm : UIForm
    {
        #region Fields and Properties

        FileSystemWatcher watcher = new();

        private readonly CancellationTokenSource cts = new();

        private static string GetUser()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filePath = Path.Combine(desktopPath, "DailyTasks", "DailyTasks-MyUser.txt");
            string username = File.ReadAllText(filePath);
            return username;
        }

        private static string GetFolder()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filePath = Path.Combine(desktopPath, "DailyTasks", "DailyTasks-MyFolder.bin");
            string folderPath;
            using (var binaryReader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                folderPath = binaryReader.ReadString();
            }
            return folderPath + @"\";
        }

        private SelectedTheme? _cachedSelectedTheme;

        #endregion

        private void LoadTheme()
        {
            if (_cachedSelectedTheme == null)
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string filePath = Path.Combine(desktopPath, "DailyTasks", "DailyTasks-ToolsTheme.bin");
                _cachedSelectedTheme = SelectedTheme.Load(filePath);
            }

            switch (_cachedSelectedTheme.CurrentTheme)
            {
                case Theme.Cloud:
                    UIStyles.InitColorful(Color.SteelBlue, Color.White);
                    AlwaysOnCheckBox.BackColor = Color.SteelBlue;
                    AlwaysOnCheckBox.CheckBoxColor = Color.White;
                    break;
                case Theme.Summer:
                    UIStyles.InitColorful(Color.Green, Color.White);
                    AlwaysOnCheckBox.BackColor = Color.Green;
                    AlwaysOnCheckBox.CheckBoxColor = Color.White;
                    break;
                case Theme.Spring:
                    UIStyles.InitColorful(Color.LightPink, Color.Black);
                    AlwaysOnCheckBox.BackColor = Color.LightPink;
                    AlwaysOnCheckBox.CheckBoxColor = Color.White;
                    break;
                case Theme.Fall:
                    UIStyles.InitColorful(Color.Orange, Color.Black);
                    AlwaysOnCheckBox.BackColor = Color.Orange;
                    AlwaysOnCheckBox.CheckBoxColor = Color.White;
                    break;
                case Theme.Snow:
                    UIStyles.InitColorful(Color.LightBlue, Color.Black);
                    AlwaysOnCheckBox.BackColor = Color.LightBlue;
                    AlwaysOnCheckBox.CheckBoxColor = Color.White;
                    break;
                case Theme.Default:
                    AlwaysOnCheckBox.ForeColor = Color.FromArgb(48, 48, 48);
                    break;
            }
        }

        public ScreenshotShareForm()
        {
            InitializeComponent();
            GetFolder();
            CreateFileSystemWatcher();
            LoadTheme();
            AlwaysOnCheckBox.Location = new Point(165, 1);
            ThemeChangedEventManager.ThemeChanged += OnThemeChanged!;
        }

        private void CreateFileSystemWatcher()
        {
            watcher = new FileSystemWatcher
            {
                Path = GetFolder(),
                NotifyFilter = NotifyFilters.FileName | NotifyFilters.Size,
                Filter = "*.jpg"
            };
            watcher.Created += new FileSystemEventHandler(OnImageCreated);
            watcher.EnableRaisingEvents = true;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm form = new();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Application.Restart();
            }
            else
            {
                return;
            }
        }

        private void CaptureButton_Click(object sender, EventArgs e)
        {
            // Get the bounds of the primary screen
            Rectangle bounds = Screen.PrimaryScreen!.Bounds;

            // Create a bitmap with the same dimensions as the screen
            using var bitmap = new Bitmap(bounds.Width, bounds.Height);

            // Copy the screen to the bitmap
            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
            }

            // Copy the bitmap to the clipboard
            Clipboard.SetImage(bitmap);

            ShowInfoTip("Image captured!");
        }

        #region Share Image Function

        private delegate void UpdateImageDelegate(string notification);

        private void ImageAlert(string notification)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new UpdateImageDelegate(ImageAlert), new object[] { notification });
                return;
            }
            Notification.Classes.Notification.ShowInformation(notification, 5000);
        }

        private async void OnImageCreated(object sender, FileSystemEventArgs e)
        {
            try
            {
                watcher.EnableRaisingEvents = false;
                await ProcessAsync(cts.Token);
            }
            finally
            {
                watcher.EnableRaisingEvents = true;
            }
        }

        public static FileInfo GetNewestFile(DirectoryInfo directory)
        {
            return directory.GetFiles()
                .OrderByDescending(f => f.LastWriteTime)
                .FirstOrDefault()!;
        }

        private async Task ProcessAsync(CancellationToken cancellationToken)
        {
            FileInfo newestFile = GetNewestFile(new DirectoryInfo(GetFolder()));
            if (!File.Exists(newestFile.FullName))
            {
                return;
            }
            string alert = $"{newestFile.Name.Split(" - ").FirstOrDefault()!} sent an image";
            await Task.Run(() => ImageAlert(alert), cancellationToken);
        }

        private void ShareButton_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject() is IDataObject data && data.GetDataPresent(DataFormats.Bitmap))
            {
                if (data.GetData(DataFormats.Bitmap, true) is Image image)
                {
                    using Bitmap bm = new(image);
                    StringBuilder fileNameBuilder = new();
                    fileNameBuilder.Append(GetFolder());
                    fileNameBuilder.Append(GetUser());
                    fileNameBuilder.Append(" - ");
                    fileNameBuilder.Append(DateTime.Now.ToString("MMdd-HH-mm-ss"));
                    fileNameBuilder.Append(".jpg");

                    using var fileStream = new FileStream(fileNameBuilder.ToString(), FileMode.Create);
                    using var bufferedStream = new BufferedStream(fileStream);
                    bm.Save(bufferedStream, System.Drawing.Imaging.ImageFormat.Jpeg);

                    ShowInfoTip("Image shared!");
                }
            }
            else
            {
                ShowErrorTip("The Data In Clipboard is not in image format!");
            }
        }

        #endregion

        //Keep window on top always

        #region Window always on top function

        [DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        const uint SWP_NOMOVE = 0x0002;
        const uint SWP_NOSIZE = 0x0001;
        private void AlwaysOnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AlwaysOnCheckBox.Checked)
            {
                // Turn on WS_EX_TOPMOST
                SetWindowPos(Handle, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
            }
            else
            {
                // Turn off WS_EX_TOPMOST
                SetWindowPos(Handle, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
            }
        }

        #endregion

        private void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            // Clear the cached value of _cachedSelectedTheme
            _cachedSelectedTheme = null;
        }
    }
}