using Sunny.UI;
using ToolsForOffice.Shared;

namespace ToolsForOffice.DailyTasks
{
    public static class ThemeHelper
    {
        public static Theme LoadTheme(UIForm form)
        {
            SelectedTheme? cachedSelectedTheme = null;
            if (cachedSelectedTheme == null)
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string filePath = Path.Combine(desktopPath, "DailyTasks", "DailyTasks-MenuTheme.bin");
                cachedSelectedTheme = SelectedTheme.Load(filePath);
            }

            switch (cachedSelectedTheme.CurrentTheme)
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
                    break;
            }

            return cachedSelectedTheme.CurrentTheme;
        }
    }
}