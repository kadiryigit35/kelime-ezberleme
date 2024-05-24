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
using static kullanicigiris.kullaniciGiris;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace kullanicigiriş
{
    public partial class kullaniciArayuz : Form
    {
        public string username;
        public string kullaniciNo;
        public kullaniciArayuz()
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

        private void baslaBtn_Click(object sender, EventArgs e)
        {
            sinav a = new sinav();
            a.FormClosed += (s, args) => this.Close();
            a.username = lblKullaniciAdi.Text;
            a.Show();
            this.Hide();
        }
        islemler bgl = new islemler();
        private void kullaniciArayuz_Load_1(object sender, EventArgs e)
        {
            lblKullaniciAdi.Text = username;
            SqlCommand komut = new SqlCommand("SELECT kullaniciNo FROM kullaniciTablo WHERE kullaniciAdi = ('" + username + "')", bgl.Baglanti());
            kullaniciNo = komut.ExecuteScalar().ToString();
            lblKullaniciNo.Text = kullaniciNo;
        }
    }
}
