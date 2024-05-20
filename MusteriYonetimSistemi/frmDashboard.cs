using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriYonetimSistemi
{
    public partial class frmDashboard : Form
    {
        bool mousedown;
        private Point offset;

        public string GetManagerName 
        {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; }
        }

        public string GetRoleName 
        {
            get { return txtUserRole.Text; }
            set { txtUserRole.Text = value; }
        }

        public frmDashboard()
        {
            InitializeComponent();
            baslangictaAnaSayfaAc();
            //this.WindowState = FormWindowState.Maximized;
        }

        void baslangictaAnaSayfaAc()
        {
            frmMusteriler frmMusteriler = new frmMusteriler { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.containerPanel.Controls.Add(frmMusteriler);
            frmMusteriler.Show();

            frmAnaSayfa2 frmAnaSayfa2 = new frmAnaSayfa2 { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlDashContainer.Controls.Add(frmAnaSayfa2);
            frmAnaSayfa2.Show();
        }

        private void bunifuPanel3_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mousedown = true;
        }

        private void bunifuPanel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                Point mevcutLokasyon = PointToScreen(e.Location);
                Location = new Point(mevcutLokasyon.X - offset.X, mevcutLokasyon.Y - offset.Y);
            }
        }

        private void bunifuPanel3_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
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

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Oturumu kapatmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.pnlDashContainer.Controls.Clear();
            frmAnaSayfa frmAnaSayfa = new frmAnaSayfa { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlDashContainer.Controls.Add(frmAnaSayfa);
            frmAnaSayfa.Show();

            this.containerPanel.Controls.Clear();
            frmAyarlar frmAyarlar = new frmAyarlar { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.containerPanel.Controls.Add(frmAyarlar);
            frmAyarlar.Show();

        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            this.containerPanel.Controls.Clear();
            frmMusteriler frmMusteriler = new frmMusteriler { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.containerPanel.Controls.Add(frmMusteriler);
            frmMusteriler.Show();

            this.pnlDashContainer.Controls.Clear();
            frmAnaSayfa2 frmAnaSayfa2 = new frmAnaSayfa2 { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlDashContainer.Controls.Add(frmAnaSayfa2);
            frmAnaSayfa2.Show();

        }

        private void brnSatislar_Click(object sender, EventArgs e)
        {
            this.containerPanel.Controls.Clear();
            frmRaporlar frmRaporlar = new frmRaporlar { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.containerPanel.Controls.Add(frmRaporlar);
            frmRaporlar.Show();

            this.pnlDashContainer.Controls.Clear();
            frmAidat frmAidat = new frmAidat { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlDashContainer.Controls.Add(frmAidat);
            frmAidat.Show();
        }

        private void btnStokYonetimi_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            this.containerPanel.Controls.Clear();
            frmAyarlar frmAyarlar = new frmAyarlar { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.containerPanel.Controls.Add(frmAyarlar);
            frmAyarlar.Show();
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            this.containerPanel.Controls.Clear();
            frmRaporlar frmRaporlar = new frmRaporlar { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.containerPanel.Controls.Add(frmRaporlar);
            frmRaporlar.Show();

            this.pnlDashContainer.Controls.Clear();
            frmAnaSayfa frmAnaSayfa = new frmAnaSayfa { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlDashContainer.Controls.Add(frmAnaSayfa);
            frmAnaSayfa.Show();
        }

        private void btnPageUp_Click(object sender, EventArgs e)
        {
            this.pnlDashContainer.Controls.Clear();
            frmAnaSayfa2 frmAnaSayfa2 = new frmAnaSayfa2 { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlDashContainer.Controls.Add(frmAnaSayfa2);
            frmAnaSayfa2.Show();

        }

        private void btnPageDown_Click(object sender, EventArgs e)
        {
            this.pnlDashContainer.Controls.Clear();
            frmAnaSayfa frmAnaSayfa = new frmAnaSayfa { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlDashContainer.Controls.Add(frmAnaSayfa);
            frmAnaSayfa.Show();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            this.pnlDashContainer.Controls.Clear();
            frmKurs frmKurs = new frmKurs { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlDashContainer.Controls.Add(frmKurs);
            frmKurs.Show();

            this.containerPanel.Controls.Clear();
            frmRaporlar frmRaporlar = new frmRaporlar { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.containerPanel.Controls.Add(frmRaporlar);
            frmRaporlar.Show();

        }
    }
}
