using Sunny.UI;
using ToolsForOffice.Shared;

namespace ToolsForOffice.DailyTasks.Forms
{
    public partial class AddUserForm : UIForm
    {
        User? user;

        internal User? User
        {
            get => user;
            set
            {
                user = value;
                UserNameTextBox.Text = user!.UserName;
            }
        }
        public AddUserForm()
        {
            InitializeComponent();
            ThemeHelper.LoadTheme(this);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                if (UserNameTextBox.Text.Length >= 3)
                {
                    user = new User(UserNameTextBox.Text);
                }
                else
                {
                    MessageBox.Show("Username must be 3 or less characters long!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    UserNameTextBox.Focus();
                    DialogResult = DialogResult.None;
                }
            }
        }
    }
}