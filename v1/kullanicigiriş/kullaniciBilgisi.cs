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

        private void geriButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kullaniciBilgisi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kullanicilarDataSet12.istatistikler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.istatistiklerTableAdapter.Fill(this.kullanicilarDataSet12.istatistikler);

        }
    }
}
