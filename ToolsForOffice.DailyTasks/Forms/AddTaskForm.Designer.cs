namespace ToolsForOffice.DailyTasks.Forms
{
    partial class AddTaskForm
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
            OKButton = new Sunny.UI.UIButton();
            CancelButton = new Sunny.UI.UIButton();
            UserTaskLabel = new Label();
            TotalLabel = new Label();
            CustomValueLabel1 = new Label();
            CustomValueLabel2 = new Label();
            CustomValueLabel3 = new Label();
            CustomValueLabel4 = new Label();
            CompletedLabel = new Label();
            MainDateTimePicker = new DateTimePicker();
            TypeComboBox = new Sunny.UI.UIComboBox();
            PriorityComboBox = new Sunny.UI.UIComboBox();
            UserTextBox = new Sunny.UI.UITextBox();
            TotalNumericUpDown = new Sunny.UI.UIIntegerUpDown();
            CustomUpDown1 = new Sunny.UI.UIIntegerUpDown();
            CustomUpDown2 = new Sunny.UI.UIIntegerUpDown();
            CustomUpDown3 = new Sunny.UI.UIIntegerUpDown();
            CustomUpDown4 = new Sunny.UI.UIIntegerUpDown();
            CompletedSwitch = new Sunny.UI.UISwitch();
            SuspendLayout();
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
            OKButton.Location = new Point(72, 448);
            OKButton.MinimumSize = new Size(1, 1);
            OKButton.Name = "OKButton";
            OKButton.RectColor = Color.FromArgb(48, 48, 48);
            OKButton.RectHoverColor = Color.FromArgb(109, 109, 103);
            OKButton.RectPressColor = Color.FromArgb(109, 109, 103);
            OKButton.RectSelectedColor = Color.FromArgb(109, 109, 103);
            OKButton.Size = new Size(117, 35);
            OKButton.Style = Sunny.UI.UIStyle.Custom;
            OKButton.TabIndex = 3;
            OKButton.Text = "OK";
            OKButton.Click += OKButton_Click;
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
            CancelButton.Location = new Point(243, 448);
            CancelButton.MinimumSize = new Size(1, 1);
            CancelButton.Name = "CancelButton";
            CancelButton.RectColor = Color.FromArgb(48, 48, 48);
            CancelButton.RectHoverColor = Color.FromArgb(109, 109, 103);
            CancelButton.RectPressColor = Color.FromArgb(109, 109, 103);
            CancelButton.RectSelectedColor = Color.FromArgb(109, 109, 103);
            CancelButton.Size = new Size(117, 35);
            CancelButton.Style = Sunny.UI.UIStyle.Custom;
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            // 
            // UserTaskLabel
            // 
            UserTaskLabel.AutoSize = true;
            UserTaskLabel.Location = new Point(102, 57);
            UserTaskLabel.Name = "UserTaskLabel";
            UserTaskLabel.Size = new Size(87, 21);
            UserTaskLabel.TabIndex = 5;
            UserTaskLabel.Text = "Username";
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Location = new Point(141, 97);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(48, 21);
            TotalLabel.TabIndex = 6;
            TotalLabel.Text = "Total";
            // 
            // CustomValueLabel1
            // 
            CustomValueLabel1.Location = new Point(54, 136);
            CustomValueLabel1.Name = "CustomValueLabel1";
            CustomValueLabel1.Size = new Size(135, 21);
            CustomValueLabel1.TabIndex = 7;
            CustomValueLabel1.Text = "Custom Value";
            CustomValueLabel1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CustomValueLabel2
            // 
            CustomValueLabel2.Location = new Point(54, 175);
            CustomValueLabel2.Name = "CustomValueLabel2";
            CustomValueLabel2.Size = new Size(135, 21);
            CustomValueLabel2.TabIndex = 8;
            CustomValueLabel2.Text = "Custom Value";
            CustomValueLabel2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CustomValueLabel3
            // 
            CustomValueLabel3.Location = new Point(54, 214);
            CustomValueLabel3.Name = "CustomValueLabel3";
            CustomValueLabel3.Size = new Size(135, 21);
            CustomValueLabel3.TabIndex = 9;
            CustomValueLabel3.Text = "Custom Value";
            CustomValueLabel3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CustomValueLabel4
            // 
            CustomValueLabel4.Location = new Point(54, 253);
            CustomValueLabel4.Name = "CustomValueLabel4";
            CustomValueLabel4.Size = new Size(134, 21);
            CustomValueLabel4.TabIndex = 10;
            CustomValueLabel4.Text = "Custom Value";
            CustomValueLabel4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CompletedLabel
            // 
            CompletedLabel.AutoSize = true;
            CompletedLabel.Location = new Point(95, 294);
            CompletedLabel.Name = "CompletedLabel";
            CompletedLabel.Size = new Size(94, 21);
            CompletedLabel.TabIndex = 11;
            CompletedLabel.Text = "Completed";
            // 
            // MainDateTimePicker
            // 
            MainDateTimePicker.Location = new Point(72, 330);
            MainDateTimePicker.Name = "MainDateTimePicker";
            MainDateTimePicker.Size = new Size(288, 29);
            MainDateTimePicker.TabIndex = 12;
            // 
            // TypeComboBox
            // 
            TypeComboBox.DataSource = null;
            TypeComboBox.FillColor = Color.White;
            TypeComboBox.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TypeComboBox.ItemRectColor = Color.FromArgb(109, 109, 103);
            TypeComboBox.ItemSelectBackColor = Color.FromArgb(109, 109, 103);
            TypeComboBox.Location = new Point(72, 367);
            TypeComboBox.Margin = new Padding(4, 5, 4, 5);
            TypeComboBox.MinimumSize = new Size(63, 0);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Padding = new Padding(0, 0, 30, 2);
            TypeComboBox.RectColor = Color.FromArgb(48, 48, 48);
            TypeComboBox.Size = new Size(288, 29);
            TypeComboBox.Style = Sunny.UI.UIStyle.Custom;
            TypeComboBox.TabIndex = 13;
            TypeComboBox.TextAlignment = ContentAlignment.MiddleLeft;
            TypeComboBox.Watermark = "";
            // 
            // PriorityComboBox
            // 
            PriorityComboBox.DataSource = null;
            PriorityComboBox.FillColor = Color.White;
            PriorityComboBox.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PriorityComboBox.ItemRectColor = Color.FromArgb(109, 109, 103);
            PriorityComboBox.ItemSelectBackColor = Color.FromArgb(109, 109, 103);
            PriorityComboBox.Location = new Point(72, 406);
            PriorityComboBox.Margin = new Padding(4, 5, 4, 5);
            PriorityComboBox.MinimumSize = new Size(63, 0);
            PriorityComboBox.Name = "PriorityComboBox";
            PriorityComboBox.Padding = new Padding(0, 0, 30, 2);
            PriorityComboBox.RectColor = Color.FromArgb(48, 48, 48);
            PriorityComboBox.Size = new Size(288, 29);
            PriorityComboBox.Style = Sunny.UI.UIStyle.Custom;
            PriorityComboBox.TabIndex = 1;
            PriorityComboBox.TextAlignment = ContentAlignment.MiddleLeft;
            PriorityComboBox.Watermark = "";
            // 
            // UserTextBox
            // 
            UserTextBox.ButtonSymbolOffset = new Point(0, 0);
            UserTextBox.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserTextBox.Location = new Point(195, 54);
            UserTextBox.Margin = new Padding(4, 5, 4, 5);
            UserTextBox.MinimumSize = new Size(1, 16);
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Padding = new Padding(5);
            UserTextBox.RectColor = Color.FromArgb(48, 48, 48);
            UserTextBox.ShowText = false;
            UserTextBox.Size = new Size(165, 29);
            UserTextBox.Style = Sunny.UI.UIStyle.Custom;
            UserTextBox.TabIndex = 1;
            UserTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            UserTextBox.Watermark = "";
            // 
            // TotalNumericUpDown
            // 
            TotalNumericUpDown.FillColor = Color.White;
            TotalNumericUpDown.FillColor2 = Color.White;
            TotalNumericUpDown.FillDisableColor = Color.White;
            TotalNumericUpDown.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TotalNumericUpDown.Location = new Point(195, 93);
            TotalNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            TotalNumericUpDown.MinimumSize = new Size(100, 0);
            TotalNumericUpDown.Name = "TotalNumericUpDown";
            TotalNumericUpDown.RectColor = Color.FromArgb(48, 48, 48);
            TotalNumericUpDown.RectDisableColor = Color.White;
            TotalNumericUpDown.ShowText = false;
            TotalNumericUpDown.Size = new Size(165, 29);
            TotalNumericUpDown.Style = Sunny.UI.UIStyle.Custom;
            TotalNumericUpDown.TabIndex = 14;
            TotalNumericUpDown.Text = "uiIntegerUpDown1";
            TotalNumericUpDown.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // CustomUpDown1
            // 
            CustomUpDown1.FillColor = Color.White;
            CustomUpDown1.FillColor2 = Color.White;
            CustomUpDown1.FillDisableColor = Color.White;
            CustomUpDown1.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CustomUpDown1.Location = new Point(195, 132);
            CustomUpDown1.Margin = new Padding(4, 5, 4, 5);
            CustomUpDown1.MinimumSize = new Size(100, 0);
            CustomUpDown1.Name = "CustomUpDown1";
            CustomUpDown1.RectColor = Color.FromArgb(48, 48, 48);
            CustomUpDown1.RectDisableColor = Color.White;
            CustomUpDown1.ShowText = false;
            CustomUpDown1.Size = new Size(165, 29);
            CustomUpDown1.Style = Sunny.UI.UIStyle.Custom;
            CustomUpDown1.TabIndex = 15;
            CustomUpDown1.Text = "uiIntegerUpDown2";
            CustomUpDown1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // CustomUpDown2
            // 
            CustomUpDown2.FillColor = Color.White;
            CustomUpDown2.FillColor2 = Color.White;
            CustomUpDown2.FillDisableColor = Color.White;
            CustomUpDown2.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CustomUpDown2.Location = new Point(195, 171);
            CustomUpDown2.Margin = new Padding(4, 5, 4, 5);
            CustomUpDown2.MinimumSize = new Size(100, 0);
            CustomUpDown2.Name = "CustomUpDown2";
            CustomUpDown2.RectColor = Color.FromArgb(48, 48, 48);
            CustomUpDown2.RectDisableColor = Color.White;
            CustomUpDown2.ShowText = false;
            CustomUpDown2.Size = new Size(165, 29);
            CustomUpDown2.Style = Sunny.UI.UIStyle.Custom;
            CustomUpDown2.TabIndex = 15;
            CustomUpDown2.Text = "uiIntegerUpDown3";
            CustomUpDown2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // CustomUpDown3
            // 
            CustomUpDown3.FillColor = Color.White;
            CustomUpDown3.FillColor2 = Color.White;
            CustomUpDown3.FillDisableColor = Color.White;
            CustomUpDown3.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CustomUpDown3.Location = new Point(195, 210);
            CustomUpDown3.Margin = new Padding(4, 5, 4, 5);
            CustomUpDown3.MinimumSize = new Size(100, 0);
            CustomUpDown3.Name = "CustomUpDown3";
            CustomUpDown3.RectColor = Color.FromArgb(48, 48, 48);
            CustomUpDown3.RectDisableColor = Color.White;
            CustomUpDown3.ShowText = false;
            CustomUpDown3.Size = new Size(165, 29);
            CustomUpDown3.Style = Sunny.UI.UIStyle.Custom;
            CustomUpDown3.TabIndex = 15;
            CustomUpDown3.Text = "uiIntegerUpDown4";
            CustomUpDown3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // CustomUpDown4
            // 
            CustomUpDown4.FillColor = Color.White;
            CustomUpDown4.FillColor2 = Color.White;
            CustomUpDown4.FillDisableColor = Color.White;
            CustomUpDown4.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CustomUpDown4.Location = new Point(195, 249);
            CustomUpDown4.Margin = new Padding(4, 5, 4, 5);
            CustomUpDown4.MinimumSize = new Size(100, 0);
            CustomUpDown4.Name = "CustomUpDown4";
            CustomUpDown4.RectColor = Color.FromArgb(48, 48, 48);
            CustomUpDown4.RectDisableColor = Color.White;
            CustomUpDown4.ShowText = false;
            CustomUpDown4.Size = new Size(165, 29);
            CustomUpDown4.Style = Sunny.UI.UIStyle.Custom;
            CustomUpDown4.TabIndex = 15;
            CustomUpDown4.Text = "uiIntegerUpDown5";
            CustomUpDown4.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // CompletedSwitch
            // 
            CompletedSwitch.ActiveColor = Color.Green;
            CompletedSwitch.ActiveText = "Yes";
            CompletedSwitch.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CompletedSwitch.InActiveColor = Color.FromArgb(192, 0, 0);
            CompletedSwitch.InActiveText = "No";
            CompletedSwitch.Location = new Point(195, 290);
            CompletedSwitch.MinimumSize = new Size(1, 1);
            CompletedSwitch.Name = "CompletedSwitch";
            CompletedSwitch.Size = new Size(75, 29);
            CompletedSwitch.Style = Sunny.UI.UIStyle.Custom;
            CompletedSwitch.TabIndex = 16;
            CompletedSwitch.Text = "uiSwitch1";
            // 
            // AddTaskForm
            // 
            AcceptButton = OKButton;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(440, 498);
            ControlBoxFillHoverColor = Color.FromArgb(109, 109, 103);
            Controls.Add(CompletedSwitch);
            Controls.Add(CustomUpDown4);
            Controls.Add(CustomUpDown3);
            Controls.Add(CustomUpDown2);
            Controls.Add(CustomUpDown1);
            Controls.Add(TotalNumericUpDown);
            Controls.Add(UserTextBox);
            Controls.Add(PriorityComboBox);
            Controls.Add(TypeComboBox);
            Controls.Add(MainDateTimePicker);
            Controls.Add(CompletedLabel);
            Controls.Add(CustomValueLabel4);
            Controls.Add(CustomValueLabel3);
            Controls.Add(CustomValueLabel2);
            Controls.Add(CustomValueLabel1);
            Controls.Add(TotalLabel);
            Controls.Add(UserTaskLabel);
            Controls.Add(CancelButton);
            Controls.Add(OKButton);
            MaximizeBox = false;
            Name = "AddTaskForm";
            RectColor = Color.FromArgb(48, 48, 48);
            ShowRadius = false;
            ShowShadow = true;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "Add/Update Task";
            TitleColor = Color.FromArgb(48, 48, 48);
            TopMost = true;
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIButton OKButton;
        private new Sunny.UI.UIButton CancelButton;
        private Label UserTaskLabel;
        private Label TotalLabel;
        private Label CustomValueLabel1;
        private Label CustomValueLabel2;
        private Label CustomValueLabel3;
        private Label CustomValueLabel4;
        private Label CompletedLabel;
        private DateTimePicker MainDateTimePicker;
        private Sunny.UI.UIComboBox TypeComboBox;
        private Sunny.UI.UIComboBox PriorityComboBox;
        private Sunny.UI.UITextBox UserTextBox;
        private Sunny.UI.UIIntegerUpDown TotalNumericUpDown;
        private Sunny.UI.UIIntegerUpDown CustomUpDown1;
        private Sunny.UI.UIIntegerUpDown CustomUpDown2;
        private Sunny.UI.UIIntegerUpDown CustomUpDown3;
        private Sunny.UI.UIIntegerUpDown CustomUpDown4;
        private Sunny.UI.UISwitch CompletedSwitch;
    }
}