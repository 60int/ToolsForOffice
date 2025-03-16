using Sunny.UI;
using System.Text;
using System.Text.Json;
using System.Data.Entity;
using System.Diagnostics;
using ToolsForOffice.Shared;
using ToolsForOffice.CopyClipboard;
using ToolsForOffice.ScreenshotShare;
using ToolsForOffice.DailyTasks.Forms;
using ToolsForOffice.DailyTasks.Properties;

namespace ToolsForOffice.DailyTasks
{
    public partial class MainForm : UIForm
    {
        #region Fields and Properties

        private static readonly HttpClient client = new();
        private readonly CancellationTokenSource cts = new();
        private Form activeForm = null!;
        FileSystemWatcher watcher = new();

        readonly string MainFolder = $"Daily Tasks/";
        readonly string SettingsFolder = $"Daily Tasks/Settings/";
        readonly string DBFolder = $"Daily Tasks/DB/";
        readonly string ImageFolder = $"Daily Tasks/Images/";
        readonly string ClipboardFile = "Daily Tasks/Settings/CopyClipboard.txt";

        private SelectedTheme? _cachedSelectedTheme;
        private CustomValues? customValues;

        #endregion

        public MainForm()
        {
            InitializeComponent();
            ThemeChangedEventManager.ThemeChanged += OnThemeChanged!;
            TasksMenuStrip.Click += TasksMenuStrip_Click!;
        }

        #region Startup Methods

        void InitializeDataGridView()
        {
            MainDataGridView.AutoGenerateColumns = false;
            MainDataGridView.Columns.Add("Day of the Week", "Day Of Week");
            MainDataGridView.Columns.Add("User", "User");
            MainDataGridView.Columns.Add("TotalSum", "Total Sum");
            MainDataGridView.Columns.Add(customValues!.Value1, customValues!.Value2);
            MainDataGridView.Columns.Add("TotalOK", "Total OK");
            MainDataGridView.Columns.Add("TotalNG", "Total NG");
            MainDataGridView.Columns.Add("Task Type", "TaskType");
        }

        private void CreateFileSystemWatcher()
        {
            watcher = new FileSystemWatcher
            {
                Path = GetFolder(),
                NotifyFilter = NotifyFilters.FileName | NotifyFilters.Size,
                Filter = "*.jpg"
            };
            watcher.Created += new FileSystemEventHandler(OnImageCreated);
            watcher.EnableRaisingEvents = true;
        }

        private void CreateDirectories()
        {
            try
            {
                string[] directories = { MainFolder, ImageFolder, SettingsFolder, DBFolder };
                foreach (string directory in directories)
                {
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while creating directories: " + ex.Message);
            }
        }

        private void CreateClipboardFile()
        {
            if (!File.Exists(ClipboardFile))
            {
                StringBuilder sb = new();
                for (int i = 1; i <= 8; i++)
                {
                    sb.Append($"Drop Down item {i}");
                    for (int j = 1; j <= 8; j++)
                    {
                        sb.Append($",New Item (column {j}/{i})");
                    }
                    sb.AppendLine();
                }

                using StreamWriter writer = new(ClipboardFile, false, Encoding.UTF8);
                writer.Write(sb.ToString());
            }
        }

        #endregion

        #region Load Data

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                CreateDirectories();
                customValues = new CustomValues();
                customValues.LoadFromFile();
                string username = GetUser();
                CurrentUserTasks.Text = "Current User: " + username;
                CurrentUserHome.Text = "Current User: " + username;
                FadeInLabel(CurrentUserHome, CurrentUserHome.BackColor, Color.Black, 2000);
                CreateClipboardFile();
                CreateFileSystemWatcher();
                InitializeDataGridView();
                RefreshListBoxAndDataGrid();
                LoadUsers();
                LoadWeatherData();
                LoadTheme();
                ConnectLabelHome.Text = "Connect Time: " + DateTime.Now.ToString();
                ConnectLabelTask.Text = "Connect Time: " + DateTime.Now.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Application couldn't start" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private static string GetFolder()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filePath = Path.Combine(desktopPath, "DailyTasks", "DailyTasks-MyFolder.bin");
            string folderPath;
            using (var binaryReader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                folderPath = binaryReader.ReadString();
            }
            return folderPath + "/";
        }

