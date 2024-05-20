using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MusteriYonetimSistemi
{
    public partial class frmKurs : Form
    {
        public frmKurs()
        {
            InitializeComponent();

            yilFiltrele();
        }

        private void yilFiltrele()
        {
            MMS_DbContext yilFiltrele = new MMS_DbContext();

            // Veritabanında kayıtlı olan tarihleri alıp yıllarını çıkarıyoruz
            var dates = yilFiltrele.genelKayitVeIslemlers.Select(x => x.odemeTarihi).ToList();
            List<string> years = new List<string>();

            foreach (var date in dates)
            {
                string year = date.ToString("yyyy");
                if (!years.Contains(year))
                {
                    years.Add(year);
                }
            }

            cmbxYillar.DataSource = years;
        }

        private async void LoadData()
        {
            MMS_DbContext kursOdemeler = new MMS_DbContext();

            int yil = int.Parse(cmbxYillar.Text);


            var kurs = kursOdemeler.finansalGelirlers
                .Where(x => x.gelirTarihi.Year == yil && x.gelirKalemi == "KURS")
                .GroupBy(x => new { x.uyeKursiyerNo})
                .Select(group => new
                {
                    No = group.Key.uyeKursiyerNo,
                    Kimden = group.Select(x => x.kimden).FirstOrDefault(),
                    OCAK = group.Where(x => x.gelirTarihi.Month == 1).Sum(x => (double?)x.gelirTutari) ?? 0,
                    ŞUBAT = group.Where(x => x.gelirTarihi.Month == 2).Sum(x => (double?)x.gelirTutari) ?? 0,
                    MART = group.Where(x => x.gelirTarihi.Month == 3).Sum(x => (double?)x.gelirTutari) ?? 0,
                    NİSAN = group.Where(x => x.gelirTarihi.Month == 4).Sum(x => (double?)x.gelirTutari) ?? 0,
                    MAYIS = group.Where(x => x.gelirTarihi.Month == 5).Sum(x => (double?)x.gelirTutari) ?? 0,
                    HAZİRAN = group.Where(x => x.gelirTarihi.Month == 6).Sum(x => (double?)x.gelirTutari) ?? 0,
                    TEMMUZ = group.Where(x => x.gelirTarihi.Month == 7).Sum(x => (double?)x.gelirTutari) ?? 0,
                    AĞUSTOS = group.Where(x => x.gelirTarihi.Month == 8).Sum(x => (double?)x.gelirTutari) ?? 0,
                    EYLÜL = group.Where(x => x.gelirTarihi.Month == 9).Sum(x => (double?)x.gelirTutari) ?? 0,
                    EKİM = group.Where(x => x.gelirTarihi.Month == 10).Sum(x => (double?)x.gelirTutari) ?? 0,
                    KASIM = group.Where(x => x.gelirTarihi.Month == 11).Sum(x => (double?)x.gelirTutari) ?? 0,
                    ARALIK = group.Where(x => x.gelirTarihi.Month == 12).Sum(x => (double?)x.gelirTutari) ?? 0,
                })
                .ToList();
           
            dgvKurs.DataSource = kurs;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // DataGridView'daki verileri bir DataTable'a aktar
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn column in dgvKurs.Columns)
                {
                    dt.Columns.Add(column.HeaderText);
                }

                foreach (DataGridViewRow row in dgvKurs.Rows)
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
                    saveFileDialog.FileName = "Kurs.xlsx";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        wb.SaveAs(saveFileDialog.FileName);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Veriler aktarılırken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
