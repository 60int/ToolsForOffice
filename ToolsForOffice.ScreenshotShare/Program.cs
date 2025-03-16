//namespace ToolsForOffice.ScreenshotShare
//{
//    internal static class Program
//    {
//        /// <summary>
//        ///  The main entry point for the application.
//        /// </summary>
//        [STAThread]
//        static void Main()
//        {
//            // To customize application configuration such as set high DPI settings or default font,
//            // see https://aka.ms/applicationconfiguration.
//            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
//            string dailyTasksPath = Path.Combine(desktopPath, "DailyTasks");
//            Directory.CreateDirectory(dailyTasksPath);
//            string filePath = Path.Combine(desktopPath, "DailyTasks", "DailyTasks-MyUser.txt");
//            if (!Directory.Exists($"Daily Tasks/Images/"))
//            {
//                Directory.CreateDirectory($"Daily Tasks/Images/");
//            }
//            if (!File.Exists(filePath))
//            {
//                using StreamWriter writer = File.CreateText(filePath);
//                writer.Write("Default");
//            }
//            string folderPath = Path.Combine(desktopPath, "DailyTasks", "DailyTasks-MyFolder.bin");
//            if (!File.Exists(folderPath))
//            {
//                using var binaryWriter = new BinaryWriter(File.Open(folderPath, FileMode.Create));
//                binaryWriter.Write($"Daily Tasks/Images/");
//            }
//            ApplicationConfiguration.Initialize();
//            Application.Run(new ScreenshotShareForm());
//        }
//    }
//}