        static List<DailyTask> LoadDataFromDatabase()
        {
            List<DailyTask> allTasks = new();
            try
            {
                using var context = new DailyTasksDBContext();
                if (GetUsernameFromFile() == "Default")
                {
                    allTasks = context.DailyTasks!.Include("User").ToList();
                }
                else
                {
                    string username = GetUsernameFromFile();
                    allTasks = context.DailyTasks!.Include("User").Where(t => t.User.UserName == username).ToList();
                }
            }
            catch (Exception ex)
            {
                // Log the error to a text file in the publish folder
                string logFilePath = Path.Combine("Daily Tasks/Settings/", "errorlog.txt");
                using var writer = new StreamWriter(logFilePath, true);
                writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                writer.WriteLine(ex.ToString());
                writer.WriteLine();
            }
            return allTasks;
        }

        void RefreshListBoxAndDataGrid(bool showCurrentWeekOnly = true)
        {
            MainListBox.Items.Clear();
            MainDataGridView.Rows.Clear();

            List<DailyTask> allTasks = LoadDataFromDatabase();

            // Calculate total sum, not finished, total OK and total NG by title
            var totalSumByUser = DailyTask.TotalSumByUser(allTasks.ToArray());
            var notFinishedByUser = DailyTask.NotFinishedByUser(allTasks.ToArray());
            var totalOKByUser = DailyTask.TotalOKByUser(allTasks.ToArray());
            var totalNGByUser = DailyTask.TotalNGByUser(allTasks.ToArray());

            // Group tasks by date and title
            var tasksGroupedByDateAndTitle = allTasks.GroupBy(t => new { t.StartTime!.Value.Date, t.User!.UserName });

            // Calculate start and end dates of current week
            DateTime startOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
            DateTime endOfWeek = startOfWeek.AddDays(7);

            // Add a row for each group
            foreach (var group in tasksGroupedByDateAndTitle.OrderBy(g => g.Key.Date))
            {
                // Check if StartTime is within current week
                if (!showCurrentWeekOnly || (group.Key.Date >= startOfWeek && group.Key.Date < endOfWeek))
                {
                    string date = group.Key.Date.ToString("d");
                    string title = group.Key.UserName!;
                    int totalSum = group.Sum(t => t.TotalAmount) ?? 0;
                    int notFinished = group.Sum(t => t.CustomValue3) ?? 0;
                    int totalOK = group.Sum(t => t.TotalAmount - (t.CustomValue1 + t.CustomValue2)) ?? 0;
                    int totalNG = group.Sum(t => t.CustomValue1 + t.CustomValue2) ?? 0;
                    string taskType = group.First().TaskType!.ToString(); // Change TaskType.ToString() to TaskType

                    MainDataGridView.Rows.Add(date, title, totalSum, notFinished, totalOK, totalNG, taskType);
                }
            }
            foreach (DailyTask item in allTasks.OrderByDescending(task => task.StartTime))
            {
                MainListBox.Items.Add(item);
            }
        }

        private void LoadWeatherData()
        {
            //string apiKey = "your api key";
            //string city = "Budapest";
            //string url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            try
            {
                //HttpResponseMessage response = client.GetAsync(url).Result;
                //response.EnsureSuccessStatusCode();
                //string json = response.Content.ReadAsStringAsync().Result;

                //using JsonDocument doc = JsonDocument.Parse(json);
                //JsonElement root = doc.RootElement;
                //double temperature = root.GetProperty("main").GetProperty("temp").GetDouble();
                //string conditions = root.GetProperty("weather")[0].GetProperty("main").GetString()!;
                LocationLabel.Text = "Your city";
                ConditionsLabel.Text = "Rainy";
                CelsiusLabel.Text = $"23°C";
                FadeInLabel(LocationLabel, LocationLabel.BackColor, Color.Black, 2000);
                FadeInLabel(ConditionsLabel, ConditionsLabel.BackColor, Color.Black, 2000);
                FadeInLabel(CelsiusLabel, CelsiusLabel.BackColor, Color.Black, 2000);
            }
            catch (HttpRequestException)
            {
                ConditionsLabel.Text = "Weather data is not available";
                CelsiusLabel.Text = "";
            }
            catch (JsonException)
            {
                ConditionsLabel.Text = "Weather data is not available";
                CelsiusLabel.Text = "";
            }
        }

        #endregion

        public static void SaveChanges(DailyTask dailyTask)
        {
            string username = GetUsernameFromFile();
            using var context = new DailyTasksDBContext();
            var user = context.Users!.FirstOrDefault(u => u.UserName == username);
            if (user != null)
            {
                dailyTask.User = user;
                context.DailyTasks!.Add(dailyTask);
                context.SaveChanges();
            }
        }

        #region Manage Users

        private static string GetUsernameFromFile()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filePath = Path.Combine(desktopPath, "DailyTasks", "DailyTasks-MyUser.txt");
            string username = File.ReadAllText(filePath).Trim();
            return username;
        }

