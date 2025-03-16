using Sunny.UI;
using ToolsForOffice.Shared;

namespace ToolsForOffice.DailyTasks.Forms
{
    public partial class EditValueForm : UIForm
    {
        private readonly CustomValues customValues;

        public EditValueForm(CustomValues customValues)
        {
            InitializeComponent();

            this.customValues = customValues;

            uiTextBox1.DataBindings.Add("Text", customValues, "Value1");
            uiTextBox2.DataBindings.Add("Text", customValues, "Value2");
            uiTextBox3.DataBindings.Add("Text", customValues, "Value3");
            uiTextBox4.DataBindings.Add("Text", customValues, "Value4");

            ThemeHelper.LoadTheme(this);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            customValues.SaveToFile();
        }
    }

}
