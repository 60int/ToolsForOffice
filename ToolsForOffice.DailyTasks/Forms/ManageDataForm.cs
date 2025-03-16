using Sunny.UI;

namespace ToolsForOffice.DailyTasks.Forms
{
    public partial class ManageDataForm : UIForm
    {
        public ManageDataForm()
        {
            InitializeComponent();
            ThemeHelper.LoadTheme(this);
            DataBackgroundPictureBox.BackColor = Color.White;
            uiLabel1.BackColor = Color.White;
            uiLabel2.BackColor = Color.White;
            uiLabel3.BackColor = Color.White;
            uiLabel4.BackColor = Color.White;
            FolderLabel.BackColor = Color.White;
            FolderNameLabel.BackColor = Color.White;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
