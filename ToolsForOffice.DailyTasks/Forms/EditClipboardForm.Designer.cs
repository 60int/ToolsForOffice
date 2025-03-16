namespace ToolsForOffice.DailyTasks.Forms
{
    partial class EditClipboardForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            MainDataGridView = new Sunny.UI.UIDataGridView();
            OKButton = new Sunny.UI.UIButton();
            CancelButton = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)MainDataGridView).BeginInit();
            SuspendLayout();
            // 
            // MainDataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MainDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            MainDataGridView.BackgroundColor = Color.White;
            MainDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            MainDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            MainDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            MainDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            MainDataGridView.EnableHeadersVisualStyles = false;
            MainDataGridView.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainDataGridView.GridColor = Color.FromArgb(48, 48, 48);
            MainDataGridView.Location = new Point(17, 17);
            MainDataGridView.Name = "MainDataGridView";
            MainDataGridView.RectColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            MainDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            MainDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(48, 48, 48);
            MainDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            MainDataGridView.RowTemplate.Height = 25;
            MainDataGridView.ScrollBarColor = Color.FromArgb(48, 48, 48);
            MainDataGridView.ScrollBarRectColor = Color.FromArgb(48, 48, 48);
            MainDataGridView.SelectedIndex = -1;
            MainDataGridView.Size = new Size(991, 425);
            MainDataGridView.StripeOddColor = Color.White;
            MainDataGridView.Style = Sunny.UI.UIStyle.Custom;
            MainDataGridView.TabIndex = 0;
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
            OKButton.Location = new Point(316, 463);
            OKButton.MinimumSize = new Size(1, 1);
            OKButton.Name = "OKButton";
            OKButton.RectColor = Color.FromArgb(48, 48, 48);
            OKButton.RectHoverColor = Color.FromArgb(109, 109, 103);
            OKButton.RectPressColor = Color.FromArgb(109, 109, 103);
            OKButton.RectSelectedColor = Color.FromArgb(109, 109, 103);
            OKButton.Size = new Size(191, 35);
            OKButton.Style = Sunny.UI.UIStyle.Custom;
            OKButton.TabIndex = 3;
            OKButton.Text = "Save";
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
            CancelButton.Location = new Point(513, 463);
            CancelButton.MinimumSize = new Size(1, 1);
            CancelButton.Name = "CancelButton";
            CancelButton.RectColor = Color.FromArgb(48, 48, 48);
            CancelButton.RectHoverColor = Color.FromArgb(109, 109, 103);
            CancelButton.RectPressColor = Color.FromArgb(109, 109, 103);
            CancelButton.RectSelectedColor = Color.FromArgb(109, 109, 103);
            CancelButton.Size = new Size(191, 35);
            CancelButton.Style = Sunny.UI.UIStyle.Custom;
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Close";
            CancelButton.Click += CancelButton_Click;
            // 
            // EditClipboardForm
            // 
            AcceptButton = OKButton;
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1026, 550);
            Controls.Add(CancelButton);
            Controls.Add(OKButton);
            Controls.Add(MainDataGridView);
            Name = "EditClipboardForm";
            Padding = new Padding(0);
            ShowTitle = false;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "EditClipboardForm";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            ((System.ComponentModel.ISupportInitialize)MainDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIDataGridView MainDataGridView;
        private Sunny.UI.UIButton OKButton;
        private new Sunny.UI.UIButton CancelButton;
    }
}