using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kullanicigiriş
{
    public partial class kullaniciBilgisi : Form
    {
        public kullaniciBilgisi()
        {
            InitializeComponent();
        }

        private void kullaniciBilgisi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kullanicilarDataSet3.bilinenTablo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bilinenTabloTableAdapter.Fill(this.kullanicilarDataSet3.bilinenTablo);

        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            adminArayuz a = new adminArayuz();
            a.FormClosed += (s, args) => this.Close();
            a.Show();
            this.Hide();
        }
    }
}
