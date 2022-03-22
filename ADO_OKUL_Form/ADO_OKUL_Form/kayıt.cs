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

namespace ADO_OKUL_Form
{
    public partial class kayıt : Form
    {
        public kayıt()
        {
            InitializeComponent();
        }
        string BaglantiCumlesi = "Data Source=DESKTOP-ICU6LR7;Initial Catalog = okull; Integrated Security = True";

        SqlDataReader bb;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Gıdtxt.Text == "")
            {
                MessageBox.Show("Lütfen aranacak veriyi giriniz");
                return;
            }
            //string sorgu = "select * from Personel where id = " + Gıdtxt.Text;
            //  string sorguadı = "select * from Personel where Adi = " + KulAdıtxt.Text;
            using (SqlConnection baglanti = new SqlConnection())
            {
                baglanti.ConnectionString = BaglantiCumlesi;

                baglanti.Open();
                using (SqlCommand eklekomut = new SqlCommand())
                {
                    eklekomut.Connection = baglanti;
                    eklekomut.CommandType = CommandType.Text;
                    eklekomut.CommandText = "select * from Personel where id = @id AND Adi =@Adi";
                    eklekomut.Parameters.AddWithValue  ("@id", Gıdtxt.Text);
                    eklekomut.Parameters.AddWithValue  ("@Adi", KulAdıtxt.Text);


                    bb = eklekomut.ExecuteReader();

                  
                        if (bb.Read())
                        {

                            Menu giriss = new Menu();
                            giriss.Show();

                        }
                        else
                        {
                            MessageBox.Show("Bilgileri Kontrol Edin");
                        }
                           
                        
                    
                    //eklekomut.ExecuteNonQuery();
                    


                }
                baglanti.Close();


                  


            }














        }
    }
}
