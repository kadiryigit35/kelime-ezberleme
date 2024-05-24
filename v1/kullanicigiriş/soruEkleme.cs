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

        private DataTable dtUsers;
        public soruEkleme()
        {
            InitializeComponent();
        }
        islemler bgl = new islemler();
        private void gozatBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtResim.Text = openFileDialog1.FileName;
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand($"insert into Kelimeler (Ad, Anlam, Resim) values (@p1, @p2, @p3); SELECT SCOPE_IDENTITY()", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtSoru.Text);
            komut.Parameters.AddWithValue("@p2", txtCevap.Text);
            komut.Parameters.AddWithValue("@p3", txtResim.Text);
            int kelimeNo = Convert.ToInt32(komut.ExecuteScalar());

            MessageBox.Show("Soru Eklendi");
            txtSoru.Clear();
            txtCevap.Clear();
            txtResim.Clear();

            // Kullanıcıların istatistikler tablosuna ekleme işlemi
            foreach (DataRow row in dtUsers.Rows)
            {
                int kullaniciNo = Convert.ToInt32(row["kullaniciNo"]);
                string kullaniciYetki = row["kullaniciYetki"].ToString();
                if (kullaniciYetki == "Kullanıcı")
                {
                    using (SqlCommand insertCommand = new SqlCommand("INSERT INTO istatistikler (kelimeNo, kullaniciNo) VALUES (@kelimeNo, @kullaniciNo)", bgl.Baglanti()))
                    {
                        insertCommand.Parameters.AddWithValue("@kelimeNo", kelimeNo);
                        insertCommand.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
                        insertCommand.ExecuteNonQuery();
                    }
                }
            }
            bgl.yenileme(dataGridView1);
        }


        private void soruEkleme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kullanicilarDataSet11.Kelimeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kelimelerTableAdapter4.Fill(this.kullanicilarDataSet11.Kelimeler);
            // TODO: Bu kod satırı 'kullanicilarDataSet10.Kelimeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kelimelerTableAdapter3.Fill(this.kullanicilarDataSet10.Kelimeler);
            // this.kelimelerTableAdapter3.Fill(this.kullanicilarDataSet11.Kelimeler);

            string kullaniciSorgusu = "SELECT * FROM kullaniciTablo";

            using (SqlCommand kmt = new SqlCommand(kullaniciSorgusu, bgl.Baglanti()))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(kmt))
                {
                    dtUsers = new DataTable();
                    adapter.Fill(dtUsers);
                }
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtSoruNo.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtSoru.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtCevap.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtResim.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void gBtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand($"update Kelimeler set Ad = @p1, Anlam = @p2, Resim = @p3 where kelimeNo = @soruNo", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtSoru.Text);
            komut.Parameters.AddWithValue("@p2", txtCevap.Text);
            komut.Parameters.AddWithValue("@p3", txtResim.Text);
            komut.Parameters.AddWithValue("@soruNo", txtSoruNo.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Soru Güncellendi");
            txtSoru.Clear();
            txtCevap.Clear();
            bgl.yenileme(dataGridView1);
        }
        private void geriButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
