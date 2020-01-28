namespace LogAnalysisApp
{
    partial class SearchForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtbxSeach = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtbxSeach);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Location = new System.Drawing.Point(116, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(11, 12);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(195, 17);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Введите данные для поиска";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(68, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtbxSeach
            // 
            this.txtbxSeach.Location = new System.Drawing.Point(14, 33);
            this.txtbxSeach.Name = "txtbxSeach";
            this.txtbxSeach.Size = new System.Drawing.Size(192, 22);
            this.txtbxSeach.TabIndex = 2;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 151);
            this.Controls.Add(this.panel1);
            this.Name = "SearchForm";
            this.Text = "Поиск";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbxSeach;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}