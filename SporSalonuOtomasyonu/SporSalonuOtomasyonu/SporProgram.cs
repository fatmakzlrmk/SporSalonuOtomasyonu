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
    public partial class SporProgram : Form
    {
        public SporProgram()
        {
            InitializeComponent();
        }

        private void SporProgram_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa f1 = new Anasayfa();
            f1.Show();
            this.Hide();
        }
    }
}
