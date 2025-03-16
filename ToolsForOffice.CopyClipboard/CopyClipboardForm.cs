using Sunny.UI;
using System.Text;
using System.Reflection;
using ToolsForOffice.Shared;
using ToolsForOffice.CopyClipboard.Properties;

namespace ToolsForOffice.CopyClipboard
{
    public partial class CopyClipboardForm : UIForm
    {
        #region Data

        static readonly List<TextCell> textCells = new();

        readonly static string ClipboardFile = "Daily Tasks/Settings/CopyClipboard.txt";

        readonly static string MacroFiles = "Daily Tasks/Settings/";

        FileSystemWatcher watcher = new();

        private readonly CancellationTokenSource cts = new();

        private string? _cachedUsername;

        private SelectedTheme? _cachedSelectedTheme;

        private Theme _currentTheme;

        #endregion

        #region Graphics

        Graphics? Canvas;
        Random? rnd;

        Effect[]? Effects;

        readonly int CloudCount = 50;
        readonly int SnowflakeCount = 300;
        readonly int GreenLeafCount = 100;

        bool isCloud;
        bool isSummer;
        bool isSpring;
        bool isFall;
        bool isSnow;

        readonly Bitmap cloud = new(Resources.SingleCloud64);
        readonly Bitmap snow = new(Resources.SingleSnowflake16);
        readonly Bitmap spring = new(Resources.SingleSpringLeaf16);
        readonly Bitmap summer = new(Resources.SingleGreenLeaf16);
        readonly Bitmap fall = new(Resources.SingleAutumnLeaf16);

        #endregion

