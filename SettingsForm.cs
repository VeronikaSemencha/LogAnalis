using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogAnalysisApp
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        #region Columns
        private void btnColumns_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
           
            Label label = new Label
            {
                Width = 200,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Text = "Название колонок"
            };
            panelContent.Controls.Add(label);
            
            Button btnSaveColumns = new Button
            {
                Width = 100,
                Height = 30,
                Location = new Point(50, ClientRectangle.Height - 50),
                Name = "btnSaveColumns",
                Text = "Ок"
            };
            btnSaveColumns.Click += BtnSaveColumns_Click;
            pnlButton.Controls.Add(btnSaveColumns);
            
            int numColumns = Properties.Settings.Default.NumColumns;
            GenerateColumn(numColumns);
        }
        Panel pnlColumns;
        private void GenerateColumn(int numColumns, bool update = false)
        {
            int[] listColumns = Enumerable.Range(1, numColumns).ToArray();
            ComboBox cmbxNumColumns = new ComboBox
            {
                Name = "cmbbxNumColumns",
                Width = 100,
                Height = 30,
                Location = new Point(50, 50),
                DataSource = listColumns,
            };
            string[] nameColumns = Properties.Settings.Default.NameColumns.Cast<string>().ToArray();
            if (nameColumns.Length > 0 & numColumns >= nameColumns.Length & !update)
            {
                numColumns = nameColumns.Length;
            }
            panelContent.Controls.Add(cmbxNumColumns);
            cmbxNumColumns.SelectedIndex = numColumns - 1;
            cmbxNumColumns.SelectedValueChanged += CmbxNumColumns_SelectedValueChanged;

            var panel = panelContent.Controls.OfType<Panel>().FirstOrDefault();
            if(panel != null)
            {
                panelContent.Controls.Remove(panel);
            }
            pnlColumns = new Panel
            {
                Location = new Point(0, 100),
                AutoSize = true,
            };
            Point lastLocation = new Point(0, 0);
            for (int i = 0; i < numColumns; i++)
            {
                TextBox textBox = new TextBox
                {
                    Name = $"col{i}",
                    Text = nameColumns.Length >= numColumns ? $"{nameColumns[i]}" : $"col{i}"
                };
                lastLocation = new Point(50, i * textBox.Height + 10);
                textBox.Location = lastLocation;
                pnlColumns.Controls.Add(textBox);
            }
            panelContent.Controls.Add(pnlColumns);
        }

        private void BtnSaveColumns_Click(object sender, EventArgs e)
        {
            var txtbxs = pnlColumns.Controls.OfType<TextBox>();
            var unique = txtbxs.Select(x => x.Text).Distinct();

            if(unique.Count() != txtbxs.Count())
            {
                MessageBox.Show("Название колонок должно быть уникальное", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtbxs.Count() > 0)
            {
                Properties.Settings.Default.NameColumns.Clear();
                
                foreach (var txtbx in txtbxs)
                {
                    Properties.Settings.Default.NameColumns.Add(txtbx.Text);
                }
                Properties.Settings.Default.Save();
                Close();
                ((MainForm)Owner).UpdateData();
            }
        }

        private void CmbxNumColumns_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            int numColumns = (int)comboBox.SelectedItem;
            Properties.Settings.Default.HiddenColumns.Clear();
            GenerateColumn(numColumns, true);
        }
        #endregion

        #region Split
        TextBox txtbxOther;
        private void btnSplit_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Label label = new Label
            {
                Width = 200,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Text = "Разделитель"
            };
            panelContent.Controls.Add(label);
            RadioButton rdbtnTab = new RadioButton
            {
                Name = "9",
                Text = "Tab",
                Font = new Font("Arial", 8, FontStyle.Bold),
                Location = new Point(0, 50)
            };
            panelContent.Controls.Add(rdbtnTab);
            RadioButton rdbtnSemicolon = new RadioButton
            {
                Name = "59",
                Text = ";",
                Font = new Font("Arial", 8, FontStyle.Bold),
                Location = new Point(0, 80)
            };
            panelContent.Controls.Add(rdbtnSemicolon);
            RadioButton rdbtnColon = new RadioButton
            {
                Name = "58",
                Text = ":",
                Font = new Font("Arial", 8, FontStyle.Bold),
                Location = new Point(0, 110)
            };
            panelContent.Controls.Add(rdbtnColon);
            RadioButton rdbtnOther = new RadioButton
            {
                Name = "Other",
                Text = "Другой",
                Font = new Font("Arial", 8, FontStyle.Bold),
                Location = new Point(0, 140)
            };
            panelContent.Controls.Add(rdbtnOther);
            txtbxOther = new TextBox
            {
                Location = new Point(0, 170)
            };
            panelContent.Controls.Add(txtbxOther);
            Button btnSaveSplit = new Button
            {
                Width = 100,
                Height = 30,
                Location = new Point(50, ClientRectangle.Height - 50),
                Name = "btnSaveSplit",
                Text = "Ок"
            };
            btnSaveSplit.Click += BtnSaveSplit_Click;
            pnlButton.Controls.Add(btnSaveSplit);          
            CheckedSplit();
        }
        private void CheckedSplit()
        {
            var rdbtns = panelContent.Controls.OfType<RadioButton>();
            string split = Properties.Settings.Default.Split;
            if (!string.IsNullOrEmpty(split))
            {
                var rdbtn = rdbtns.Where(x => x.Name == split).FirstOrDefault();
                if(rdbtn != null)
                {
                    rdbtn.Checked = true;
                }
                else
                {
                    var rdbtnOther = rdbtns.Where(x => x.Name == "Other").FirstOrDefault();
                    rdbtnOther.Checked = true;
                }
            }
        }
        private void BtnSaveSplit_Click(object sender, EventArgs e)
        {
            var rdbtns = panelContent.Controls.OfType<RadioButton>();
            if(rdbtns.Count() > 0)
            {
                foreach (var rdbtn in rdbtns)
                {
                    if (rdbtn.Checked)
                    {
                        if (rdbtn.Name == "Other")
                        {
                            string otherText = txtbxOther.Text;
                            if (string.IsNullOrEmpty(otherText))
                            {
                                MessageBox.Show("Поле не заполнено", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            Properties.Settings.Default.Split = otherText;
                        }
                        else
                        {
                            Properties.Settings.Default.Split = rdbtn.Name; 
                        }
                        Properties.Settings.Default.Save();
                        Close();
                        ((MainForm)Owner).UpdateData();
                    }
                }
            }
        }
        #endregion

        #region Colors
        private void btnColors_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
