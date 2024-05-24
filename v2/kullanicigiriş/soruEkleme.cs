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
using kullanicigiris;

namespace kullanicigiriş
{
    public partial class soruEkleme : Form
    {

        public soruEkleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SBIVES4;Initial Catalog=kullanicilar;Integrated Security=True;");
        private void gozatBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            TxtResim.Text = openFileDialog1.FileName;
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand($"insert into sorularTablo (soru,cevap,resim) values (@p1 ,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtSoru.Text);
            komut.Parameters.AddWithValue("@p2", TxtCevap.Text);
            komut.Parameters.AddWithValue("@p3", TxtResim.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Soru Eklendi");
        }

        private void soruEkleme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kullanicilarDataSet2.sorularTablo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sorularTabloTableAdapter2.Fill(this.kullanicilarDataSet2.sorularTablo);
            // TODO: Bu kod satırı 'kullanicilarDataSet1.sorularTablo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sorularTabloTableAdapter1.Fill(this.kullanicilarDataSet1.sorularTablo);
            // TODO: Bu kod satırı 'kullanicilarDataSet.sorularTablo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sorularTabloTableAdapter.Fill(this.kullanicilarDataSet.sorularTablo);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtSoruNo.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtSoru.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtCevap.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtResim.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void gBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand($"update sorularTablo set soru = @p1, cevap = @p2, resim = @p3 where soruNo = @soruNo", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtSoru.Text);
            komut.Parameters.AddWithValue("@p2", TxtCevap.Text);
            komut.Parameters.AddWithValue("@p3", TxtResim.Text);
            // Güncelleme işlemi için soruNo'yu parametre olarak ekleyin
            komut.Parameters.AddWithValue("@soruNo", TxtSoruNo.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Soru Güncellendi");
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            if (kullaniciGiris.KullaniciBilgileri.Yetki == "Admin")
            {
                adminArayuz adminForm = new adminArayuz();
                adminForm.FormClosed += (s, args) => this.Close();
                adminForm.Show();
            }
            else
            {
                kullaniciArayuz kullaniciForm = new kullaniciArayuz();
                kullaniciForm.FormClosed += (s, args) => this.Close();
                kullaniciForm.Show();
            }

            this.Hide();
        }
    }
}
