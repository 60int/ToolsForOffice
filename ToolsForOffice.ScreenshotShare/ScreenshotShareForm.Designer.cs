namespace ToolsForOffice.ScreenshotShare
{
    partial class ScreenshotShareForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenshotShareForm));
            CaptureButton = new Sunny.UI.UIButton();
            ShareButton = new Sunny.UI.UIButton();
            SettingsButton = new Sunny.UI.UIButton();
            AlwaysOnCheckBox = new Sunny.UI.UICheckBox();
            SuspendLayout();
            // 
            // CaptureButton
            // 
            CaptureButton.BackColor = Color.White;
            CaptureButton.FillColor = Color.FromArgb(48, 48, 48);
            CaptureButton.FillColor2 = Color.FromArgb(48, 48, 48);
            CaptureButton.FillHoverColor = Color.FromArgb(109, 109, 103);
            CaptureButton.FillPressColor = Color.FromArgb(109, 109, 103);
            CaptureButton.FillSelectedColor = Color.FromArgb(109, 109, 103);
            CaptureButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CaptureButton.Location = new Point(9, 40);
            CaptureButton.MinimumSize = new Size(1, 1);
            CaptureButton.Name = "CaptureButton";
            CaptureButton.RectColor = Color.FromArgb(48, 48, 48);
            CaptureButton.RectHoverColor = Color.FromArgb(109, 109, 103);
            CaptureButton.RectPressColor = Color.FromArgb(109, 109, 103);
            CaptureButton.RectSelectedColor = Color.FromArgb(109, 109, 103);
            CaptureButton.Size = new Size(75, 36);
            CaptureButton.Style = Sunny.UI.UIStyle.Custom;
            CaptureButton.TabIndex = 3;
            CaptureButton.Text = "Capture";
            CaptureButton.Click += CaptureButton_Click;
            // 
            // ShareButton
            // 
            ShareButton.BackColor = Color.White;
            ShareButton.FillColor = Color.FromArgb(48, 48, 48);
            ShareButton.FillColor2 = Color.FromArgb(48, 48, 48);
            ShareButton.FillHoverColor = Color.FromArgb(109, 109, 103);
            ShareButton.FillPressColor = Color.FromArgb(109, 109, 103);
            ShareButton.FillSelectedColor = Color.FromArgb(109, 109, 103);
            ShareButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ShareButton.Location = new Point(90, 40);
            ShareButton.MinimumSize = new Size(1, 1);
            ShareButton.Name = "ShareButton";
            ShareButton.RectColor = Color.FromArgb(48, 48, 48);
            ShareButton.RectHoverColor = Color.FromArgb(109, 109, 103);
            ShareButton.RectPressColor = Color.FromArgb(109, 109, 103);
            ShareButton.RectSelectedColor = Color.FromArgb(109, 109, 103);
            ShareButton.Size = new Size(75, 36);
            ShareButton.Style = Sunny.UI.UIStyle.Custom;
            ShareButton.TabIndex = 4;
            ShareButton.Text = "Share";
            ShareButton.Click += ShareButton_Click;
            // 
            // SettingsButton
            // 
            SettingsButton.BackColor = Color.White;
            SettingsButton.FillColor = Color.FromArgb(48, 48, 48);
            SettingsButton.FillColor2 = Color.FromArgb(48, 48, 48);
            SettingsButton.FillHoverColor = Color.FromArgb(109, 109, 103);
            SettingsButton.FillPressColor = Color.FromArgb(109, 109, 103);
            SettingsButton.FillSelectedColor = Color.FromArgb(109, 109, 103);
            SettingsButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SettingsButton.Location = new Point(171, 40);
            SettingsButton.MinimumSize = new Size(1, 1);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.RectColor = Color.FromArgb(48, 48, 48);
            SettingsButton.RectHoverColor = Color.FromArgb(109, 109, 103);
            SettingsButton.RectPressColor = Color.FromArgb(109, 109, 103);
            SettingsButton.RectSelectedColor = Color.FromArgb(109, 109, 103);
            SettingsButton.Size = new Size(75, 36);
            SettingsButton.Style = Sunny.UI.UIStyle.Custom;
            SettingsButton.TabIndex = 5;
            SettingsButton.Text = "Settings";
            SettingsButton.Click += SettingsButton_Click;
            // 
            // AlwaysOnCheckBox
            // 
            AlwaysOnCheckBox.BackColor = Color.FromArgb(48, 48, 48);
            AlwaysOnCheckBox.CheckBoxColor = Color.White;
            AlwaysOnCheckBox.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AlwaysOnCheckBox.ForeColor = Color.White;
            AlwaysOnCheckBox.Location = new Point(166, 35);
            AlwaysOnCheckBox.MinimumSize = new Size(1, 1);
            AlwaysOnCheckBox.Name = "AlwaysOnCheckBox";
            AlwaysOnCheckBox.Size = new Size(20, 27);
            AlwaysOnCheckBox.Style = Sunny.UI.UIStyle.Custom;
            AlwaysOnCheckBox.TabIndex = 6;
            AlwaysOnCheckBox.CheckedChanged += AlwaysOnCheckBox_CheckedChanged;
            // 
            // ScreenshotShareForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(256, 87);
            ControlBoxFillHoverColor = Color.FromArgb(109, 109, 103);
            Controls.Add(AlwaysOnCheckBox);
            Controls.Add(SettingsButton);
            Controls.Add(ShareButton);
            Controls.Add(CaptureButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ScreenshotShareForm";
            Padding = new Padding(0, 29, 0, 0);
            RectColor = Color.FromArgb(48, 48, 48);
            ShowRadius = false;
            ShowShadow = true;
            ShowTitleIcon = true;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "";
            TitleColor = Color.FromArgb(48, 48, 48);
            TitleHeight = 29;
            TopMost = true;
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIButton CaptureButton;
        private Sunny.UI.UIButton ShareButton;
        private Sunny.UI.UIButton SettingsButton;
        private Sunny.UI.UICheckBox AlwaysOnCheckBox;
    }
}