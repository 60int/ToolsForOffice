using ToolsForOffice.Shared;

namespace ToolsForOffice.DailyTasks
{
    internal static class Program
    {
        private static readonly string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        private static readonly string DailyTasksPath = Path.Combine(DesktopPath, "DailyTasks");

        public static void EnsureFilesExist()
        {
            Directory.CreateDirectory(DailyTasksPath);

            EnsureValuesFileExists();
            EnsureMyFolderFileExists();
            EnsureMyUserFileExists();
            EnsureMenuThemeFileExists();
            EnsureToolsThemeFileExists();
        }

        private static void EnsureValuesFileExists()
        {
            string valuesFilePath = Path.Combine(DailyTasksPath, "DailyTasks-Values.bin");

            string[] defaultValues = new[] { "Scrap/Double", "Other NG", "Amount Left", "NG/OK" };
            if (!File.Exists(valuesFilePath))
            {
                File.WriteAllLines(valuesFilePath, defaultValues);
            }
        }

        private static void EnsureMyFolderFileExists()
        {
            string folderPath = Path.Combine(DailyTasksPath, "DailyTasks-MyFolder.bin");
            if (!File.Exists(folderPath))
            {
                using var binaryWriter = new BinaryWriter(File.Open(folderPath, FileMode.Create));
                binaryWriter.Write($"Daily Tasks/Images/");
            }
        }

        private static void EnsureMyUserFileExists()
        {
            string filePath = Path.Combine(DailyTasksPath, "DailyTasks-MyUser.txt");
            if (!File.Exists(filePath))
            {
                using StreamWriter writer = File.CreateText(filePath);
                writer.Write("Default");
            }
        }

        private static void EnsureMenuThemeFileExists()
        {
            string filePath = Path.Combine(DailyTasksPath, "DailyTasks-MenuTheme.bin");
            if (!File.Exists(filePath))
            {
                SelectedTheme selectedTheme = new(Theme.Default);
                selectedTheme.Save(filePath);
            }
        }

        private static void EnsureToolsThemeFileExists()
        {
            string filePath = Path.Combine(DailyTasksPath, "DailyTasks-ToolsTheme.bin");
            if (!File.Exists(filePath))
            {
                SelectedTheme selectedTheme = new(Theme.Default);
                selectedTheme.Save(filePath);
            }
        }

        [STAThread]
        static void Main()
        {
            EnsureFilesExist();

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }


}