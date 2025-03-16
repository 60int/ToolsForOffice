namespace ToolsForOffice.Shared
{
    public static class ThemeChangedEventManager
    {
        public static event EventHandler<ThemeChangedEventArgs>? ThemeChanged;

        public static void OnThemeChanged(Theme newTheme)
        {
            ThemeChanged?.Invoke(null, new ThemeChangedEventArgs(newTheme));
        }
    }

    public class ThemeChangedEventArgs : EventArgs
    {
        public Theme NewTheme { get; }

        public ThemeChangedEventArgs(Theme newTheme)
        {
            NewTheme = newTheme;
        }
    }
}