        private string GetUser()
        {
            if (string.IsNullOrEmpty(_cachedUsername))
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string filePath = Path.Combine(desktopPath, "DailyTasks", "DailyTasks-MyUser.txt");
                _cachedUsername = File.ReadAllText(filePath);
            }
            return _cachedUsername;
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
            return folderPath + "/";
        }

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
                    StartCloud();
                    isCloud = true;
                    break;
                case Theme.Summer:
                    StartSummer();
                    isSummer = true;
                    break;
                case Theme.Spring:
                    StartSpring();
                    isSpring = true;
                    break;
                case Theme.Fall:
                    StartFall();
                    isFall = true;
                    break;
                case Theme.Snow:
                    StartSnow();
                    isSnow = true;
                    break;
                case Theme.Default:
                    MainPictureBox.BackColor = Color.White;
                    break;
            }
        }

        private static void ReadText()
        {
            using StreamReader reader = new(ClipboardFile, Encoding.UTF8);
            while (!reader.EndOfStream)
            {
                textCells.Add(new TextCell(reader.ReadLine()));
            }
            reader.Close();
        }

        private static void WriteDefaultTextToFile()
        {
            if (!File.Exists(ClipboardFile))
            {
                StringBuilder sb = new();
                // Read the names of the first 8 files in the MacroFiles directory
                string[] macroFiles = Directory.GetFiles(MacroFiles).Take(8).ToArray();
                for (int i = 1; i <= 8; i++)
                {
                    if (i == 7)
                    {
                        sb.Append("Macros & Other");
                    }
                    else
                    {
                        sb.Append($"Drop Down item {i}");
                    }
                    for (int j = 1; j <= 8; j++)
                    {
                        if (j == 7 && i <= macroFiles.Length)
                        {
                            sb.Append($",{Path.GetFileNameWithoutExtension(macroFiles[i - 1])}");
                        }
                        else
                        {
                            sb.Append($",New Item (column {j}/{i})");
                        }
                    }
                    sb.AppendLine();
                }

                using StreamWriter writer = new(ClipboardFile, false, Encoding.UTF8);
                writer.Write(sb.ToString());
            }
        }

        public CopyClipboardForm()
        {
            InitializeComponent();
            try
            {

                string MainFolder = $"Daily Tasks/";
                string SettingsFolder = $"Daily Tasks/Settings/";
                string ImageFolder = $"Daily Tasks/Images/";
                string[] directories = { MainFolder, SettingsFolder, ImageFolder };
                foreach (string directory in directories)
                {
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while creating directories: " + ex.Message);
            }

            CreateFileSystemWatcher();

            LoadTheme();

            if (File.Exists(ClipboardFile))
            {
                MainComboBox.DataSource = null;
                MainComboBox.Items.Clear();

                if (textCells.Count == 0)
                {
                    ReadText();
                }

                MainComboBox.DataSource = textCells;
                MainComboBox.SelectedIndex = 0;

                #region Visuals / UI

                MaximizeBox = false;

                MainLabel.Visible = false;
                CopyLabel.Visible = false;
                SkinsButton.Visible = true;
                SkinsButton.Enabled = true;
                CancelButton.Visible = false;

                SetButtonVisibility(false);

                if (isCloud)
                {
                    UIStyles.InitColorful(Color.SteelBlue, Color.White);
                }
                else if (isSummer)
                {
                    UIStyles.InitColorful(Color.Green, Color.White);
                }
                else if (isSpring)
                {
                    UIStyles.InitColorful(Color.LightPink, Color.White);
                }
                else if (isFall)
                {
                    UIStyles.InitColorful(Color.Orange, Color.White);
                }
                else if (isSnow)
                {
                    UIStyles.InitColorful(Color.LightBlue, Color.White);
                }
                else
                {
                    UIStyles.InitColorful(Color.FromArgb(48, 48, 48), Color.White);
                }


                CameraButton.BringToFront();

                #endregion
            }
            else
            {
                WriteDefaultTextToFile();

                switch (MessageBox.Show("Text file is corrupted or doesn't exist! Do you want to create a new one?", "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        MessageBox.Show("Text file created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Environment.Exit(0);
                        break;
                    case DialogResult.Cancel:
                        Environment.Exit(0);
                        break;
                    case DialogResult.No:
                        Environment.Exit(0);
                        break;
                }
            }
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

        private void MainComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (MainComboBox.SelectedIndex == 6)
                {
                    string[] macroFiles = Directory.GetFiles(MacroFiles);

                    MainListBox.Items.Clear();

                    foreach (string file in macroFiles)
                    {
                        MainListBox.Items.Add(Path.GetFileNameWithoutExtension(file));
                    }
                }
                else
                {
                    PropertyInfo[] properties = new PropertyInfo[] { typeof(TextCell).GetProperty("ColOne")!, typeof(TextCell).GetProperty("ColTwo")!, typeof(TextCell).GetProperty("ColThree")!,
                typeof(TextCell).GetProperty("ColFour")!,typeof(TextCell).GetProperty("ColFive")!, typeof(TextCell).GetProperty("ColSix")!, typeof(TextCell).GetProperty("ColSeven")!,  typeof(TextCell).GetProperty("ColEight")!};

                    PropertyInfo selectedProperty = properties[MainComboBox.SelectedIndex];

                    MainListBox.Items.Clear();

                    foreach (TextCell item in textCells)
                    {
                        MainListBox.Items.Add(selectedProperty.GetValue(item)!);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt, indítsd újra a programot." + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (MainListBox.SelectedIndex != -1)
                {
                    if (MainComboBox.SelectedIndex == 6)
                    {
                        string filePath = Path.Combine(MacroFiles, MainListBox.Text + ".txt");
                        string macroText = File.ReadAllText(filePath);
                        MainLabel.Text = MainListBox.Text;
                        Clipboard.SetText(macroText);
                    }
                    else
                    {
                        MainLabel.Text = MainListBox.Text;
                        Clipboard.SetText(MainLabel.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt, indítsd újra a programot." + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainListBox_Click(object sender, EventArgs e)
        {
            CopyTimer.Interval = 1000;
            CopyTimer.Start();
            MainLabel.Visible = true;
            CopyLabel.Visible = true;
            GC.Collect();
        }

        private void CopyTimer_Tick(object sender, EventArgs e)
        {
            CopyTimer.Stop();
            MainLabel.Visible = false;
            CopyLabel.Visible = false;
        }

        #region All Animations

        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            MainPictureBox.Invalidate();
        }

        private void MakeCloud()
        {
            float addSpeed = 2 + (float)rnd!.NextDouble();

            for (int i = 0; i < CloudCount; i++)
            {
                Effects![i] = new Effect(rnd!.Next(-100, 550), rnd!.Next(0, 580), addSpeed, rnd!.Next(16, 64), 1, cloud);
            }
        }
        private void MakeSnow()
        {
            float addSpeed = 2 + (float)rnd!.NextDouble();

            for (int i = 0; i < SnowflakeCount; i++)
            {
                Effects![i] = new Effect(rnd!.Next(-100, 550), rnd!.Next(0, 580), addSpeed * 0.7f, rnd!.Next(8, 16), 1, snow);
            }
        }
        private void MakeSpring()
        {
            float addSpeed = 2 + (float)rnd!.NextDouble() + (float)rnd!.NextDouble() + (float)rnd!.NextDouble();

            for (int i = 0; i < SnowflakeCount; i++)
            {
                Effects![i] = new Effect(rnd!.Next(-100, 550), rnd!.Next(0, 580), addSpeed * 0.5f, rnd!.Next(8, 32), 1, spring);
            }
        }
        private void MakeSummer()
        {
            float addSpeed = 2 + (float)rnd!.NextDouble() + (float)rnd!.NextDouble() + (float)rnd!.NextDouble();

            for (int i = 0; i < GreenLeafCount; i++)
            {
                Effects![i] = new Effect(rnd!.Next(-100, 550), rnd!.Next(0, 580), addSpeed * 0.5f, rnd!.Next(8, 16), 1, summer);
            }
        }
        private void MakeAutumn()
        {
            float addSpeed = 2 + (float)rnd!.NextDouble() + (float)rnd!.NextDouble() + (float)rnd!.NextDouble();

            for (int i = 0; i < SnowflakeCount; i++)
            {
                Effects![i] = new Effect(rnd!.Next(-100, 550), rnd!.Next(0, 580), addSpeed * 0.5f, rnd!.Next(8, 16), 1, fall);
            }
        }
        private void StartSnow()
        {
            rnd = new Random();

            Bitmap myBitmap = new(Width, Height);

            MainPictureBox.Image = myBitmap;

            Canvas = Graphics.FromImage(MainPictureBox.Image);
            Effects = new Effect[SnowflakeCount];
            MakeSnow();
        }
        private void StartSpring()
        {
            rnd = new Random();

            Bitmap myBitmap = new(Width, Height);

            MainPictureBox.Image = myBitmap;

            Canvas = Graphics.FromImage(MainPictureBox.Image);
            Effects = new Effect[SnowflakeCount];
            MakeSpring();
        }
        private void StartSummer()
        {
            rnd = new Random();

            Bitmap myBitmap = new(Width, Height);

            MainPictureBox.Image = myBitmap;

            Canvas = Graphics.FromImage(MainPictureBox.Image);
            Effects = new Effect[GreenLeafCount];
            MakeSummer();
        }
        private void StartFall()
        {
            rnd = new Random();

            Bitmap myBitmap = new(Width, Height);

            MainPictureBox.Image = myBitmap;

            Canvas = Graphics.FromImage(MainPictureBox.Image);
            Effects = new Effect[SnowflakeCount];
            MakeAutumn();
        }
        private void StartCloud()
        {
            rnd = new Random();

            Bitmap myBitmap = new(Width, Height);

            MainPictureBox.Image = myBitmap;

            Canvas = Graphics.FromImage(MainPictureBox.Image);
            Effects = new Effect[CloudCount];
            MakeCloud();
        }

        private void MainPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Canvas?.Clear(Color.White);

            if (isSnow)
            {
                for (int i = 0; i < SnowflakeCount; i++)
                {
                    Canvas!.DrawImage(Effects![i].Img, Effects[i].X, Effects[i].Y, Effects[i].Size, Effects[i].Size);

                    Effects[i].Time += 0.9f;

                    if (Effects[i].Y > 600)
                    {
                        Effects[i].Y = -25;
                        Effects[i].Time = 0;
                    }
                    if (Effects[i].X > 580 & Effects[i].X < -5)
                    {
                        Effects[i].X = rnd!.Next(0, 580);
                    }
                    else
                    {
                        Effects[i].Y += Effects[i].Speed + rnd!.Next(-1, 0);
                    }
                }
            }
            else if (isCloud)
            {
                for (int i = 0; i < CloudCount; i++)
                {
                    Canvas!.DrawImage(Effects![i].Img, Effects[i].X, Effects[i].Y, Effects[i].Size, Effects[i].Size);

                    Effects[i].Time += 0.9f;

                    if (Effects[i].X > 700)
                    {
                        Effects[i].X = -25;
                        Effects[i].Time = 0;
                    }
                    if (Effects[i].Y > 580 & Effects[i].Y < -5)
                    {
                        Effects[i].Y = rnd!.Next(0, 580);
                    }
                    else
                    {
                        Effects[i].X += Effects[i].Speed + rnd!.Next(-1, 0);
                    }
                }
            }
            else if (isFall)
            {
                for (int i = 0; i < SnowflakeCount; i++)
                {
                    Canvas!.DrawImage(Effects![i].Img, Effects[i].X, Effects[i].Y, Effects[i].Size, Effects[i].Size);

                    Effects[i].Time += 0.9f;
                    Effects[i].X += (float)Math.Sin(Effects[i].Time) * 2;

                    if (Effects[i].Y > 600)
                    {
                        Effects[i].Y = -15;
                        Effects[i].Time = 0;
                    }
                    if (Effects[i].X > 580 & Effects[i].X < -5)
                    {
                        Effects[i].X = rnd!.Next(0, 580);
                    }
                    else
                    {
                        Effects[i].Y += Effects[i].Speed + rnd!.Next(-1, 0);
                    }
                }
            }
            else if (isSpring)
            {
                for (int i = 0; i < SnowflakeCount; i++)
                {
                    Canvas!.DrawImage(Effects![i].Img, Effects[i].X, Effects[i].Y, Effects[i].Size, Effects[i].Size);

                    Effects[i].Time += 0.2f;

                    if (Effects[i].Y > 600)
                    {
                        Effects[i].Y = -15;
                        Effects[i].Time = 0;
                    }
                    if (Effects[i].X > 580 & Effects[i].X < -5)
                    {
                        Effects[i].X = rnd!.Next(0, 580);
                    }
                    else
                    {
                        Effects[i].Y += Effects[i].Speed + rnd!.Next(-1, 0);
                    }
                }
            }
            else if (isSummer)
            {
                for (int i = 0; i < GreenLeafCount; i++)
                {
                    Canvas!.DrawImage(Effects![i].Img, Effects[i].X, Effects[i].Y, Effects[i].Size, Effects[i].Size);

                    Effects[i].Time += 0.2f;

                    if (Effects[i].Y > 600)
                    {
                        Effects[i].Y = -15;
                        Effects[i].Time = 0;
                    }
                    if (Effects[i].X > 580 & Effects[i].X < -5)
                    {
                        Effects[i].X = rnd!.Next(0, 580);
                    }
                    else
                    {
                        Effects[i].Y += Effects[i].Speed + rnd!.Next(-1, 0);
                    }
                }
            }
        }

        #endregion

        #region Skin Buttons

        private void SetButtonVisibility(bool visible)
        {
            foreach (var button in new[] { CloudButton, SnowButton, SpringButton, SummerButton, FallButton })
            {
                button.Visible = visible;
            }
        }

        private void SetTheme(Theme theme)
        {
            // Only save the theme and start the animation if the theme has changed
            if (theme != _currentTheme)
            {
                SaveSelectedTheme(theme);
                ThemeChangedEventManager.OnThemeChanged(theme);
                StartAnimationForTheme(theme);
                _currentTheme = theme;
            }

            UpdateUIForTheme(theme);
        }

        private static void SaveSelectedTheme(Theme theme)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filePath = Path.Combine(desktopPath, "DailyTasks", "DailyTasks-ToolsTheme.bin");
            SelectedTheme selectedTheme = new(theme);
            selectedTheme.Save(filePath);
        }

        private void UpdateUIForTheme(Theme theme)
        {
            isCloud = (theme == Theme.Cloud);
            isSummer = (theme == Theme.Summer);
            isSpring = (theme == Theme.Spring);
            isFall = (theme == Theme.Fall);
            isSnow = (theme == Theme.Snow);

            MainPictureBox.Invalidate();
            SkinsButton.Visible = true;
            SkinsButton.Enabled = true;

            CancelButton.Visible = false;
            SetButtonVisibility(false);
        }

        private void StartAnimationForTheme(Theme theme)
        {
            switch (theme)
            {
                case Theme.Cloud:
                    StartCloud();
                    break;
                case Theme.Summer:
                    StartSummer();
                    break;
                case Theme.Spring:
                    StartSpring();
                    break;
                case Theme.Fall:
                    StartFall();
                    break;
                case Theme.Snow:
                    StartSnow();
                    break;
                case Theme.Default:
                    break;
            }
        }

        private void SkinsButton_Click(object sender, EventArgs e)
        {
            SkinsButton.Visible = false;
            SkinsButton.Enabled = false;
            CancelButton.Visible = true;
            SetButtonVisibility(true);
        }

        private void CloudButton_Click(object sender, EventArgs e)
        {
            SetTheme(Theme.Cloud);
            UIStyles.InitColorful(Color.SteelBlue, Color.White);
        }

        private void SummerButton_Click(object sender, EventArgs e)
        {
            SetTheme(Theme.Summer);
            UIStyles.InitColorful(Color.Green, Color.White);
        }

        private void SpringButton_Click(object sender, EventArgs e)
        {
            SetTheme(Theme.Spring);
            UIStyles.InitColorful(Color.LightPink, Color.White);
        }

        private void FallButton_Click(object sender, EventArgs e)
        {
            SetTheme(Theme.Fall);
            UIStyles.InitColorful(Color.Orange, Color.White);
        }

        private void SnowButton_Click(object sender, EventArgs e)
        {
            SetTheme(Theme.Snow);
            UIStyles.InitColorful(Color.LightBlue, Color.White);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            SetTheme(Theme.Default);
            SaveSelectedTheme(Theme.Default);
            UIStyles.InitColorful(Color.FromArgb(48, 48, 48), Color.White);


            isCloud = false;
            isSpring = false;
            isSummer = false;
            isFall = false;
            isSnow = false;

            MainPictureBox.Invalidate();
            SkinsButton.Visible = true;
            SkinsButton.Enabled = true;

            CancelButton.Visible = false;
            SetButtonVisibility(false);
        }

        #endregion

        #region Share Image Function / Threading

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
                var attributes = File.GetAttributes(e.FullPath);
                if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden || (attributes & FileAttributes.System) == FileAttributes.System || Path.GetExtension(e.FullPath) != ".jpg")
                {
                    return;
                }
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
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("OnImage error", "Error" + ex);
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

        private void CameraButton_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject() is IDataObject data && data.GetDataPresent(DataFormats.Bitmap))
            {
                if (data.GetData(DataFormats.Bitmap, true) is Image image)
                {
                    Bitmap bm = new(image);
                    bm.Save(GetFolder() + $"{GetUser()} - {DateTime.Now:MMdd-HH-mm-ss}.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    ShowInfoTip("Image captured and saved!");
                }
            }
            else
            {
                ShowErrorTip("The Data In Clipboard is not in image format!");
            }
        }

        #endregion

        //Keep window on top always
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 8;  // Turn on WS_EX_TOPMOST
                return cp;
            }
        }
    }
}