using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogAnalysisApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadLastFile();
            NumLaunches();
        }

        private void NumLaunches()
        {
            int numLaunches = Properties.Settings.Default.NumLaunches;
            numLaunches++;
            Properties.Settings.Default.NumLaunches = numLaunches;
            Properties.Settings.Default.Save();
            numberLaucherToolStripMenuItem.Text = $"Кол-во запусков приложения {numLaunches}";
        }
        private void LoadLastFile()
        {
            string lastFile = Properties.Settings.Default.LastFile;
            if (!string.IsNullOrEmpty(lastFile))
            {
                последнийФайлToolStripMenuItem.Text = lastFile;
                последнийФайлToolStripMenuItem.Visible = true;
            }
        }

        public void UpdateData(string searchStr = null)
        {
            if (ListLines != null && ListLines.Count > 0)
            {
                string splitStr = Properties.Settings.Default.Split;
                ParseFile parseFile = ParseLogFileLogic.ParseLogFile(ListLines, splitStr);
                if (!string.IsNullOrEmpty(parseFile.Error))
                {
                    MessageBox.Show(parseFile.Error, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(searchStr != null)
                {
                    parseFile.ParseLines = SearchLogic.Search(parseFile.ParseLines, searchStr);
                }
                LoadData(parseFile);
                SetBackColorCells();
            }
        }

        private void LoadColumns(string[] nameColumns)
        {
            pnlColumns.Controls.Clear();
            for (int i = 0; i < nameColumns.Length; i++)
            {
                CheckBox checkBox = new CheckBox
                {
                    Name = $"col{i}",
                    Text = $"{nameColumns[i]}"
                };
                checkBox.Location = new Point(0, i * checkBox.Height + 10);
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
                pnlColumns.Controls.Add(checkBox);
            }
        }

        private void HiddenColumns()
        {
            string[] nameHiddenColumns = Properties.Settings.Default.HiddenColumns.Cast<string>().ToArray();
            if (dt.Columns.Count >= nameHiddenColumns.Length)
            {
                for (int i = 0; i < dtgrdvwMain.Columns.Count; i++)
                {
                    dtgrdvwMain.Columns[i].Visible = true;
                }
                foreach (var hiddenColumn in nameHiddenColumns)
                {
                    if(int.TryParse(hiddenColumn, out int numColumn))
                    {
                        dtgrdvwMain.Columns[numColumn].Visible = false;
                    }
                }
            }
        }
        DataTable dt;
        private void LoadData(ParseFile parseFile)
        {
            dt = new DataTable();
            if (parseFile.ParseLines.Count == 0)
            {
                dtgrdvwMain.DataSource = null;
                return;
            }
            string[] nameColumns = Properties.Settings.Default.NameColumns.Cast<string>().ToArray();
            if(nameColumns.Length > 0)
            {
                LoadColumns(nameColumns);
                var item = parseFile.ParseLines.FirstOrDefault();
                if (item.Length >= nameColumns.Length)
                {
                    parseFile.NumColumns = nameColumns.Length;
                }
            }
            for (int i = 0; i < parseFile.NumColumns; i++)
            {
                string columnName = nameColumns.Length >= parseFile.NumColumns ? $"{nameColumns[i]}" : $"col{i}";
                dt.Columns.Add(columnName);
            }
            foreach (var line in parseFile.ParseLines)
            {
                DataRow row = dt.NewRow();
                for (int i = 0; i < parseFile.NumColumns; i++)
                {
                    row[i] = line[i];
                }
                dt.Rows.Add(row);
            }
            dtgrdvwMain.DataSource = dt;
        }

        private void SetBackColorCells()
        {
            string[] colorCells = Properties.Settings.Default.ColorCells.Cast<string>().ToArray();
            for (int i = 0; i < colorCells.Length; i++)
            {
                string[] parse = colorCells[i].Split(';');
                if(parse.Length == 2)
                {
                    string value = parse[0];
                    Color color = Color.FromArgb(Convert.ToInt32(parse[1]));
                    for (int c = 0; c < dtgrdvwMain.ColumnCount; c++)
                    {
                        for (int r = 0; r < dtgrdvwMain.RowCount; r++)
                        {
                            var cell = dtgrdvwMain[c, r];
                            if(cell != null && (string)cell.Value == value)
                            {
                                cell.Style.BackColor = color;
                            }
                        }
                    }
                }
            }
        }

        #region EventHandlersUI
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked)
            {
                int numColumn = Convert.ToInt32(Regex.Replace(checkBox.Name, @"[^\d]", ""));
                Properties.Settings.Default.HiddenColumns.Add(numColumn.ToString());
                Properties.Settings.Default.Save();
            }
            else
            {
                int numColumn = Convert.ToInt32(Regex.Replace(checkBox.Name, @"[^\d]", ""));
                var columns = Properties.Settings.Default.HiddenColumns.Cast<string>().Where(x => x == numColumn.ToString()).ToList();
                foreach (var column in columns)
                {
                    Properties.Settings.Default.HiddenColumns.Remove(column);
                }
                Properties.Settings.Default.Save();
            }
            HiddenColumns();
        }
        public List<string> ListLines;
        private void открытьЛогФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                string fileName = ofd.FileName;
                Properties.Settings.Default.LastFile = fileName;
                ListLines = File.ReadLines(fileName).ToList();
                UpdateData();
                LoadLastFile();
            }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void параметрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog(this);
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlColumns.Controls.Clear();
            ListLines.Clear();
            dtgrdvwMain.DataSource = null;
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog(this);
        }

        private void последнийФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            ListLines = File.ReadLines(menuItem.Text).ToList();
            UpdateData();
        }

        private void dtgrdvwMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                int currentMouseOverRow = dtgrdvwMain.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    MenuItem colorMenu = new MenuItem(string.Format("Задать случайный цвет", currentMouseOverRow.ToString()));
                    colorMenu.Click += ColorMenu_Click;
                    m.MenuItems.Add(colorMenu);
                }
                m.Show(dtgrdvwMain, new Point(e.X, e.Y));
            }
        }
        private Random rnd = new Random();
        private void ColorMenu_Click(object sender, EventArgs e)
        {
            string selectedCellValue = (string)dtgrdvwMain.CurrentCell.Value;
            if (!string.IsNullOrEmpty(selectedCellValue))
            {
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                dtgrdvwMain.CurrentCell.Style.BackColor = randomColor;
                Properties.Settings.Default.ColorCells.Add($"{selectedCellValue};{randomColor.ToArgb().ToString()}");
                SetBackColorCells();
            }
        }
        #endregion
    }
}
