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
        private DataTable dtUsers;
        islemler bgl = new islemler();
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
                    SqlCommand komutkaydet = new SqlCommand($"INSERT INTO kullaniciTablo (kullaniciAdi, kullaniciSifre, kullaniciMail, kullaniciYetki) VALUES (@p1, @p2, @p3, @p4); SELECT SCOPE_IDENTITY();", baglanti);
                    komutkaydet.Parameters.AddWithValue("@p1", TxtKytKullaniciadi.Text);
                    komutkaydet.Parameters.AddWithValue("@p2", TxtKytSifre.Text);
                    komutkaydet.Parameters.AddWithValue("@p3", TxtMail.Text);
                    komutkaydet.Parameters.AddWithValue("@p4", yetki);
                    int kullaniciNo = Convert.ToInt32(komutkaydet.ExecuteScalar());

                    MessageBox.Show("Kayıt başarıyla eklendi!");
                    TxtKytKullaniciadi.Clear();
                    TxtKytSifre.Clear();
                    TxtMail.Clear();
                    baglanti.Close();

                    // Kullanıcı başarıyla eklendikten sonra istatistikler tablosuna giriş yapılıyor
                    foreach (DataRow row in dtKelimeler.Rows)
                    {
                        int kelimeNo = Convert.ToInt32(row["kelimeNo"]);
                        if (yetki == "Kullanıcı")
                        {
                            baglanti.Open();
                            using (SqlCommand insertCommand = new SqlCommand("INSERT INTO istatistikler (kelimeNo, kullaniciNo) VALUES (@kelimeNo, @kullaniciNo)", baglanti))
                            {
                                insertCommand.Parameters.AddWithValue("@kelimeNo", kelimeNo);
                                insertCommand.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
                                insertCommand.ExecuteNonQuery();
                            }
                            baglanti.Close();
                        }
                    }
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
            u.Show();
        }


        public void btnGiris_Click(object sender, EventArgs e)
        {
            if (adminRB1.Checked || kullaniciRB1.Checked)
            {
                string yetki = "Kullanıcı";
                if (adminRB1.Checked)
                {
                    yetki = "Admin";
                }
                islemler bgl = new islemler();

                SqlCommand komutgiris = new SqlCommand($"SELECT * FROM kullaniciTablo WHERE kullaniciAdi = @p1 AND kullaniciSifre = @p2 AND kullaniciYetki = '{yetki}' ", bgl.Baglanti());
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
                        k.username = TxtKullaniciAdi.Text;
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
        private DataTable dtKelimeler;

        private void kullaniciGiris_Load(object sender, EventArgs e)
        {
            string kelimeSorgusu = "SELECT kelimeNo FROM Kelimeler";
            using (SqlCommand kmt = new SqlCommand(kelimeSorgusu, bgl.Baglanti()))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(kmt))
                {
                    dtKelimeler = new DataTable();
                    adapter.Fill(dtKelimeler);
                }
            }
        }
    }
}
