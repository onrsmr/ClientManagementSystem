using DocumentFormat.OpenXml.Drawing;
using MusteriYonetimSistemi.Database_EF_Transactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.BunifuCheckBox.Transitions;

namespace MusteriYonetimSistemi
{
    public partial class frmAnaSayfa : Form
    {

        public frmAnaSayfa()
        {
            InitializeComponent();
            yilFiltrele();

            btnFilter.Enabled = true;

            pnlGenelGorunum.HorizontalScroll.Enabled = true;
            pnlGenelGorunum.VerticalScroll.Enabled = true;
        }

        private void yilFiltrele()
        {
            MMS_DbContext yilFiltrele = new MMS_DbContext();

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

        private void btnFilter_Click(object sender, EventArgs e)
        {


        }

        private void btnAylar_Click(object sender, EventArgs e)
        {
        }

        private void btnAylar_Click_1(object sender, EventArgs e)
        {

            MMS_DbContext hesaplamalar = new MMS_DbContext();

            if (cmbxYillar.Text == string.Empty)
            {
                MessageBox.Show("Ay ve Yıl bilgilerini giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                int yil = int.Parse(cmbxYillar.Text);

                int ocak = 1;
                int subat = 2;
                int mart = 3;
                int nisan = 4;
                int mayis = 5;
                int haziran = 6;
                int temmuz = 7;
                int agustos = 8;
                int eylul = 9;
                int ekim = 10;
                int kasim = 11;
                int aralik = 12;

                // aylık toplam gelir, gider ve kar zarar hesaplaması

                // GELİRLER

                double? calculatedIncomesOcak = hesaplamalar.finansalGelirlers.Where(x => x.gelirTarihi.Month == ocak && x.gelirTarihi.Year == yil).Sum(x => (double?)x.gelirTutari);
                double? calculatedIncomesSubat = hesaplamalar.finansalGelirlers.Where(x => x.gelirTarihi.Month == subat && x.gelirTarihi.Year == yil).Sum(x => (double?)x.gelirTutari);
                double? calculatedIncomesMart = hesaplamalar.finansalGelirlers.Where(x => x.gelirTarihi.Month == mart && x.gelirTarihi.Year == yil).Sum(x => (double?)x.gelirTutari);
                double? calculatedIncomesNisan = hesaplamalar.finansalGelirlers.Where(x => x.gelirTarihi.Month == nisan && x.gelirTarihi.Year == yil).Sum(x => (double?)x.gelirTutari);
                double? calculatedIncomesMayis = hesaplamalar.finansalGelirlers.Where(x => x.gelirTarihi.Month == mayis && x.gelirTarihi.Year == yil).Sum(x => (double?)x.gelirTutari);
                double? calculatedIncomesHaziran = hesaplamalar.finansalGelirlers.Where(x => x.gelirTarihi.Month == haziran && x.gelirTarihi.Year == yil).Sum(x => (double?)x.gelirTutari);
                double? calculatedIncomesTemmuz = hesaplamalar.finansalGelirlers.Where(x => x.gelirTarihi.Month == temmuz && x.gelirTarihi.Year == yil).Sum(x => (double?)x.gelirTutari);
                double? calculatedIncomesAgustos = hesaplamalar.finansalGelirlers.Where(x => x.gelirTarihi.Month == agustos && x.gelirTarihi.Year == yil).Sum(x => (double?)x.gelirTutari);
                double? calculatedIncomesEylul = hesaplamalar.finansalGelirlers.Where(x => x.gelirTarihi.Month == eylul && x.gelirTarihi.Year == yil).Sum(x => (double?)x.gelirTutari);
                double? calculatedIncomesEkim = hesaplamalar.finansalGelirlers.Where(x => x.gelirTarihi.Month == ekim && x.gelirTarihi.Year == yil).Sum(x => (double?)x.gelirTutari);
                double? calculatedIncomesKasim = hesaplamalar.finansalGelirlers.Where(x => x.gelirTarihi.Month == kasim && x.gelirTarihi.Year == yil).Sum(x => (double?)x.gelirTutari);
                double? calculatedIncomesAralik = hesaplamalar.finansalGelirlers.Where(x => x.gelirTarihi.Month == aralik && x.gelirTarihi.Year == yil).Sum(x => (double?)x.gelirTutari);

                txtGelirOcak.Text = (calculatedIncomesOcak ?? 0).ToString();
                txtGelirSubat.Text = (calculatedIncomesSubat ?? 0).ToString();
                txtGelirMart.Text = (calculatedIncomesMart ?? 0).ToString();
                txtGelirNisan.Text = (calculatedIncomesNisan ?? 0).ToString();
                txtGelirMayis.Text = (calculatedIncomesMayis ?? 0).ToString();
                txtGelirHaziran.Text = (calculatedIncomesHaziran ?? 0).ToString();
                txtGelirTemmuz.Text = (calculatedIncomesTemmuz ?? 0).ToString();
                txtGelirAgustos.Text = (calculatedIncomesAgustos ?? 0).ToString();
                txtGelirEylul.Text = (calculatedIncomesEylul ?? 0).ToString();
                txtGelirEkim.Text = (calculatedIncomesEkim ?? 0).ToString();
                txtGelirKasim.Text = (calculatedIncomesKasim ?? 0).ToString();
                txtGelirAralik.Text = (calculatedIncomesAralik ?? 0).ToString();


                // GİDERLER

                double? calculatedExpensesOcak = hesaplamalar.finansalGiderlers.Where(x => x.giderTarihi.Month == ocak && x.giderTarihi.Year == yil).Sum(x => (double?)x.giderTutari);
                double? calculatedExpensesSubat = hesaplamalar.finansalGiderlers.Where(x => x.giderTarihi.Month == subat && x.giderTarihi.Year == yil).Sum(x => (double?)x.giderTutari);
                double? calculatedExpensesMart = hesaplamalar.finansalGiderlers.Where(x => x.giderTarihi.Month == mart && x.giderTarihi.Year == yil).Sum(x => (double?)x.giderTutari);
                double? calculatedExpensesNisan = hesaplamalar.finansalGiderlers.Where(x => x.giderTarihi.Month == nisan && x.giderTarihi.Year == yil).Sum(x => (double?)x.giderTutari);
                double? calculatedExpensesMayis = hesaplamalar.finansalGiderlers.Where(x => x.giderTarihi.Month == mayis && x.giderTarihi.Year == yil).Sum(x => (double?)x.giderTutari);
                double? calculatedExpensesHaziran = hesaplamalar.finansalGiderlers.Where(x => x.giderTarihi.Month == haziran && x.giderTarihi.Year == yil).Sum(x => (double?)x.giderTutari);
                double? calculatedExpensesTemmuz = hesaplamalar.finansalGiderlers.Where(x => x.giderTarihi.Month == temmuz && x.giderTarihi.Year == yil).Sum(x => (double?)x.giderTutari);
                double? calculatedExpensesAgustos = hesaplamalar.finansalGiderlers.Where(x => x.giderTarihi.Month == agustos && x.giderTarihi.Year == yil).Sum(x => (double?)x.giderTutari);
                double? calculatedExpensesEylul = hesaplamalar.finansalGiderlers.Where(x => x.giderTarihi.Month == eylul && x.giderTarihi.Year == yil).Sum(x => (double?)x.giderTutari);
                double? calculatedExpensesEkim = hesaplamalar.finansalGiderlers.Where(x => x.giderTarihi.Month == ekim && x.giderTarihi.Year == yil).Sum(x => (double?)x.giderTutari);
                double? calculatedExpensesKasim = hesaplamalar.finansalGiderlers.Where(x => x.giderTarihi.Month == kasim && x.giderTarihi.Year == yil).Sum(x => (double?)x.giderTutari);
                double? calculatedExpensesAralik = hesaplamalar.finansalGiderlers.Where(x => x.giderTarihi.Month == aralik && x.giderTarihi.Year == yil).Sum(x => (double?)x.giderTutari);

                txtGiderOcak.Text = (calculatedExpensesOcak ?? 0).ToString();
                txtGiderSubat.Text = (calculatedExpensesSubat ?? 0).ToString();
                txtGiderMart.Text = (calculatedExpensesMart ?? 0).ToString();
                txtGiderNisan.Text = (calculatedExpensesNisan ?? 0).ToString();
                txtGiderMayis.Text = (calculatedExpensesMayis ?? 0).ToString();
                txtGiderHaziran.Text = (calculatedExpensesHaziran ?? 0).ToString();
                txtGiderTemmuz.Text = (calculatedExpensesTemmuz ?? 0).ToString();
                txtGiderAgustos.Text = (calculatedExpensesAgustos ?? 0).ToString();
                txtGiderEylul.Text = (calculatedExpensesEylul ?? 0).ToString();
                txtGiderEkim.Text = (calculatedExpensesEkim ?? 0).ToString();
                txtGiderKasim.Text = (calculatedExpensesKasim ?? 0).ToString();
                txtGiderAralik.Text = (calculatedExpensesAralik ?? 0).ToString();

                // TOPLAMLAR

                //önceki yıl bakiye
                int oncekiYil = yil - 1;

                double? oncekiYilToplamGelir = hesaplamalar.finansalGelirlers.Where(x => x.gelirTarihi.Year == oncekiYil).Sum(x => (double?)x.gelirTutari);
                txtPrevIncome.Text = (oncekiYilToplamGelir ?? 0).ToString();

                double? oncekiYilToplamGider = hesaplamalar.finansalGiderlers.Where(x => x.giderTarihi.Year == oncekiYil).Sum(x => (double?)x.giderTutari);
                txtPrevExpense.Text = (oncekiYilToplamGider ?? 0).ToString();

                // güncel bakiye
                double? toplamGelir = hesaplamalar.finansalGelirlers.Where(x => x.gelirTarihi.Year == yil).Sum(x => (double?)x.gelirTutari);
                txtGelirToplam.Text = (toplamGelir ?? 0).ToString();

                double? toplamGider = hesaplamalar.finansalGiderlers.Where(x => x.giderTarihi.Year == yil).Sum(x => (double?)x.giderTutari);
                txtGiderToplam.Text = (toplamGider ?? 0).ToString();

                // birlikte bakiye
                double oncekiGelir = double.Parse(txtPrevIncome.Text);
                double guncelGelir = double.Parse(txtGelirToplam.Text);

                double birlikteToplamGelir = oncekiGelir + guncelGelir;
                txtGelirPrevToplam.Text = birlikteToplamGelir.ToString();

                double oncekiGider = double.Parse(txtPrevExpense.Text);
                double guncelGider = double.Parse(txtGiderToplam.Text);

                double birlikteToplamGider = oncekiGider + guncelGider;
                txtGiderPrevToplam.Text = birlikteToplamGider.ToString();

                //kasa toplamlar
                double toplamGelirKasa = double.Parse(txtGelirToplam.Text);
                double toplamGiderKasa = double.Parse(txtGiderToplam.Text);
                double toplamKasa = toplamGelirKasa - toplamGiderKasa;

                txtKasaToplam.Text = toplamKasa.ToString();

                double birlikteToplamKasaGelir = double.Parse(txtGelirPrevToplam.Text);
                double birlikteToplamKasaGider = double.Parse(txtGiderPrevToplam.Text);
                double birlikteToplamKasa = birlikteToplamKasaGelir - birlikteToplamKasaGider;

                txtKasaPrevToplam.Text = birlikteToplamKasa.ToString();

                // KASA HESAPLAMALARI

                double oncekiYilGelir = double.Parse(txtPrevIncome.Text);
                double gelirOcak = double.Parse(txtGelirOcak.Text);
                double gelirSubat = double.Parse(txtGelirSubat.Text);
                double gelirMart = double.Parse(txtGelirMart.Text);
                double gelirNisan = double.Parse(txtGelirNisan.Text);
                double gelirMayis = double.Parse(txtGelirMayis.Text);
                double gelirHaziran = double.Parse(txtGelirHaziran.Text);
                double gelirTemmuz = double.Parse(txtGelirTemmuz.Text);
                double gelirAgustos = double.Parse(txtGelirAgustos.Text);
                double gelirEylul = double.Parse(txtGelirEylul.Text);
                double gelirEkim = double.Parse(txtGelirEkim.Text);
                double gelirKasim = double.Parse(txtGelirKasim.Text);
                double gelirAralik = double.Parse(txtGelirAralik.Text);

                double oncekiYilGider = double.Parse(txtPrevExpense.Text);
                double giderOcak = double.Parse(txtGiderOcak.Text);
                double giderSubat = double.Parse(txtGiderSubat.Text);
                double giderMart = double.Parse(txtGiderMart.Text);
                double giderNisan = double.Parse(txtGiderNisan.Text);
                double giderMayis = double.Parse(txtGiderMayis.Text);
                double giderHaziran = double.Parse(txtGiderHaziran.Text);
                double giderTemmuz = double.Parse(txtGiderTemmuz.Text);
                double giderAgustos = double.Parse(txtGiderAgustos.Text);
                double giderEylul = double.Parse(txtGiderEylul.Text);
                double giderEkim = double.Parse(txtGiderEkim.Text);
                double giderKasim = double.Parse(txtGiderKasim.Text);
                double giderAralik = double.Parse(txtGiderAralik.Text);


                txtKasaOcak.Text = (gelirOcak - giderOcak).ToString();
                txtKasaSubat.Text = (gelirSubat - giderSubat).ToString();
                txtKasaMart.Text = (gelirMart - giderMart).ToString();
                txtKasaNisan.Text = (gelirNisan - giderNisan).ToString();
                txtKasaMayis.Text = (gelirMayis - giderMayis).ToString();
                txtKasaHaziran.Text = (gelirHaziran - giderHaziran).ToString();
                txtKasaTemmuz.Text = (gelirTemmuz - giderTemmuz).ToString();
                txtKasaAgustos.Text = (gelirAgustos - giderAgustos).ToString();
                txtKasaEylul.Text = (gelirEylul - giderEylul).ToString();
                txtKasaEkim.Text = (gelirEkim - giderEkim).ToString();
                txtKasaKasim.Text = (gelirKasim - giderKasim).ToString();
                txtKasaAralik.Text = (gelirAralik - giderAralik).ToString();
                txtPrevCase.Text = (oncekiYilGelir - oncekiYilGider).ToString();

                //// chart Report
                chartReport.Series["Gelir"].Points.AddXY("Ocak", calculatedIncomesOcak);
                chartReport.Series["Gider"].Points.AddXY("Ocak", calculatedExpensesOcak);
                chartReport.Series["Kar/Zarar"].Points.AddXY("Ocak", calculatedIncomesOcak - calculatedExpensesOcak);

                chartReport.Series["Gelir"].Points.AddXY("Şubat", calculatedIncomesSubat);
                chartReport.Series["Gider"].Points.AddXY("Şubat", calculatedExpensesSubat);
                chartReport.Series["Kar/Zarar"].Points.AddXY("Şubat", calculatedIncomesSubat - calculatedExpensesSubat);


                chartReport.Series["Gelir"].Points.AddXY("Mart", calculatedIncomesMart);
                chartReport.Series["Gider"].Points.AddXY("Mart", calculatedExpensesMart);
                chartReport.Series["Kar/Zarar"].Points.AddXY("Mart", calculatedIncomesMart - calculatedExpensesMart);


                chartReport.Series["Gelir"].Points.AddXY("Nisan", calculatedIncomesNisan);
                chartReport.Series["Gider"].Points.AddXY("Nisan", calculatedExpensesNisan);
                chartReport.Series["Kar/Zarar"].Points.AddXY("Nisan", calculatedIncomesNisan - calculatedExpensesNisan);

                chartReport.Series["Gelir"].Points.AddXY("Mayıs", calculatedIncomesMayis);
                chartReport.Series["Gider"].Points.AddXY("Mayıs", calculatedExpensesMayis);
                chartReport.Series["Kar/Zarar"].Points.AddXY("Mayıs", calculatedIncomesMayis - calculatedExpensesMayis);


                chartReport.Series["Gelir"].Points.AddXY("Haziran", calculatedIncomesHaziran);
                chartReport.Series["Gider"].Points.AddXY("Haziran", calculatedExpensesHaziran);
                chartReport.Series["Kar/Zarar"].Points.AddXY("Haziran", calculatedIncomesHaziran - calculatedExpensesHaziran);


                chartReport.Series["Gelir"].Points.AddXY("Temmuz", calculatedIncomesTemmuz);
                chartReport.Series["Gider"].Points.AddXY("Temmuz", calculatedExpensesTemmuz);
                chartReport.Series["Kar/Zarar"].Points.AddXY("Temmuz", calculatedIncomesTemmuz - calculatedExpensesTemmuz);


                chartReport.Series["Gelir"].Points.AddXY("Ağustos", calculatedIncomesAgustos);
                chartReport.Series["Gider"].Points.AddXY("Ağustos", calculatedExpensesAgustos);
                chartReport.Series["Kar/Zarar"].Points.AddXY("Ağustos", calculatedIncomesAgustos - calculatedExpensesAgustos);


                chartReport.Series["Gelir"].Points.AddXY("Eylül", calculatedIncomesEylul);
                chartReport.Series["Gider"].Points.AddXY("Eylül", calculatedExpensesEylul);
                chartReport.Series["Kar/Zarar"].Points.AddXY("Eylül", calculatedIncomesEylul - calculatedExpensesEylul);


                chartReport.Series["Gelir"].Points.AddXY("Ekim", calculatedIncomesEkim);
                chartReport.Series["Gider"].Points.AddXY("Ekim", calculatedExpensesEkim);
                chartReport.Series["Kar/Zarar"].Points.AddXY("Ekim", calculatedIncomesEkim - calculatedExpensesEkim);


                chartReport.Series["Gelir"].Points.AddXY("Kasım", calculatedIncomesKasim);
                chartReport.Series["Gider"].Points.AddXY("Kasım", calculatedExpensesKasim);
                chartReport.Series["Kar/Zarar"].Points.AddXY("Kasım", calculatedIncomesKasim - calculatedExpensesKasim);


                chartReport.Series["Gelir"].Points.AddXY("Aralık", calculatedIncomesAralik);
                chartReport.Series["Gider"].Points.AddXY("Aralık", calculatedExpensesAralik);
                chartReport.Series["Kar/Zarar"].Points.AddXY("Aralık", calculatedIncomesAralik - calculatedExpensesAralik);
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click_1(object sender, EventArgs e)
        {

            MMS_DbContext hesaplamalar = new MMS_DbContext();

            if (cmbxAylar.Text == string.Empty || cmbxYillar.Text == string.Empty)
            {
                MessageBox.Show("Ay ve Yıl bilgilerini giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                int yil = int.Parse(cmbxYillar.Text);
                string ayString = cmbxAylar.Text.ToString();

                int ay = DateTime.ParseExact(ayString, "MMMM", CultureInfo.CurrentCulture).Month;

                // aylık toplam gelir, gider ve kar zarar hesaplaması

                double? calculatedIncomes = hesaplamalar.finansalGelirlers.Where(x => x.gelirTarihi.Month == ay && x.gelirTarihi.Year == yil).Sum(x => (double?)x.gelirTutari);
                double? calculatedExpenses = hesaplamalar.finansalGiderlers.Where(x => x.giderTarihi.Month == ay && x.giderTarihi.Year == yil).Sum(x => (double?)x.giderTutari);

                txtAylikToplamGelir.Text = calculatedIncomes.ToString();
                txtAylikToplamGider.Text = calculatedExpenses.ToString();

                double? karZarar = calculatedIncomes - calculatedExpenses;
                txtAylikKarZarar.Text = karZarar.ToString();

                // en büyük ve en küçük gelir ve gider hesaplaması

                var enBuyukGelir = hesaplamalar.finansalGelirlers
                                 .Where(x => x.gelirTarihi.Month == ay && x.gelirTarihi.Year == yil)
                                 .GroupBy(x => x.gelirKalemi)
                                 .Select(group => new
                                 {
                                     GelirKalemi = group.Key,
                                     ToplamGelir = group.Sum(x => x.gelirTutari)
                                 })
                                 .OrderByDescending(x => x.ToplamGelir)
                                 .ToList();


                var enBuyukGider = hesaplamalar.finansalGiderlers
                                 .Where(x => x.giderTarihi.Month == ay && x.giderTarihi.Year == yil)
                                 .GroupBy(x => x.giderKalemi)
                                 .Select(group => new
                                 {
                                     GelirKalemi = group.Key,
                                     ToplamGelir = group.Sum(x => x.giderTutari)
                                 })
                                 .OrderByDescending(x => x.ToplamGelir)
                                 .ToList();

                dgvEnBuyukGelir.DataSource = enBuyukGelir;
                dgvEnBuyukGider.DataSource = enBuyukGider;

            }
            catch (Exception)
            {
                MessageBox.Show("Aya ait veri bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void hScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {

        }
    }
}
