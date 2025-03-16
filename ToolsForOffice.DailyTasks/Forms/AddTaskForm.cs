using Sunny.UI;
using ToolsForOffice.Shared;

namespace ToolsForOffice.DailyTasks.Forms
{
    public partial class AddTaskForm : UIForm
    {
        DailyTask? task;

        internal DailyTask? Task
        {
            get => task;
            set
            {
                task = value;
                UserTextBox.Text = task!.User!.UserName;
                TotalNumericUpDown.Value = (int)task.TotalAmount!;
                CustomUpDown1.Value = (int)task.CustomValue1!;
                CustomUpDown2.Value = (int)task.CustomValue2!;
                CustomUpDown3.Value = (int)task.CustomValue3!;
                CustomUpDown4.Value = (int)task.CustomValue4!;
                CompletedSwitch.Active = task.Completed;
                MainDateTimePicker.Value = (DateTime)task.StartTime!;
                TypeComboBox.SelectedItem = task.TaskType;
                PriorityComboBox.SelectedIndex = (int)task.Priority;
            }
        }

        private static string GetUser()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filePath = Path.Combine(desktopPath, "DailyTasks", "DailyTasks-MyUser.txt");
            string username = File.ReadAllText(filePath);
            return username;
        }

        public AddTaskForm(string cellTypeFilename, CustomValues customValues)
        {
            InitializeComponent();
            string[] lines = File.ReadAllLines(cellTypeFilename);
            foreach (string line in lines)
            {
                string cellType = line.Split(',')[0];
                TypeComboBox.Items.Add(cellType);
            }
            TypeComboBox.SelectedIndex = 0;
            PriorityComboBox.DataSource = Enum.GetValues(typeof(TaskPriority));
            MaximizeBox = false;
            UserTextBox.Text = GetUser();
            AcceptButton = OKButton;

            CustomValueLabel1.Text = customValues!.Value1;
            CustomValueLabel2.Text = customValues!.Value2;
            CustomValueLabel3.Text = customValues!.Value3;
            CustomValueLabel4.Text = customValues!.Value4;
            ThemeHelper.LoadTheme(this);
        }


        private void OKButton_Click(object sender, EventArgs e)
        {
            if (task == null)
            {
                if (UserTextBox.Text.Length >= 3)
                {
                    // Retrieve the User object from the database
                    User user;
                    using (var context = new DailyTasksDBContext())
                    {
                        user = context.Users!.FirstOrDefault(u => u.UserName == UserTextBox.Text)!;
                        if (user == null)
                        {
                            // If the user doesn't exist in the database, create a new User object
                            user = new User(UserTextBox.Text);
                            context.Users!.Add(user);
                            context.SaveChanges();
                        }
                    }

                    // Create a new DailyTask object associated with the existing User object
                    task = new DailyTask(user, (int)TotalNumericUpDown.Value, (int)CustomUpDown1.Value, (int)CustomUpDown2.Value, (int)CustomUpDown3.Value, (int)CustomUpDown4.Value, CompletedSwitch.Active, MainDateTimePicker.Value, TypeComboBox.SelectedItem.ToString(), (TaskPriority)PriorityComboBox.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("The title must be 3 or less characters long!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    UserTextBox.Focus();
                    DialogResult = DialogResult.None;
                }
            }
            else
            {
                task.User!.UserName = UserTextBox.Text;
                task.TotalAmount = (int)TotalNumericUpDown.Value;
                task.CustomValue1 = (int)CustomUpDown1.Value;
                task.CustomValue2 = (int)CustomUpDown2.Value;
                task.CustomValue3 = (int)CustomUpDown3.Value;
                task.CustomValue4 = (int)CustomUpDown4.Value;
                task.Completed = CompletedSwitch.Active;
                task.StartTime = MainDateTimePicker.Value;
                task.TaskType = TypeComboBox.SelectedItem.ToString();
                task.Priority = (TaskPriority)PriorityComboBox.SelectedIndex;
            }
        }
    }
}
