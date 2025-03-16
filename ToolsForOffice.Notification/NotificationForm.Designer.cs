namespace ToolsForOffice.Notification
{
    partial class NotificationForm
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
            MainTimer = new System.Windows.Forms.Timer(components);
            TimerUpdate = new System.Windows.Forms.Timer(components);
            MainPictureBox = new PictureBox();
            LogoImage = new PictureBox();
            MessageLabel = new Label();
            ClickMessage = new Label();
            CloseButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            SuspendLayout();
            // 
            // MainTimer
            // 
            MainTimer.Interval = 10;
            MainTimer.Tick += MainTimer_Tick;
            // 
            // TimerUpdate
            // 
            TimerUpdate.Enabled = true;
            TimerUpdate.Interval = 30;
            TimerUpdate.Tick += TimerUpdate_Tick;
            // 
            // MainPictureBox
            // 
            MainPictureBox.BackColor = Color.Transparent;
            MainPictureBox.Dock = DockStyle.Fill;
            MainPictureBox.Location = new Point(0, 0);
            MainPictureBox.Name = "MainPictureBox";
            MainPictureBox.Size = new Size(400, 81);
            MainPictureBox.TabIndex = 0;
            MainPictureBox.TabStop = false;
            MainPictureBox.Click += NotificationForm_Click;
            MainPictureBox.Paint += MainPictureBox_Paint;
            // 
            // LogoImage
            // 
            LogoImage.BackColor = Color.Transparent;
            LogoImage.Image = Properties.Resources.Camera48;
            LogoImage.Location = new Point(12, 12);
            LogoImage.Name = "LogoImage";
            LogoImage.Size = new Size(63, 57);
            LogoImage.SizeMode = PictureBoxSizeMode.Zoom;
            LogoImage.TabIndex = 1;
            LogoImage.TabStop = false;
            LogoImage.Click += NotificationForm_Click;
            // 
            // MessageLabel
            // 
            MessageLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MessageLabel.BackColor = Color.Transparent;
            MessageLabel.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MessageLabel.ForeColor = Color.White;
            MessageLabel.Location = new Point(81, 2);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(275, 57);
            MessageLabel.TabIndex = 2;
            MessageLabel.Text = "Text Message";
            MessageLabel.TextAlign = ContentAlignment.MiddleLeft;
            MessageLabel.Click += NotificationForm_Click;
            // 
            // ClickMessage
            // 
            ClickMessage.AutoSize = true;
            ClickMessage.BackColor = Color.Transparent;
            ClickMessage.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ClickMessage.Location = new Point(83, 45);
            ClickMessage.Name = "ClickMessage";
            ClickMessage.Size = new Size(115, 17);
            ClickMessage.TabIndex = 3;
            ClickMessage.Text = "Click here to open";
            ClickMessage.Click += NotificationForm_Click;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Image = Properties.Resources.Close48;
            CloseButton.Location = new Point(362, 24);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(26, 33);
            CloseButton.SizeMode = PictureBoxSizeMode.Zoom;
            CloseButton.TabIndex = 4;
            CloseButton.TabStop = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // NotificationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 81);
            Controls.Add(CloseButton);
            Controls.Add(ClickMessage);
            Controls.Add(MessageLabel);
            Controls.Add(LogoImage);
            Controls.Add(MainPictureBox);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "NotificationForm";
            ShowInTaskbar = false;
            Text = "DailyTasks Notification";
            TopMost = true;
            Click += NotificationForm_Click;
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Timer TimerUpdate;
        private PictureBox MainPictureBox;
        private PictureBox LogoImage;
        private Label MessageLabel;
        private Label ClickMessage;
        private PictureBox CloseButton;
    }
}