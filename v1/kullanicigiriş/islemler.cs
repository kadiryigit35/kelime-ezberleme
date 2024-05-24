using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace kullanicigiris
{

    public class islemler
    {

        public SqlConnection Baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-SBIVES4;Initial Catalog=kullanicilar;Integrated Security=True;");
            baglan.Open();
            return baglan;
        }

        public void RastgeleGetir(int KullaniciNo, Control control, PictureBox pictureBox)
        {
            SqlCommand updateCommand = new SqlCommand("UPDATE istatistikler SET HatırlatmaTarihi = DATEADD(day, 1, GETDATE()), EzberDurum = 0, EzberSeviye = 1, EzberTarihi = NULL WHERE HatırlatmaTarihi < DATEADD(day, -1, GETDATE()) AND kullaniciNo = @kullaniciNo", Baglanti());
            updateCommand.Parameters.AddWithValue("@kullaniciNo", KullaniciNo);
            updateCommand.ExecuteNonQuery();
            // Ardından rastgele bir kelime getir
            SqlCommand selectCommand = new SqlCommand("SELECT TOP 1 k.Ad AS KelimeAdı, k.Resim AS ResimYolu " +
                                            "FROM istatistikler i " +
                                            "INNER JOIN kelimeler k ON i.kelimeNo = k.kelimeNo " +
                                            "WHERE (i.EzberDurum = 0 AND i.kullaniciNo = @kullaniciNo) AND " +
                                            "((i.HatırlatmaTarihi >= @dun AND HatırlatmaTarihi <= @bugun) OR " +
                                            "(i.HatırlatmaTarihi >= @birHaftaDun AND HatırlatmaTarihi <= @birHaftaYarin) OR " +
                                            "(i.HatırlatmaTarihi >= @birAyDun AND HatırlatmaTarihi <= @birAyYarin) OR " +
                                            "(i.HatırlatmaTarihi >= @altiAyDun AND HatırlatmaTarihi <= @altiAyYarin)) " +
                                            "ORDER BY NEWID()", Baglanti());
            selectCommand.Parameters.AddWithValue("@kullaniciNo", KullaniciNo);
            selectCommand.Parameters.AddWithValue("@dun", DateTime.Now.AddDays(-1));
            selectCommand.Parameters.AddWithValue("@bugun", DateTime.Now.AddDays(+1));
            selectCommand.Parameters.AddWithValue("@birHaftaDun", DateTime.Now.AddDays(+6));
            selectCommand.Parameters.AddWithValue("@birHaftaYarin", DateTime.Now.AddDays(+7));
            selectCommand.Parameters.AddWithValue("@birAyDun", DateTime.Now.AddDays(+29));
            selectCommand.Parameters.AddWithValue("@birAyYarin", DateTime.Now.AddDays(+30));
            selectCommand.Parameters.AddWithValue("@altiAyDun", DateTime.Now.AddDays(+179));
            selectCommand.Parameters.AddWithValue("@altiAyYarin", DateTime.Now.AddDays(+180));

            SqlDataReader reader = selectCommand.ExecuteReader();

            if (reader.Read())
            {
                string kelimeAdi = reader["KelimeAdı"].ToString();
                string resimYolu = reader["ResimYolu"].ToString();
                reader.Close(); // DataReader'ı kapat

                control.Text = kelimeAdi;

                if (!string.IsNullOrEmpty(resimYolu))
                {
                    if (File.Exists(resimYolu))
                    {
                        pictureBox.Image = Image.FromFile(resimYolu);
                    }
                    else
                    {
                        pictureBox.Image = null;
                    }
                }
                else
                {
                    pictureBox.Image = null;
                }
            }
            else
            {
                reader.Close(); // DataReader'ı kapat
                MessageBox.Show("Günlük Başarıya Ulaştın! Yarın Tekrar Etmeyi Unutma.");
                control.Text = string.Empty;
                pictureBox.Image = null;
            }
        }




        public bool Dogrula(string ing, string tr)
        {
            bool kontrol = false;
            using (SqlConnection connection = Baglanti())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Kelimeler WHERE Ad = @ad", connection);
                command.Parameters.AddWithValue("@ad", ing);

                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    kontrol = string.Compare(tr, dr["Anlam"].ToString(), true) == 0;
                }
                dr.Close();
            }
            return kontrol;
        }
        public void HatirlaticiAyari(int KullaniciNo, string calisilan)
        {
            int kelimeNo;
            using (SqlConnection connection = Baglanti())
            {
                // KelimeNo'yu bulmak için sorgu yap
                SqlCommand command1 = new SqlCommand("SELECT kelimeNo FROM Kelimeler WHERE Ad = @ad", connection);
                command1.Parameters.AddWithValue("@ad", calisilan);
                SqlDataReader da = command1.ExecuteReader();

                if (da.Read())
                {
                    kelimeNo = Convert.ToInt32(da["kelimeNo"]);
                }
                else
                {
                    // Kelime bulunamadıysa işlemi sonlandır
                    da.Close();
                    throw new InvalidOperationException("Kelime bulunamadı.");
                }
                da.Close();

                SqlCommand command = new SqlCommand("SELECT * FROM istatistikler WHERE [kelimeNo] = @kelimeNo AND [kullaniciNo]= @kullaniciNo ", connection);
                command.Parameters.AddWithValue("@kelimeNo", kelimeNo);
                command.Parameters.AddWithValue("@kullaniciNo", KullaniciNo);
                SqlDataReader dr = command.ExecuteReader();
                SqlCommand command2 = null;
                if (dr.Read())
                {
                    switch (Convert.ToInt32(dr["EzberSeviye"]))
                    {
                        case 1:
                            command2 = new SqlCommand("Update istatistikler set HatırlatmaTarihi = DATEADD(d, 1,  HatırlatmaTarihi) where [kelimeNo] = @kelimeNo AND [kullaniciNo]= @kullaniciNo", Baglanti());
                            command2.Parameters.AddWithValue("@kelimeNo", kelimeNo);
                            command2.Parameters.AddWithValue("@kullaniciNo", KullaniciNo);
                            break;

                        case 2:
                            command2 = new SqlCommand("Update istatistikler set HatırlatmaTarihi = DATEADD(ww, 1,  HatırlatmaTarihi) where [kelimeNo] = @kelimeNo AND [kullaniciNo]= @kullaniciNo", Baglanti());
                            command2.Parameters.AddWithValue("@kelimeNo", kelimeNo);
                            command2.Parameters.AddWithValue("@kullaniciNo", KullaniciNo);
                            break;

                        case 3:
                            command2 = new SqlCommand("Update istatistikler set HatırlatmaTarihi = DATEADD(m, 1,  HatırlatmaTarihi) where [kelimeNo] = @kelimeNo AND [kullaniciNo]= @kullaniciNo", Baglanti());
                            command2.Parameters.AddWithValue("@kelimeNo", kelimeNo);
                            command2.Parameters.AddWithValue("@kullaniciNo", KullaniciNo);
                            break;

                        case 4:
                            command2 = new SqlCommand("Update istatistikler set HatırlatmaTarihi = DATEADD(m, 6,  HatırlatmaTarihi) where [kelimeNo] = @kelimeNo AND [kullaniciNo]= @kullaniciNo", Baglanti());
                            command2.Parameters.AddWithValue("@kelimeNo", kelimeNo);
                            command2.Parameters.AddWithValue("@kullaniciNo", KullaniciNo);
                            break;

                        default:
                            command2 = new SqlCommand("Update istatistikler set HatırlatmaTarihi = GETDATE() where [kelimeNo] = @kelimeNo AND [kullaniciNo]= @kullaniciNo", Baglanti());
                            command2.Parameters.AddWithValue("@kelimeNo", kelimeNo);
                            command2.Parameters.AddWithValue("@kullaniciNo", KullaniciNo);
                            break;
                    }
                    dr.Close();
                    command2.ExecuteNonQuery(); // Komut çalıştırıldıktan sonra SqlDataReader kapatılabilir
                }
                else
                {
                    dr.Close(); // DataReader'ı kapat
                }
            }



        }

        public void DurumGuncelle(int KullaniciNo, string ezberlenen)
        {
            int kelimeNo;
            using (SqlConnection connection = Baglanti())
            {
                // İlk olarak kelimeNo'yu bulmak için sorgu yapıyoruz
                SqlCommand komut = new SqlCommand("SELECT kelimeNo FROM Kelimeler WHERE Ad = @Ad", connection);
                komut.Parameters.AddWithValue("@Ad", ezberlenen);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    kelimeNo = Convert.ToInt32(dr["kelimeNo"]);
                }
                else
                {
                    // Kelime bulunamadıysa işlemi sonlandır
                    dr.Close();
                    throw new InvalidOperationException("Kelime bulunamadı.");
                }
                dr.Close();

                // EzberSeviye'yi güncelle
                SqlCommand command = new SqlCommand("UPDATE istatistikler SET EzberSeviye = EzberSeviye + 1 WHERE kelimeNo = @kelimeNo AND kullaniciNo = @kullaniciNo", connection);
                command.Parameters.AddWithValue("@kelimeNo", kelimeNo);
                command.Parameters.AddWithValue("@kullaniciNo", KullaniciNo); // Burada @kullaniciNo parametresini ekledik
                command.ExecuteNonQuery();

                int durumOnceki = DurumGetir(KullaniciNo, kelimeNo);

                // EzberDurum'u güncelle sadece ilgili kelime için
                SqlCommand command2 = new SqlCommand("UPDATE istatistikler SET EzberDurum = 1 WHERE kelimeNo = @kelimeNo AND EzberSeviye >= 5", connection);
                command2.Parameters.AddWithValue("@kelimeNo", kelimeNo);
                command2.ExecuteNonQuery();

                int durumSonraki = DurumGetir(KullaniciNo, kelimeNo);

                // Eğer durum değişmişse, EzberTarihi'ni güncelle
                if (durumOnceki != durumSonraki)
                {
                    SqlCommand commandDurum = new SqlCommand("UPDATE istatistikler SET EzberTarihi = GETDATE() WHERE kelimeNo = @kelimeNo AND kullaniciNo = @kullaniciNo", connection);
                    commandDurum.Parameters.AddWithValue("@kelimeNo", kelimeNo);
                    commandDurum.Parameters.AddWithValue("@kullaniciNo", KullaniciNo);
                    commandDurum.ExecuteNonQuery();
                }

                // Hatırlatma ayarlarını yap
                HatirlaticiAyari(KullaniciNo, ezberlenen);
            }
        }



        public int DurumGetir(int KullaniciNo, int ezber)
        {
            int durum;
            SqlCommand command = new SqlCommand("select EzberDurum from istatistikler where kelimeNo = @kelimeNo AND kullaniciNo = @kullaniciNo", Baglanti());
            command.Parameters.AddWithValue("@kelimeNo", ezber);
            command.Parameters.AddWithValue("@kullaniciNo", KullaniciNo); // Burada da @kullaniciNo parametresini ekledik
            durum = Convert.ToInt32(command.ExecuteScalar());
            return durum;
        }

        public void yenileme(DataGridView dataGridView)
        {

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Kelimeler", Baglanti()))
            {
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }

        }
    }
}