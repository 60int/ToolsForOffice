namespace ToolsForOffice.DailyTasks.Forms
{
    partial class AddUserForm
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
            UserNameTextBox = new Sunny.UI.UITextBox();
            CancelButton = new Sunny.UI.UIButton();
            OKButton = new Sunny.UI.UIButton();
            SuspendLayout();
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.ButtonFillColor = Color.FromArgb(48, 48, 48);
            UserNameTextBox.ButtonFillHoverColor = Color.FromArgb(109, 109, 103);
            UserNameTextBox.ButtonFillPressColor = Color.FromArgb(48, 48, 48);
            UserNameTextBox.ButtonRectColor = Color.FromArgb(48, 48, 48);
            UserNameTextBox.ButtonRectHoverColor = Color.FromArgb(109, 109, 103);
            UserNameTextBox.ButtonRectPressColor = Color.FromArgb(109, 109, 103);
            UserNameTextBox.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserNameTextBox.Location = new Point(18, 49);
            UserNameTextBox.Margin = new Padding(4, 5, 4, 5);
            UserNameTextBox.MinimumSize = new Size(1, 16);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Padding = new Padding(5);
            UserNameTextBox.RectColor = Color.FromArgb(48, 48, 48);
            UserNameTextBox.ScrollBarColor = Color.FromArgb(48, 48, 48);
            UserNameTextBox.ShowText = false;
            UserNameTextBox.Size = new Size(206, 29);
            UserNameTextBox.Style = Sunny.UI.UIStyle.Custom;
            UserNameTextBox.TabIndex = 0;
            UserNameTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            UserNameTextBox.Watermark = "";
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
            CancelButton.Location = new Point(124, 92);
            CancelButton.MinimumSize = new Size(1, 1);
            CancelButton.Name = "CancelButton";
            CancelButton.RectColor = Color.FromArgb(48, 48, 48);
            CancelButton.RectHoverColor = Color.FromArgb(109, 109, 103);
            CancelButton.RectPressColor = Color.FromArgb(109, 109, 103);
            CancelButton.RectSelectedColor = Color.FromArgb(109, 109, 103);
            CancelButton.Size = new Size(100, 35);
            CancelButton.Style = Sunny.UI.UIStyle.Custom;
            CancelButton.TabIndex = 6;
            CancelButton.Text = "Cancel";
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
            OKButton.Location = new Point(18, 92);
            OKButton.MinimumSize = new Size(1, 1);
            OKButton.Name = "OKButton";
            OKButton.RectColor = Color.FromArgb(48, 48, 48);
            OKButton.RectHoverColor = Color.FromArgb(109, 109, 103);
            OKButton.RectPressColor = Color.FromArgb(109, 109, 103);
            OKButton.RectSelectedColor = Color.FromArgb(109, 109, 103);
            OKButton.Size = new Size(100, 35);
            OKButton.Style = Sunny.UI.UIStyle.Custom;
            OKButton.TabIndex = 5;
            OKButton.Text = "OK";
            OKButton.Click += OKButton_Click;
            // 
            // AddUserForm
            // 
            AcceptButton = OKButton;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(245, 138);
            ControlBoxFillHoverColor = Color.FromArgb(109, 109, 103);
            Controls.Add(CancelButton);
            Controls.Add(UserNameTextBox);
            Controls.Add(OKButton);
            MaximizeBox = false;
            Name = "AddUserForm";
            RectColor = Color.FromArgb(48, 48, 48);
            ShowRadius = false;
            ShowShadow = true;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "Add User";
            TitleColor = Color.FromArgb(48, 48, 48);
            TopMost = true;
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITextBox UserNameTextBox;
        private new Sunny.UI.UIButton CancelButton;
        private Sunny.UI.UIButton OKButton;
    }
}