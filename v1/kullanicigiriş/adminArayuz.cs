using kullanicigiris;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static kullanicigiris.kullaniciGiris;

namespace kullanicigiriş
{
    public partial class adminArayuz : Form
    {
        public adminArayuz()
        {
            InitializeComponent();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            soruEkleme u = new soruEkleme();
            u.Show();
        }

        private void btnOturumuKapat_Click(object sender, EventArgs e)
        {
            kullaniciGiris k = new kullaniciGiris();
            k.FormClosed += (s, args) => this.Close();
            k.Show();
            this.Hide();
        }

        private void btnKullaniciGoruntule_Click(object sender, EventArgs e)
        {
            kullaniciBilgisi b = new kullaniciBilgisi();
            b.Show();
        }

    }
}
