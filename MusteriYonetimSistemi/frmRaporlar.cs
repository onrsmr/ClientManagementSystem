using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriYonetimSistemi
{
    public partial class frmRaporlar : Form
    {
        public frmRaporlar()
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

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            MMS_DbContext filtre = new MMS_DbContext();

            try
            {
                if (cmbxAylar.Text == string.Empty && cmbxYillar.Text == string.Empty)
                {
                    MessageBox.Show("Ay ve Yıl seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int yil = int.Parse(cmbxYillar.Text);
                    string ayString = cmbxAylar.Text.ToString();

                    int ay = DateTime.ParseExact(ayString, "MMMM", CultureInfo.CurrentCulture).Month;

                    string aidatBorcu = "Aidat Borcu Var";
                    string kursBorcu = "Kurs Borcu Var";

                    var filteredIncomes = filtre.finansalGelirlers.Where(x => x.gelirTarihi.Year == yil && x.gelirTarihi.Month == ay).ToList();
                    var filteredExpenses = filtre.finansalGiderlers.Where(x => x.giderTarihi.Year == yil && x.giderTarihi.Month == ay).ToList();


                    //var aidatBorclusu = filtre.genelKayitVeIslemlers.Where(x => x.odemeDurumu == aidatBorcu).ToList();
                    //var kursBorculsu = filtre.genelKayitVeIslemlers.Where(x => x.odemeDurumu == kursBorcu).ToList();

                    dgvListGelir.DataSource = filteredIncomes;
                    dgvListGelir.Columns[0].Visible = false;
                    dgvListGider.DataSource = filteredExpenses;
                    dgvListGider.Columns[0].Visible = false;
                    dgvListGider.Columns[1].Visible = false;
                    //dgvAidatBorclulari.DataSource = aidatBorclusu;
                    //dgvKursBorclulari.DataSource = kursBorcu;

                    var aidatBorcusu = filtre.genelKayitVeIslemlers.Where(x => x.odemeDurumu == aidatBorcu).ToList();
                    var kursBorcusu = filtre.genelKayitVeIslemlers.Where(x => x.odemeDurumu == kursBorcu).ToList();

                    var combinedList = aidatBorcusu.Concat(kursBorcusu).ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veriler getirilirken hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            //MMS_DbContext filtre = new MMS_DbContext();

            //try
            //{
            //    if (string.IsNullOrEmpty(txtKayitNo.Text))
            //    {
            //        MessageBox.Show("Kayıt numarasını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //    string kayitNo = txtKayitNo.Text.ToString();

            //    var bilgiler = filtre.genelKayitVeIslemlers
            //             .Where(x => x.kayitNo == kayitNo)
            //             .GroupBy(x => new { x.kayitNo, x.AdiSoyadi, x.odemeDurumu, x.odemeTarihi})
            //             .Select(group => new
            //             {
            //                 KayitNo = group.Key.kayitNo,
            //                 Kisi = group.Key.AdiSoyadi,
            //                 KayitTarihi = group.Key.odemeTarihi,
            //                 OdemeDurumu = group.Key.odemeDurumu,
            //                 ToplamBorc = group.Sum(x => x.odemeTutari)
            //             })
            //             .ToList();

            //    dgvKisiToplamBorc.DataSource = bilgiler;
            //}
            //catch (FormatException)
            //{
            //    MessageBox.Show("Geçerli bir kayıt numarası giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
