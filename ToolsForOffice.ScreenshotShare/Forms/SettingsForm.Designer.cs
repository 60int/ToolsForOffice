namespace ToolsForOffice.ScreenshotShare.Forms
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UserLabel = new Sunny.UI.UILabel();
            UserNameTextBox = new Sunny.UI.UITextBox();
            FolderNameLabel = new Sunny.UI.UILabel();
            FolderLabel = new Sunny.UI.UILabel();
            ChangeFolderButton = new Sunny.UI.UIButton();
            CancelButton = new Sunny.UI.UIButton();
            OKButton = new Sunny.UI.UIButton();
            SuspendLayout();
            // 
            // UserLabel
            // 
            UserLabel.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserLabel.Location = new Point(19, 58);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(100, 23);
            UserLabel.Style = Sunny.UI.UIStyle.Custom;
            UserLabel.TabIndex = 0;
            UserLabel.Text = "Username:";
            UserLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.ButtonFillColor = Color.FromArgb(48, 48, 48);
            UserNameTextBox.ButtonFillHoverColor = Color.FromArgb(109, 109, 103);
            UserNameTextBox.ButtonFillPressColor = Color.FromArgb(48, 48, 48);
            UserNameTextBox.ButtonRectColor = Color.FromArgb(48, 48, 48);
            UserNameTextBox.ButtonRectHoverColor = Color.FromArgb(109, 109, 103);
            UserNameTextBox.ButtonRectPressColor = Color.FromArgb(48, 48, 48);
            UserNameTextBox.ButtonSymbolOffset = new Point(0, 0);
            UserNameTextBox.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserNameTextBox.Location = new Point(109, 58);
            UserNameTextBox.Margin = new Padding(4, 5, 4, 5);
            UserNameTextBox.MinimumSize = new Size(1, 16);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Padding = new Padding(5);
            UserNameTextBox.RectColor = Color.FromArgb(48, 48, 48);
            UserNameTextBox.ScrollBarColor = Color.FromArgb(48, 48, 48);
            UserNameTextBox.ShowText = false;
            UserNameTextBox.Size = new Size(186, 29);
            UserNameTextBox.Style = Sunny.UI.UIStyle.Custom;
            UserNameTextBox.TabIndex = 1;
            UserNameTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            UserNameTextBox.Watermark = "";
            // 
            // FolderNameLabel
            // 
            FolderNameLabel.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FolderNameLabel.Location = new Point(19, 123);
            FolderNameLabel.Name = "FolderNameLabel";
            FolderNameLabel.Size = new Size(67, 23);
            FolderNameLabel.Style = Sunny.UI.UIStyle.Custom;
            FolderNameLabel.TabIndex = 2;
            FolderNameLabel.Text = "Folder:";
            FolderNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FolderLabel
            // 
            FolderLabel.AutoSize = true;
            FolderLabel.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FolderLabel.Location = new Point(78, 128);
            FolderLabel.Name = "FolderLabel";
            FolderLabel.Size = new Size(0, 17);
            FolderLabel.Style = Sunny.UI.UIStyle.Custom;
            FolderLabel.TabIndex = 3;
            FolderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ChangeFolderButton
            // 
            ChangeFolderButton.BackColor = Color.White;
            ChangeFolderButton.FillColor = Color.FromArgb(48, 48, 48);
            ChangeFolderButton.FillColor2 = Color.FromArgb(48, 48, 48);
            ChangeFolderButton.FillHoverColor = Color.FromArgb(109, 109, 103);
            ChangeFolderButton.FillPressColor = Color.FromArgb(109, 109, 103);
            ChangeFolderButton.FillSelectedColor = Color.FromArgb(109, 109, 103);
            ChangeFolderButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeFolderButton.Location = new Point(80, 178);
            ChangeFolderButton.MinimumSize = new Size(1, 1);
            ChangeFolderButton.Name = "ChangeFolderButton";
            ChangeFolderButton.RectColor = Color.FromArgb(48, 48, 48);
            ChangeFolderButton.RectHoverColor = Color.FromArgb(109, 109, 103);
            ChangeFolderButton.RectPressColor = Color.FromArgb(109, 109, 103);
            ChangeFolderButton.RectSelectedColor = Color.FromArgb(109, 109, 103);
            ChangeFolderButton.Size = new Size(164, 36);
            ChangeFolderButton.Style = Sunny.UI.UIStyle.Custom;
            ChangeFolderButton.TabIndex = 4;
            ChangeFolderButton.Text = "Change Folder";
            ChangeFolderButton.Click += ChangeFolderButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.FillColor = Color.FromArgb(48, 48, 48);
            CancelButton.FillColor2 = Color.FromArgb(48, 48, 48);
            CancelButton.FillHoverColor = Color.FromArgb(109, 109, 103);
            CancelButton.FillPressColor = Color.FromArgb(109, 109, 103);
            CancelButton.FillSelectedColor = Color.FromArgb(109, 109, 103);
            CancelButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CancelButton.Location = new Point(164, 230);
            CancelButton.MinimumSize = new Size(1, 1);
            CancelButton.Name = "CancelButton";
            CancelButton.RectColor = Color.FromArgb(48, 48, 48);
            CancelButton.RectHoverColor = Color.FromArgb(109, 109, 103);
            CancelButton.RectPressColor = Color.FromArgb(109, 109, 103);
            CancelButton.RectSelectedColor = Color.FromArgb(109, 109, 103);
            CancelButton.Size = new Size(100, 35);
            CancelButton.Style = Sunny.UI.UIStyle.Custom;
            CancelButton.TabIndex = 8;
            CancelButton.Text = "Cancel";
            CancelButton.Click += CancelButton_Click;
            // 
            // OKButton
            // 
            OKButton.DialogResult = DialogResult.OK;
            OKButton.FillColor = Color.FromArgb(48, 48, 48);
            OKButton.FillColor2 = Color.FromArgb(48, 48, 48);
            OKButton.FillHoverColor = Color.FromArgb(109, 109, 103);
            OKButton.FillPressColor = Color.FromArgb(109, 109, 103);
            OKButton.FillSelectedColor = Color.FromArgb(109, 109, 103);
            OKButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OKButton.Location = new Point(58, 230);
            OKButton.MinimumSize = new Size(1, 1);
            OKButton.Name = "OKButton";
            OKButton.RectColor = Color.FromArgb(48, 48, 48);
            OKButton.RectHoverColor = Color.FromArgb(109, 109, 103);
            OKButton.RectPressColor = Color.FromArgb(109, 109, 103);
            OKButton.RectSelectedColor = Color.FromArgb(109, 109, 103);
            OKButton.Size = new Size(100, 35);
            OKButton.Style = Sunny.UI.UIStyle.Custom;
            OKButton.TabIndex = 7;
            OKButton.Text = "OK";
            OKButton.Click += OKButton_Click;
            // 
            // SettingsForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(329, 277);
            ControlBoxFillHoverColor = Color.FromArgb(109, 109, 103);
            Controls.Add(CancelButton);
            Controls.Add(OKButton);
            Controls.Add(ChangeFolderButton);
            Controls.Add(FolderLabel);
            Controls.Add(FolderNameLabel);
            Controls.Add(UserNameTextBox);
            Controls.Add(UserLabel);
            MaximizeBox = false;
            Name = "SettingsForm";
            Padding = new Padding(0, 29, 0, 0);
            RectColor = Color.FromArgb(48, 48, 48);
            ShowRadius = false;
            ShowShadow = true;
            SizeGripStyle = SizeGripStyle.Hide;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "Settings";
            TitleColor = Color.FromArgb(48, 48, 48);
            TitleHeight = 29;
            TopMost = true;
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UILabel UserLabel;
        private Sunny.UI.UITextBox UserNameTextBox;
        private Sunny.UI.UILabel FolderNameLabel;
        private Sunny.UI.UILabel FolderLabel;
        private Sunny.UI.UIButton ChangeFolderButton;
        private new Sunny.UI.UIButton CancelButton;
        private Sunny.UI.UIButton OKButton;
    }
}