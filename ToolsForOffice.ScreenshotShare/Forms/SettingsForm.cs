using Sunny.UI;
using ToolsForOffice.Shared;

namespace ToolsForOffice.ScreenshotShare.Forms
{
    public partial class SettingsForm : UIForm
    {
        private readonly Settings _settings;
        private readonly string _originalSelectedPath;

        private SelectedTheme? _cachedSelectedTheme;

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
                    break;
                case Theme.Summer:
                    UIStyles.InitColorful(Color.Green, Color.White);
                    break;
                case Theme.Spring:
                    UIStyles.InitColorful(Color.LightPink, Color.Black);
                    break;
                case Theme.Fall:
                    UIStyles.InitColorful(Color.Orange, Color.Black);
                    break;
                case Theme.Snow:
                    UIStyles.InitColorful(Color.LightBlue, Color.Black);
                    break;
                case Theme.Default:
                    break;
            }
        }

        public SettingsForm()
        {
            InitializeComponent();

            _settings = new Settings();
            _settings.Load();
            _originalSelectedPath = _settings.SelectedPath!;

            UserNameTextBox.Text = _settings.UserName;
            FolderLabel.Text = FormatFolderPath(_settings.SelectedPath!);
            LoadTheme();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will restart the application", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _settings.UserName = UserNameTextBox.Text;

                _settings.Save();
            }
        }

        private void ChangeFolderButton_Click(object sender, EventArgs e)
        {
            using var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                _settings.SelectedPath = folderBrowserDialog.SelectedPath;
                FolderLabel.Text = FormatFolderPath(_settings.SelectedPath);
                _settings.Save();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _settings.SelectedPath = _originalSelectedPath;
            _settings.Save();
        }

        private static string FormatFolderPath(string path)
        {
            string[] folders = path.Split('\\');
            if (folders.Length > 4)
            {
                string shortenedPath = string.Join("\\", folders.Take(2)) + "\\...\\"
                    + string.Join("\\", folders.Skip(folders.Length - 3));
                if (shortenedPath.Length >= 35)
                {
                    shortenedPath = shortenedPath.Insert(35, "\n");
                }
                return shortenedPath;
            }
            return path;
        }
    }
}
