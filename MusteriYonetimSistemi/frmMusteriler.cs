using DocumentFormat.OpenXml.Presentation;
using MusteriYonetimSistemi.Database_EF_Transactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriYonetimSistemi
{
    public partial class frmMusteriler : Form
    {
        
        public frmMusteriler()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmMusteriler_KeyDown);

            temizle();
         
        }

        private void frmMusteriler_KeyDown(object sender, KeyEventArgs e)
        {
        //    if (e.Control && e.KeyCode == Keys.S)
        //    {
        //        // Varsayılan davranışı durdur
        //        e.SuppressKeyPress = true;
        //        // Butona odaklanın
        //        btnKaydet.Focus();
        //        // Buton click olayını tetikleyin
        //        btnKaydet.PerformClick();

        //        MessageBox.Show("Değişiklikler kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    if (e.Control && e.KeyCode == Keys.F && btnFind.Focused)
        //    {
        //        e.SuppressKeyPress = true;
        //        // Buton click olayını tetikleyin
        //        btnFind.PerformClick();

        //        MessageBox.Show("Bilgiler getirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        }




        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // bu kısımda kursiyer veya üyelik bilgileri genelKayitVeIslemler tablosunda çekilecek, her kaydetme işlemi aynı kişi adına farklı bir ID de gerçekleşecek, böylece kişi adına bilgiler rahatlıkla genel listeden seçilebilecek.

            MMS_DbContext db = new MMS_DbContext();

            if (txtIslemId.Text == string.Empty)
            {
                MessageBox.Show("İşlem için ID bilgisini giriniz.", "Uyarı", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtIslemId.BackColor = Color.IndianRed;
            }
            else
            {
                int id = int.Parse(txtIslemId.Text);

                if (string.IsNullOrEmpty(cmbxListeSec.Text))
                {
                    MessageBox.Show("Lütfen bir liste seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxListeSec.BorderColor = Color.IndianRed;
                }
                else
                {
                    try
                    {
                        if (cmbxListeSec.Text == "Üyeler")
                        {
                            try
                            {
                                var islemGuncelle = db.genelKayitVeIslemlers.Find(id);

                                if (id != null)
                                {
                                    islemGuncelle.odemeDurumu = cmbxUyeOdemeDurumu.Text;
                                    islemGuncelle.aciklamalar = txtAciklamalar.Text;

                                    db.SaveChanges();

                                    MessageBox.Show("Üye işlem bilgileri güncellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("işlem için ID bilgisini giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Üye işlem bilgileri güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (cmbxListeSec.Text == "Kursiyerler")
                        {
                            try
                            {
                                var islemGuncelle = db.genelKayitVeIslemlers.Find(id);

                                if (id != null)
                                {
                                    islemGuncelle.odemeDurumu = cmbxUyeOdemeDurumu.Text;
                                    islemGuncelle.aciklamalar = txtAciklamalar.Text;

                                    db.SaveChanges();

                                    MessageBox.Show("Kursiyer işlem bilgileri güncellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("işlem için ID bilgisini giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Kursiyer işlem bilgileri güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bilgier güncellenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            MMS_DbContext setDataUyeMusteriler = new MMS_DbContext();

            if (string.IsNullOrEmpty(cmbxListeSec.Text))
            {
                MessageBox.Show("Lütfen bir liste seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbxListeSec.BorderColor = Color.IndianRed;
            }
            else
            {
                try
                {
                    if (cmbxListeSec.Text == "Üyeler")
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
                                txtUyeAdiSoyadi.Text = kisi.uyeAdSoyad;
                                txtUyeSirketi.Text = kisi.uyeSirket;
                                txtUyelikTarihi.Text = kisi.uyeUyelikTarihi.ToString();
                                txtUyeGSM.Text = kisi.uyeGsm;
                                txtUyeSehir.Text = kisi.uyeKisaAdres;
                                txtUyeEposta.Text = kisi.uyeEposta;
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (cmbxListeSec.Text == "Kursiyerler")
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
                                txtUyeAdiSoyadi.Text = kisi.kursiyerAdSoyad;
                                txtUyeSirketi.Text = kisi.kursiyerSirket;
                                txtUyelikTarihi.Text = kisi.kursiyerBaslangicTarihi.ToString();
                                txtUyeGSM.Text = kisi.kursiyerGsm;
                                txtUyeSehir.Text = kisi.kursiyerKisaAdres;
                                txtUyeEposta.Text = kisi.kursiyerEposta;
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Üye veya kursiyer bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            cmbxListeSec.Text = string.Empty;
            txtUyeKursiyerArat.Clear();
            txtUyeAdiSoyadi.Clear();
            txtUyeSirketi.Clear();
            txtUyelikTarihi.Clear();
            txtUyeGSM.Clear();
            txtUyeSehir.Clear();
            txtUyeEposta.Clear();
            cmbxUyeOdemeDurumu.SelectedItem = string.Empty;
            txtIslemId.Clear();
            txtAciklamalar.Clear();
            txtIslemId.BackColor = Color.WhiteSmoke;
        }

        void temizle()
        {
            cmbxListeSec.Text = string.Empty;
            txtUyeKursiyerArat.Clear();
            txtUyeAdiSoyadi.Clear();
            txtUyeSirketi.Clear();
            txtUyelikTarihi.Clear();
            txtUyeGSM.Clear();
            txtUyeSehir.Clear();
            txtUyeEposta.Clear();
            cmbxUyeOdemeDurumu.SelectedItem = string.Empty;
            txtIslemId.Clear();
            txtAciklamalar.Clear();
            txtIslemId.BackColor = Color.WhiteSmoke;
        }

        private void btnIslemSil_Click(object sender, EventArgs e)
        {
            MMS_DbContext db = new MMS_DbContext();

            try
            {
                if (txtIslemId.Text == string.Empty)
                {
                    MessageBox.Show("Silinecek işlemin ID'sini giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIslemId.BackColor = Color.Orange;
                }
                else
                {
                    int id = int.Parse(txtIslemId.Text);

                    var islemSil = db.genelKayitVeIslemlers.Find(id);

                    db.genelKayitVeIslemlers.Remove(islemSil);
                    db.SaveChanges();

                    MessageBox.Show("İşlem başarıyla silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
