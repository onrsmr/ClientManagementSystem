using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForm;
using MusteriYonetimSistemi.Database_EF_Transactions;

namespace MusteriYonetimSistemi
{
    public partial class frmKayit : Form
    {
        public frmKayit()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kayıt açılmadan çıkış yapılıyor.", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            MMS_DbContext setDataUser = new MMS_DbContext();

            try
            {
                var yeniKullanici = new yeniKullaniciOlustur();
                yeniKullanici.userNameSurname = txtAdSoyad.Text.ToString();
                yeniKullanici.userName = txtKullaniciAdi.Text.ToString();
                yeniKullanici.userRole = cmbxRole.Text.ToString();
                yeniKullanici.userPassword = txtSifre.Text.ToString();

                setDataUser.yeniKullaniciOlusturs.Add(yeniKullanici);
                setDataUser.SaveChanges();
                MessageBox.Show("Kullanıcı başarıyla eklendi.", "Başarılı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();

        }

        private void tggSifremiGoster_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (chcSifremiGoster.Checked == true)
            {
                txtSifre.UseSystemPasswordChar = false;
                txtSifreTekrar.UseSystemPasswordChar = false;
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
                txtSifreTekrar.UseSystemPasswordChar = true;

            }
        }
    }
}
