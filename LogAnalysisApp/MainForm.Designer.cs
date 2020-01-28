namespace LogAnalysisApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьЛогФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgrdvwMain = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.последнийФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlColumns = new System.Windows.Forms.Panel();
            this.numberLaucherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwMain)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьЛогФайлToolStripMenuItem,
            this.последнийФайлToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьЛогФайлToolStripMenuItem
            // 
            this.открытьЛогФайлToolStripMenuItem.Name = "открытьЛогФайлToolStripMenuItem";
            this.открытьЛогФайлToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.открытьЛогФайлToolStripMenuItem.Text = "Открыть лог файл";
            this.открытьЛогФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьЛогФайлToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьToolStripMenuItem});
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметрыToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            this.параметрыToolStripMenuItem.Click += new System.EventHandler(this.параметрыToolStripMenuItem_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberLaucherToolStripMenuItem});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // dtgrdvwMain
            // 
            this.dtgrdvwMain.AllowUserToAddRows = false;
            this.dtgrdvwMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrdvwMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrdvwMain.Location = new System.Drawing.Point(3, 3);
            this.dtgrdvwMain.Name = "dtgrdvwMain";
            this.dtgrdvwMain.RowHeadersVisible = false;
            this.dtgrdvwMain.RowTemplate.Height = 24;
            this.dtgrdvwMain.Size = new System.Drawing.Size(826, 521);
            this.dtgrdvwMain.TabIndex = 1;
            this.dtgrdvwMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgrdvwMain_MouseClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.dtgrdvwMain, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlColumns, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 527);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // последнийФайлToolStripMenuItem
            // 
            this.последнийФайлToolStripMenuItem.Name = "последнийФайлToolStripMenuItem";
            this.последнийФайлToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.последнийФайлToolStripMenuItem.Text = "Последний файл";
            this.последнийФайлToolStripMenuItem.Visible = false;
            this.последнийФайлToolStripMenuItem.Click += new System.EventHandler(this.последнийФайлToolStripMenuItem_Click);
            // 
            // pnlColumns
            // 
            this.pnlColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColumns.Location = new System.Drawing.Point(835, 3);
            this.pnlColumns.Name = "pnlColumns";
            this.pnlColumns.Size = new System.Drawing.Size(144, 521);
            this.pnlColumns.TabIndex = 2;
            // 
            // numberLaucherToolStripMenuItem
            // 
            this.numberLaucherToolStripMenuItem.Name = "numberLaucherToolStripMenuItem";
            this.numberLaucherToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.numberLaucherToolStripMenuItem.Text = "NumberLaunches";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 555);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Анализ логов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwMain)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьЛогФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgrdvwMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem последнийФайлToolStripMenuItem;
        private System.Windows.Forms.Panel pnlColumns;
        private System.Windows.Forms.ToolStripMenuItem numberLaucherToolStripMenuItem;
    }
}

