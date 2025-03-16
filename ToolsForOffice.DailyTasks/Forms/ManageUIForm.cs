using Sunny.UI;
using ToolsForOffice.Shared;

namespace ToolsForOffice.DailyTasks.Forms
{
    public partial class ManageUIForm : UIForm
    {
        private SelectedTheme? _cachedSelectedTheme;

        private Theme _currentTheme;

        private void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            _cachedSelectedTheme = null;
        }

        private void LoadTheme()
        {
            if (_cachedSelectedTheme == null)
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string filePath = Path.Combine(desktopPath, "DailyTasks", "DailyTasks-MenuTheme.bin");
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
                    UIStyles.InitColorful(Color.LightBlue, Color.White);
                    break;
                case Theme.Default:
                    UIStyles.InitColorful(Color.FromArgb(48, 48, 48), Color.White);
                    break;
            }
        }
        public ManageUIForm()
        {
            InitializeComponent();
            LoadTheme();
            BackColor = Color.White;
            rectColor = Color.White;
        }

        private void SetTheme(Theme theme)
        {
            // Only save the theme and start the animation if the theme has changed
            if (theme != _currentTheme)
            {
                SaveSelectedTheme(theme);
                ThemeChangedEventManager.OnThemeChanged(theme);
                _currentTheme = theme;
            }
        }

        private static void SaveSelectedTheme(Theme theme)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filePath = Path.Combine(desktopPath, "DailyTasks", "DailyTasks-MenuTheme.bin");
            SelectedTheme selectedTheme = new(theme);
            selectedTheme.Save(filePath);
        }

        private void CLoudMenuButton_Click(object sender, EventArgs e)
        {
            SetTheme(Theme.Cloud);
            UIStyles.InitColorful(Color.SteelBlue, Color.White);
            ThemeChangedEventManager.OnThemeChanged(Theme.Cloud);
        }

        private void SummerMenuButton_Click(object sender, EventArgs e)
        {
            SetTheme(Theme.Summer);
            UIStyles.InitColorful(Color.Green, Color.White);
            ThemeChangedEventManager.OnThemeChanged(Theme.Summer);
        }

        private void SpringMenuButton_Click(object sender, EventArgs e)
        {
            SetTheme(Theme.Spring);
            UIStyles.InitColorful(Color.LightPink, Color.White);
            ThemeChangedEventManager.OnThemeChanged(Theme.Spring);
        }

        private void FallMenuButton_Click(object sender, EventArgs e)
        {
            SetTheme(Theme.Fall);
            UIStyles.InitColorful(Color.Orange, Color.White);
            ThemeChangedEventManager.OnThemeChanged(Theme.Fall);
        }

        private void SnowMenuButton_Click(object sender, EventArgs e)
        {
            SetTheme(Theme.Snow);
            UIStyles.InitColorful(Color.LightBlue, Color.White);
            ThemeChangedEventManager.OnThemeChanged(Theme.Snow);
        }

        private void DefaultMenuButton_Click(object sender, EventArgs e)
        {
            SetTheme(Theme.Default);
            SaveSelectedTheme(Theme.Default);
            UIStyles.InitColorful(Color.FromArgb(48, 48, 48), Color.White);
            ThemeChangedEventManager.OnThemeChanged(Theme.Default);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
