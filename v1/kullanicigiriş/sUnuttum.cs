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
    public partial class sUnuttum : Form
    {
        public sUnuttum()
        {
            InitializeComponent();
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ileriBtn_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SBIVES4;Initial Catalog=kullanicilar;Integrated Security=True;");
            baglanti.Open();

            SqlCommand komutgiris = new SqlCommand("SELECT * FROM kullaniciTablo WHERE kullaniciAdi = @p1 AND kullaniciMail = @p2", baglanti);
            komutgiris.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
            komutgiris.Parameters.AddWithValue("@p2", TxtMail.Text);
            SqlDataReader oku = komutgiris.ExecuteReader();
            if (oku.Read())
            {
                string sifre = oku["kullaniciSifre"].ToString();
                MessageBox.Show("Şifreniz: " + sifre);

            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!");
            }
        }

    }
}
