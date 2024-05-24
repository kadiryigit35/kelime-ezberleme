using kullanicigiris;
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

namespace kullanicigiriş
{
    public partial class kullaniciArayuz : Form
    {
        public kullaniciArayuz()
        {
            InitializeComponent();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            soruEkleme u = new soruEkleme();
            u.FormClosed += (s, args) => this.Close();
            u.Show();
            this.Hide();
        }

        private void btnOturumuKapat_Click(object sender, EventArgs e)
        {
            kullaniciGiris k = new kullaniciGiris();
            k.FormClosed += (s, args) => this.Close();
            k.Show();
            this.Hide();

        }

        private void baslaBtn_Click(object sender, EventArgs e)
        {
            sinav a = new sinav();
            a.FormClosed += (s, args) => this.Close();
            a.Show();
            this.Hide();
        }
    }
}
