namespace MusteriYonetimSistemi
{
    partial class frmAnaSayfa2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa2));
            this.cmbxList2 = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.gdvListDash2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdvListDash2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbxList2
            // 
            this.cmbxList2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxList2.Font = new System.Drawing.Font("Arial", 11.25F);
            this.cmbxList2.ForeColor = System.Drawing.Color.DimGray;
            this.cmbxList2.FormattingEnabled = true;
            this.cmbxList2.Items.AddRange(new object[] {
            "Üye Listesi",
            "Kursiyer Listesi",
            "Gelirler Listesi",
            "Giderler Listesi",
            "İşlemler"});
            this.cmbxList2.Location = new System.Drawing.Point(147, 64);
            this.cmbxList2.Name = "cmbxList2";
            this.cmbxList2.Size = new System.Drawing.Size(146, 25);
            this.cmbxList2.TabIndex = 9;
            this.cmbxList2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(297, 64);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 25);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(338, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExportToExcel.FlatAppearance.BorderSize = 0;
            this.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportToExcel.Image")));
            this.btnExportToExcel.Location = new System.Drawing.Point(441, 62);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(25, 25);
            this.btnExportToExcel.TabIndex = 15;
            this.btnExportToExcel.UseVisualStyleBackColor = false;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // gdvListDash2
            // 
            this.gdvListDash2.AllowUserToAddRows = false;
            this.gdvListDash2.AllowUserToDeleteRows = false;
            this.gdvListDash2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdvListDash2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvListDash2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gdvListDash2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvListDash2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvListDash2.GridColor = System.Drawing.Color.WhiteSmoke;
            this.gdvListDash2.Location = new System.Drawing.Point(10, 95);
            this.gdvListDash2.Name = "gdvListDash2";
            this.gdvListDash2.ReadOnly = true;
            this.gdvListDash2.RowHeadersVisible = false;
            this.gdvListDash2.Size = new System.Drawing.Size(456, 426);
            this.gdvListDash2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Genel Liste";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(7, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Öğeleri Listeleyin:";
            // 
            // frmAnaSayfa2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(478, 533);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gdvListDash2);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cmbxList2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnaSayfa2";
            this.Text = "frmAnaSayfa2";
            ((System.ComponentModel.ISupportInitialize)(this.gdvListDash2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbxList2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.DataGridView gdvListDash2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}