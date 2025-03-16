namespace ToolsForOffice.Shared
{
    public class Settings
    {
        public string? UserName { get; set; }
        public string? SelectedPath { get; set; }

        public void Load()
        {
            // Load the user name from a text file
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filePath = Path.Combine(desktopPath, "DailyTasks", "DailyTasks-MyUser.txt");
            if (File.Exists(filePath))
            {
                UserName = File.ReadAllText(filePath);
            }

            // Load the selected path from a binary file
            filePath = Path.Combine(desktopPath, "DailyTasks", "DailyTasks-MyFolder.bin");
            if (File.Exists(filePath))
            {
                using var binaryReader = new BinaryReader(File.Open(filePath, FileMode.Open));
                SelectedPath = binaryReader.ReadString();
            }
        }

        public void Save()
        {
            // Save the user name to a text file
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filePath = Path.Combine(desktopPath, "DailyTasks", "DailyTasks-MyUser.txt");
            File.WriteAllText(filePath, UserName);

            // Save the selected path to a binary file
            filePath = Path.Combine(desktopPath, "DailyTasks", "DailyTasks-MyFolder.bin");
            using var binaryWriter = new BinaryWriter(File.Open(filePath, FileMode.Create));
            binaryWriter.Write(SelectedPath!);
        }
    }

}
