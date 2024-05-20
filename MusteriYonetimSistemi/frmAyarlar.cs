using MusteriYonetimSistemi.Database_EF_Transactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriYonetimSistemi
{
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();

            chcNewIncome.Checked = false;
            chcNewExpense.Checked = false;
            btnAddNewIncome.Enabled = false;
            btnAddNewExpense.Enabled = false;
            btnFind.Enabled = false;

            txtYeniGelir.ReadOnly = true;
            txtYeniGider.ReadOnly = true;

            txtUyeKursiyerArat.ReadOnly = true;

            txtUyeKursiyerArat.PlaceholderText = "Gelir veya Gider İşlemlerini Seçiniz.";
            txtYeniGelir.BorderColorActive = Color.IndianRed;
            txtYeniGider.BorderColorActive = Color.IndianRed;

            gelirlerListele();
            giderlerListele();
        }

        void gelirlerListele()
        {
            MMS_DbContext getData = new MMS_DbContext();

            var gelirler = getData.gelirKalemleris.Select(x => x.gelirAdi).ToList();

            cmbxGelirKalemi.DataSource = gelirler;
        }

        void giderlerListele()
        {
            MMS_DbContext getData = new MMS_DbContext();

            var giderler = getData.giderKalemleris.Select(x => x.giderAdi).ToList();

            cmbxGiderKalemi.DataSource = giderler;
        }

        private void chcGelirEkle_CheckedChanged(object sender, EventArgs e)
        {
            if (chcGelirIslemleri.Checked)
            {
                chcGiderIslemleri.Enabled = false;
                cmbxGiderKalemi.Enabled = false;

                chcEkleGider.Enabled = false;
                chcSilGider.Enabled = false;
                chcGuncelleGider.Enabled = false;

                txtUyeKursiyerArat.PlaceholderText = "Üye veya Kursiyer Numarasını Giriniz.";

                txtUyeKursiyerArat.ReadOnly = false;
                cmbxListeSec.Enabled = true;
                txtNoGiderKime.ReadOnly = true;

                txtGiderKime.ReadOnly = true;
                txtGiderNeKadar.ReadOnly = true;
                txtGiderTarihi.ReadOnly = true;

                chcNewExpense.Enabled = false;
                txtYeniGider.ReadOnly = true;
                txtYeniGider.PlaceholderText = string.Empty;
                btnAddNewExpense.Enabled = false;

                btnFind.Enabled = true;
                btn2BugunFinans.Enabled = false;

                lblKime.Enabled = false;
                lblGiderKalemi.Enabled = false;
                lblGiderTarih.Enabled = false;
                lblGiderTutar.Enabled = false;

                cmbxListeSec.BorderColor = Color.LimeGreen;
            }
            else
            {
                chcGiderIslemleri.Enabled = true;
                cmbxGiderKalemi.Enabled = true;

                chcEkleGider.Enabled = true;
                chcSilGider.Enabled = true;
                chcGuncelleGider.Enabled = true;

                txtUyeKursiyerArat.ReadOnly = true;
                cmbxListeSec.Enabled = false;
                txtNoGiderKime.ReadOnly = false;

                txtUyeKursiyerArat.PlaceholderText = "Gelir veya Gider Eklemeyi Seçiniz.";

                txtGelirKimden.Clear();
                txtNoGelirKimden.Clear();
                txtGiderKime.ReadOnly = false;
                txtGiderNeKadar.ReadOnly = false;
                txtGiderTarihi.ReadOnly = false;

                chcNewExpense.Enabled = true;
                txtYeniGider.ReadOnly = false;
                txtYeniGider.PlaceholderText = "Yeni Gider Kalemi Ekle";
                btnAddNewExpense.Enabled = true;

                btnFind.Enabled = false;
                btn2BugunFinans.Enabled = true;

                lblKime.Enabled = true;
                lblGiderKalemi.Enabled = true;
                lblGiderTarih.Enabled = true;
                lblGiderTutar.Enabled = true;

                cmbxListeSec.BorderColor = Color.Gray;
            }
        }

        private void chcGiderEkle_CheckedChanged(object sender, EventArgs e)
        {
            if (chcGiderIslemleri.Checked)
            {
                txtYeniGelir.PlaceholderText = string.Empty;
                
                cmbxListeSec.Enabled = true;
                txtUyeKursiyerArat.ReadOnly = false;
                btnFind.Enabled = true;
                txtNoGelirKimden.ReadOnly = true;

                chcGelirIslemleri.Enabled = false;
                cmbxGelirKalemi.Enabled = false;

                chcEkleGelir.Enabled = false;
                chcSilGelir.Enabled = false;
                chcGuncelleGelir.Enabled = false;

                btnBugunFinans.Enabled = false;

                txtUyeKursiyerArat.PlaceholderText = "Üye veya Kursiyer Numarasını Giriniz.";

                txtGelirKimden.ReadOnly = true;
                txtGelirNeKadar.ReadOnly = true;
                txtGelirTarihi.ReadOnly = true;

                chcNewIncome.Enabled = false;
                txtYeniGelir.ReadOnly = true;
                btnAddNewIncome.Enabled = false;

                lblKimden.Enabled = false;
                lblGelirKalemi.Enabled = false;
                lblGelirTarih.Enabled = false;
                lblGelirTutar.Enabled = false;

                cmbxListeSec.BorderColor = Color.LimeGreen;
            }
            else
            {
                txtYeniGelir.PlaceholderText = "Yeni Gelir Kalemi Ekle";

                cmbxListeSec.Enabled = false;
                txtUyeKursiyerArat.ReadOnly = true;
                btnFind.Enabled = false;
                txtNoGelirKimden.ReadOnly = false;

                chcGelirIslemleri.Enabled = true;
                cmbxGelirKalemi.Enabled = true;

                chcEkleGelir.Enabled = true;
                chcSilGelir.Enabled = true;
                chcGuncelleGelir.Enabled = true;

                btnBugunFinans.Enabled = true;

                txtUyeKursiyerArat.PlaceholderText = "Gelir veya Gider Eklemeyi Seçiniz.";

                txtNoGiderKime.Clear();
                txtGiderKime.Clear();
                txtGelirKimden.ReadOnly = false;
                txtGelirNeKadar.ReadOnly = false;
                txtGelirTarihi.ReadOnly = false;

                chcNewIncome.Enabled = true;
                txtYeniGelir.ReadOnly = false;
                btnAddNewIncome.Enabled = true;

                lblKimden.Enabled = true;
                lblGelirKalemi.Enabled = true;
                lblGelirTarih.Enabled = true;
                lblGelirTutar.Enabled = true;

                cmbxListeSec.BorderColor = Color.Gray;
            }
        }

       
        #region Uye-Kursiyer-Crud
        private void btnMusteriKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbxUyeStatusu.Text))
            {
                cmbxUyeStatusu.BorderColor = Color.IndianRed;
                MessageBox.Show("Lütfen kayıt yerini belirtiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cmbxUyeStatusu.Text == "Dernek Üyesi")
            {
                if (chcUyeEkle.Checked)
                {
                    MMS_DbContext ekleDataUye = new MMS_DbContext();

                    try
                    {
                        var yeniUye = new uyelikBilgileri();
                        yeniUye.uyeNo = lblWho.Text + txtUyeNo.Text;
                        yeniUye.uyeAdSoyad = txtUyeAdSoyad.Text;
                        yeniUye.uyeUyelikTarihi = Convert.ToDateTime(txtUyeUyelikTarihi.Text);
                        yeniUye.uyeSirket = txtUyeSirket.Text;
                        yeniUye.uyeGsm = txtUyeGSM.Text;
                        yeniUye.uyeEposta = txtUyeEposta.Text;
                        yeniUye.uyeKisaAdres = txtUyeKisaAdres.Text;
                        yeniUye.uyeDogumTarihi = Convert.ToDateTime(txtUyeDogumTarihi.Text);
                        yeniUye.uyeAktifPasif = cmbxUyeDurum.Text.ToString();
                        yeniUye.uyeAciklamalar = rtxtUyeAciklamalar.Text;

                        ekleDataUye.uyelikBilgileris.Add(yeniUye);
                        ekleDataUye.SaveChanges();

                        cmbxUyeStatusu.BorderColor = SystemColors.Control;
                        lblStatus.Text = "Üye başarıyla eklendi.";
                        lblStatus.BackColor = Color.LimeGreen;
                    }
                    catch (Exception)
                    {
                        lblStatus.Text = "Bir hata oluştu.";
                        lblStatus.BackColor = Color.Red;
                    }
                }
                else if (chcUyeSil.Checked)
                {
                    MMS_DbContext silDataUye = new MMS_DbContext();


                    if (!string.IsNullOrEmpty(txtUyeNo.Text))
                    {
                        string veriSil = "M-" + txtUyeNo.Text;

                        var uyeSil = silDataUye.uyelikBilgileris.Find(veriSil);

                        silDataUye.uyelikBilgileris.Remove(uyeSil);
                        silDataUye.SaveChanges();

                        lblStatus.Text = "Üye başarıyla silindi.";
                        lblStatus.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        lblStatus.Text = "Bir hata oluştu.";
                        lblStatus.BackColor = Color.Red;
                    }
                }
                else if (chcUyeGuncelle.Checked)
                {
                    MMS_DbContext guncelleDataUye = new MMS_DbContext();

                    string guncelle = "M-" + txtUyeNo.Text;

                    var uyeGuncelle = guncelleDataUye.uyelikBilgileris.Find(guncelle);

                    if (!string.IsNullOrEmpty(txtUyeNo.Text))
                    {
                        uyeGuncelle.uyeAdSoyad = txtUyeAdSoyad.Text.ToString();
                        uyeGuncelle.uyeUyelikTarihi = Convert.ToDateTime(txtUyeUyelikTarihi.Text);
                        uyeGuncelle.uyeSirket = txtUyeSirket.Text.ToString();
                        uyeGuncelle.uyeGsm = txtUyeGSM.Text.ToString();
                        uyeGuncelle.uyeEposta = txtUyeEposta.Text.ToString();
                        uyeGuncelle.uyeKisaAdres = txtUyeKisaAdres.Text.ToString();
                        uyeGuncelle.uyeDogumTarihi = Convert.ToDateTime(txtUyeDogumTarihi.Text);
                        uyeGuncelle.uyeAktifPasif = cmbxUyeDurum.Text.ToString();
                        uyeGuncelle.uyeAciklamalar = rtxtUyeAciklamalar.Text.ToString();

                        guncelleDataUye.SaveChanges();

                        cmbxUyeStatusu.BorderColor = SystemColors.Control;
                        lblStatus.Text = "Üye bilgileri başarıyla güncellendi.";
                        lblStatus.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        lblStatus.Text = "Bir hata oluştu.";
                        lblStatus.BackColor = Color.Red;
                    }
                }
            }

            if (cmbxUyeStatusu.Text == "Kursiyer")
            {
                if (chcUyeEkle.Checked)
                {
                    MMS_DbContext ekleDataKursiyer = new MMS_DbContext();

                    try
                    {
                        // KURSİYER TABLOSUN AKTARIM

                        var yeniKursiyer = new kursiyerBilgileri();
                        yeniKursiyer.kursiyerNo = lblWho.Text + txtUyeNo.Text;
                        yeniKursiyer.kursiyerAdSoyad = txtUyeAdSoyad.Text;
                        yeniKursiyer.kursiyerBaslangicTarihi = Convert.ToDateTime(txtUyeUyelikTarihi.Text);
                        yeniKursiyer.kursiyerSirket = txtUyeSirket.Text;
                        yeniKursiyer.kursiyerGsm = txtUyeGSM.Text;
                        yeniKursiyer.kursiyerEposta = txtUyeEposta.Text;
                        yeniKursiyer.kursiyerKisaAdres = txtUyeKisaAdres.Text;
                        yeniKursiyer.kursiyerDogumTarihi = Convert.ToDateTime(txtUyeDogumTarihi.Text);
                        yeniKursiyer.kursiyerAktifPasif = cmbxUyeDurum.Text.ToString();
                        yeniKursiyer.kursiyerAciklamalar = rtxtUyeAciklamalar.Text;

                        ekleDataKursiyer.kursiyerBilgileris.Add(yeniKursiyer);
                        ekleDataKursiyer.SaveChanges();

                        cmbxUyeStatusu.BorderColor = SystemColors.Control;
                        lblStatus.Text = "Kursiyer başarıyla eklendi.";
                        lblStatus.BackColor = Color.LimeGreen;
                    }
                    catch (Exception)
                    {
                        lblStatus.Text = "Bir hata oluştu.";
                        lblStatus.BackColor = Color.Red;
                    }
                }
                else if (chcUyeSil.Checked)
                {
                    MMS_DbContext silDataKursiyer = new MMS_DbContext();


                    if (!string.IsNullOrEmpty(txtUyeNo.Text))
                    {
                        string veriSil = "C-" + txtUyeNo.Text;

                        var kursiyerSil = silDataKursiyer.kursiyerBilgileris.Find(veriSil);

                        silDataKursiyer.kursiyerBilgileris.Remove(kursiyerSil);
                        silDataKursiyer.SaveChanges();

                        cmbxUyeStatusu.BorderColor = SystemColors.Control;
                        lblStatus.Text = "Kursiyer başarıyla silindi.";
                        lblStatus.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        lblStatus.Text = "Bir hata oluştu.";
                        lblStatus.BackColor = Color.Red;
                    }
                }
                else if (chcUyeGuncelle.Checked)
                {
                    MMS_DbContext guncelleDataKursiyer = new MMS_DbContext();

                    if (!string.IsNullOrEmpty(txtUyeNo.Text))
                    {
                        string guncelle = "C-" + txtUyeNo.Text;

                        var uyeGuncelle = guncelleDataKursiyer.kursiyerBilgileris.Find(guncelle);

                        uyeGuncelle.kursiyerAdSoyad = txtUyeAdSoyad.Text;
                        uyeGuncelle.kursiyerBaslangicTarihi = Convert.ToDateTime(txtUyeUyelikTarihi.Text);
                        uyeGuncelle.kursiyerSirket = txtUyeSirket.Text;
                        uyeGuncelle.kursiyerGsm = txtUyeGSM.Text;
                        uyeGuncelle.kursiyerEposta = txtUyeEposta.Text;
                        uyeGuncelle.kursiyerKisaAdres = txtUyeKisaAdres.Text;
                        uyeGuncelle.kursiyerDogumTarihi = Convert.ToDateTime(txtUyeDogumTarihi.Text);
                        uyeGuncelle.kursiyerAktifPasif = cmbxUyeDurum.Text.ToString();
                        uyeGuncelle.kursiyerAciklamalar = rtxtUyeAciklamalar.Text;

                        guncelleDataKursiyer.SaveChanges();
                        lblStatus.Text = "Kursiyer biglileri başarıyla güncellendi.";
                        lblStatus.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        lblStatus.Text = "Bir hata oluştu.";
                        lblStatus.BackColor = Color.Red;
                    }
                }
            }
        }

        private void btnFindMusteri_Click(object sender, EventArgs e)
        {
            MMS_DbContext findDataUyeKursiyer= new MMS_DbContext();

            if (string.IsNullOrEmpty(cmbxUyeStatusu.Text))
            {
                cmbxUyeStatusu.BorderColor = Color.IndianRed;
                MessageBox.Show("Lütfen kayıt yerini belirtiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cmbxUyeStatusu.Text == "Dernek Üyesi")
                {
                    string uyeNo = lblWho.Text + txtUyeNo.Text;

                    var uye = findDataUyeKursiyer.uyelikBilgileris.FirstOrDefault(m => m.uyeNo == uyeNo);

                    if (uye != null)
                    {
                        txtUyeNo.Text = uye.uyeNo;
                        txtUyeAdSoyad.Text = uye.uyeAdSoyad;
                        txtUyeSirket.Text = uye.uyeSirket;
                        txtUyeUyelikTarihi.Text = uye.uyeUyelikTarihi.ToString();
                        txtUyeGSM.Text = uye.uyeGsm;
                        txtUyeEposta.Text = uye.uyeEposta;
                        txtUyeKisaAdres.Text = uye.uyeKisaAdres;
                        txtUyeDogumTarihi.Text = uye.uyeDogumTarihi.ToString();
                        cmbxUyeDurum.Text= uye.uyeAktifPasif.ToString();
                        rtxtUyeAciklamalar.Text = uye.uyeAciklamalar;
                    }
                    else
                    {
                        lblStatus.Text = "Üye bulunamadı.";
                        lblStatus.BackColor = Color.Red;
                    }
                }
                else if (cmbxUyeStatusu.Text == "Kursiyer")
                {
                    string kursiyerNo = lblWho.Text + txtUyeNo.Text;

                    var kursiyer = findDataUyeKursiyer.kursiyerBilgileris.FirstOrDefault(m => m.kursiyerNo == kursiyerNo);

                    if (kursiyer != null)
                    {
                        txtUyeNo.Text = kursiyer.kursiyerNo;
                        txtUyeAdSoyad.Text = kursiyer.kursiyerAdSoyad;
                        txtUyeSirket.Text = kursiyer.kursiyerSirket;
                        txtUyeUyelikTarihi.Text = kursiyer.kursiyerBaslangicTarihi.ToString();
                        txtUyeGSM.Text = kursiyer.kursiyerGsm;
                        txtUyeEposta.Text = kursiyer.kursiyerEposta;
                        txtUyeKisaAdres.Text = kursiyer.kursiyerKisaAdres;
                        txtUyeDogumTarihi.Text = kursiyer.kursiyerDogumTarihi.ToString();
                        cmbxUyeDurum.Text = kursiyer.kursiyerAktifPasif.ToString();
                        rtxtUyeAciklamalar.Text = kursiyer.kursiyerAciklamalar.ToString();
                    }
                    else
                    {
                        lblStatus.Text = "Kursiyer bulunamadı.";
                        lblStatus.BackColor = Color.Red;
                    }
                }
            }
        }
        #endregion


        #region Finansal-Crud
        private void btnFinansalKaydet_Click(object sender, EventArgs e)
        {
            MMS_DbContext setDataFinans = new MMS_DbContext();
            MMS_DbContext gonderData = new MMS_DbContext();

            if (chcGelirIslemleri.Checked == false && chcGiderIslemleri.Checked == false)
            {
                MessageBox.Show("Lütfen gelir veya gider işaretleyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            if (chcGelirIslemleri.Checked)
            {
                if (chcEkleGelir.Checked)
                {
                    try
                    {
                        var yeniGelir = new finansalGelirler();
                        yeniGelir.kimden = txtGelirKimden.Text;
                        yeniGelir.uyeKursiyerNo = txtNoGelirKimden.Text.ToString();
                        yeniGelir.gelirTutari = double.Parse(txtGelirNeKadar.Text);
                        yeniGelir.gelirTarihi = DateTime.Parse(txtGelirTarihi.Text);
                        yeniGelir.gelirKalemi = cmbxGelirKalemi.Text.ToString();

                        setDataFinans.finansalGelirlers.Add(yeniGelir);
                        setDataFinans.SaveChanges();

                        var gonder = new genelKayitVeIslemler();
                        gonder.kayitNo = txtNoGelirKimden.Text.ToString();
                        gonder.AdiSoyadi = txtGelirKimden.Text.ToString();
                        gonder.odemeTutari = double.Parse(txtGelirNeKadar.Text);
                        gonder.odemeTarihi = DateTime.Parse(txtGelirTarihi.Text);
                        gonder.aciklamalar = cmbxGelirKalemi.Text.ToString();

                        gonderData.genelKayitVeIslemlers.Add(gonder);
                        gonderData.SaveChanges();

                        lblStatus.Text = "Gelir bilgisi başarıyla eklendi.";
                        lblStatus.BackColor = Color.LimeGreen;
                    }
                    catch (Exception)
                    {

                        lblStatus.Text = "Bir hata oluştu.";
                        lblStatus.BackColor = Color.Red;
                    }
                }
                if (chcSilGelir.Checked)
                {
                    if (!string.IsNullOrEmpty(txtUyeKursiyerArat.Text))
                    {
                         int id = int.Parse(txtUyeKursiyerArat.Text);

                        var gelirSil = setDataFinans.finansalGelirlers.Find(id);

                        setDataFinans.finansalGelirlers.Remove(gelirSil);
                        setDataFinans.SaveChanges();

                        lblStatus.Text = "Gelir başarıyla silindi.";
                        lblStatus.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        lblStatus.Text = "Bir hata oluştu.";
                        lblStatus.BackColor = Color.Red;
                    }
                }
                if (chcGuncelleGelir.Checked)
                {
                    int id;

                    if (!int.TryParse(txtUyeKursiyerArat.Text, out id))
                    {
                        lblStatus.Text = "Geçersiz ID.";
                        lblStatus.BackColor = Color.Red;
                        return;
                    }

                    var gelirGuncelle = setDataFinans.finansalGelirlers.Find(id);

                    try
                    {
                        if (gelirGuncelle != null)
                        {
                            gelirGuncelle.uyeKursiyerNo = txtNoGelirKimden.Text;
                            gelirGuncelle.kimden = txtGelirKimden.Text;
                            gelirGuncelle.gelirTutari = double.Parse(txtGelirNeKadar.Text);
                            gelirGuncelle.gelirTarihi = DateTime.Parse(txtGelirTarihi.Text);
                            gelirGuncelle.gelirKalemi = cmbxGelirKalemi.Text;

                            setDataFinans.SaveChanges();

                            lblStatus.Text = "Gelir bilgileri başarıyla güncellendi.";
                            lblStatus.BackColor = Color.LimeGreen;
                        }
                        else
                        {
                            lblStatus.Text = "Belirtilen ID ile bir finansal gelir bulunamadı.";
                            lblStatus.BackColor = Color.Red;
                        }
                    }
                    catch (Exception ex)
                    {
                        lblStatus.Text = "Güncelleme işlemi sırasında bir hata oluştu: " + ex.Message;
                        lblStatus.BackColor = Color.Red;
                    }
                }
            }
            else if (chcGiderIslemleri.Checked)
            {
                if (chcEkleGider.Checked)
                {
                    try
                    {
                        var yeniGider = new finansalGiderler();
                        yeniGider.kime = txtGiderKime.Text;
                        yeniGider.uyeKursiyerNo = txtNoGiderKime.Text.ToString();
                        yeniGider.giderTutari = double.Parse(txtGiderNeKadar.Text);
                        yeniGider.giderTarihi = DateTime.Parse(txtGiderTarihi.Text);
                        yeniGider.giderKalemi = cmbxGiderKalemi.Text.ToString();

                        setDataFinans.finansalGiderlers.Add(yeniGider);
                        setDataFinans.SaveChanges();

                        var gonder = new genelKayitVeIslemler();
                        gonder.kayitNo = txtNoGiderKime.Text.ToString();
                        gonder.AdiSoyadi = txtGiderKime.Text.ToString();
                        gonder.odemeTutari = double.Parse(txtGiderNeKadar.Text);
                        gonder.odemeTarihi = DateTime.Parse(txtGiderTarihi.Text);
                        gonder.aciklamalar = cmbxGiderKalemi.Text.ToString();

                        gonderData.genelKayitVeIslemlers.Add(gonder);
                        gonderData.SaveChanges();

                        lblStatus.Text = "Gider bilgisi başarıyla eklendi.";
                        lblStatus.BackColor = Color.LimeGreen;
                    }
                    catch (Exception)
                    {
                        lblStatus.Text = "Bir hata oluştu.";
                        lblStatus.BackColor = Color.Red;
                    }
                }
                else if (chcSilGider.Checked)
                {
                    if (!string.IsNullOrEmpty(txtUyeKursiyerArat.Text))
                    {
                        int id = int.Parse(txtUyeKursiyerArat.Text);

                        var giderSil = setDataFinans.finansalGiderlers.Find(id);

                        setDataFinans.finansalGiderlers.Remove(giderSil);
                        setDataFinans.SaveChanges();

                        lblStatus.Text = "Gider başarıyla silindi.";
                        lblStatus.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        lblStatus.Text = "Bir hata oluştu.";
                        lblStatus.BackColor = Color.Red;
                    }
                }
                else if (chcGuncelleGider.Checked)
                {
                    int id;

                    if (!int.TryParse(txtUyeKursiyerArat.Text, out id))
                    {
                        lblStatus.Text = "Geçersiz ID.";
                        lblStatus.BackColor = Color.Red;
                        return;
                    }

                    var giderGuncelle = setDataFinans.finansalGiderlers.Find(id);

                    try
                    {
                        if (giderGuncelle != null)
                        {
                            if (cmbxListeSec.Text == "Diğer")
                            {
                                txtNoGiderKime.Text = string.Empty;
                                txtNoGiderKime.ReadOnly = true;
                                giderGuncelle.kime = txtGiderKime.Text;
                                giderGuncelle.giderTutari = double.Parse(txtGiderNeKadar.Text);
                                giderGuncelle.giderTarihi = DateTime.Parse(txtGiderTarihi.Text);
                                giderGuncelle.giderKalemi = cmbxGiderKalemi.Text;
                            }
                            else
                            {
                                txtNoGiderKime.ReadOnly = false;
                                giderGuncelle.uyeKursiyerNo = txtNoGiderKime.Text;
                                giderGuncelle.kime = txtGiderKime.Text;
                                giderGuncelle.giderTutari = double.Parse(txtGiderNeKadar.Text);
                                giderGuncelle.giderTarihi = DateTime.Parse(txtGiderTarihi.Text);
                                giderGuncelle.giderKalemi = cmbxGiderKalemi.Text;
                            }

                            setDataFinans.SaveChanges();

                            lblStatus.Text = "Gider bilgileri başarıyla güncellendi.";
                            lblStatus.BackColor = Color.LimeGreen;
                        }
                        else
                        {
                            lblStatus.Text = "Belirtilen ID ile bir finansal gider bulunamadı.";
                            lblStatus.BackColor = Color.Red;
                        }
                    }
                    catch (Exception ex)
                    {
                        lblStatus.Text = "Güncelleme işlemi sırasında bir hata oluştu: " + ex.Message;
                        lblStatus.BackColor = Color.Red;
                    }
                }
            }
        }
        #endregion

        private void chcNewIncome_CheckedChanged(object sender, EventArgs e)
        {
            if (chcNewIncome.Checked)
            {
                txtYeniGelir.BorderColorActive = Color.LimeGreen;

                btnFinansalKaydet.Enabled = false;

                txtYeniGelir.PlaceholderText = "Bir gelir kalemi giriniz.";
                btnAddNewIncome.Enabled = true;
                btnAddNewIncome.BackColor = Color.LimeGreen;

                txtYeniGelir.ReadOnly = false;

                //

                chcEkleGelir.Enabled = false;
                chcSilGelir.Enabled = false;
                chcGuncelleGelir.Enabled = false;

                lblKimden.Enabled = false;
                lblGelirTutar.Enabled = false;
                lblGelirTarih.Enabled = false;
                lblGelirKalemi.Enabled = false;

                btnBugunFinans.Enabled = false;

                txtNoGelirKimden.ReadOnly = true;
                txtGelirKimden.ReadOnly = true;
                txtGelirNeKadar.ReadOnly = true;
                txtGelirTarihi.ReadOnly = true;


            }
            else
            {
                txtYeniGelir.BorderColorActive = Color.IndianRed;

                btnFinansalKaydet.Enabled = true;

                btnAddNewIncome.Enabled = false;
                btnAddNewIncome.BackColor = SystemColors.Control;

                txtYeniGelir.PlaceholderText = "Yeni Gelir Kalemi Ekle";
                txtYeniGelir.ReadOnly = true;

                //

                chcEkleGelir.Enabled = true;
                chcSilGelir.Enabled = true;
                chcGuncelleGelir.Enabled = true;

                lblKimden.Enabled = true;
                lblGelirTutar.Enabled = true;
                lblGelirTarih.Enabled = true;
                lblGelirKalemi.Enabled = true;

                btnBugunFinans.Enabled = true;

                txtNoGelirKimden.ReadOnly = false;
                txtGelirKimden.ReadOnly = false;
                txtGelirNeKadar.ReadOnly = false;
                txtGelirTarihi.ReadOnly = false;

                txtYeniGelir.Clear();
            }
        }

        private void chcNewExpense_CheckedChanged(object sender, EventArgs e)
        {
            if (chcNewExpense.Checked)
            {
                txtYeniGider.BorderColorActive = Color.LimeGreen;

                btnFinansalKaydet.Enabled = false;

                txtYeniGider.PlaceholderText = "Bir gider kalemi giriniz.";

                btnAddNewExpense.Enabled = true;
                btnAddNewExpense.BackColor = Color.LimeGreen;

                txtYeniGider.ReadOnly = false;

                //

                chcEkleGider.Enabled = false;
                chcSilGider.Enabled = false;
                chcGuncelleGider.Enabled = false;

                lblKime.Enabled = false;
                lblGiderTutar.Enabled = false;
                lblGiderTarih.Enabled = false;
                lblGiderKalemi.Enabled = false;

                btn2BugunFinans.Enabled = false;

                txtNoGiderKime.ReadOnly = true;
                txtGiderKime.ReadOnly = true;
                txtGiderNeKadar.ReadOnly = true;
                txtGiderTarihi.ReadOnly = true;
            }
            else
            {
                txtYeniGider.BorderColorActive = Color.IndianRed;

                btnFinansalKaydet.Enabled = true;

                txtYeniGider.PlaceholderText = "Yeni Gelir Kalemi Ekle";

                btnAddNewExpense.Enabled = false;
                btnAddNewExpense.BackColor = SystemColors.Control;

                txtYeniGider.Clear();
                txtYeniGider.ReadOnly = true;

                //

                chcEkleGider.Enabled = true;
                chcSilGider.Enabled = true;
                chcGuncelleGider.Enabled = true;

                lblKime.Enabled = true;
                lblGiderTutar.Enabled = true;
                lblGiderTarih.Enabled = true;
                lblGiderKalemi.Enabled = true;

                btn2BugunFinans.Enabled = true;

                txtNoGiderKime.ReadOnly = false;
                txtGiderKime.ReadOnly = false;
                txtGiderNeKadar.ReadOnly = false;
                txtGiderTarihi.ReadOnly = false;
            }
        }

        private void chcUyeEkle_CheckedChanged(object sender, EventArgs e)
        {
            if (chcUyeEkle.Checked)
            {
                chcUyeSil.Enabled = false;
                chcUyeGuncelle.Enabled = false;

                btnFindMember.Enabled = false;
            }
            else
            {
                chcUyeSil.Enabled = true;
                chcUyeGuncelle.Enabled = true;

                btnFindMember.Enabled = true;
            }
        }

        private void chcUyeSil_CheckedChanged(object sender, EventArgs e)
        {
            if (chcUyeSil.Checked)
            {
                chcUyeEkle.Enabled = false;
                chcUyeGuncelle.Enabled = false;

                txtUyeAdSoyad.ReadOnly = true;
                txtUyeSirket.ReadOnly = true;
                txtUyeUyelikTarihi.ReadOnly = true;
                txtUyeGSM.ReadOnly = true;
                txtUyeEposta.ReadOnly = true;
                txtUyeKisaAdres.ReadOnly = true;
                txtUyeDogumTarihi.ReadOnly = true;
                cmbxUyeDurum.Enabled = false;
                rtxtUyeAciklamalar.ReadOnly = true;

                btnFindMember.Text = "<";
            }
            else
            {
                chcUyeEkle.Enabled = true;
                chcUyeGuncelle.Enabled = true;

                txtUyeAdSoyad.ReadOnly = false;
                txtUyeSirket.ReadOnly = false;
                txtUyeUyelikTarihi.ReadOnly = false;
                txtUyeGSM.ReadOnly = false;
                txtUyeEposta.ReadOnly = false;
                txtUyeKisaAdres.ReadOnly = false;
                txtUyeDogumTarihi.ReadOnly = false;
                cmbxUyeDurum.Enabled = true;
                rtxtUyeAciklamalar.ReadOnly = false;

                btnFindMember.Text = "";
            }
        }

        private void chcUyeGuncelle_CheckedChanged(object sender, EventArgs e)
        {
            if (chcUyeGuncelle.Checked)
            {
                chcUyeSil.Enabled = false;
                chcUyeEkle.Enabled = false;

                txtUyeNo.ReadOnly = true;

                btnFindMember.Text = "<";
            }
            else
            {
                chcUyeSil.Enabled = true;
                chcUyeEkle.Enabled = true;

                txtUyeNo.ReadOnly = false;
            }
        }


        private void btnAddNewIncome_Click(object sender, EventArgs e)
        {
            MMS_DbContext setDataGelirKalemi = new MMS_DbContext();

            if (string.IsNullOrEmpty(txtYeniGelir.Text))
            {
                MessageBox.Show("Yeni gelir türünü giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var yeniGelirKalemi = new gelirKalemleri();
                    yeniGelirKalemi.gelirAdi = txtYeniGelir.Text.ToString();

                    setDataGelirKalemi.gelirKalemleris.Add(yeniGelirKalemi);

                    // Benzersizlik kontrolü
                    if (IsIncomeColumnNameUnique(setDataGelirKalemi, "gelirAdi"))
                    {
                        setDataGelirKalemi.SaveChanges();

                        var gelirler = setDataGelirKalemi.gelirKalemleris.Select(x => x.gelirAdi).ToList();

                        cmbxGelirKalemi.DataSource = gelirler;

                        lblStatus.Text = "Yeni gelir kalemi başarıyla eklendi.";
                        lblStatus.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        lblStatus.Text = "Girilen gelir kalemi zaten mavut.";
                        lblStatus.BackColor = Color.Orange;
                    }
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "Bir hata oluştu.";
                    lblStatus.BackColor = Color.Red;
                }
            }
        }

        private void btnNewExpense_Click(object sender, EventArgs e)
        {
            MMS_DbContext setDataGiderKalemi = new MMS_DbContext();

            if (string.IsNullOrEmpty(txtYeniGider.Text))
            {
                MessageBox.Show("Yeni gider türünü giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var yeniGiderKalemi = new giderKalemleri();
                    yeniGiderKalemi.giderAdi = txtYeniGider.Text.ToString();

                    setDataGiderKalemi.giderKalemleris.Add(yeniGiderKalemi);

                    // Benzersizlik kontrolü
                    if (IsExpenseColumnNameUnique(setDataGiderKalemi, "giderAdi"))
                    {
                        setDataGiderKalemi.SaveChanges();

                        var giderler = setDataGiderKalemi.giderKalemleris.Select(x => x.giderAdi).ToList();

                        cmbxGiderKalemi.DataSource = giderler;

                        lblStatus.Text = "Yeni gider kalemi başarıyla eklendi.";
                        lblStatus.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        lblStatus.Text = "Girilen gelir kalemi zaten mavut.";
                        lblStatus.BackColor = Color.Orange;
                    }
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "Bir hata oluştu.";
                    lblStatus.BackColor = Color.Red;
                }
            }
        }

        public static bool IsExpenseColumnNameUnique(DbContext dbContext, string columnName)
        {
            var duplicateValues = dbContext.Set<giderKalemleri>()
                                            .GroupBy(x => x.giderAdi)
                                            .Where(g => g.Count() > 1)
                                            .Select(y => y.Key)
                                            .ToList();

            if (duplicateValues.Any())
            {
                foreach (var value in duplicateValues)
                {
                    MessageBox.Show($"Benzersiz olmayan değer: {value}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return false;
            }
            return true;
        }

        public static bool IsIncomeColumnNameUnique(DbContext dbContext, string columnName)
        {
            var duplicateValues = dbContext.Set<gelirKalemleri>()
                                            .GroupBy(x => x.gelirAdi)
                                            .Where(g => g.Count() > 1)
                                            .Select(y => y.Key)
                                            .ToList();

            if (duplicateValues.Any())
            {
                foreach (var value in duplicateValues)
                {
                    MessageBox.Show($"Benzersiz olmayan değer: {value}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return false;
            }
            return true;
        }

        private void btnFindMember_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbxUyeStatusu.Text))
            {
                cmbxUyeStatusu.BorderColor = Color.IndianRed;
                MessageBox.Show("Lütfen kayıt yerini belirtiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (cmbxUyeStatusu.Text == "Dernek Üyesi")
                    {
                        MMS_DbContext setDataUye = new MMS_DbContext();

                        string uyeNo = lblWho.Text + txtUyeNo.Text.ToString();

                        var uye = setDataUye.uyelikBilgileris.FirstOrDefault(m => m.uyeNo == uyeNo);

                        if (uye != null)
                        {
                            txtUyeAdSoyad.Text = uye.uyeAdSoyad;
                            txtUyeSirket.Text = uye.uyeSirket;
                            txtUyeUyelikTarihi.Text = uye.uyeUyelikTarihi.ToString();
                            txtUyeGSM.Text = uye.uyeGsm;
                            txtUyeEposta.Text = uye.uyeEposta;
                            txtUyeKisaAdres.Text = uye.uyeKisaAdres;
                            txtUyeDogumTarihi.Text = uye.uyeDogumTarihi.ToString();
                            cmbxUyeDurum.Text = uye.uyeAktifPasif;
                            rtxtUyeAciklamalar.Text = uye.uyeAciklamalar;
                        }
                        else
                        {
                            lblStatus.Text = "Arattığınız üye bulunamadı.";
                            lblStatus.BackColor = Color.Red;

                            //MessageBox.Show("Üye bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (cmbxUyeStatusu.Text == "Kursiyer")
                    {
                        MMS_DbContext setDataKursiyer = new MMS_DbContext();

                        string kursiyerNo = lblWho.Text + txtUyeNo.Text.ToString();

                        var kursiyer = setDataKursiyer.kursiyerBilgileris.FirstOrDefault(m => m.kursiyerNo == kursiyerNo);

                        if (kursiyer != null)
                        {
                            txtUyeAdSoyad.Text = kursiyer.kursiyerAdSoyad;
                            txtUyeSirket.Text = kursiyer.kursiyerSirket;
                            txtUyeUyelikTarihi.Text = kursiyer.kursiyerBaslangicTarihi.ToString();
                            txtUyeGSM.Text = kursiyer.kursiyerGsm;
                            txtUyeEposta.Text = kursiyer.kursiyerEposta;
                            txtUyeKisaAdres.Text = kursiyer.kursiyerKisaAdres;
                            txtUyeDogumTarihi.Text = kursiyer.kursiyerDogumTarihi.ToString();
                            cmbxUyeDurum.Text = kursiyer.kursiyerAktifPasif.ToString();
                            rtxtUyeAciklamalar.Text = kursiyer.kursiyerAciklamalar;
                        }
                        else
                        {
                            lblStatus.Text = "Arattığınız üye bulunamadı.";
                            lblStatus.BackColor = Color.Red;
                        }
                    }
                }
                catch (Exception)
                {
                    lblStatus.Text = "Bir hata oluştu.";
                    lblStatus.BackColor = Color.Red;
                }
            }
        }

        private void btnYenileUye_Click(object sender, EventArgs e)
        {
            lblWho.Text = string.Empty;
            txtUyeNo.Clear();
            txtUyeAdSoyad.Clear();
            txtUyeUyelikTarihi.Clear();
            txtUyeSirket.Clear();
            txtUyeGSM.Clear();
            txtUyeEposta.Clear();
            txtUyeKisaAdres.Clear();
            txtUyeDogumTarihi.Clear();
            cmbxUyeDurum.Text = string.Empty;
            cmbxUyeStatusu.Text = string.Empty;
            rtxtUyeAciklamalar.Clear();
            chcUyeEkle.Checked = false;
            chcUyeSil.Checked = false;
            chcUyeGuncelle.Checked = false;
            lblStatus.Text = string.Empty;
        }

        private void btnYenileFinansal_Click(object sender, EventArgs e)
        {
            chcGelirIslemleri.Checked = false;
            chcNewIncome.Checked = false;

            cmbxListeSec.Text = string.Empty;
            cmbxListeSec.Enabled = true;
            txtUyeKursiyerArat.Text = string.Empty;

            txtYeniGelir.Clear();
            txtGelirKimden.Clear();
            txtGelirNeKadar.Clear();
            txtGelirTarihi.Clear();
            txtNoGelirKimden.Clear();
            cmbxGelirKalemi.Text = string.Empty;
            lblStatus.Text = string.Empty;

            chcEkleGelir.Checked = false;
            chcSilGelir.Checked = false;
            chcGuncelleGelir.Checked = false;

            //

            chcGiderIslemleri.Checked = false;
            chcNewExpense.Checked = false;

            txtYeniGider.Clear();
            txtGiderKime.Clear();
            txtGiderNeKadar.Clear();
            txtGiderTarihi.Clear();
            cmbxGiderKalemi.Text = string.Empty;

            chcEkleGider.Checked = false;
            chcSilGider.Checked = false;
            chcGuncelleGider.Checked = false;
        }

        private void btnBugunFinans_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;
            txtGelirTarihi.Text = bugun.ToString("d");
        }

        private void btn2BugunFinans_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;
            txtGiderTarihi.Text = bugun.ToString("d");
        }

        private void btnBugunKayit_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;
            txtUyeUyelikTarihi.Text = bugun.ToString("d");
        }

        private void cmbxUyeStatusu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbxUyeStatusu.Text == "Dernek Üyesi")
            {
                lblWho.Text = "M-";
            }
            else if (cmbxUyeStatusu.Text == "Kursiyer")
            {
                lblWho.Text = "C-";
            }
        }

        void kayitGelir()
        {
            MMS_DbContext setDataUyeMusteriler = new MMS_DbContext();
            try
            {
                if (cmbxListeSec.Text == "Üye")
                {
                    try
                    {
                        string kayitNo = "M-" + txtUyeKursiyerArat.Text;

                        var kisi = setDataUyeMusteriler.uyelikBilgileris.FirstOrDefault(m => m.uyeNo == kayitNo);

                        if (kisi == null)
                        {
                            MessageBox.Show("Üye bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            txtNoGelirKimden.Text = kisi.uyeNo.ToString();
                            txtGelirKimden.Text = kisi.uyeAdSoyad;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (cmbxListeSec.Text == "Kursiyer")
                {
                    try
                    {
                        string kayitNo = "C-" + txtUyeKursiyerArat.Text;

                        var kisi = setDataUyeMusteriler.kursiyerBilgileris.FirstOrDefault(m => m.kursiyerNo == kayitNo);

                        if (kisi == null)
                        {
                            MessageBox.Show("Kursiyer bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            txtNoGelirKimden.Text = kisi.kursiyerNo.ToString();
                            txtGelirKimden.Text = kisi.kursiyerAdSoyad;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (cmbxListeSec.Text == "Diğer")
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Üye veya kursiyer bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void kayitGider()
        {
            MMS_DbContext setDataUyeMusteriler = new MMS_DbContext();
            try
            {
                if (cmbxListeSec.Text == "Üye")
                {
                    try
                    {
                        string kayitNo = "M-" + txtUyeKursiyerArat.Text;

                        var kisi = setDataUyeMusteriler.uyelikBilgileris.FirstOrDefault(m => m.uyeNo == kayitNo);

                        if (kisi == null)
                        {
                            MessageBox.Show("Üye bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            txtNoGiderKime.Text = kisi.uyeNo.ToString();
                            txtGiderKime.Text = kisi.uyeAdSoyad;

                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (cmbxListeSec.Text == "Kursiyer")
                {
                    try
                    {
                        string kayitNo = "C-" + txtUyeKursiyerArat.Text;

                        var kisi = setDataUyeMusteriler.kursiyerBilgileris.FirstOrDefault(m => m.kursiyerNo == kayitNo);

                        if (kisi == null)
                        {
                            MessageBox.Show("Kursiyer bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            txtNoGiderKime.Text = kisi.kursiyerNo.ToString();
                            txtGiderKime.Text = kisi.kursiyerAdSoyad;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (cmbxListeSec.Text == "Diğer")
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Üye veya kursiyer bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbxListeSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxListeSec.Text == "Üye" || cmbxListeSec.Text == "Kursiyer")
            {
                txtNoGelirKimden.ReadOnly = true;
                txtGelirKimden.ReadOnly = true;

                txtNoGiderKime.ReadOnly = true;
                txtGiderKime.ReadOnly = true;
            }
            else
            {
                txtNoGelirKimden.ReadOnly = false;
                txtGelirKimden.ReadOnly = false;

                txtNoGiderKime.ReadOnly = false;
                txtGiderKime.ReadOnly = false;
            }

            if (cmbxListeSec.Text == "Diğer")
            {
                txtUyeKursiyerArat.ReadOnly = true;
                txtUyeKursiyerArat.PlaceholderText = string.Empty;
                btnFind.Enabled = false;
            }
            else
            {
                txtUyeKursiyerArat.ReadOnly = false;
                txtUyeKursiyerArat.PlaceholderText = "Üye veya Kursiyer Numarasını Giriniz";
                btnFind.Enabled = true;
            }
        }

        private void chcGuncelleGelir_CheckedChanged(object sender, EventArgs e)
        {
            if (chcGuncelleGelir.Checked)
            {
                txtYeniGelir.BorderColorActive = Color.IndianRed;

                cmbxListeSec.Enabled = false;

                chcGelirIslemleri.Enabled = false;
                chcSilGelir.Enabled = false;

                chcGelirIslemleri.Enabled = true;

                chcGiderIslemleri.Enabled = false;
                txtUyeKursiyerArat.PlaceholderText = "İşlem ID numarasını giriniz.";
                txtYeniGelir.PlaceholderText = string.Empty;
                txtUyeKursiyerArat.ReadOnly = false;
                btnFind.Enabled = true;

                txtYeniGelir.ReadOnly = true;

                chcEkleGelir.Enabled = false;
                chcSilGelir.Enabled = false;

                chcNewIncome.Enabled = false;
                btnAddNewIncome.Enabled = false;
            }
            else
            {
                txtYeniGelir.BorderColorActive = Color.IndianRed;

                cmbxListeSec.Enabled = true;

                txtUyeKursiyerArat.PlaceholderText = "Üye veya Kursiyer Numarasını Giriniz.";
                txtYeniGelir.PlaceholderText = "Yeni Gelir Kalemi Ekle";
                txtUyeKursiyerArat.ReadOnly = true;
                btnFind.Enabled = false;


                txtYeniGelir.ReadOnly = true;

                chcGelirIslemleri.Enabled = true;
                chcSilGelir.Enabled = true;

                chcEkleGelir.Enabled = true;
                chcNewIncome.Enabled = true;
                btnAddNewIncome.Enabled = true;
            }
        }

       
        private void chcSilGelir_CheckedChanged(object sender, EventArgs e)
        {
            if (chcSilGelir.Checked)
            {
                txtYeniGelir.BorderColorActive = Color.IndianRed;

                chcNewIncome.Enabled = false;
                txtYeniGelir.ReadOnly = true;
                btnAddNewIncome.Enabled = false;

                btnFind.Enabled = false;

                cmbxListeSec.Enabled = false;

                txtYeniGelir.ReadOnly = true;
                txtYeniGelir.BackColor = Color.WhiteSmoke;
                txtYeniGelir.PlaceholderText = string.Empty;
                txtUyeKursiyerArat.PlaceholderText = "İşlem ID numarasını giriniz.";

                chcEkleGelir.Enabled = false;
                chcGuncelleGelir.Enabled = false;

                txtNoGelirKimden.ReadOnly = true;
                txtGelirKimden.ReadOnly = true;
                txtGelirNeKadar.ReadOnly = true;
                txtGelirTarihi.ReadOnly = true;
                cmbxGelirKalemi.Enabled = false;
                btnBugunFinans.Enabled = false;
            }
            else
            {
                txtYeniGelir.BorderColorActive = Color.LimeGreen;

                chcNewIncome.Enabled = true;
                txtYeniGelir.ReadOnly = false;
                btnAddNewIncome.Enabled = true;

                btnFind.Enabled = true;

                cmbxListeSec.Enabled = true;

                txtYeniGelir.ReadOnly = true;
                txtUyeKursiyerArat.PlaceholderText = "Üye veya Kursiyer Numarasını Giriniz.";

                txtYeniGelir.PlaceholderText = "Yeni Gelir Kalemi Ekle.";

                chcEkleGelir.Enabled = true;
                chcGuncelleGelir.Enabled = true;

                txtNoGelirKimden.ReadOnly = false;
                txtGelirKimden.ReadOnly = false;
                txtGelirNeKadar.ReadOnly = false;
                txtGelirTarihi.ReadOnly = false;
                cmbxGelirKalemi.Enabled = true;
                btnBugunFinans.Enabled = true;
            }
        }

        private void chcGuncelleGider_CheckedChanged(object sender, EventArgs e)
        {
            if (chcGuncelleGider.Checked)
            {
                txtYeniGider.BorderColorActive = Color.IndianRed;

                txtUyeKursiyerArat.PlaceholderText = "İşlem ID numarasını giriniz.";
                txtYeniGider.PlaceholderText = string.Empty;
                txtUyeKursiyerArat.ReadOnly = false;
                btnFind.Enabled = true;

                txtYeniGider.ReadOnly = true;

                chcEkleGider.Enabled = false;
                chcSilGider.Enabled = false;

                chcNewExpense.Enabled = false;
                btnAddNewExpense.Enabled = false;
            }
            else
            {
                txtYeniGider.BorderColorActive = Color.LimeGreen;

                txtUyeKursiyerArat.PlaceholderText = "Üye veya Kursiyer Numarasını Giriniz.";
                txtYeniGelir.PlaceholderText = "Yeni Gider Kalemi Ekle";
                txtUyeKursiyerArat.ReadOnly = true;
                btnFind.Enabled = false;


                txtYeniGider.ReadOnly = true;

                chcEkleGider.Enabled = true;
                chcSilGider.Enabled = true;

                chcNewExpense.Enabled = true;
                btnAddNewExpense.Enabled = true;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            MMS_DbContext setTranstastionInfo = new MMS_DbContext();

            if (chcGelirIslemleri.Checked)
            {
                if (chcEkleGelir.Checked)
                {
                    kayitGelir();
                }

                if (chcGuncelleGelir.Checked)
                {
                    int id = int.Parse(txtUyeKursiyerArat.Text);

                    var islemID = setTranstastionInfo.finansalGelirlers.FirstOrDefault(m => m.id == id);

                    if (islemID != null)
                    {
                        txtNoGelirKimden.Text = islemID.uyeKursiyerNo;
                        txtGelirKimden.Text = islemID.kimden;
                        txtGelirNeKadar.Text = islemID.gelirTutari.ToString();
                        txtGelirTarihi.Text = islemID.gelirTarihi.ToString();
                        cmbxGelirKalemi.Text = islemID.gelirKalemi.ToString();
                    }
                    else
                    {
                        lblStatus.Text = "Arattığınız gelir bulunamadı.";
                        lblStatus.BackColor = Color.Red;
                    }
                }
                else if (chcSilGelir.Checked)
                {
                    
                }
                else if (chcEkleGelir.Checked)
                {
                    if (string.IsNullOrEmpty(cmbxListeSec.Text))
                    {
                        MessageBox.Show("Lütfen bir kayıt yeri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbxListeSec.BorderColor = Color.IndianRed;
                    }
                }
            }
            else if (chcGiderIslemleri.Checked)
            {
                if (chcEkleGider.Checked)
                {
                    kayitGider();
                }

                if (chcGuncelleGider.Checked)
                {
                    int id = int.Parse(txtUyeKursiyerArat.Text);

                    var islemID = setTranstastionInfo.finansalGiderlers.FirstOrDefault(m => m.id == id);

                    if (islemID != null)
                    {
                        txtNoGelirKimden.Text = islemID.uyeKursiyerNo;
                        txtGiderKime.Text = islemID.kime;
                        txtGiderNeKadar.Text = islemID.giderTutari.ToString();
                        txtGiderTarihi.Text = islemID.giderTarihi.ToString();
                        cmbxGiderKalemi.Text = islemID.giderKalemi.ToString();
                    }
                    else
                    {
                        lblStatus.Text = "Arattığınız gider bulunamadı.";
                        lblStatus.BackColor = Color.Red;
                    }
                }
                else if (chcSilGider.Checked)
                {
                    if (!string.IsNullOrEmpty(txtUyeKursiyerArat.Text))
                    {
                        int id = int.Parse(txtUyeKursiyerArat.Text);

                        var giderSil = setTranstastionInfo.finansalGiderlers.Find(id);

                        setTranstastionInfo.finansalGiderlers.Remove(giderSil);
                        setTranstastionInfo.SaveChanges();

                        lblStatus.Text = "Gider başarıyla silindi.";
                        lblStatus.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        lblStatus.Text = "Bir hata oluştu.";
                        lblStatus.BackColor = Color.Red;
                    }
                }
                else if (chcEkleGider.Checked)
                {
                    if (string.IsNullOrEmpty(cmbxListeSec.Text))
                    {
                        MessageBox.Show("Lütfen bir kayıt yeri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbxListeSec.BorderColor = Color.IndianRed;
                    }
                }
            }
        }

        private void chcEkleGelir_CheckedChanged(object sender, EventArgs e)
        {
            if (chcEkleGelir.Checked)
            {
                chcGuncelleGelir.Enabled = false;
                chcSilGelir.Enabled = false;
                chcNewIncome.Enabled = false;
                btnAddNewIncome.Enabled = false;
                txtYeniGelir.ReadOnly = true;
                txtYeniGelir.PlaceholderText = string.Empty;

            }
            else
            {
                chcGuncelleGelir.Enabled = true;
                chcSilGelir.Enabled = true;
                chcNewIncome.Enabled = true;
                btnAddNewIncome.Enabled = true;
                txtYeniGelir.ReadOnly = false;
                txtYeniGelir.PlaceholderText = "Yeni Gelir Kalemi Ekle";
            }
        }

        private void chcEkleGider_CheckedChanged(object sender, EventArgs e)
        {
            if (chcEkleGider.Checked)
            {
                chcGuncelleGider.Enabled = false;
                chcSilGider.Enabled = false;
                chcNewExpense.Enabled = false;
                btnAddNewExpense.Enabled = false;
                txtYeniGider.ReadOnly = true;
                txtYeniGider.PlaceholderText = string.Empty;
            }
            else
            {
                chcGuncelleGider.Enabled = true;
                chcSilGider.Enabled = true;
                chcNewExpense.Enabled = true;
                btnAddNewExpense.Enabled = true;
                txtYeniGider.ReadOnly = false;
                txtYeniGider.PlaceholderText = "Yeni Gider Kalemi Ekle";
            }
        }

        private void chcSilGider_CheckedChanged(object sender, EventArgs e)
        {
            if (chcSilGider.Checked)
            {
                cmbxListeSec.Enabled = false;

                txtYeniGider.BorderColorActive = Color.IndianRed;

                chcNewExpense.Enabled = false;
                txtYeniGider.ReadOnly = true;
                btnAddNewExpense.Enabled = false;
                btn2BugunFinans.Enabled = false;

                cmbxListeSec.Enabled = false;

                txtYeniGider.ReadOnly = true;
                txtYeniGider.BackColor = Color.WhiteSmoke;
                txtYeniGider.PlaceholderText = string.Empty;
                txtUyeKursiyerArat.PlaceholderText = "İşlem ID numarasını giriniz.";

                chcEkleGider.Enabled = false;
                chcGuncelleGider.Enabled = false;

                txtNoGiderKime.ReadOnly = true;
                txtGiderKime.ReadOnly = true;
                txtGiderNeKadar.ReadOnly = true;
                txtGiderTarihi.ReadOnly = true;
                cmbxGiderKalemi.Enabled = false;
                btnBugunFinans.Enabled = false;

                txtYeniGider.PlaceholderText = string.Empty;
            }
            else
            {
                cmbxListeSec.Enabled = true;

                txtYeniGider.BorderColorActive = Color.LimeGreen;

                chcNewExpense.Enabled = true;
                txtYeniGider.ReadOnly = false;
                btnAddNewExpense.Enabled = true;
                btn2BugunFinans.Enabled = true;

                cmbxListeSec.Enabled = false;

                txtYeniGider.ReadOnly = true;
                txtYeniGider.BackColor = Color.WhiteSmoke;
                txtYeniGider.PlaceholderText = string.Empty;
                txtUyeKursiyerArat.PlaceholderText = "İşlem ID numarasını giriniz.";

                chcEkleGider.Enabled = true;
                chcGuncelleGider.Enabled = true;

                txtNoGiderKime.ReadOnly = false;
                txtGiderKime.ReadOnly = false;
                txtGiderNeKadar.ReadOnly = false;
                txtGiderTarihi.ReadOnly = false;
                cmbxGiderKalemi.Enabled = true;
                btnBugunFinans.Enabled = true;

                txtYeniGider.PlaceholderText = "Yeni Gider Kalemi Ekle";
            }
        }
    }
}
