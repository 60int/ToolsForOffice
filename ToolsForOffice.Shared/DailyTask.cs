using System.Text;

namespace ToolsForOffice.Shared
{
    public enum TaskPriority
    {
        Normal,
        Important,
        Urgent
    }

    public class DailyTask
    {
        User? user;
        int? totalAmount;
        int? customValue1;
        int? customValue2;
        int? customValue3;
        int? customValue4;
        bool completed;
        DateTime? startTime;
        TaskPriority priority;
        string? taskType;

        public int Id { get; set; }

        public int UserId { get; set; }

        public virtual User User { get => user!; set => user = value; }

        public int? TotalAmount
        {
            get => totalAmount;
            set
            {
                if (value >= 0)
                {
                    totalAmount = value;
                }
                else
                {
                    throw new ArgumentException("Amount can only contain positive numbers!");
                }
            }
        }

        public int? CustomValue1
        {
            get => customValue1;
            set
            {
                if (value >= 0)
                {
                    customValue1 = value;
                }
                else
                {
                    throw new ArgumentException("Amount can only contain positive numbers!");
                }
            }
        }

        public int? CustomValue2
        {
            get => customValue2;
            set
            {
                if (value >= 0)
                {
                    customValue2 = value;
                }
                else
                {
                    throw new ArgumentException("Amount can only contain positive numbers!");
                }
            }
        }

        public int? CustomValue3
        {
            get => customValue3;
            set
            {
                if (value >= 0)
                {
                    customValue3 = value;
                }
                else
                {
                    throw new ArgumentException("Amount can only contain positive numbers!");
                }
            }
        }

        public int? CustomValue4
        {
            get => customValue4;
            set
            {
                if (value >= 0)
                {
                    customValue4 = value;
                }
                else
                {
                    throw new ArgumentException("Amount can only contain positive numbers!");
                }
            }
        }

        public bool Completed { get => completed; set => completed = value; }

        public DateTime? StartTime { get => startTime; set => startTime = value; }

        public string? TaskType { get => taskType; set => taskType = value; }

        public TaskPriority Priority { get => priority; set => priority = value; }

        public DailyTask()
        {
            
        }

        public DailyTask(User user, int? totalAmount, int? customValue1, int? customValue2, int? customValue3, int? customValue4, bool completed, DateTime? startTime, string? taskType, TaskPriority priority)
        {
            User = user;
            TotalAmount = totalAmount;
            CustomValue1 = customValue1;
            CustomValue2 = customValue2;
            CustomValue3 = customValue3;
            CustomValue4 = customValue4;
            Completed = completed;
            StartTime = startTime;
            TaskType = taskType;
            Priority = priority;
        }

        public override string? ToString()
        {
            string yes = completed ? "✔" : "✖";
            return user! + " - " + StartTime!.Value.ToString("MM/dd") + " - " + totalAmount + " - " + yes;
        }

        public string CSVFormat()
        {
            //CustomValue3 is set to "Amount Left" by default in Program.cs file!
            if (completed == true)
            {
                customValue3 = 0;
            }
            else if (completed == false)
            {
                customValue3 = totalAmount;
            }
            return $"{user!.UserName},{totalAmount},{customValue1},{customValue2},{customValue3},{customValue4},{completed},{StartTime},{TaskType},{(int)priority}";
        }

        public static DailyTask[] Deserialize(string filename)
        {
            string[] lines = File.ReadAllLines(filename, Encoding.UTF8).Skip(1).ToArray();
            List<DailyTask> tasks = new();
            for (int i = 0; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');
                User user = new(line[0]);
                tasks.Add(new DailyTask(user, int.Parse(line[1]), int.Parse(line[2]), int.Parse(line[3]), int.Parse(line[4]), int.Parse(line[5]), bool.Parse(line[6]), DateTime.Parse(line[7]), line[8], (TaskPriority)int.Parse(line[9])));
            }
            return tasks.ToArray();
        }

        public static IEnumerable<(User User, int TotalSum)> TotalSumByUser(DailyTask[] tasks)
        {
            return tasks
                .GroupBy(t => t.User)
                .Select(g => (g.Key, g.Sum(t => t.totalAmount) ?? 0))
                .OrderBy(g => g.Key)!;
        }

        public static IEnumerable<(User User, int CustomValue1Sum)> CustomValue1SumByUser(DailyTask[] tasks)
        {
            return tasks
                .GroupBy(t => t.User)
                .Select(g => (g.Key, g.Sum(t => t.customValue1) ?? 0))
                .OrderBy(g => g.Key)!;
        }

        public static IEnumerable<(User User, int CustomValue2Sum)> CustomValue2SumByUser(DailyTask[] tasks)
        {
            return tasks
                .GroupBy(t => t.User)
                .Select(g => (g.Key, g.Sum(t => t.customValue2) ?? 0))
                .OrderBy(g => g.Key)!;
        }

        public static IEnumerable<(User User, int NotFinished)> NotFinishedByUser(DailyTask[] tasks)
        {
            return tasks
                .GroupBy(t => t.User)
                .Select(g => (g.Key, g.Sum(t => t.customValue3) ?? 0))
                .OrderBy(g => g.Key)!;
        }

        public static IEnumerable<(User User, int TotalOK)> TotalOKByUser(DailyTask[] tasks)
        {
            return tasks
                .GroupBy(t => t.User)
                .Select(g => (g.Key, g.Sum(t => t.totalAmount - (t.customValue1 + t.customValue2)) ?? 0))
                .OrderBy(g => g.Key)!;
        }

        public static IEnumerable<(User User, int TotalNG)> TotalNGByUser(DailyTask[] tasks)
        {
            return tasks
                .GroupBy(t => t.User)
                .Select(g => (g.Key, g.Sum(t => t.customValue1 + t.customValue2) ?? 0))
                .OrderBy(g => g.Key)!;
        }

        public static void Serialize(string filename, DailyTask[] tasks)
        {
            CustomValues customValues = new();
            customValues.LoadFromFile();
            string value1 = customValues.Value1!;
            string value2 = customValues.Value2!;
            string value3 = customValues.Value3!;
            string value4 = customValues.Value4!;

            string header = $"User, Total Amount, {value1}, {value2}, {value3}, {value4}, Completed, Task Date Time, Task Type, Priority";

            StreamWriter writer = new(filename, false, Encoding.UTF8);
            writer.WriteLine(header);
            foreach (DailyTask item in tasks)
            {
                writer.WriteLine(item.CSVFormat());
            }
            writer.Close();
        }
    }
}