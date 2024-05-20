using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriYonetimSistemi
{
    public partial class frmAnaSayfa2 : Form
    {

        MMS_DbContext setDataUyeKursiyer = new MMS_DbContext();

        public frmAnaSayfa2()
        {
            InitializeComponent();
            visibleFalse();
            gdvListDash2.DataSource = setDataUyeKursiyer.genelKayitVeIslemlers.ToList();
            cmbxList2.Text = "İşlemler";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbxList2.Text == "Üye Listesi")
                {
                    gdvListDash2.DataSource = setDataUyeKursiyer.uyelikBilgileris.ToList();
                    visibleFalse();
                }
                else if (cmbxList2.Text == "Kursiyer Listesi")
                {
                    gdvListDash2.DataSource = setDataUyeKursiyer.kursiyerBilgileris.ToList();
                    visibleFalse();
                }
                else if (cmbxList2.Text == "Gelirler Listesi")
                {
                    gdvListDash2.DataSource = setDataUyeKursiyer.finansalGelirlers.ToList();
                    visibleFalse();
                }
                else if (cmbxList2.Text == "Giderler Listesi")
                {
                    gdvListDash2.DataSource = setDataUyeKursiyer.finansalGiderlers.ToList();
                    visibleFalse();
                }
                else if (cmbxList2.Text == "İşlemler")
                {
                    gdvListDash2.DataSource = setDataUyeKursiyer.genelKayitVeIslemlers.ToList();
                    dateTimePicker1.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void visibleFalse()
        {
            dateTimePicker1.Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbxList2.Text == "Üye Listesi")
                {
                    gdvListDash2.DataSource = setDataUyeKursiyer.uyelikBilgileris.ToList();
                    
                }
                else if (cmbxList2.Text == "Kursiyer Listesi")
                {
                    gdvListDash2.DataSource = setDataUyeKursiyer.kursiyerBilgileris.ToList();
                }
                else if (cmbxList2.Text == "Gelirler Listesi")
                {
                    gdvListDash2.DataSource = setDataUyeKursiyer.finansalGelirlers.ToList();
                    btnExportToExcel.Visible = true;
                }
                else if (cmbxList2.Text == "Giderler Listesi")
                {
                    gdvListDash2.DataSource = setDataUyeKursiyer.finansalGiderlers.ToList();
                    btnExportToExcel.Visible = true;
                }
                else if (cmbxList2.Text == "İşlemler")
                {
                    gdvListDash2.DataSource = setDataUyeKursiyer.genelKayitVeIslemlers.ToList();
                    btnExportToExcel.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MMS_DbContext dateFilter = new MMS_DbContext();

            try
            {
                DateTime selectedDate = dateTimePicker1.Value.Date;
                var filteredDate = dateFilter.genelKayitVeIslemlers.Where(p => DbFunctions.TruncateTime(p.odemeTarihi) == selectedDate).ToList();
                gdvListDash2.DataSource = filteredDate;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filtreleme hatası: " + ex.Message);
            }
        }


        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // DataGridView'daki verileri bir DataTable'a aktar
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn column in gdvListDash2.Columns)
                {
                    dt.Columns.Add(column.HeaderText);
                }

                foreach (DataGridViewRow row in gdvListDash2.Rows)
                {
                    DataRow dr = dt.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dr[cell.ColumnIndex] = cell.Value;
                    }
                    dt.Rows.Add(dr);
                }

                // Excel dosyası oluştur
                using (XLWorkbook wb = new XLWorkbook())
                {
                    // Yeni bir sayfa oluştur
                    var ws = wb.Worksheets.Add("Sayfa1");

                    // DataTable'daki verileri Excel sayfasına ekle
                    ws.Cell(1, 1).InsertTable(dt);

                    // Dosyayı kaydet
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.FileName = cmbxList2.Text + ".xlsx";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        wb.SaveAs(saveFileDialog.FileName);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Veriler aktarılırken bir hata oluştu.", "Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
