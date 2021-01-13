using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SporSalonuOtomasyonu
{
    public partial class UyeListele : Form
    {
        public UyeListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = dbKullaniciLogin; Integrated Security = True");

        private void UyeListele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbKullaniciLoginDataSet1.UyeEkle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.uyeEkleTableAdapter1.Fill(this.dbKullaniciLoginDataSet1.UyeEkle);
            // TODO: Bu kod satırı 'dbKullaniciLoginDataSet.UyeEkle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.uyeEkleTableAdapter.Fill(this.dbKullaniciLoginDataSet.UyeEkle);
            /* SqlCommand komut = new SqlCommand();
             komut.CommandText = "SELECET * FROM UyeEkle";
             komut.Connection = baglanti;
             SqlDataAdapter adap = new SqlDataAdapter(komut);
             DataTable tablo = new DataTable();
             adap.Fill(tablo);   
             dataGridView1.DataSource = tablo;*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECET * FROM UyeEkle";
            komut.Connection = baglanti;
            SqlDataAdapter dd = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            dd.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Anasayfa f1 = new Anasayfa();
            f1.Show();
            this.Hide();
        }
    }
}
