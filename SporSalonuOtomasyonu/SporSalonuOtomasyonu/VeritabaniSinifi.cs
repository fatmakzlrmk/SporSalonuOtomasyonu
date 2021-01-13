using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace SporSalonuOtomasyonu
{
    class VeritabaniSinifi
    {
        SqlConnection Connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog=dbKullaniciLogin; Integrated Security =True");
        SqlCommand command;
        SqlDataReader reader;

        public void girisYap(string name, string password, Form frm1)
        {
            command = new SqlCommand("Select * From tblKullanici where name ='"+name+"' and password = '"+password+"'", Connection);
            Connection.Open();
            reader = command.ExecuteReader();
            if(reader.Read())
            {
                KullaniciGiris.gnderilecekAdminAd = reader["ad"].ToString();
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                
            }
            else
            {
                MessageBox.Show("Hatali Giris", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Connection.Close();
            command.Dispose();

        }
       
    }
}
