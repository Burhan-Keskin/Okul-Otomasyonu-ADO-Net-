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
    public partial class Adres : Form
    {
        public Adres()
        {
            InitializeComponent();
        }
        string BaglantiCumlesii = "Data Source=DESKTOP-ICU6LR7;Initial Catalog=okull;Integrated Security=True";
     

        private void Adres_Load(object sender, EventArgs e)
        {
            string komutcumlesii = "select * from adres";
            using (SqlConnection baglanti = new SqlConnection())
            {
                baglanti.ConnectionString = BaglantiCumlesii;
                using (SqlCommand listelemekomutu = new SqlCommand(komutcumlesii, baglanti))
                {
                    baglanti.Open();

                    using (DataTable datatable = new DataTable())
                    {
                        datatable.Columns.Add("ID");
                        datatable.Columns.Add("Adres BAşlığı");
                        datatable.Columns.Add("Adres Bilgisi");
                        using (SqlDataReader okuyucu = listelemekomutu.ExecuteReader())
                        {
                            while (okuyucu.Read())
                            {
                                DataRow row = datatable.NewRow();
                                row["ID"] = okuyucu["id"];
                                row["Adres BAşlığı"] = okuyucu["AdresBaslıgı"];
                                row["Adres Bilgisi"] = okuyucu["Bilgisi"];

                                datatable.Rows.Add(row);


                            }
                        }
                        dataGridView2.DataSource = datatable;
                    }
                }
                baglanti.Close();
                if (baglanti.State == System.Data.ConnectionState.Closed)
                {
                    toolStripStatusLabel1.Text = "Kapalı";
                }
                else
                {
                    toolStripStatusLabel1.Text = "Açık";

                }
                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[1].Width = 250;
                dataGridView2.Columns[2].Width = 250;

            }
        }

        private void AEklebtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection())
            {
                baglanti.ConnectionString = BaglantiCumlesii;
                baglanti.Open();
                using (SqlCommand eklekomut = new SqlCommand())
                {
                    eklekomut.Connection = baglanti;
                    eklekomut.CommandType = CommandType.Text;
                    eklekomut.CommandText = "Insert into adres(AdresBaslıgı,Bilgisi) values (@ABaslıgı,@Bilgisi)";
                    eklekomut.Parameters.AddWithValue("@ABaslıgı", AdresBtxt.Text);
                    eklekomut.Parameters.AddWithValue("@Bilgisi", AdresBiltxt.Text);

                    //eklekomut.ExecuteNonQuery();
                    if (eklekomut.ExecuteNonQuery() == 1)
                        MessageBox.Show("Kayıt eklendi");
                    else
                        MessageBox.Show("Kayıt eklenmedi");


                }
                baglanti.Close();



            }
            Adres_Load(this, null);
        }

        private void AArabtn_Click(object sender, EventArgs e)
        {
            if (ıdtxt.Text == "")
            {
                MessageBox.Show("Lütfen aranacak veriyi giriniz");
                return;
            }
            string sorgu = "select * from adres where id = " + ıdtxt.Text;
            using (SqlConnection baglanti = new SqlConnection())
            {
                baglanti.ConnectionString = BaglantiCumlesii;
                using (SqlDataAdapter adapter = new SqlDataAdapter(sorgu, baglanti))
                {
                    using (DataSet ds = new DataSet())
                    {
                        adapter.Fill(ds, "adres");
                        dataGridView2.DataSource = ds.Tables["adres"];
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AdresBtxt.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            AdresBiltxt.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            ıdtxt.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }
        void temizle()
        {
            AdresBtxt.Clear();
            AdresBiltxt.Clear();
            ıdtxt.Clear();


        }

        private void ATumLbtn_Click(object sender, EventArgs e)
        {
            Adres_Load(this, null);
            temizle();
        }

        private void AGuncellebtn_Click(object sender, EventArgs e)
        {
            if (ıdtxt.Text == "")
            {
                MessageBox.Show("Lütfen aranacak veriyi giriniz");
                return;
            }
            using (SqlConnection baglanti = new SqlConnection())
            {
                baglanti.ConnectionString = BaglantiCumlesii;
                baglanti.Open();
                using (SqlCommand guncellekomut = new SqlCommand())
                {
                    guncellekomut.Connection = baglanti;
                    guncellekomut.CommandType = CommandType.Text;
                    guncellekomut.CommandText = "Update adres set AdresBaslıgı " +
                        "=(@ABaslıgı,Bilgisi =@Bilgisi where id = @id";
                    guncellekomut.Parameters.AddWithValue("@Adi", AdresBtxt.Text);
                    guncellekomut.Parameters.AddWithValue("@Soyadi", AdresBiltxt.Text);
                    guncellekomut.Parameters.AddWithValue("@id", ıdtxt.Text);
                    //guncellekomut.ExecuteNonQuery();


                    if (guncellekomut.ExecuteNonQuery() == 1)
                        MessageBox.Show("Kayıt Güncellendi");
                    else
                        MessageBox.Show("Kayıt Güncellenmedi");

                }
                baglanti.Close();
            }
            Adres_Load(this, null);
        }

        private void ASilbtn_Click(object sender, EventArgs e)
        {
            if (ıdtxt.Text == "")
            {
                MessageBox.Show("Lütfen aranacak veriyi giriniz");
                return;
                using (SqlConnection baglanti = new SqlConnection())
                {
                    baglanti.ConnectionString = BaglantiCumlesii;
                    baglanti.Open();
                    using (SqlCommand silkomut = new SqlCommand())
                    {
                        silkomut.Connection = baglanti;
                        silkomut.CommandType = CommandType.Text;
                        silkomut.CommandText = "Delete adres  where id = @id";
                        silkomut.Parameters.AddWithValue("@id", ıdtxt.Text);
                        if (silkomut.ExecuteNonQuery() == 1)
                            MessageBox.Show("Kayıt silindi");
                        else
                            MessageBox.Show("Kayıt silinmedi");

                    }
                    baglanti.Close();
                }
                Adres_Load(this, null);
                temizle();
            }
        }
    }
}
