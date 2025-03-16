namespace ToolsForOffice.Shared
{
    public enum Theme { Default, Cloud, Summer, Spring, Fall, Snow }

    public class SelectedTheme
    {
        public Theme CurrentTheme { get; set; }

        public SelectedTheme(Theme currentTheme)
        {
            CurrentTheme = currentTheme;
        }

        public override string ToString()
        {
            return CurrentTheme.ToString();
        }

        public static SelectedTheme Load(string filename)
        {
            if (!File.Exists(filename))
            {
                return new SelectedTheme(Theme.Default);
            }

            using BinaryReader reader = new(File.Open(filename, FileMode.Open));
            Theme theme = (Theme)reader.ReadInt32();
            return new SelectedTheme(theme);
        }

        public void Save(string filename)
        {
            using BinaryWriter writer = new(File.Open(filename, FileMode.Create));
            writer.Write((int)CurrentTheme);
        }
    }
}