using Sunny.UI;
using System.Text;
using ToolsForOffice.Shared;

namespace ToolsForOffice.DailyTasks.Forms
{
    public partial class EditClipboardForm : UIForm
    {
        #region Fields

        static readonly List<TextCell> textCells = new();

        private SelectedTheme? _cachedSelectedTheme;

        private void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            _cachedSelectedTheme = null;
        }

        #endregion

        public EditClipboardForm()
        {
            InitializeComponent();

            //Check if file is empty
            long fileLen = new FileInfo("Daily Tasks/Settings/CopyClipboard.txt").Length;
            if (fileLen == 0 || (fileLen == 3 && File.ReadAllBytes("file").SequenceEqual(new byte[] { 239, 187, 191 })))
            {
                MessageBox.Show("A text fájl jelenleg nem szerkeszthető", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textCells.Count == 0)
                {
                    using StreamReader reader = new("Daily Tasks/Settings/CopyClipboard.txt", Encoding.UTF8);
                    while (!reader.EndOfStream)
                    {
                        textCells.Add(new TextCell(reader.ReadLine()));
                    }
                    reader.Close();
                }
            }
            MainDataGridView.DataSource = null;
            MainDataGridView.Rows.Clear();
            MainDataGridView.Columns.Clear();
            MainDataGridView.DataSource = textCells;
            MainDataGridView.Columns[1].HeaderText = MainDataGridView.Rows[0].DataBoundItem.ToString();
            MainDataGridView.Columns[2].HeaderText = MainDataGridView.Rows[1].DataBoundItem.ToString();
            MainDataGridView.Columns[3].HeaderText = MainDataGridView.Rows[2].DataBoundItem.ToString();
            MainDataGridView.Columns[4].HeaderText = MainDataGridView.Rows[3].DataBoundItem.ToString();
            MainDataGridView.Columns[5].HeaderText = MainDataGridView.Rows[4].DataBoundItem.ToString();
            MainDataGridView.Columns[6].HeaderText = MainDataGridView.Rows[5].DataBoundItem.ToString();
            MainDataGridView.Columns[7].HeaderText = MainDataGridView.Rows[6].DataBoundItem.ToString();
            MainDataGridView.Columns[8].HeaderText = MainDataGridView.Rows[7].DataBoundItem.ToString();

            MainDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            int rowHeight = (MainDataGridView.Height - MainDataGridView.ColumnHeadersHeight) / MainDataGridView.Rows.Count - 2;
            MainDataGridView.RowTemplate.Height = rowHeight;
            MainDataGridView.ColumnHeadersHeight = rowHeight;
            MainDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            ThemeChangedEventManager.ThemeChanged += OnThemeChanged!;
            ThemeHelper.LoadTheme(this);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Do you want to change this value?", "Value change", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    using TextWriter tw = new StreamWriter("Daily Tasks/Settings/CopyClipboard.txt", false);
                    for (int i = 0; i < MainDataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < MainDataGridView.Columns.Count; j++)
                        {
                            tw.Write($"{MainDataGridView.Rows[i].Cells[j].Value}");
                            if (j != MainDataGridView.Columns.Count - 1)
                            {
                                tw.Write(",");
                            }
                        }
                        tw.WriteLine();
                    }
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
