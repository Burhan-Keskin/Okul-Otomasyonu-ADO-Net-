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
    public partial class KayıtOl : Form
    {
        public KayıtOl()
        {
            InitializeComponent();
        }
       // string BaglantiCumlesi = "Data Source=DESKTOP-ICU6LR7;Initial Catalog = okull; Integrated Security = True";

        //private void KayıtOl_Load(object sender, EventArgs e)
        //{
        //    using (SqlConnection baglanti = new SqlConnection())
        //    {
        //        baglanti.ConnectionString = BaglantiCumlesi;
        //        baglanti.Open();

        //        baglanti.ConnectionString = BaglantiCumlesi;
        //        baglanti.Open();
        //        using (SqlCommand eklekomut = new SqlCommand())
        //        {
        //            eklekomut.Connection = baglanti;
        //            eklekomut.CommandType = CommandType.Text;
        //            eklekomut.CommandText = "Insert into KullanıcıGiriş([Kullanıcı Adı],[Kullanıcı Şifre]) values (@KulAdi,@KulSifre)";
        //            eklekomut.Parameters.AddWithValue("@KulAdi", KayıtAdıtxt.Text);
        //            eklekomut.Parameters.AddWithValue("@KulSifre", KayıtSifretxt.Text);

        //            //eklekomut.ExecuteNonQuery();
        //            if (eklekomut.ExecuteNonQuery() == 1)
        //                MessageBox.Show("Kullanıcı Eklendi");
        //            else
        //                MessageBox.Show("Kullanıcı Eklenmedi");


        //        }
        //        baglanti.Close();
        //    }
        //}

        private void KayıtOlbtn_Click(object sender, EventArgs e)
        {

        }

        
    }
}
