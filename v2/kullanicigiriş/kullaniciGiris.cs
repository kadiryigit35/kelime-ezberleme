using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using kullanicigiriş;
using System.Diagnostics.Eventing.Reader;
// Data Source = DESKTOP - SBIVES4; Initial Catalog = kullanicilar; Integrated Security = True; Trust Server Certificate=True

namespace kullanicigiris
{
    public partial class kullaniciGiris : Form
    {
        public kullaniciGiris()
        {
            InitializeComponent();
        }
        public static class KullaniciBilgileri
        {
            public static int KullaniciNo { get; set; }
            public static string KullaniciAdi { get; set; }
            public static string Yetki { get; set; }
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SBIVES4;Initial Catalog=kullanicilar;Integrated Security=True;");
        private void kayit_ol_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TxtKytKullaniciadi.Text) || string.IsNullOrWhiteSpace(TxtKytSifre.Text) || string.IsNullOrWhiteSpace(TxtMail.Text))
            {
                MessageBox.Show("Lütfen Bilgilerinizi Eksiksiz Giriniz!");
                return; // Boşsa kayıt işlemine devam etmeyi durdur
            }

            try
            {
                if (adminRB2.Checked || kullaniciRB2.Checked)
                {
                    string yetki = "Kullanıcı";
                    if (adminRB2.Checked)
                    {
                        yetki = "Admin";
                    }
                    baglanti.Open();
                    SqlCommand komutkaydet = new SqlCommand($"INSERT INTO kullaniciTablo (kullaniciAdi, kullaniciSifre,kullaniciMail,kullaniciYetki ) VALUES (@p1, @p2,@p3,'{yetki}')", baglanti);
                    komutkaydet.Parameters.AddWithValue("@p1", TxtKytKullaniciadi.Text);
                    komutkaydet.Parameters.AddWithValue("@p2", TxtKytSifre.Text);
                    komutkaydet.Parameters.AddWithValue("@p3", TxtMail.Text);
                    komutkaydet.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Kayıt başarıyla eklendi!");
                    TxtKytKullaniciadi.Clear();
                    TxtKytSifre.Clear();
                    TxtMail.Clear();
                }
                else
                {
                    MessageBox.Show("Lütfen Bilgilerinizi Eksiksiz Giriniz!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void sifremi_unuttum_Click(object sender, EventArgs e)
        {

            sUnuttum u = new sUnuttum();
            u.FormClosed += (s, args) => this.Close();
            u.Show();
            this.Hide();

        }


        private void giris_yap_Click(object sender, EventArgs e)
        {
            if (adminRB1.Checked || kullaniciRB1.Checked)
            {
                string yetki = "Kullanıcı";
                if (adminRB1.Checked)
                {
                    yetki = "Admin";
                }

                SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SBIVES4;Initial Catalog=kullanicilar;Integrated Security=True;");
                baglanti.Open();

                SqlCommand komutgiris = new SqlCommand($"SELECT * FROM kullaniciTablo WHERE kullaniciAdi = @p1 AND kullaniciSifre = @p2 AND kullaniciYetki = '{yetki}' ", baglanti);
                komutgiris.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
                komutgiris.Parameters.AddWithValue("@p2", TxtSifre.Text);

                SqlDataReader oku = komutgiris.ExecuteReader();
                if (oku.Read())
                {
                    KullaniciBilgileri.KullaniciNo = Convert.ToInt32(oku["kullaniciNo"]);
                    KullaniciBilgileri.KullaniciAdi = TxtKullaniciAdi.Text;
                    KullaniciBilgileri.Yetki = yetki;

                    if (adminRB1.Checked)
                    {

                        adminArayuz a = new adminArayuz();
                        a.FormClosed += (s, args) => this.Close();
                        a.Show();
                        this.Hide();

                    }
                    else
                    {
                        kullaniciArayuz k = new kullaniciArayuz();
                        k.FormClosed += (s, args) => this.Close();
                        k.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş Yaptınız!");
                }

            }
            else
            {
                MessageBox.Show("yetki seçiniz");
            }
        }
    }
}
