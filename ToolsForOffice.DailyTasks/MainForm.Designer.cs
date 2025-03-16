namespace ToolsForOffice.DailyTasks
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainTabControl = new Sunny.UI.UITabControl();
            HomePage = new TabPage();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            MainPictureBox = new PictureBox();
            uiButton4 = new Sunny.UI.UIButton();
            SourceLabel = new Sunny.UI.UILabel();
            ConnectLabelHome = new Sunny.UI.UILabel();
            SourceCodeLabel = new Sunny.UI.UILinkLabel();
            HomePageLine = new Sunny.UI.UILine();
            ConditionsLabel = new Sunny.UI.UILabel();
            CelsiusLabel = new Sunny.UI.UILabel();
            LocationLabel = new Sunny.UI.UILabel();
            CurrentUserHome = new Sunny.UI.UILabel();
            HomeMenuStrip = new MenuStrip();
            TaskPage = new TabPage();
            ConnectLabelTask = new Sunny.UI.UILabel();
            uiButton1 = new Sunny.UI.UIButton();
            ShareImageLabel = new Label();
            CurrentUserTasks = new Sunny.UI.UILabel();
            TasksLine = new Sunny.UI.UILine();
            MainDataGridView = new Sunny.UI.UIDataGridView();
            CurrentWeekButton = new Sunny.UI.UIButton();
            ShowAllButton = new Sunny.UI.UIButton();
            MainDateTimePicker = new DateTimePicker();
            ShareScreenshotButton = new Sunny.UI.UIButton();
            RemoveTaskButton = new Sunny.UI.UIButton();
            UpdateTaskButton = new Sunny.UI.UIButton();
            AddTaskButton = new Sunny.UI.UIButton();
            MainListBox = new Sunny.UI.UIListBox();
            TasksMenuStrip = new MenuStrip();
            ManageUsersMenuStrip = new ToolStripMenuItem();
            NewUserToolStripMenuItem = new ToolStripMenuItem();
            UsersToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            ChangeValuesToolStripMenuItem = new ToolStripMenuItem();
            EditValueToolStripMenuItem = new ToolStripMenuItem();
            ChangeTypesToolStripMenuItem = new ToolStripMenuItem();
            EditTypeToolStripMenuItem = new ToolStripMenuItem();
            ToolsPage = new TabPage();
            uiButton2 = new Sunny.UI.UIButton();
            ToolsLine = new Sunny.UI.UILine();
            EditClipboardLabel = new Sunny.UI.UILabel();
            EditClipboardButton = new Sunny.UI.UIImageButton();
            uiLabel4 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            ClipboardButton = new Sunny.UI.UIImageButton();
            ScreenshotShareButton = new Sunny.UI.UIImageButton();
            ToolsMenuStrip = new MenuStrip();
            SettingsPage = new TabPage();
            uiButton3 = new Sunny.UI.UIButton();
            SettingsLine = new Sunny.UI.UILine();
            SettingsMenuStrip = new MenuStrip();
            CULabel = new Sunny.UI.UILabel();
            CustomUIButton = new Sunny.UI.UIImageButton();
            MDLabel = new Sunny.UI.UILabel();
            ManageDataButton = new Sunny.UI.UIImageButton();
            ShareImageTimer = new System.Windows.Forms.Timer(components);
            TimerUpdate = new System.Windows.Forms.Timer(components);
            MainTabControl.SuspendLayout();
            HomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).BeginInit();
            TaskPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainDataGridView).BeginInit();
            TasksMenuStrip.SuspendLayout();
            ToolsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EditClipboardButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClipboardButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ScreenshotShareButton).BeginInit();
            SettingsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomUIButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ManageDataButton).BeginInit();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(HomePage);
            MainTabControl.Controls.Add(TaskPage);
            MainTabControl.Controls.Add(ToolsPage);
            MainTabControl.Controls.Add(SettingsPage);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            MainTabControl.FillColor = Color.White;
            MainTabControl.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainTabControl.Frame = this;
            MainTabControl.ItemSize = new Size(150, 40);
            MainTabControl.Location = new Point(0, 35);
            MainTabControl.MainPage = "";
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(1026, 590);
            MainTabControl.SizeMode = TabSizeMode.Fixed;
            MainTabControl.Style = Sunny.UI.UIStyle.Custom;
            MainTabControl.TabIndex = 0;
            MainTabControl.TabSelectedForeColor = Color.White;
            MainTabControl.TabSelectedHighColor = Color.White;
            MainTabControl.TabUnSelectedForeColor = Color.FromArgb(240, 240, 240);
            // 
            // HomePage
            // 
            HomePage.BackColor = Color.White;
            HomePage.BorderStyle = BorderStyle.FixedSingle;
            HomePage.Controls.Add(pictureBox1);
            HomePage.Controls.Add(pictureBox2);
            HomePage.Controls.Add(MainPictureBox);
            HomePage.Controls.Add(uiButton4);
            HomePage.Controls.Add(SourceLabel);
            HomePage.Controls.Add(ConnectLabelHome);
            HomePage.Controls.Add(SourceCodeLabel);
            HomePage.Controls.Add(HomePageLine);
            HomePage.Controls.Add(ConditionsLabel);
            HomePage.Controls.Add(CelsiusLabel);
            HomePage.Controls.Add(LocationLabel);
            HomePage.Controls.Add(CurrentUserHome);
            HomePage.Controls.Add(HomeMenuStrip);
            HomePage.Location = new Point(0, 40);
            HomePage.Name = "HomePage";
            HomePage.Size = new Size(1026, 550);
            HomePage.TabIndex = 0;
            HomePage.Text = "Home";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(329, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 200);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(648, 117);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 200);
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // MainPictureBox
            // 
            MainPictureBox.BackColor = Color.Transparent;
            MainPictureBox.BackgroundImage = Properties.Resources.DailyTask_MainIcon;
            MainPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            MainPictureBox.Location = new Point(346, 117);
            MainPictureBox.Name = "MainPictureBox";
            MainPictureBox.Size = new Size(345, 200);
            MainPictureBox.TabIndex = 1;
            MainPictureBox.TabStop = false;
            MainPictureBox.Paint += MainPictureBox_Paint;
            // 
            // uiButton4
            // 
            uiButton4.FillColor = Color.FromArgb(48, 48, 48);
            uiButton4.FillColor2 = Color.FromArgb(48, 48, 48);
            uiButton4.FillHoverColor = Color.FromArgb(109, 109, 103);
            uiButton4.FillPressColor = Color.FromArgb(109, 109, 103);
            uiButton4.FillSelectedColor = Color.FromArgb(109, 109, 103);
            uiButton4.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton4.Location = new Point(921, 520);
            uiButton4.MinimumSize = new Size(1, 1);
            uiButton4.Name = "uiButton4";
            uiButton4.RectColor = Color.FromArgb(48, 48, 48);
            uiButton4.RectHoverColor = Color.FromArgb(109, 109, 103);
            uiButton4.RectPressColor = Color.FromArgb(109, 109, 103);
            uiButton4.RectSelectedColor = Color.FromArgb(109, 109, 103);
            uiButton4.Size = new Size(100, 22);
            uiButton4.Style = Sunny.UI.UIStyle.Custom;
            uiButton4.TabIndex = 26;
            uiButton4.Text = "Quick Guide";
            // 
            // SourceLabel
            // 
            SourceLabel.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SourceLabel.Location = new Point(3, 520);
            SourceLabel.Name = "SourceLabel";
            SourceLabel.Size = new Size(87, 22);
            SourceLabel.Style = Sunny.UI.UIStyle.Custom;
            SourceLabel.TabIndex = 19;
            SourceLabel.Text = "Source code:";
            SourceLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ConnectLabelHome
            // 
            ConnectLabelHome.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ConnectLabelHome.Location = new Point(389, 520);
            ConnectLabelHome.Name = "ConnectLabelHome";
            ConnectLabelHome.Size = new Size(253, 22);
            ConnectLabelHome.Style = Sunny.UI.UIStyle.Custom;
            ConnectLabelHome.TabIndex = 18;
            ConnectLabelHome.Text = "Connect Time:";
            ConnectLabelHome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SourceCodeLabel
            // 
            SourceCodeLabel.ActiveLinkColor = Color.FromArgb(220, 155, 40);
            SourceCodeLabel.BackColor = Color.White;
            SourceCodeLabel.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SourceCodeLabel.LinkBehavior = LinkBehavior.AlwaysUnderline;
            SourceCodeLabel.Location = new Point(89, 523);
            SourceCodeLabel.Name = "SourceCodeLabel";
            SourceCodeLabel.Size = new Size(148, 22);
            SourceCodeLabel.Style = Sunny.UI.UIStyle.Custom;
            SourceCodeLabel.TabIndex = 17;
            SourceCodeLabel.TabStop = true;
            SourceCodeLabel.Text = "https://github.com/60int/DailyTasksNew";
            SourceCodeLabel.TextAlign = ContentAlignment.MiddleLeft;
            SourceCodeLabel.VisitedLinkColor = Color.FromArgb(230, 80, 80);
            SourceCodeLabel.Click += SourceCodeLabel_Click;
            // 
            // HomePageLine
            // 
            HomePageLine.FillColor = Color.White;
            HomePageLine.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HomePageLine.LineColor = Color.FromArgb(48, 48, 48);
            HomePageLine.LineColor2 = Color.FromArgb(48, 48, 48);
            HomePageLine.Location = new Point(-2, 508);
            HomePageLine.MinimumSize = new Size(1, 1);
            HomePageLine.Name = "HomePageLine";
            HomePageLine.Size = new Size(1029, 10);
            HomePageLine.Style = Sunny.UI.UIStyle.Custom;
            HomePageLine.TabIndex = 1;
            // 
            // ConditionsLabel
            // 
            ConditionsLabel.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ConditionsLabel.Location = new Point(389, 416);
            ConditionsLabel.Name = "ConditionsLabel";
            ConditionsLabel.Size = new Size(253, 23);
            ConditionsLabel.Style = Sunny.UI.UIStyle.Custom;
            ConditionsLabel.TabIndex = 16;
            ConditionsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CelsiusLabel
            // 
            CelsiusLabel.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CelsiusLabel.Location = new Point(389, 374);
            CelsiusLabel.Name = "CelsiusLabel";
            CelsiusLabel.Size = new Size(253, 23);
            CelsiusLabel.Style = Sunny.UI.UIStyle.Custom;
            CelsiusLabel.TabIndex = 15;
            CelsiusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LocationLabel
            // 
            LocationLabel.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LocationLabel.Location = new Point(389, 330);
            LocationLabel.Name = "LocationLabel";
            LocationLabel.Size = new Size(253, 23);
            LocationLabel.Style = Sunny.UI.UIStyle.Custom;
            LocationLabel.TabIndex = 0;
            LocationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CurrentUserHome
            // 
            CurrentUserHome.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentUserHome.Location = new Point(791, 29);
            CurrentUserHome.Name = "CurrentUserHome";
            CurrentUserHome.Size = new Size(230, 32);
            CurrentUserHome.Style = Sunny.UI.UIStyle.Custom;
            CurrentUserHome.TabIndex = 13;
            CurrentUserHome.Text = "Current User:";
            CurrentUserHome.TextAlign = ContentAlignment.MiddleRight;
            // 
            // HomeMenuStrip
            // 
            HomeMenuStrip.BackColor = Color.FromArgb(56, 56, 56);
            HomeMenuStrip.Location = new Point(0, 0);
            HomeMenuStrip.Name = "HomeMenuStrip";
            HomeMenuStrip.Size = new Size(1024, 24);
            HomeMenuStrip.TabIndex = 0;
            HomeMenuStrip.Text = "menuStrip1";
            // 
            // TaskPage
            // 
            TaskPage.BackColor = Color.White;
            TaskPage.BorderStyle = BorderStyle.FixedSingle;
            TaskPage.Controls.Add(ConnectLabelTask);
            TaskPage.Controls.Add(uiButton1);
            TaskPage.Controls.Add(ShareImageLabel);
            TaskPage.Controls.Add(CurrentUserTasks);
            TaskPage.Controls.Add(TasksLine);
            TaskPage.Controls.Add(MainDataGridView);
            TaskPage.Controls.Add(CurrentWeekButton);
            TaskPage.Controls.Add(ShowAllButton);
            TaskPage.Controls.Add(MainDateTimePicker);
            TaskPage.Controls.Add(ShareScreenshotButton);
            TaskPage.Controls.Add(RemoveTaskButton);
            TaskPage.Controls.Add(UpdateTaskButton);
            TaskPage.Controls.Add(AddTaskButton);
            TaskPage.Controls.Add(MainListBox);
            TaskPage.Controls.Add(TasksMenuStrip);
            TaskPage.Location = new Point(0, 40);
            TaskPage.Name = "TaskPage";
            TaskPage.Size = new Size(200, 60);
            TaskPage.TabIndex = 1;
            TaskPage.Text = "Tasks";
            // 
            // ConnectLabelTask
            // 
            ConnectLabelTask.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ConnectLabelTask.Location = new Point(389, 520);
            ConnectLabelTask.Name = "ConnectLabelTask";
            ConnectLabelTask.Size = new Size(253, 22);
            ConnectLabelTask.Style = Sunny.UI.UIStyle.Custom;
            ConnectLabelTask.TabIndex = 26;
            ConnectLabelTask.Text = "Connect Time:";
            ConnectLabelTask.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiButton1
            // 
            uiButton1.FillColor = Color.FromArgb(48, 48, 48);
            uiButton1.FillColor2 = Color.FromArgb(48, 48, 48);
            uiButton1.FillHoverColor = Color.FromArgb(109, 109, 103);
            uiButton1.FillPressColor = Color.FromArgb(109, 109, 103);
            uiButton1.FillSelectedColor = Color.FromArgb(109, 109, 103);
            uiButton1.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(921, 520);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.RectColor = Color.FromArgb(48, 48, 48);
            uiButton1.RectHoverColor = Color.FromArgb(109, 109, 103);
            uiButton1.RectPressColor = Color.FromArgb(109, 109, 103);
            uiButton1.RectSelectedColor = Color.FromArgb(109, 109, 103);
            uiButton1.Size = new Size(100, 22);
            uiButton1.Style = Sunny.UI.UIStyle.Custom;
            uiButton1.TabIndex = 25;
            uiButton1.Text = "Quick Guide";
            // 
            // ShareImageLabel
            // 
            ShareImageLabel.AutoSize = true;
            ShareImageLabel.Location = new Point(471, 35);
            ShareImageLabel.Name = "ShareImageLabel";
            ShareImageLabel.Size = new Size(0, 21);
            ShareImageLabel.TabIndex = 12;
            // 
            // CurrentUserTasks
            // 
            CurrentUserTasks.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentUserTasks.Location = new Point(791, 29);
            CurrentUserTasks.Name = "CurrentUserTasks";
            CurrentUserTasks.Size = new Size(230, 32);
            CurrentUserTasks.Style = Sunny.UI.UIStyle.Custom;
            CurrentUserTasks.TabIndex = 11;
            CurrentUserTasks.Text = "Current User:";
            CurrentUserTasks.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TasksLine
            // 
            TasksLine.BackColor = Color.White;
            TasksLine.FillColor = Color.White;
            TasksLine.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TasksLine.LineColor = Color.FromArgb(48, 48, 48);
            TasksLine.LineColor2 = Color.FromArgb(48, 48, 48);
            TasksLine.Location = new Point(-2, 508);
            TasksLine.MinimumSize = new Size(1, 1);
            TasksLine.Name = "TasksLine";
            TasksLine.Size = new Size(1027, 10);
            TasksLine.Style = Sunny.UI.UIStyle.Custom;
            TasksLine.TabIndex = 21;
            // 
            // MainDataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            MainDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            MainDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            MainDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            MainDataGridView.BackgroundColor = Color.White;
            MainDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            MainDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            MainDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            MainDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            MainDataGridView.EnableHeadersVisualStyles = false;
            MainDataGridView.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainDataGridView.GridColor = Color.FromArgb(48, 48, 48);
            MainDataGridView.Location = new Point(201, 68);
            MainDataGridView.Name = "MainDataGridView";
            MainDataGridView.RectColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            MainDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            MainDataGridView.RowTemplate.Height = 25;
            MainDataGridView.ScrollBarBackColor = Color.White;
            MainDataGridView.ScrollBarColor = Color.FromArgb(48, 48, 48);
            MainDataGridView.ScrollBarRectColor = Color.FromArgb(48, 48, 48);
            MainDataGridView.SelectedIndex = -1;
            MainDataGridView.Size = new Size(821, 439);
            MainDataGridView.StripeOddColor = Color.White;
            MainDataGridView.Style = Sunny.UI.UIStyle.Custom;
            MainDataGridView.TabIndex = 9;
            // 
            // CurrentWeekButton
            // 
            CurrentWeekButton.FillColor = Color.FromArgb(48, 48, 48);
            CurrentWeekButton.FillColor2 = Color.FromArgb(48, 48, 48);
            CurrentWeekButton.FillHoverColor = Color.FromArgb(109, 109, 103);
            CurrentWeekButton.FillPressColor = Color.FromArgb(109, 109, 103);
            CurrentWeekButton.FillSelectedColor = Color.FromArgb(109, 109, 103);
            CurrentWeekButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentWeekButton.Location = new Point(331, 31);
            CurrentWeekButton.MinimumSize = new Size(1, 1);
            CurrentWeekButton.Name = "CurrentWeekButton";
            CurrentWeekButton.RectColor = Color.FromArgb(48, 48, 48);
            CurrentWeekButton.RectHoverColor = Color.FromArgb(109, 109, 103);
            CurrentWeekButton.RectPressColor = Color.FromArgb(109, 109, 103);
            CurrentWeekButton.RectSelectedColor = Color.FromArgb(109, 109, 103);
            CurrentWeekButton.Size = new Size(124, 29);
            CurrentWeekButton.Style = Sunny.UI.UIStyle.Custom;
            CurrentWeekButton.TabIndex = 8;
            CurrentWeekButton.Text = "Current Week";
            CurrentWeekButton.Click += CurrentWeekButton_Click;
            // 
            // ShowAllButton
            // 
            ShowAllButton.FillColor = Color.FromArgb(48, 48, 48);
            ShowAllButton.FillColor2 = Color.FromArgb(48, 48, 48);
            ShowAllButton.FillHoverColor = Color.FromArgb(109, 109, 103);
            ShowAllButton.FillPressColor = Color.FromArgb(109, 109, 103);
            ShowAllButton.FillSelectedColor = Color.FromArgb(109, 109, 103);
            ShowAllButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ShowAllButton.Location = new Point(201, 31);
            ShowAllButton.MinimumSize = new Size(1, 1);
            ShowAllButton.Name = "ShowAllButton";
            ShowAllButton.RectColor = Color.FromArgb(48, 48, 48);
            ShowAllButton.RectHoverColor = Color.FromArgb(109, 109, 103);
            ShowAllButton.RectPressColor = Color.FromArgb(109, 109, 103);
            ShowAllButton.RectSelectedColor = Color.FromArgb(109, 109, 103);
            ShowAllButton.Size = new Size(124, 29);
            ShowAllButton.Style = Sunny.UI.UIStyle.Custom;
            ShowAllButton.TabIndex = 7;
            ShowAllButton.Text = "Show All";
            ShowAllButton.Click += ShowAllButton_Click;
            // 
            // MainDateTimePicker
            // 
            MainDateTimePicker.CalendarTitleBackColor = SystemColors.GrayText;
            MainDateTimePicker.Format = DateTimePickerFormat.Short;
            MainDateTimePicker.Location = new Point(5, 31);
            MainDateTimePicker.Name = "MainDateTimePicker";
            MainDateTimePicker.Size = new Size(191, 29);
            MainDateTimePicker.TabIndex = 6;
            MainDateTimePicker.ValueChanged += MainDateTimePicker_ValueChanged;
            // 
            // ShareScreenshotButton
            // 
            ShareScreenshotButton.FillColor = Color.FromArgb(48, 48, 48);
            ShareScreenshotButton.FillColor2 = Color.FromArgb(48, 48, 48);
            ShareScreenshotButton.FillHoverColor = Color.FromArgb(109, 109, 103);
            ShareScreenshotButton.FillPressColor = Color.FromArgb(109, 109, 103);
            ShareScreenshotButton.FillSelectedColor = Color.FromArgb(109, 109, 103);
            ShareScreenshotButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ShareScreenshotButton.Location = new Point(4, 472);
            ShareScreenshotButton.MinimumSize = new Size(1, 1);
            ShareScreenshotButton.Name = "ShareScreenshotButton";
            ShareScreenshotButton.RectColor = Color.FromArgb(48, 48, 48);
            ShareScreenshotButton.RectHoverColor = Color.FromArgb(109, 109, 103);
            ShareScreenshotButton.RectPressColor = Color.FromArgb(109, 109, 103);
            ShareScreenshotButton.RectSelectedColor = Color.FromArgb(109, 109, 103);
            ShareScreenshotButton.Size = new Size(191, 35);
            ShareScreenshotButton.Style = Sunny.UI.UIStyle.Custom;
            ShareScreenshotButton.TabIndex = 5;
            ShareScreenshotButton.Text = "Share Screenshot";
            ShareScreenshotButton.Click += ShareScreenshotButton_Click;
            // 
            // RemoveTaskButton
            // 
            RemoveTaskButton.FillColor = Color.FromArgb(48, 48, 48);
            RemoveTaskButton.FillColor2 = Color.FromArgb(48, 48, 48);
            RemoveTaskButton.FillHoverColor = Color.FromArgb(109, 109, 103);
            RemoveTaskButton.FillPressColor = Color.FromArgb(109, 109, 103);
            RemoveTaskButton.FillSelectedColor = Color.FromArgb(109, 109, 103);
            RemoveTaskButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveTaskButton.Location = new Point(4, 431);
            RemoveTaskButton.MinimumSize = new Size(1, 1);
            RemoveTaskButton.Name = "RemoveTaskButton";
            RemoveTaskButton.RectColor = Color.FromArgb(48, 48, 48);
            RemoveTaskButton.RectHoverColor = Color.FromArgb(109, 109, 103);
            RemoveTaskButton.RectPressColor = Color.FromArgb(109, 109, 103);
            RemoveTaskButton.RectSelectedColor = Color.FromArgb(109, 109, 103);
            RemoveTaskButton.Size = new Size(191, 35);
            RemoveTaskButton.Style = Sunny.UI.UIStyle.Custom;
            RemoveTaskButton.TabIndex = 4;
            RemoveTaskButton.Text = "Remove Task";
            RemoveTaskButton.Click += RemoveTaskButton_Click;
            // 
            // UpdateTaskButton
            // 
            UpdateTaskButton.FillColor = Color.FromArgb(48, 48, 48);
            UpdateTaskButton.FillColor2 = Color.FromArgb(48, 48, 48);
            UpdateTaskButton.FillHoverColor = Color.FromArgb(109, 109, 103);
            UpdateTaskButton.FillPressColor = Color.FromArgb(109, 109, 103);
            UpdateTaskButton.FillSelectedColor = Color.FromArgb(109, 109, 103);
            UpdateTaskButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateTaskButton.Location = new Point(4, 390);
            UpdateTaskButton.MinimumSize = new Size(1, 1);
            UpdateTaskButton.Name = "UpdateTaskButton";
            UpdateTaskButton.RectColor = Color.FromArgb(48, 48, 48);
            UpdateTaskButton.RectHoverColor = Color.FromArgb(109, 109, 103);
            UpdateTaskButton.RectPressColor = Color.FromArgb(109, 109, 103);
            UpdateTaskButton.RectSelectedColor = Color.FromArgb(109, 109, 103);
            UpdateTaskButton.Size = new Size(191, 35);
            UpdateTaskButton.Style = Sunny.UI.UIStyle.Custom;
            UpdateTaskButton.TabIndex = 3;
            UpdateTaskButton.Text = "Update Task";
            UpdateTaskButton.Click += UpdateTaskButton_Click;
            // 
            // AddTaskButton
            // 
            AddTaskButton.FillColor = Color.FromArgb(48, 48, 48);
            AddTaskButton.FillColor2 = Color.FromArgb(48, 48, 48);
            AddTaskButton.FillHoverColor = Color.FromArgb(109, 109, 103);
            AddTaskButton.FillPressColor = Color.FromArgb(109, 109, 103);
            AddTaskButton.FillSelectedColor = Color.FromArgb(109, 109, 103);
            AddTaskButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddTaskButton.Location = new Point(4, 349);
            AddTaskButton.MinimumSize = new Size(1, 1);
            AddTaskButton.Name = "AddTaskButton";
            AddTaskButton.RectColor = Color.FromArgb(48, 48, 48);
            AddTaskButton.RectHoverColor = Color.FromArgb(109, 109, 103);
            AddTaskButton.RectPressColor = Color.FromArgb(109, 109, 103);
            AddTaskButton.RectSelectedColor = Color.FromArgb(109, 109, 103);
            AddTaskButton.Size = new Size(191, 35);
            AddTaskButton.Style = Sunny.UI.UIStyle.Custom;
            AddTaskButton.TabIndex = 2;
            AddTaskButton.Text = "Add Task";
            AddTaskButton.Click += AddTaskButton_Click;
            // 
            // MainListBox
            // 
            MainListBox.FillColor = Color.White;
            MainListBox.FillColor2 = Color.White;
            MainListBox.FillDisableColor = Color.White;
            MainListBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MainListBox.HoverColor = Color.Silver;
            MainListBox.ItemSelectBackColor = Color.FromArgb(109, 109, 103);
            MainListBox.ItemSelectForeColor = Color.White;
            MainListBox.Location = new Point(4, 68);
            MainListBox.Margin = new Padding(4, 5, 4, 5);
            MainListBox.MinimumSize = new Size(1, 1);
            MainListBox.Name = "MainListBox";
            MainListBox.Padding = new Padding(2);
            MainListBox.RectColor = Color.FromArgb(48, 48, 48);
            MainListBox.ScrollBarBackColor = Color.White;
            MainListBox.ScrollBarColor = Color.FromArgb(48, 48, 48);
            MainListBox.ShowText = false;
            MainListBox.Size = new Size(191, 273);
            MainListBox.Style = Sunny.UI.UIStyle.Custom;
            MainListBox.TabIndex = 1;
            MainListBox.Text = null;
            MainListBox.DoubleClick += MainListBox_DoubleClick;
            // 
            // TasksMenuStrip
            // 
            TasksMenuStrip.BackColor = Color.FromArgb(56, 56, 56);
            TasksMenuStrip.Items.AddRange(new ToolStripItem[] { ManageUsersMenuStrip, ChangeValuesToolStripMenuItem, ChangeTypesToolStripMenuItem });
            TasksMenuStrip.Location = new Point(0, 0);
            TasksMenuStrip.Name = "TasksMenuStrip";
            TasksMenuStrip.Size = new Size(198, 24);
            TasksMenuStrip.TabIndex = 0;
            TasksMenuStrip.Text = "menuStrip2";
            TasksMenuStrip.Click += TasksMenuStrip_Click;
            // 
            // ManageUsersMenuStrip
            // 
            ManageUsersMenuStrip.DropDownItems.AddRange(new ToolStripItem[] { NewUserToolStripMenuItem, UsersToolStripMenuItem, ExitToolStripMenuItem });
            ManageUsersMenuStrip.ForeColor = Color.White;
            ManageUsersMenuStrip.Name = "ManageUsersMenuStrip";
            ManageUsersMenuStrip.Size = new Size(93, 20);
            ManageUsersMenuStrip.Text = "Manage Users";
            ManageUsersMenuStrip.DropDownClosed += ToolStripMenuItem_DropDownClosed;
            ManageUsersMenuStrip.DropDownOpened += ToolStripMenuItem_DropDownOpened;
            // 
            // NewUserToolStripMenuItem
            // 
            NewUserToolStripMenuItem.BackColor = Color.FromArgb(56, 56, 56);
            NewUserToolStripMenuItem.ForeColor = Color.White;
            NewUserToolStripMenuItem.Name = "NewUserToolStripMenuItem";
            NewUserToolStripMenuItem.Size = new Size(131, 22);
            NewUserToolStripMenuItem.Text = "New User";
            NewUserToolStripMenuItem.Click += NewUserToolStripMenuItem_Click;
            // 
            // UsersToolStripMenuItem
            // 
            UsersToolStripMenuItem.BackColor = Color.FromArgb(56, 56, 56);
            UsersToolStripMenuItem.ForeColor = Color.White;
            UsersToolStripMenuItem.Name = "UsersToolStripMenuItem";
            UsersToolStripMenuItem.Size = new Size(131, 22);
            UsersToolStripMenuItem.Text = "Select User";
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.BackColor = Color.FromArgb(56, 56, 56);
            ExitToolStripMenuItem.ForeColor = Color.White;
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(131, 22);
            ExitToolStripMenuItem.Text = "Exit";
            // 
            // ChangeValuesToolStripMenuItem
            // 
            ChangeValuesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { EditValueToolStripMenuItem });
            ChangeValuesToolStripMenuItem.ForeColor = Color.White;
            ChangeValuesToolStripMenuItem.Name = "ChangeValuesToolStripMenuItem";
            ChangeValuesToolStripMenuItem.Size = new Size(96, 20);
            ChangeValuesToolStripMenuItem.Text = "Change Values";
            ChangeValuesToolStripMenuItem.DropDownClosed += ToolStripMenuItem_DropDownClosed;
            ChangeValuesToolStripMenuItem.DropDownOpened += ToolStripMenuItem_DropDownOpened;
            // 
            // EditValueToolStripMenuItem
            // 
            EditValueToolStripMenuItem.BackColor = Color.FromArgb(56, 56, 56);
            EditValueToolStripMenuItem.ForeColor = Color.White;
            EditValueToolStripMenuItem.Name = "EditValueToolStripMenuItem";
            EditValueToolStripMenuItem.Size = new Size(94, 22);
            EditValueToolStripMenuItem.Text = "Edit";
            EditValueToolStripMenuItem.Click += EditValueToolStripMenuItem_Click;
            // 
            // ChangeTypesToolStripMenuItem
            // 
            ChangeTypesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { EditTypeToolStripMenuItem });
            ChangeTypesToolStripMenuItem.ForeColor = Color.White;
            ChangeTypesToolStripMenuItem.Name = "ChangeTypesToolStripMenuItem";
            ChangeTypesToolStripMenuItem.Size = new Size(92, 20);
            ChangeTypesToolStripMenuItem.Text = "Change Types";
            ChangeTypesToolStripMenuItem.DropDownClosed += ToolStripMenuItem_DropDownClosed;
            ChangeTypesToolStripMenuItem.DropDownOpened += ToolStripMenuItem_DropDownOpened;
            // 
            // EditTypeToolStripMenuItem
            // 
            EditTypeToolStripMenuItem.BackColor = Color.FromArgb(56, 56, 56);
            EditTypeToolStripMenuItem.ForeColor = Color.White;
            EditTypeToolStripMenuItem.Name = "EditTypeToolStripMenuItem";
            EditTypeToolStripMenuItem.Size = new Size(94, 22);
            EditTypeToolStripMenuItem.Text = "Edit";
            EditTypeToolStripMenuItem.Click += EditTypeToolStripMenuItem_Click;
            // 
            // ToolsPage
            // 
            ToolsPage.BackColor = Color.White;
            ToolsPage.BorderStyle = BorderStyle.FixedSingle;
            ToolsPage.Controls.Add(uiButton2);
            ToolsPage.Controls.Add(ToolsLine);
            ToolsPage.Controls.Add(EditClipboardLabel);
            ToolsPage.Controls.Add(EditClipboardButton);
            ToolsPage.Controls.Add(uiLabel4);
            ToolsPage.Controls.Add(uiLabel3);
            ToolsPage.Controls.Add(ClipboardButton);
            ToolsPage.Controls.Add(ScreenshotShareButton);
            ToolsPage.Controls.Add(ToolsMenuStrip);
            ToolsPage.Location = new Point(0, 40);
            ToolsPage.Name = "ToolsPage";
            ToolsPage.Size = new Size(200, 60);
            ToolsPage.TabIndex = 2;
            ToolsPage.Text = "Tools";
            // 
            // uiButton2
            // 
            uiButton2.FillColor = Color.FromArgb(48, 48, 48);
            uiButton2.FillColor2 = Color.FromArgb(48, 48, 48);
            uiButton2.FillHoverColor = Color.FromArgb(109, 109, 103);
            uiButton2.FillPressColor = Color.FromArgb(109, 109, 103);
            uiButton2.FillSelectedColor = Color.FromArgb(109, 109, 103);
            uiButton2.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton2.Location = new Point(921, 520);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.RectColor = Color.FromArgb(48, 48, 48);
            uiButton2.RectHoverColor = Color.FromArgb(109, 109, 103);
            uiButton2.RectPressColor = Color.FromArgb(109, 109, 103);
            uiButton2.RectSelectedColor = Color.FromArgb(109, 109, 103);
            uiButton2.Size = new Size(100, 22);
            uiButton2.Style = Sunny.UI.UIStyle.Custom;
            uiButton2.TabIndex = 26;
            uiButton2.Text = "Quick Guide";
            // 
            // ToolsLine
            // 
            ToolsLine.FillColor = Color.White;
            ToolsLine.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ToolsLine.LineColor = Color.FromArgb(48, 48, 48);
            ToolsLine.LineColor2 = Color.FromArgb(48, 48, 48);
            ToolsLine.Location = new Point(-2, 508);
            ToolsLine.MinimumSize = new Size(1, 1);
            ToolsLine.Name = "ToolsLine";
            ToolsLine.Size = new Size(1028, 10);
            ToolsLine.Style = Sunny.UI.UIStyle.Custom;
            ToolsLine.TabIndex = 21;
            // 
            // EditClipboardLabel
            // 
            EditClipboardLabel.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditClipboardLabel.Location = new Point(449, 164);
            EditClipboardLabel.Name = "EditClipboardLabel";
            EditClipboardLabel.Size = new Size(120, 23);
            EditClipboardLabel.Style = Sunny.UI.UIStyle.Custom;
            EditClipboardLabel.TabIndex = 7;
            EditClipboardLabel.Text = "Edit Clipboard";
            EditClipboardLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EditClipboardButton
            // 
            EditClipboardButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditClipboardButton.Image = (Image)resources.GetObject("EditClipboardButton.Image");
            EditClipboardButton.ImageHover = (Image)resources.GetObject("EditClipboardButton.ImageHover");
            EditClipboardButton.ImageOffset = new Point(1, -1);
            EditClipboardButton.Location = new Point(442, 205);
            EditClipboardButton.Name = "EditClipboardButton";
            EditClipboardButton.Size = new Size(130, 126);
            EditClipboardButton.Style = Sunny.UI.UIStyle.Custom;
            EditClipboardButton.TabIndex = 6;
            EditClipboardButton.TabStop = false;
            EditClipboardButton.Text = null;
            EditClipboardButton.Click += EditClipboardButton_Click;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel4.Location = new Point(740, 164);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(144, 23);
            uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            uiLabel4.TabIndex = 5;
            uiLabel4.Text = "Screenshot Share";
            uiLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel3.Location = new Point(136, 164);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(138, 23);
            uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            uiLabel3.TabIndex = 4;
            uiLabel3.Text = "Copy Clipboard";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ClipboardButton
            // 
            ClipboardButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClipboardButton.Image = (Image)resources.GetObject("ClipboardButton.Image");
            ClipboardButton.ImageHover = (Image)resources.GetObject("ClipboardButton.ImageHover");
            ClipboardButton.ImageOffset = new Point(1, -1);
            ClipboardButton.Location = new Point(134, 205);
            ClipboardButton.Name = "ClipboardButton";
            ClipboardButton.Size = new Size(130, 126);
            ClipboardButton.Style = Sunny.UI.UIStyle.Custom;
            ClipboardButton.TabIndex = 3;
            ClipboardButton.TabStop = false;
            ClipboardButton.Text = null;
            ClipboardButton.Click += ClipboardButton_Click;
            // 
            // ScreenshotShareButton
            // 
            ScreenshotShareButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ScreenshotShareButton.Image = (Image)resources.GetObject("ScreenshotShareButton.Image");
            ScreenshotShareButton.ImageHover = (Image)resources.GetObject("ScreenshotShareButton.ImageHover");
            ScreenshotShareButton.ImageOffset = new Point(1, -1);
            ScreenshotShareButton.Location = new Point(744, 205);
            ScreenshotShareButton.Name = "ScreenshotShareButton";
            ScreenshotShareButton.Size = new Size(130, 126);
            ScreenshotShareButton.Style = Sunny.UI.UIStyle.Custom;
            ScreenshotShareButton.TabIndex = 2;
            ScreenshotShareButton.TabStop = false;
            ScreenshotShareButton.Text = null;
            ScreenshotShareButton.Click += ScreenshotShareButton_Click;
            // 
            // ToolsMenuStrip
            // 
            ToolsMenuStrip.BackColor = Color.FromArgb(56, 56, 56);
            ToolsMenuStrip.Location = new Point(0, 0);
            ToolsMenuStrip.Name = "ToolsMenuStrip";
            ToolsMenuStrip.Size = new Size(198, 24);
            ToolsMenuStrip.TabIndex = 0;
            ToolsMenuStrip.Text = "menuStrip1";
            // 
            // SettingsPage
            // 
            SettingsPage.BackColor = Color.White;
            SettingsPage.BorderStyle = BorderStyle.FixedSingle;
            SettingsPage.Controls.Add(uiButton3);
            SettingsPage.Controls.Add(SettingsLine);
            SettingsPage.Controls.Add(SettingsMenuStrip);
            SettingsPage.Controls.Add(CULabel);
            SettingsPage.Controls.Add(CustomUIButton);
            SettingsPage.Controls.Add(MDLabel);
            SettingsPage.Controls.Add(ManageDataButton);
            SettingsPage.Location = new Point(0, 40);
            SettingsPage.Name = "SettingsPage";
            SettingsPage.Size = new Size(200, 60);
            SettingsPage.TabIndex = 3;
            SettingsPage.Text = "Settings";
            // 
            // uiButton3
            // 
            uiButton3.FillColor = Color.FromArgb(48, 48, 48);
            uiButton3.FillColor2 = Color.FromArgb(48, 48, 48);
            uiButton3.FillHoverColor = Color.FromArgb(109, 109, 103);
            uiButton3.FillPressColor = Color.FromArgb(109, 109, 103);
            uiButton3.FillSelectedColor = Color.FromArgb(109, 109, 103);
            uiButton3.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton3.Location = new Point(921, 520);
            uiButton3.MinimumSize = new Size(1, 1);
            uiButton3.Name = "uiButton3";
            uiButton3.RectColor = Color.FromArgb(48, 48, 48);
            uiButton3.RectHoverColor = Color.FromArgb(109, 109, 103);
            uiButton3.RectPressColor = Color.FromArgb(109, 109, 103);
            uiButton3.RectSelectedColor = Color.FromArgb(109, 109, 103);
            uiButton3.Size = new Size(100, 22);
            uiButton3.Style = Sunny.UI.UIStyle.Custom;
            uiButton3.TabIndex = 27;
            uiButton3.Text = "Quick Guide";
            // 
            // SettingsLine
            // 
            SettingsLine.FillColor = Color.White;
            SettingsLine.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SettingsLine.LineColor = Color.FromArgb(48, 48, 48);
            SettingsLine.LineColor2 = Color.FromArgb(48, 48, 48);
            SettingsLine.Location = new Point(-2, 508);
            SettingsLine.MinimumSize = new Size(1, 1);
            SettingsLine.Name = "SettingsLine";
            SettingsLine.Size = new Size(1029, 10);
            SettingsLine.Style = Sunny.UI.UIStyle.Custom;
            SettingsLine.TabIndex = 21;
            // 
            // SettingsMenuStrip
            // 
            SettingsMenuStrip.BackColor = Color.FromArgb(56, 56, 56);
            SettingsMenuStrip.Location = new Point(0, 0);
            SettingsMenuStrip.Name = "SettingsMenuStrip";
            SettingsMenuStrip.Size = new Size(198, 24);
            SettingsMenuStrip.TabIndex = 12;
            SettingsMenuStrip.Text = "menuStrip1";
            // 
            // CULabel
            // 
            CULabel.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CULabel.Location = new Point(631, 164);
            CULabel.Name = "CULabel";
            CULabel.Size = new Size(120, 23);
            CULabel.Style = Sunny.UI.UIStyle.Custom;
            CULabel.TabIndex = 11;
            CULabel.Text = "Customize UI";
            CULabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CustomUIButton
            // 
            CustomUIButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CustomUIButton.Image = (Image)resources.GetObject("CustomUIButton.Image");
            CustomUIButton.ImageHover = (Image)resources.GetObject("CustomUIButton.ImageHover");
            CustomUIButton.ImageOffset = new Point(1, -1);
            CustomUIButton.Location = new Point(625, 205);
            CustomUIButton.Name = "CustomUIButton";
            CustomUIButton.Size = new Size(130, 126);
            CustomUIButton.SizeMode = PictureBoxSizeMode.StretchImage;
            CustomUIButton.Style = Sunny.UI.UIStyle.Custom;
            CustomUIButton.TabIndex = 10;
            CustomUIButton.TabStop = false;
            CustomUIButton.Text = null;
            CustomUIButton.Click += CustomUIButton_Click;
            // 
            // MDLabel
            // 
            MDLabel.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MDLabel.Location = new Point(246, 164);
            MDLabel.Name = "MDLabel";
            MDLabel.Size = new Size(120, 23);
            MDLabel.Style = Sunny.UI.UIStyle.Custom;
            MDLabel.TabIndex = 9;
            MDLabel.Text = "Manage Data";
            MDLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ManageDataButton
            // 
            ManageDataButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ManageDataButton.Image = (Image)resources.GetObject("ManageDataButton.Image");
            ManageDataButton.ImageHover = (Image)resources.GetObject("ManageDataButton.ImageHover");
            ManageDataButton.ImageOffset = new Point(1, -1);
            ManageDataButton.Location = new Point(240, 205);
            ManageDataButton.Name = "ManageDataButton";
            ManageDataButton.Size = new Size(130, 126);
            ManageDataButton.SizeMode = PictureBoxSizeMode.StretchImage;
            ManageDataButton.Style = Sunny.UI.UIStyle.Custom;
            ManageDataButton.TabIndex = 8;
            ManageDataButton.TabStop = false;
            ManageDataButton.Text = null;
            ManageDataButton.Click += ManageDataButton_Click;
            // 
            // ShareImageTimer
            // 
            ShareImageTimer.Interval = 1000;
            ShareImageTimer.Tick += ShareImageTimer_Tick;
            // 
            // TimerUpdate
            // 
            TimerUpdate.Enabled = true;
            TimerUpdate.Interval = 30;
            TimerUpdate.Tick += TimerUpdate_Tick;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1026, 625);
            ControlBoxFillHoverColor = Color.FromArgb(109, 109, 103);
            Controls.Add(MainTabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = TasksMenuStrip;
            MaximizeBox = false;
            Name = "MainForm";
            RectColor = Color.FromArgb(48, 48, 48);
            ShowRadius = false;
            ShowShadow = true;
            ShowTitleIcon = true;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "DailyTasks";
            TitleColor = Color.FromArgb(48, 48, 48);
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += MainForm_Load;
            MainTabControl.ResumeLayout(false);
            HomePage.ResumeLayout(false);
            HomePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).EndInit();
            TaskPage.ResumeLayout(false);
            TaskPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MainDataGridView).EndInit();
            TasksMenuStrip.ResumeLayout(false);
            TasksMenuStrip.PerformLayout();
            ToolsPage.ResumeLayout(false);
            ToolsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EditClipboardButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClipboardButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)ScreenshotShareButton).EndInit();
            SettingsPage.ResumeLayout(false);
            SettingsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomUIButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)ManageDataButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private new Sunny.UI.UITabControl MainTabControl;
        private TabPage HomePage;
        private TabPage TaskPage;
        private TabPage ToolsPage;
        private MenuStrip HomeMenuStrip;
        private MenuStrip TasksMenuStrip;
        private ToolStripMenuItem ManageUsersMenuStrip;
        private MenuStrip ToolsMenuStrip;
        private ToolStripMenuItem NewUserToolStripMenuItem;
        private ToolStripMenuItem UsersToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem ChangeValuesToolStripMenuItem;
        private ToolStripMenuItem EditValueToolStripMenuItem;
        private ToolStripMenuItem ChangeTypesToolStripMenuItem;
        private ToolStripMenuItem EditTypeToolStripMenuItem;
        private Sunny.UI.UIListBox MainListBox;
        private Sunny.UI.UIButton AddTaskButton;
        private DateTimePicker MainDateTimePicker;
        private Sunny.UI.UIButton ShareScreenshotButton;
        private Sunny.UI.UIButton RemoveTaskButton;
        private Sunny.UI.UIButton UpdateTaskButton;
        private Sunny.UI.UIButton CurrentWeekButton;
        private Sunny.UI.UIButton ShowAllButton;
        private Sunny.UI.UIDataGridView MainDataGridView;
        private Sunny.UI.UILabel CurrentUserTasks;
        private Sunny.UI.UILabel CurrentUserHome;
        private Sunny.UI.UIImageButton ScreenshotShareButton;
        private Sunny.UI.UIImageButton ClipboardButton;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel ConditionsLabel;
        private Sunny.UI.UILabel CelsiusLabel;
        private Sunny.UI.UILabel LocationLabel;
        private System.Windows.Forms.Timer ShareImageTimer;
        private Label ShareImageLabel;
        private Sunny.UI.UILabel EditClipboardLabel;
        private Sunny.UI.UIImageButton EditClipboardButton;
        private TabPage SettingsPage;
        private Sunny.UI.UILabel CULabel;
        private Sunny.UI.UIImageButton CustomUIButton;
        private Sunny.UI.UILabel MDLabel;
        private Sunny.UI.UIImageButton ManageDataButton;
        private MenuStrip SettingsMenuStrip;
        private Sunny.UI.UILinkLabel SourceCodeLabel;
        private Sunny.UI.UILine HomePageLine;
        private Sunny.UI.UILabel SourceLabel;
        private Sunny.UI.UILabel ConnectLabelHome;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UILine TasksLine;
        private Sunny.UI.UILabel ConnectLabelTask;
        private Sunny.UI.UILine ToolsLine;
        private Sunny.UI.UILine SettingsLine;
        private Sunny.UI.UIButton uiButton4;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton3;
        private System.Windows.Forms.Timer TimerUpdate;
        private PictureBox MainPictureBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}