using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kullanicigiris;
using SpeechLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace kullanicigiriş
{
    public partial class sinav : Form
    {
        bool calismaDurumu = false;
        public sinav()
        {
            InitializeComponent();
        }
        private void btnOku_Click(object sender, EventArgs e)
        {
            SpVoice ses = new SpVoice();
            ses.Speak(label1.Text);
        }
        private void btnBasla_Click(object sender, EventArgs e)
        {
            islemler islem = new islemler();
            calismaDurumu = true;
            islem.RastgeleGetir(kullaniciNo, this.label1, this.pictureBox1);
            btnBasla.Enabled = false;
        }
        private void btnBitir_Click(object sender, EventArgs e)
        {
            if (calismaDurumu == false)
            {
                MessageBox.Show("Önce Çalışmayı Başlatmalısın.");
            }
            else
            {
                MessageBox.Show("Seni Bekliyoruz. Çok Ara Verme.");
                calismaDurumu = false;
                label1.Refresh();
                txtTr.Clear();
                this.Close();
            }
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            if (calismaDurumu == false)
            {
                MessageBox.Show("Önce Çalışmaya Başlamalısın.");
            }
            else
            {
                islem.RastgeleGetir(kullaniciNo, this.label1, this.pictureBox1);
            }
        }
        private islemler islem = new islemler();
        private void btnKontrol_Click(object sender, EventArgs e)
        {

            if (calismaDurumu == false)
            {
                MessageBox.Show("Önce Çalışmayı Başlatmalısın.");
                return;
            }

            bool durum = islem.Dogrula(label1.Text.Trim().ToString(), txtTr.Text.Trim().ToString());

            if (durum)
            {
                islem.DurumGuncelle(kullaniciNo, label1.Text.ToString());
                MessageBox.Show("Tebrikler! Devam Et.");
                txtTr.Clear();
                islem.RastgeleGetir(kullaniciNo, label1, pictureBox1);
            }
            else
            {
                MessageBox.Show("Tekrar Denemelisin. İyi Düşün.");
            }
        }
        public string username;
        public int kullaniciNo;
        islemler bgl = new islemler();
        private void sinav_Load_1(object sender, EventArgs e)
        {
            lblKullaniciAdi.Text = username;
            SqlCommand komut = new SqlCommand("SELECT kullaniciNo FROM kullaniciTablo WHERE kullaniciAdi = ('" + username + "')", bgl.Baglanti());
            kullaniciNo = Convert.ToInt32(komut.ExecuteScalar());
            lblKullaniciNo.Text = Convert.ToString(kullaniciNo);
        }
    }
}