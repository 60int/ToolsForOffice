using System.Text;

namespace ToolsForOffice.Shared
{
    public class User
    {
        string? userName;

        public int Id { get; set; }
        public string? UserName { get => userName; set => userName = value; }
        public User()
        {
                
        }
        public User(string userName)
        {
            UserName = userName;
        }

        public override string ToString()
        {
            return userName!;
        }

        public string CSVFormat()
        {
            return $"{userName}";
        }

        public static User[] Deserialize(string filename)
        {
            string[] lines = File.ReadAllLines(filename, Encoding.UTF8).ToArray();
            User[] users = new User[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');
                users[i] = new User(line[0]);
            }
            return users;
        }

        public static void Serialize(string filename, User[] users)
        {
            StreamWriter writer = new(filename, false, Encoding.UTF8);
            foreach (User item in users)
            {
                writer.WriteLine(item.CSVFormat());
            }
            writer.Close();
        }
    }
}