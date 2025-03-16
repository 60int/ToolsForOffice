namespace ToolsForOffice.Shared
{
    public class CustomValues
    {
        public string? Value1 { get; set; }
        public string? Value2 { get; set; }
        public string? Value3 { get; set; }
        public string? Value4 { get; set; }

        private static readonly string DailyTasksPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DailyTasks");
        private static readonly string ValuesFilePath = Path.Combine(DailyTasksPath, "DailyTasks-Values.bin");

        public void LoadFromFile()
        {
            if (File.Exists(ValuesFilePath))
            {
                string[] values = File.ReadAllLines(ValuesFilePath);
                Value1 = values[0];
                Value2 = values[1];
                Value3 = values[2];
                Value4 = values[3];
            }
        }

        public void SaveToFile()
        {
            string[] values = new string[] { Value1!, Value2!, Value3!, Value4! };
            File.WriteAllLines(ValuesFilePath, values);
        }
    }

}
