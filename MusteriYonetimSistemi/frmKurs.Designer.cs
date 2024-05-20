namespace MusteriYonetimSistemi
{
    partial class frmKurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKurs));
            this.cmbxYillar = new System.Windows.Forms.ComboBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.dgvKurs = new System.Windows.Forms.DataGridView();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKurs)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbxYillar
            // 
            this.cmbxYillar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxYillar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxYillar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.cmbxYillar.ForeColor = System.Drawing.Color.DimGray;
            this.cmbxYillar.FormattingEnabled = true;
            this.cmbxYillar.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cmbxYillar.Location = new System.Drawing.Point(333, 22);
            this.cmbxYillar.Name = "cmbxYillar";
            this.cmbxYillar.Size = new System.Drawing.Size(91, 25);
            this.cmbxYillar.TabIndex = 17;
            // 
            // btnBul
            // 
            this.btnBul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBul.Location = new System.Drawing.Point(430, 23);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(23, 23);
            this.btnBul.TabIndex = 18;
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // dgvKurs
            // 
            this.dgvKurs.AllowUserToAddRows = false;
            this.dgvKurs.AllowUserToDeleteRows = false;
            this.dgvKurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKurs.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvKurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKurs.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvKurs.Location = new System.Drawing.Point(10, 54);
            this.dgvKurs.Name = "dgvKurs";
            this.dgvKurs.ReadOnly = true;
            this.dgvKurs.RowHeadersVisible = false;
            this.dgvKurs.Size = new System.Drawing.Size(472, 473);
            this.dgvKurs.TabIndex = 19;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExportToExcel.FlatAppearance.BorderSize = 0;
            this.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportToExcel.Image")));
            this.btnExportToExcel.Location = new System.Drawing.Point(457, 21);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(25, 25);
            this.btnExportToExcel.TabIndex = 20;
            this.btnExportToExcel.UseVisualStyleBackColor = false;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Kurs Ödemeleri";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(300, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Yıl:";
            // 
            // frmKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 539);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.dgvKurs);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.cmbxYillar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKurs";
            this.Text = "frmKurs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbxYillar;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.DataGridView dgvKurs;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}