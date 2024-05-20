using MusteriYonetimSistemi.Database_EF_Transactions;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MusteriYonetimSistemi
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            frmKayit frm = new frmKayit();
            frm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MMS_DbContext conncetion = new MMS_DbContext();

            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                lblUyari.Visible = true;
                btnLogin.IdleBorderColor = Color.IndianRed;
                btnLogin.IdleFillColor = Color.IndianRed;
                return;
            }

            //string query = @"select userRole from kullanicilar where userName = @KullaniciAdi and userPassword = @Sifre";

            var user = conncetion.yeniKullaniciOlusturs
                .FirstOrDefault(x => x.userName == kullaniciAdi && x.userPassword == sifre);

            //object role = cmd.ExecuteScalar();

            if (user != null)
            {
                string userRole = user.userRole.ToString();
                string userNAme = user.userNameSurname.ToString();

                if (userRole == "admin" || userRole == "patron" || userRole == "yönetici" || userRole == "çalışan")
                {
                    frmLogin frmLogin = new frmLogin();
                    frmLogin.Close();
                    this.Close();
                    frmDashboard frmDashboard = new frmDashboard();
                    frmDashboard.GetManagerName = user.userNameSurname.ToString();
                    frmDashboard.GetRoleName = userRole.ToString();
                    frmDashboard.Show();
                }
            }
            else
            {
                lblUyari.Text = "Hatalı Kullanıcı Adı veya Şifre";
                btnLogin.IdleBorderColor = Color.IndianRed;
            }
        }

        private void tggSifremiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (tggSifremiGoster.Checked)
            {
                txtSifre.UseSystemPasswordChar = false;

            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }
}
