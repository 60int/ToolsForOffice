using System.Data.SQLite;
using System.Data.Entity;
using System.Data.SQLite.EF6;
using System.Data.Entity.Core.Common;

namespace ToolsForOffice.Shared
{
    public class DailyTasksDBContext : DbContext
    {
        public DbSet<DailyTask>? DailyTasks { get; set; }
        public DbSet<User>? Users { get; set; }

        public DailyTasksDBContext() : base(new SQLiteConnection()
        {
            ConnectionString = new SQLiteConnectionStringBuilder()
            {
                DataSource = GetDatabaseFilePath(),
                ForeignKeys = true
            }.ConnectionString
        }, true)
        {
            Database.SetInitializer<DailyTasksDBContext>(null);
            DbConfiguration.SetConfiguration(new SQLiteConfiguration());
        }

        private static string GetDatabaseFilePath()
        {
            var databaseFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Daily Tasks", "DB", "DailyTasksDB.db");
            return databaseFilePath;
        }

        //public static void LogDatabaseFilePath()
        //{
        //    // Log the database file path to a text file in the publish folder
        //    string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");
        //    using var writer = new StreamWriter(logFilePath, true);
        //    writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        //    writer.WriteLine("Database file path: " + GetDatabaseFilePath());
        //    writer.WriteLine();
        //}
    }

    public class SQLiteConfiguration : DbConfiguration
    {
        public SQLiteConfiguration()
        {
            SetProviderFactory("System.Data.SQLite", SQLiteFactory.Instance);
            SetProviderFactory("System.Data.SQLite.EF6", SQLiteProviderFactory.Instance);
            SetProviderServices("System.Data.SQLite", (DbProviderServices)SQLiteProviderFactory.Instance.GetService(typeof(DbProviderServices)));
        }
    }
}
