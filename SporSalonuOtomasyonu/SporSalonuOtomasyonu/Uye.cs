using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace SporSalonuOtomasyonu
{
    public partial class Uye : Form
    {
        
        public Uye()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = dbKullaniciLogin; Integrated Security = True");

        private void Uye_Load(object sender, EventArgs e)
        {

        }

        private void bttn_kapat_Click(object sender, EventArgs e)
        {
           
            
                Anasayfa f1 = new Anasayfa();
                f1.Show();
                this.Hide();
            
        }

        private void bttn_kaydet_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO UyeEkle (ad,soyad,telNo,bas_Tarih,bit_Tarih,cinsiyet,boy,kilo,omuz,gögüs,kol,bel,kalca,baldir)" +
                "VALUES(@ad,@soyad,@telNo,@bas_Tarih,@bit_Tarih,@cinsiyet,@boy,@kilo,@omuz,@gögüs,@kol,@bel,@kalca,@baldir)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ad", txtad.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            komut.Parameters.AddWithValue("@telNo", txtno.Text);
            komut.Parameters.AddWithValue("@bas_Tarih", txtgiris.MinDate);
            komut.Parameters.AddWithValue("@bit_Tarih", txtbitis.MaxDate);
            komut.Parameters.AddWithValue("@cinsiyet", txtcins.Text);
            komut.Parameters.AddWithValue("@boy", txtboyu.Text);
            komut.Parameters.AddWithValue("@kilo", txtkilo.Text);
            komut.Parameters.AddWithValue("@omuz", txtomuz.Text);
            komut.Parameters.AddWithValue("@gögüs", txtgogus.Text);
            komut.Parameters.AddWithValue("@kol", txtkol.Text);
            komut.Parameters.AddWithValue("@bel", txtbel.Text);
            komut.Parameters.AddWithValue("@kalca", txtkalca.Text);
            komut.Parameters.AddWithValue("@baldir", txtkalca.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt İşlemi Tamamlandı!", "Bilgilendirme Penceresi");

            Anasayfa f1 = new Anasayfa();
            f1.Show();
            this.Hide();


            /*string ad = txtad.Text;
        string soyad = txtsoyad.Text;
        string telNo = txtno.Text;
        string bas_Tarih = txtgiris.Text;
        string bit_Tarih = txtgiris.Text;
        string cinsiyet = txtcins.Text;
        string boy = txtboyu.Text;
        string kilo = txtkilo.Text;
        string omuz = txtomuz.Text;
        string gogus = txtgogus.Text;
        string kol = txtkol.Text;
        string bel = txtbel.Text;
        string kalca = txtkalca.Text;
        string baldir =  txtkalca.Text;*/


        }
    }
}
