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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            loginGiris();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           
        }

        void loginGiris()
        {
            this.pnlLogin.Controls.Clear();
            frmGiris frm = new frmGiris { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlLogin.Controls.Add(frm);
            frm.Show();
        }
        

        private void tggSifremiGoster_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {

        }
    }
}
