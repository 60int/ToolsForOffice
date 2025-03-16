using Sunny.UI;

namespace ToolsForOffice.DailyTasks.Forms
{
    public partial class EditTypeForm : UIForm
    {
        public List<string> Types { get; } = new List<string>();

        public EditTypeForm(List<string> types)
        {
            InitializeComponent();

            // Set the Text property of each text box to the corresponding item in the types list
            uiTextBox1.Text = types[0];
            uiTextBox2.Text = types[1];
            uiTextBox3.Text = types[2];
            uiTextBox4.Text = types[3];
            uiTextBox5.Text = types[4];
            uiTextBox6.Text = types[5];
            uiTextBox7.Text = types[6];
            uiTextBox8.Text = types[7];
            ThemeHelper.LoadTheme(this);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Do you want to change these values?", "Value change", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    // Add the text from each text box to the Types list
                    Types.Add(uiTextBox1.Text);
                    Types.Add(uiTextBox2.Text);
                    Types.Add(uiTextBox3.Text);
                    Types.Add(uiTextBox4.Text);
                    Types.Add(uiTextBox5.Text);
                    Types.Add(uiTextBox6.Text);
                    Types.Add(uiTextBox7.Text);
                    Types.Add(uiTextBox8.Text);
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }
    }

}