        private static string GetUser()
        {
            string username = GetUsernameFromFile();
            return username;
        }

        private void LoadUsers()
        {
            try
            {
                UsersToolStripMenuItem.DropDownItems.Clear();

                // Load users from the database
                using var db = new DailyTasksDBContext();
                foreach (User userItem in db.Users!)
                {
                    ToolStripItem item = UsersToolStripMenuItem.DropDownItems.Add(userItem.UserName);
                    item.Click += UserItem_Click;

                    #region Visuals

                    if (_cachedSelectedTheme == null)
                    {
                        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                        string filePath = Path.Combine(desktopPath, "DailyTasks", "DailyTasks-MenuTheme.bin");
                        _cachedSelectedTheme = SelectedTheme.Load(filePath);
                    }
                    switch (_cachedSelectedTheme.CurrentTheme)
                    {
                        case Theme.Default:
                            item.BackColor = Color.FromArgb(48, 48, 48);
                            item.ForeColor = Color.White;
                            break;
                        case Theme.Cloud:
                            item.BackColor = Color.SteelBlue;
                            item.ForeColor = Color.White;
                            break;
                        case Theme.Summer:
                            item.BackColor = Color.Green;
                            item.ForeColor = Color.White;
                            break;
                        case Theme.Spring:
                            item.BackColor = Color.Pink;
                            item.ForeColor = Color.White;
                            break;
                        case Theme.Fall:
                            item.BackColor = Color.Orange;
                            item.ForeColor = Color.White;
                            break;
                        case Theme.Snow:
                            item.BackColor = Color.LightSteelBlue;
                            item.ForeColor = Color.White;
                            break;
                        default:
                            break;
                    }

                    #endregion
                }
            }
            catch (Exception ex)
            {
                // Log the error to a text file in the publish folder
                string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "errorlog.txt");
                using var writer = new StreamWriter(logFilePath, true);
                writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                writer.WriteLine(ex.ToString());
                writer.WriteLine();
            }
        }

        private void NewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserForm form = new();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Create a new User object
                User newUser = new(form.User!.UserName!);

                // Add the new user to the database
                using (var db = new DailyTasksDBContext())
                {
                    db.Users!.Add(newUser);
                    db.SaveChanges();
                }

                // Update the UI
                ToolStripItem newUserItem = new ToolStripMenuItem(newUser.UserName);
                newUserItem.Click += UserItem_Click;
                UsersToolStripMenuItem.DropDownItems.Add(newUserItem);
                newUserItem.BackColor = Color.FromArgb(48, 48, 48);
                newUserItem.ForeColor = Color.White;

                MessageBox.Show("New User added!", "Success");
            }

            LoadTheme();
        }

        private void UserItem_Click(object? sender, EventArgs e)
        {
            CurrentUserTasks.Text = "Current user: " + (sender! as ToolStripItem)!.Text;
            CurrentUserHome.Text = "Current user: " + (sender! as ToolStripItem)!.Text;

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filePath = Path.Combine(desktopPath, "DailyTasks", "DailyTasks-MyUser.txt");
            File.WriteAllText(filePath, CurrentUserTasks.Text.Replace("Current user: ", ""));
            RefreshListBoxAndDataGrid();
        }

        #endregion

        #region Main Buttons

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            RefreshListBoxAndDataGrid(showCurrentWeekOnly: false);
        }

        private void CurrentWeekButton_Click(object sender, EventArgs e)
        {
            RefreshListBoxAndDataGrid(showCurrentWeekOnly: true);
        }

        private void MainDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Get the selected date
            DateTime selectedDate = MainDateTimePicker.Value;

            MainListBox.Items.Clear();
            MainDataGridView.Rows.Clear();

            // Load data from CSV files
            List<DailyTask> allTasks = LoadDataFromDatabase();

            var totalSumByUser = DailyTask.TotalSumByUser(allTasks.ToArray());
            var notFinishedByUser = DailyTask.NotFinishedByUser(allTasks.ToArray());
            var totalOKByUser = DailyTask.TotalOKByUser(allTasks.ToArray());
            var totalNGByUser = DailyTask.TotalNGByUser(allTasks.ToArray());

            // Filter tasks by selected date
            var tasksBySelectedDate = allTasks.Where(t => t.StartTime.HasValue && t.StartTime.Value.Date == selectedDate.Date);

            // Group tasks by date and title
            var tasksGroupedByDateAndTitle = tasksBySelectedDate.GroupBy(t => new { t.StartTime!.Value.Date, t.User!.UserName });

            // Add a row for each group
            foreach (var group in tasksGroupedByDateAndTitle)
            {
                string date = group.Key.Date.ToString("d");
                string title = group.Key.UserName!;
                int totalSum = group.Sum(t => t.TotalAmount) ?? 0;
                int notFinished = group.Sum(t => t.CustomValue3) ?? 0;
                int totalOK = group.Sum(t => t.TotalAmount - (t.CustomValue1 + t.CustomValue2)) ?? 0;
                int totalNG = group.Sum(t => t.CustomValue1 + t.CustomValue2) ?? 0;
                string taskType = group.First().TaskType!;

                MainDataGridView.Rows.Add(date, title, totalSum, notFinished, totalOK, totalNG, taskType);
            }

            foreach (DailyTask item in allTasks)
            {
                MainListBox.Items.Add(item);
            }
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            CustomValues customValues = new();
            customValues.LoadFromFile();
            AddTaskForm form = new(ClipboardFile, customValues);
            if (form.ShowDialog() == DialogResult.OK)
            {
                MainListBox.Items.Add(form.Task!);
                SaveChanges(form.Task!);
                RefreshListBoxAndDataGrid();
            }
            LoadTheme();
        }

        private void UpdateTaskButton_Click(object sender, EventArgs e)
        {
            if (MainListBox.SelectedItem != null)
            {
                CustomValues customValues = new();
                customValues.LoadFromFile();
                AddTaskForm form = new(ClipboardFile, customValues)
                {
                    Task = (DailyTask)MainListBox.SelectedItem
                };
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Update the selected DailyTask object in the database
                    using (var context = new DailyTasksDBContext())
                    {
                        context.Entry(form.Task).State = EntityState.Modified;
                        context.SaveChanges();
                    }

                    // Update the UI
                    MainListBox.Items[MainListBox.SelectedIndex] = MainListBox.SelectedItem!;
                    RefreshListBoxAndDataGrid();
                }
            }
            LoadTheme();
        }

        private void RemoveTaskButton_Click(object sender, EventArgs e)
        {
            if (MainListBox.SelectedIndex != -1 && MessageBox.Show("Do you want to delete this item?", "Delete item?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Get the selected DailyTask object
                DailyTask selectedTask = (DailyTask)MainListBox.SelectedItem;

                // Remove the selected DailyTask object from the database
                using (var context = new DailyTasksDBContext())
                {
                    context.DailyTasks!.Attach(selectedTask);
                    context.DailyTasks.Remove(selectedTask);
                    context.SaveChanges();
                }

                // Update the UI
                MainListBox.Items.RemoveAt(MainListBox.SelectedIndex);
                RefreshListBoxAndDataGrid();
            }
            LoadTheme();
        }

        private void MainListBox_DoubleClick(object sender, EventArgs e)
        {
            if (MainListBox.SelectedItem != null)
            {
                CustomValues customValues = new();
                customValues.LoadFromFile();
                AddTaskForm form = new(ClipboardFile, customValues)
                {
                    Task = (DailyTask)MainListBox.SelectedItem
                };
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Update the selected DailyTask object in the database
                    using (var context = new DailyTasksDBContext())
                    {
                        context.Entry(form.Task).State = EntityState.Modified;
                        context.SaveChanges();
                    }

                    // Update the UI
                    MainListBox.Items[MainListBox.SelectedIndex] = MainListBox.SelectedItem!;
                    RefreshListBoxAndDataGrid();
                }
            }
            LoadTheme();
        }

        private void ClipboardButton_Click(object sender, EventArgs e)
        {
            watcher.EnableRaisingEvents = false;
            CopyClipboardForm Form = new();
            WindowState = FormWindowState.Minimized;
            Form.Owner = this;
            Form.FormClosed += (s, args) =>
            {
                watcher.EnableRaisingEvents = true;
                WindowState = FormWindowState.Normal;
                LoadTheme();
            };
            Form.Show();
        }

        private void ScreenshotShareButton_Click(object sender, EventArgs e)
        {
            watcher.EnableRaisingEvents = false;
            ScreenshotShareForm Form = new();
            WindowState = FormWindowState.Minimized;
            Form.Owner = this;
            Form.FormClosed += (s, args) =>
            {
                watcher.EnableRaisingEvents = true;
                WindowState = FormWindowState.Normal;
                LoadTheme();
            };
            Form.Show();
        }

        private void EditClipboardButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditClipboardForm());
            LoadTheme();
        }

        private void ShareImageTimer_Tick(object sender, EventArgs e)
        {
            ShareImageTimer.Stop();
            ShareImageLabel.Visible = false;
        }

        private void ToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            ToolStripMenuItem? menuItem = sender as ToolStripMenuItem;
            menuItem!.ForeColor = Color.Black;
        }

        private void ToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            ToolStripMenuItem? menuItem = sender as ToolStripMenuItem;
            menuItem!.ForeColor = Color.White;
        }

        private void EditValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditValueForm editValueForm = new(customValues!);
            if (editValueForm.ShowDialog() == DialogResult.OK)
            {
                customValues!.SaveToFile();
            }
            LoadTheme();
        }

        private void EditTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Load the data from the text file using the LoadTextCells method
            List<string> lines = TextCell.LoadTextCells(ClipboardFile);

            // Create a new list to store only the first item of each row (Types)
            List<string> types = new();
            foreach (string line in lines)
            {
                string firstItem = line.Split(',')[0];
                types.Add(firstItem);
            }

            // Create an instance of the EditTypeForm class and pass the list of strings to its constructor
            EditTypeForm editTypeForm = new(types);
            if (editTypeForm.ShowDialog() == DialogResult.OK)
            {
                // Update the first item of each row with the updated data from the form
                for (int i = 0; i < lines.Count; i++)
                {
                    string[] items = lines[i].Split(',');
                    items[0] = editTypeForm.Types[i];
                    lines[i] = string.Join(",", items);
                }

                // Save the updated data to the text file using SaveTextCells method
                TextCell.SaveTextCells(ClipboardFile, lines);
            }
            LoadTheme();
        }

        private async void ManageDataButton_Click(object sender, EventArgs e)
        {
            // Suspend the layout of the parent form to prevent redrawing
            // for the transition to be smoother
            SuspendLayout();
            CustomUIButton.Visible = false;
            ManageDataButton.Visible = false;
            MDLabel.Visible = false;
            CULabel.Visible = false;
            OpenChildSettingsForm(new ManageDataForm());
            LoadTheme();
            await Task.Delay(1000);
            CustomUIButton.Visible = true;
            ManageDataButton.Visible = true;
            MDLabel.Visible = true;
            CULabel.Visible = true;
            ResumeLayout();
        }

        private async void CustomUIButton_Click(object sender, EventArgs e)
        {
            // Suspend the layout of the parent form to prevent redrawing
            // for the transition to be smoother
            SuspendLayout();
            CustomUIButton.Visible = false;
            ManageDataButton.Visible = false;
            MDLabel.Visible = false;
            CULabel.Visible = false;
            OpenChildSettingsForm(new ManageUIForm());
            LoadTheme();
            await Task.Delay(1000);
            CustomUIButton.Visible = true;
            ManageDataButton.Visible = true;
            MDLabel.Visible = true;
            CULabel.Visible = true;
            ResumeLayout();
            //Reload users to refresh visual style
            LoadUsers();
        }

        private void SourceCodeLabel_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new()
            {
                FileName = "https://github.com/60int/DailyTasksNew",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        #endregion

        #region UI / Visuals

        private void OpenChildForm(Form childForm)
        {
            activeForm?.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ToolsPage.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private async void OpenChildSettingsForm(Form childForm)
        {
            activeForm?.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            SettingsPage.Controls.Add(childForm);
            childForm.BringToFront();
            for (double i = 0; i <= 1; i += 0.1)
            {
                childForm.Opacity = i;
                await Task.Delay(10);
            }
            childForm.Show();
        }

        private void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            _cachedSelectedTheme = null;
            LoadTheme();
        }

        private void SetThemeColors(Color backColor, Color foreColor)
        {
            UIStyles.InitColorful(backColor, foreColor);
            MainTabControl.TabBackColor = backColor;
            MainTabControl.TabSelectedColor = backColor;
            MainTabControl.TabSelectedForeColor = foreColor;
            MainTabControl.TabSelectedHighColor = foreColor;
            MainTabControl.TabUnSelectedForeColor = foreColor;
            MainMenuStrip!.BackColor = backColor;
            HomeMenuStrip.BackColor = backColor;
            ToolsMenuStrip.BackColor = backColor;
            TasksMenuStrip.BackColor = backColor;
            SettingsMenuStrip.BackColor = backColor;
            NewUserToolStripMenuItem.BackColor = backColor;
            UsersToolStripMenuItem.BackColor = backColor;
            ExitToolStripMenuItem.BackColor = backColor;
            EditValueToolStripMenuItem.BackColor = backColor;
            EditTypeToolStripMenuItem.BackColor = backColor;
            HomePageLine.FillColor = foreColor;
            TasksLine.FillColor = foreColor;
            ToolsLine.FillColor = foreColor;
            SettingsLine.FillColor = foreColor;
        }

        private void LoadTheme()
        {
            if (_cachedSelectedTheme == null)
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string filePath = Path.Combine(desktopPath, "DailyTasks", "DailyTasks-MenuTheme.bin");
                _cachedSelectedTheme = SelectedTheme.Load(filePath);
            }

            switch (_cachedSelectedTheme.CurrentTheme)
            {
                case Theme.Cloud:
                    SetThemeColors(Color.SteelBlue, Color.White);
                    TitleColor = Color.FromArgb(50, 110, 160);
                    isCloud = true;
                    StartCloud();
                    break;
                case Theme.Summer:
                    SetThemeColors(Color.Green, Color.White);
                    TitleColor = Color.FromArgb(0, 108, 0);
                    isSummer = true;
                    StartSummer();
                    break;
                case Theme.Spring:
                    SetThemeColors(Color.LightPink, Color.Black);
                    HomePageLine.FillColor = Color.White;
                    TasksLine.FillColor = Color.White;
                    ToolsLine.FillColor = Color.White;
                    SettingsLine.FillColor = Color.White;
                    TitleColor = Color.FromArgb(235, 162, 173);
                    isSpring = true;
                    StartSpring();
                    break;
                case Theme.Fall:
                    SetThemeColors(Color.Orange, Color.Black);
                    HomePageLine.FillColor = Color.White;
                    TasksLine.FillColor = Color.White;
                    ToolsLine.FillColor = Color.White;
                    SettingsLine.FillColor = Color.White;
                    TitleColor = Color.FromArgb(235, 145, 0);
                    isFall = true;
                    StartFall();
                    break;
                case Theme.Snow:
                    SetThemeColors(Color.LightBlue, Color.Black);
                    TitleColor = Color.FromArgb(153, 196, 210);
                    isSnow = true;
                    StartSnow();
                    break;
                case Theme.Default:
                    SetThemeColors(Color.FromArgb(48, 48, 48), Color.White);
                    TitleColor = Color.FromArgb(36, 36, 36);
                    break;
            }
        }

        private static void FadeInLabel(Label label, Color startColor, Color endColor, int duration)
        {
            var timer = new System.Windows.Forms.Timer();
            int elapsed = 0;
            timer.Interval = 10;
            timer.Tick += (s, e) =>
            {
                elapsed += timer.Interval;
                float progress = (float)elapsed / duration;
                if (progress >= 1)
                {
                    progress = 1;
                    timer.Stop();
                }
                int r = (int)(startColor.R + (endColor.R - startColor.R) * progress);
                int g = (int)(startColor.G + (endColor.G - startColor.G) * progress);
                int b = (int)(startColor.B + (endColor.B - startColor.B) * progress);
                label.ForeColor = Color.FromArgb(r, g, b);
            };
            timer.Start();
        }

        private void TasksMenuStrip_Click(object sender, EventArgs e)
        {
            // Dynamically change the theme and get the new theme
            Theme newTheme = ThemeHelper.LoadTheme(this);

            // Call the OnThemeChanged method with the new theme
            ThemeChangedEventManager.OnThemeChanged(newTheme);
        }

        #endregion

        #region Graphics

        Graphics? Canvas;
        Random? rnd;

        Effect[]? Effects;

        readonly int CloudCount = 25;
        readonly int SnowflakeCount = 300;
        readonly int GreenLeafCount = 300;

        bool isCloud;
        bool isSummer;
        bool isSpring;
        bool isFall;
        bool isSnow;


        readonly Bitmap cloud = new(Resources.SingleCloud64);
        readonly Bitmap snow = new(Resources.SingleSnowflake16);
        readonly Bitmap spring = new(Resources.SingleSpringLeaf16);
        readonly Bitmap summer = new(Resources.SingleGreenLeaf16);
        readonly Bitmap fall = new(Resources.SingleAutumnLeaf16);

        private void MakeCloud()
        {
            for (int i = 0; i < CloudCount; i++)
            {
                float addSpeed = 1.3f + (float)rnd!.NextDouble();

                Effects![i] = new Effect(rnd!.Next(-100, 550), rnd!.Next(150, 180), addSpeed, rnd!.Next(16, 64), 1, cloud);
            }
        }
        private void MakeSnow()
        {
            float addSpeed = 2 + (float)rnd!.NextDouble();

            for (int i = 0; i < SnowflakeCount; i++)
            {
                Effects![i] = new Effect(rnd!.Next(-100, 1000), rnd!.Next(0, 580), addSpeed * 0.7f, rnd!.Next(8, 16), 1, snow);
            }
        }
        private void MakeSpring()
        {
            float addSpeed = 2 + (float)rnd!.NextDouble() + (float)rnd!.NextDouble() + (float)rnd!.NextDouble();

            for (int i = 0; i < SnowflakeCount; i++)
            {
                Effects![i] = new Effect(rnd!.Next(-100, 1000), rnd!.Next(0, 580), addSpeed * 0.5f, rnd!.Next(8, 32), 1, spring);
            }
        }
        private void MakeSummer()
        {
            float addSpeed = 2 + (float)rnd!.NextDouble() + (float)rnd!.NextDouble() + (float)rnd!.NextDouble();

            for (int i = 0; i < GreenLeafCount; i++)
            {
                Effects![i] = new Effect(rnd!.Next(-100, 1000), rnd!.Next(0, 580), addSpeed * 0.5f, rnd!.Next(8, 16), 1, summer);
            }
        }
        private void MakeAutumn()
        {
            float addSpeed = 2 + (float)rnd!.NextDouble() + (float)rnd!.NextDouble() + (float)rnd!.NextDouble();

            for (int i = 0; i < SnowflakeCount; i++)
            {
                Effects![i] = new Effect(rnd!.Next(-100, 1000), rnd!.Next(0, 580), addSpeed * 0.5f, rnd!.Next(8, 16), 1, fall);
            }
        }
        private void StartSnow()
        {
            rnd = new Random();

            Bitmap myBitmap = new(Width, Height);

            MainPictureBox.Image = myBitmap;

            Canvas = Graphics.FromImage(MainPictureBox.Image);
            Effects = new Effect[SnowflakeCount];
            MakeSnow();
        }
        private void StartSpring()
        {
            rnd = new Random();

            Bitmap myBitmap = new(Width, Height);

            MainPictureBox.Image = myBitmap;

            Canvas = Graphics.FromImage(MainPictureBox.Image);
            Effects = new Effect[SnowflakeCount];
            MakeSpring();
        }
        private void StartSummer()
        {
            rnd = new Random();

            Bitmap myBitmap = new(Width, Height);

            MainPictureBox.Image = myBitmap;

            Canvas = Graphics.FromImage(MainPictureBox.Image);
            Effects = new Effect[GreenLeafCount];
            MakeSummer();
        }
        private void StartFall()
        {
            rnd = new Random();

            Bitmap myBitmap = new(Width, Height);

            MainPictureBox.Image = myBitmap;

            Canvas = Graphics.FromImage(MainPictureBox.Image);
            Effects = new Effect[SnowflakeCount];
            MakeAutumn();
        }
        private void StartCloud()
        {
            rnd = new Random();

            Bitmap myBitmap = new(Width, Height);

            MainPictureBox.Image = myBitmap;

            Canvas = Graphics.FromImage(MainPictureBox.Image);
            Effects = new Effect[CloudCount];
            MakeCloud();
        }
        private void MainPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Canvas?.Clear(Color.Transparent);

            if (isSnow)
            {
                for (int i = 0; i < SnowflakeCount; i++)
                {
                    Canvas!.DrawImage(Effects![i].Img, Effects[i].X, Effects[i].Y, Effects[i].Size, Effects[i].Size);

                    Effects[i].Time += 0.9f;

                    if (Effects[i].Y > 600)
                    {
                        Effects[i].Y = -25;
                        Effects[i].Time = 0;
                    }
                    if (Effects[i].X > 580 & Effects[i].X < -5)
                    {
                        Effects[i].X = rnd!.Next(0, 580);
                    }
                    else
                    {
                        Effects[i].Y += Effects[i].Speed + rnd!.Next(-1, 0);
                    }
                }
            }
            else if (isCloud)
            {
                for (int i = 0; i < CloudCount; i++)
                {
                    Canvas!.DrawImage(Effects![i].Img, Effects[i].X, Effects[i].Y, Effects[i].Size, Effects[i].Size);

                    Effects[i].Time += 0.9f;

                    if (Effects[i].X > 700)
                    {
                        Effects[i].X = -25;
                        Effects[i].Time = 0;
                    }
                    if (Effects[i].Y > 580 & Effects[i].Y < -5)
                    {
                        Effects[i].Y = rnd!.Next(0, 580);
                    }
                    else
                    {
                        Effects[i].X += Effects[i].Speed + rnd!.Next(-1, 0);
                    }
                }
            }
            else if (isFall)
            {
                for (int i = 0; i < SnowflakeCount; i++)
                {
                    Canvas!.DrawImage(Effects![i].Img, Effects[i].X, Effects[i].Y, Effects[i].Size, Effects[i].Size);

                    Effects[i].Time += 0.9f;
                    Effects[i].X += (float)Math.Sin(Effects[i].Time) * 2;

                    if (Effects[i].Y > 600)
                    {
                        Effects[i].Y = -15;
                        Effects[i].Time = 0;
                    }
                    if (Effects[i].X > 580 & Effects[i].X < -5)
                    {
                        Effects[i].X = rnd!.Next(0, 580);
                    }
                    else
                    {
                        Effects[i].Y += Effects[i].Speed + rnd!.Next(-1, 0);
                    }
                }
            }
            else if (isSpring)
            {
                for (int i = 0; i < SnowflakeCount; i++)
                {
                    Canvas!.DrawImage(Effects![i].Img, Effects[i].X, Effects[i].Y, Effects[i].Size, Effects[i].Size);

                    Effects[i].Time += 0.2f;

                    if (Effects[i].Y > 600)
                    {
                        Effects[i].Y = -15;
                        Effects[i].Time = 0;
                    }
                    if (Effects[i].X > 580 & Effects[i].X < -5)
                    {
                        Effects[i].X = rnd!.Next(0, 580);
                    }
                    else
                    {
                        Effects[i].Y += Effects[i].Speed + rnd!.Next(-1, 0);
                    }
                }
            }
            else if (isSummer)
            {
                for (int i = 0; i < GreenLeafCount; i++)
                {
                    Canvas!.DrawImage(Effects![i].Img, Effects[i].X, Effects[i].Y, Effects[i].Size, Effects[i].Size);

                    Effects[i].Time += 0.2f;

                    if (Effects[i].Y > 600)
                    {
                        Effects[i].Y = -15;
                        Effects[i].Time = 0;
                    }
                    if (Effects[i].X > 580 & Effects[i].X < -5)
                    {
                        Effects[i].X = rnd!.Next(0, 580);
                    }
                    else
                    {
                        Effects[i].Y += Effects[i].Speed + rnd!.Next(-1, 0);
                    }
                }
            }
        }
        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            MainPictureBox.Invalidate();
        }

        #endregion

        #region Share Image Function

        private delegate void UpdateImageDelegate(string notification);

        private void ImageAlert(string notification)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new UpdateImageDelegate(ImageAlert), new object[] { notification });
                return;
            }
            Notification.Classes.Notification.ShowInformation(notification, 5000);
        }

        private async void OnImageCreated(object sender, FileSystemEventArgs e)
        {
            try
            {
                watcher.EnableRaisingEvents = false;
                await ProcessAsync(cts.Token);
            }
            finally
            {
                watcher.EnableRaisingEvents = true;
            }
        }

        public static FileInfo GetNewestFile(DirectoryInfo directory)
        {
            return directory.GetFiles()
                .OrderByDescending(f => f.LastWriteTime)
                .FirstOrDefault()!;
        }

        private async Task ProcessAsync(CancellationToken cancellationToken)
        {
            FileInfo newestFile = GetNewestFile(new DirectoryInfo(GetFolder()));
            if (!File.Exists(newestFile.FullName))
            {
                return;
            }
            string alert = $"{newestFile.Name.Split(" - ").FirstOrDefault()!} sent an image";
            await Task.Run(() => ImageAlert(alert), cancellationToken);
        }

        private void ShareScreenshotButton_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject() is IDataObject data && data.GetDataPresent(DataFormats.Bitmap))
            {
                if (data.GetData(DataFormats.Bitmap, true) is Image image)
                {
                    using Bitmap bm = new(image);
                    StringBuilder fileNameBuilder = new();
                    fileNameBuilder.Append(GetFolder());
                    fileNameBuilder.Append(CurrentUserTasks.Text);
                    fileNameBuilder.Append(" - ");
                    fileNameBuilder.Append(DateTime.Now.ToString("MMdd-HH-mm-ss"));
                    fileNameBuilder.Append(".jpg");

                    using var fileStream = new FileStream(fileNameBuilder.ToString(), FileMode.Create);
                    using var bufferedStream = new BufferedStream(fileStream);
                    bm.Save(bufferedStream, System.Drawing.Imaging.ImageFormat.Jpeg);

                    ShareImageTimer.Start();
                    ShareImageLabel.Text = "Image saved!";
                    ShareImageLabel.Visible = true;
                    ShowInfoTip("Image captured and saved!");
                }
            }
            else
            {
                ShareImageTimer.Start();
                ShareImageLabel.Text = "Error";
                ShareImageLabel.Visible = true;
                ShowErrorTip("The Data In Clipboard is not in image format!");
            }
        }

        #endregion

    }
}