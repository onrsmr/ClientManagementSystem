namespace MusteriYonetimSistemi
{
    partial class frmRaporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaporlar));
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListGelir = new System.Windows.Forms.DataGridView();
            this.cmbxAylar = new System.Windows.Forms.ComboBox();
            this.cmbxYillar = new System.Windows.Forms.ComboBox();
            this.dgvListGider = new System.Windows.Forms.DataGridView();
            this.btnFiltre = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGelir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGider)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 20;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 12);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = false;
            this.bunifuPanel1.Size = new System.Drawing.Size(494, 75);
            this.bunifuPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(203, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Raporlar";
            // 
            // dgvListGelir
            // 
            this.dgvListGelir.AllowUserToAddRows = false;
            this.dgvListGelir.AllowUserToDeleteRows = false;
            this.dgvListGelir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListGelir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListGelir.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListGelir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListGelir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListGelir.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListGelir.Location = new System.Drawing.Point(17, 161);
            this.dgvListGelir.MultiSelect = false;
            this.dgvListGelir.Name = "dgvListGelir";
            this.dgvListGelir.ReadOnly = true;
            this.dgvListGelir.RowHeadersVisible = false;
            this.dgvListGelir.Size = new System.Drawing.Size(469, 288);
            this.dgvListGelir.TabIndex = 8;
            // 
            // cmbxAylar
            // 
            this.cmbxAylar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxAylar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.cmbxAylar.ForeColor = System.Drawing.Color.DimGray;
            this.cmbxAylar.FormattingEnabled = true;
            this.cmbxAylar.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cmbxAylar.Location = new System.Drawing.Point(138, 105);
            this.cmbxAylar.Name = "cmbxAylar";
            this.cmbxAylar.Size = new System.Drawing.Size(223, 25);
            this.cmbxAylar.TabIndex = 6;
            // 
            // cmbxYillar
            // 
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
            this.cmbxYillar.Location = new System.Drawing.Point(368, 105);
            this.cmbxYillar.Name = "cmbxYillar";
            this.cmbxYillar.Size = new System.Drawing.Size(91, 25);
            this.cmbxYillar.TabIndex = 11;
            // 
            // dgvListGider
            // 
            this.dgvListGider.AllowUserToAddRows = false;
            this.dgvListGider.AllowUserToDeleteRows = false;
            this.dgvListGider.AllowUserToResizeColumns = false;
            this.dgvListGider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListGider.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListGider.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListGider.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListGider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListGider.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListGider.Location = new System.Drawing.Point(17, 478);
            this.dgvListGider.MultiSelect = false;
            this.dgvListGider.Name = "dgvListGider";
            this.dgvListGider.ReadOnly = true;
            this.dgvListGider.RowHeadersVisible = false;
            this.dgvListGider.Size = new System.Drawing.Size(469, 288);
            this.dgvListGider.TabIndex = 8;
            // 
            // btnFiltre
            // 
            this.btnFiltre.Location = new System.Drawing.Point(464, 106);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(23, 23);
            this.btnFiltre.TabIndex = 13;
            this.btnFiltre.UseVisualStyleBackColor = true;
            this.btnFiltre.Click += new System.EventHandler(this.btnFiltre_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(13, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ay ve Yıl Seçiniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(14, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Gelir Listesi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(14, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Gider Listesi:";
            // 
            // frmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(502, 783);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFiltre);
            this.Controls.Add(this.dgvListGider);
            this.Controls.Add(this.cmbxYillar);
            this.Controls.Add(this.dgvListGelir);
            this.Controls.Add(this.cmbxAylar);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRaporlar";
            this.Text = "frmRaporlar";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGelir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.DataGridView dgvListGelir;
        private System.Windows.Forms.ComboBox cmbxAylar;
        private System.Windows.Forms.ComboBox cmbxYillar;
        private System.Windows.Forms.DataGridView dgvListGider;
        private System.Windows.Forms.Button btnFiltre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}