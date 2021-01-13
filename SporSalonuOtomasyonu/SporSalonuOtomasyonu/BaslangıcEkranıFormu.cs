using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuOtomasyonu
{
    public partial class BaslangıcEkranıFormu : Form
    {
        public BaslangıcEkranıFormu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
            if(progressBar1.Value > 99)
            {
                KullaniciGiris f1 = new KullaniciGiris();
                f1.Show();
                this.Hide();
                timer1.Enabled = false;
            }
        }
    }
}
