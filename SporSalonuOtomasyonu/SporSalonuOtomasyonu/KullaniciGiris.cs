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
    public partial class KullaniciGiris : Form
    {
        
        public KullaniciGiris()
        {
            InitializeComponent();
        }
        public static string gnderilecekAdminAd;
        private void KullaniciGiris_Load(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            VeritabaniSinifi islem = new VeritabaniSinifi();
            islem.girisYap(user, pass, this);
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
