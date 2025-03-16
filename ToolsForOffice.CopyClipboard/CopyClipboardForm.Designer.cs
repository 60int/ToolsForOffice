namespace ToolsForOffice.CopyClipboard
{
    partial class CopyClipboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyClipboardForm));
            MainPictureBox = new PictureBox();
            CopyTimer = new System.Windows.Forms.Timer(components);
            TimerUpdate = new System.Windows.Forms.Timer(components);
            MainComboBox = new Sunny.UI.UIComboBox();
            SkinsButton = new Sunny.UI.UIButton();
            MainListBox = new Sunny.UI.UIListBox();
            CameraButton = new Button();
            CloudButton = new Sunny.UI.UIImageButton();
            SummerButton = new Sunny.UI.UIImageButton();
            SpringButton = new Sunny.UI.UIImageButton();
            FallButton = new Sunny.UI.UIImageButton();
            SnowButton = new Sunny.UI.UIImageButton();
            CancelButton = new Sunny.UI.UIButton();
            CopyLabel = new Label();
            MainLabel = new Label();
            ShareImageLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).BeginInit();
            MainListBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloudButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SummerButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpringButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FallButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SnowButton).BeginInit();
            SuspendLayout();
            // 
            // MainPictureBox
            // 
            MainPictureBox.Dock = DockStyle.Fill;
            MainPictureBox.Location = new Point(0, 29);
            MainPictureBox.Name = "MainPictureBox";
            MainPictureBox.Size = new Size(193, 210);
            MainPictureBox.TabIndex = 0;
            MainPictureBox.TabStop = false;
            MainPictureBox.Paint += MainPictureBox_Paint;
            // 
            // CopyTimer
            // 
            CopyTimer.Tick += CopyTimer_Tick;
            // 
            // TimerUpdate
            // 
            TimerUpdate.Enabled = true;
            TimerUpdate.Interval = 30;
            TimerUpdate.Tick += TimerUpdate_Tick;
            // 
            // MainComboBox
            // 
            MainComboBox.BackColor = Color.White;
            MainComboBox.DataSource = null;
            MainComboBox.FillColor = Color.White;
            MainComboBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MainComboBox.Location = new Point(14, 41);
            MainComboBox.Margin = new Padding(4, 5, 4, 5);
            MainComboBox.MinimumSize = new Size(63, 0);
            MainComboBox.Name = "MainComboBox";
            MainComboBox.Padding = new Padding(0, 0, 30, 2);
            MainComboBox.Size = new Size(148, 25);
            MainComboBox.Style = Sunny.UI.UIStyle.Custom;
            MainComboBox.TabIndex = 1;
            MainComboBox.TextAlignment = ContentAlignment.MiddleLeft;
            MainComboBox.Watermark = "";
            MainComboBox.SelectedIndexChanged += MainComboBox_SelectedIndexChanged;
            // 
            // SkinsButton
            // 
            SkinsButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SkinsButton.Location = new Point(169, 41);
            SkinsButton.MinimumSize = new Size(1, 1);
            SkinsButton.Name = "SkinsButton";
            SkinsButton.Size = new Size(10, 25);
            SkinsButton.Style = Sunny.UI.UIStyle.Custom;
            SkinsButton.TabIndex = 3;
            SkinsButton.Click += SkinsButton_Click;
            // 
            // MainListBox
            // 
            MainListBox.Controls.Add(CameraButton);
            MainListBox.FillColor = Color.White;
            MainListBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MainListBox.HoverColor = Color.FromArgb(155, 200, 255);
            MainListBox.ItemHeight = 15;
            MainListBox.ItemSelectForeColor = Color.White;
            MainListBox.Location = new Point(14, 76);
            MainListBox.Margin = new Padding(4, 5, 4, 5);
            MainListBox.MinimumSize = new Size(1, 1);
            MainListBox.Name = "MainListBox";
            MainListBox.Padding = new Padding(2);
            MainListBox.ShowText = false;
            MainListBox.Size = new Size(165, 124);
            MainListBox.Style = Sunny.UI.UIStyle.Custom;
            MainListBox.TabIndex = 4;
            MainListBox.Text = "uiListBox1";
            MainListBox.Click += MainListBox_Click;
            MainListBox.SelectedIndexChanged += MainListBox_SelectedIndexChanged;
            // 
            // CameraButton
            // 
            CameraButton.BackColor = Color.White;
            CameraButton.BackgroundImage = Properties.Resources.Camera_Icon;
            CameraButton.BackgroundImageLayout = ImageLayout.Center;
            CameraButton.Cursor = Cursors.Hand;
            CameraButton.FlatAppearance.BorderColor = Color.White;
            CameraButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 255);
            CameraButton.FlatAppearance.MouseOverBackColor = Color.White;
            CameraButton.FlatStyle = FlatStyle.Flat;
            CameraButton.ForeColor = Color.White;
            CameraButton.Location = new Point(143, 103);
            CameraButton.Name = "CameraButton";
            CameraButton.Size = new Size(20, 20);
            CameraButton.TabIndex = 12;
            CameraButton.UseVisualStyleBackColor = false;
            CameraButton.Click += CameraButton_Click;
            // 
            // CloudButton
            // 
            CloudButton.BackColor = Color.SteelBlue;
            CloudButton.BorderStyle = BorderStyle.FixedSingle;
            CloudButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CloudButton.Location = new Point(14, 208);
            CloudButton.Name = "CloudButton";
            CloudButton.Size = new Size(10, 25);
            CloudButton.Style = Sunny.UI.UIStyle.Custom;
            CloudButton.TabIndex = 5;
            CloudButton.TabStop = false;
            CloudButton.Text = null;
            CloudButton.Click += CloudButton_Click;
            // 
            // SummerButton
            // 
            SummerButton.BackColor = Color.FromArgb(0, 192, 0);
            SummerButton.BorderStyle = BorderStyle.FixedSingle;
            SummerButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SummerButton.Location = new Point(30, 208);
            SummerButton.Name = "SummerButton";
            SummerButton.Size = new Size(10, 25);
            SummerButton.Style = Sunny.UI.UIStyle.Custom;
            SummerButton.TabIndex = 6;
            SummerButton.TabStop = false;
            SummerButton.Text = null;
            SummerButton.Click += SummerButton_Click;
            // 
            // SpringButton
            // 
            SpringButton.BackColor = Color.FromArgb(255, 128, 255);
            SpringButton.BorderStyle = BorderStyle.FixedSingle;
            SpringButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SpringButton.Location = new Point(46, 208);
            SpringButton.Name = "SpringButton";
            SpringButton.Size = new Size(10, 25);
            SpringButton.Style = Sunny.UI.UIStyle.Custom;
            SpringButton.TabIndex = 7;
            SpringButton.TabStop = false;
            SpringButton.Text = null;
            SpringButton.Click += SpringButton_Click;
            // 
            // FallButton
            // 
            FallButton.BackColor = Color.FromArgb(255, 128, 0);
            FallButton.BorderStyle = BorderStyle.FixedSingle;
            FallButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FallButton.Location = new Point(62, 208);
            FallButton.Name = "FallButton";
            FallButton.Size = new Size(10, 25);
            FallButton.Style = Sunny.UI.UIStyle.Custom;
            FallButton.TabIndex = 8;
            FallButton.TabStop = false;
            FallButton.Text = null;
            FallButton.Click += FallButton_Click;
            // 
            // SnowButton
            // 
            SnowButton.BackColor = Color.White;
            SnowButton.BorderStyle = BorderStyle.FixedSingle;
            SnowButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SnowButton.Location = new Point(78, 208);
            SnowButton.Name = "SnowButton";
            SnowButton.Size = new Size(10, 25);
            SnowButton.Style = Sunny.UI.UIStyle.Custom;
            SnowButton.TabIndex = 9;
            SnowButton.TabStop = false;
            SnowButton.Text = null;
            SnowButton.Click += SnowButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CancelButton.Location = new Point(117, 208);
            CancelButton.MinimumSize = new Size(1, 1);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(62, 25);
            CancelButton.Style = Sunny.UI.UIStyle.Custom;
            CancelButton.TabIndex = 10;
            CancelButton.Text = "Cancel";
            CancelButton.Click += CancelButton_Click;
            // 
            // CopyLabel
            // 
            CopyLabel.AutoSize = true;
            CopyLabel.BackColor = Color.White;
            CopyLabel.FlatStyle = FlatStyle.Flat;
            CopyLabel.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CopyLabel.Location = new Point(74, 219);
            CopyLabel.Name = "CopyLabel";
            CopyLabel.Size = new Size(52, 17);
            CopyLabel.TabIndex = 2;
            CopyLabel.Text = "copied!";
            // 
            // MainLabel
            // 
            MainLabel.BackColor = Color.White;
            MainLabel.FlatStyle = FlatStyle.Flat;
            MainLabel.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MainLabel.Location = new Point(14, 202);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(165, 17);
            MainLabel.TabIndex = 11;
            MainLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ShareImageLabel
            // 
            ShareImageLabel.AutoSize = true;
            ShareImageLabel.BackColor = Color.White;
            ShareImageLabel.FlatStyle = FlatStyle.Flat;
            ShareImageLabel.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ShareImageLabel.Location = new Point(74, 219);
            ShareImageLabel.Name = "ShareImageLabel";
            ShareImageLabel.Size = new Size(0, 17);
            ShareImageLabel.TabIndex = 12;
            // 
            // CopyClipboardForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(193, 239);
            Controls.Add(ShareImageLabel);
            Controls.Add(MainLabel);
            Controls.Add(CopyLabel);
            Controls.Add(CancelButton);
            Controls.Add(SnowButton);
            Controls.Add(FallButton);
            Controls.Add(SpringButton);
            Controls.Add(SummerButton);
            Controls.Add(CloudButton);
            Controls.Add(MainListBox);
            Controls.Add(SkinsButton);
            Controls.Add(MainComboBox);
            Controls.Add(MainPictureBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CopyClipboardForm";
            Padding = new Padding(0, 29, 0, 0);
            RectColor = Color.FromArgb(48, 48, 48);
            ShowRadius = false;
            ShowShadow = true;
            SizeGripStyle = SizeGripStyle.Hide;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "";
            TitleColor = Color.FromArgb(48, 48, 48);
            TitleHeight = 29;
            TopMost = true;
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).EndInit();
            MainListBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CloudButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)SummerButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpringButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)FallButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)SnowButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox MainPictureBox;
        private System.Windows.Forms.Timer CopyTimer;
        private System.Windows.Forms.Timer TimerUpdate;
        private Sunny.UI.UIComboBox MainComboBox;
        private Sunny.UI.UIButton SkinsButton;
        private Sunny.UI.UIListBox MainListBox;
        private Sunny.UI.UIImageButton CloudButton;
        private Sunny.UI.UIImageButton SummerButton;
        private Sunny.UI.UIImageButton SpringButton;
        private Sunny.UI.UIImageButton FallButton;
        private Sunny.UI.UIImageButton SnowButton;
        private new Sunny.UI.UIButton CancelButton;
        private Label CopyLabel;
        private Label MainLabel;
        private Button CameraButton;
        private Label ShareImageLabel;
    }
}