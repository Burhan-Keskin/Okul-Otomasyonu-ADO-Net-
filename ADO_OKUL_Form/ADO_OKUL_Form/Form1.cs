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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string BaglantiCumlesi = "Data Source=DESKTOP-ICU6LR7;Initial Catalog = okull; Integrated Security = True";

        private void Form1_Load(object sender, EventArgs e)
        {
            string komutcumlesi = "select * from Ogrenci";

            using (SqlConnection baglanti = new SqlConnection())

            {
                baglanti.ConnectionString = BaglantiCumlesi;
                using (SqlCommand listelemekomutu = new SqlCommand(komutcumlesi,baglanti))
                {
                    baglanti.Open();
                    using (DataTable datatable = new DataTable())
                    {
                        datatable.Columns.Add("OgrenciID"); 
                        datatable.Columns.Add("Adi");
                        datatable.Columns.Add("Soyadi");
                        using (SqlDataReader okuyucu = listelemekomutu.ExecuteReader())
                        {
                            while (okuyucu.Read())
                            {
                                DataRow row = datatable.NewRow();
                                row["OgrenciID"] = okuyucu["id"];
                                row["Adi"] = okuyucu["Adi"];
                                row["Soyadi"] = okuyucu["Soyadi"];
                                
                                datatable.Rows.Add(row);


                            }

                        }
                        dataGridView1.DataSource = datatable;
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
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Width = 250;
                dataGridView1.Columns[2].Width = 250;
            
            }
        }

        private void Eklebtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection())
            {
                baglanti.ConnectionString = BaglantiCumlesi;
                baglanti.Open();
                using (SqlCommand eklekomut = new SqlCommand())
                {
                    eklekomut.Connection = baglanti;
                    eklekomut.CommandType = CommandType.Text;
                    eklekomut.CommandText = "Insert into Ogrenci(Adi,Soyadi) values (@Adi,@Soyadi)";
                    eklekomut.Parameters.AddWithValue("@Adi",Adıtxt.Text);
                    eklekomut.Parameters.AddWithValue("@Soyadi", soyadıtxt.Text);

                    //eklekomut.ExecuteNonQuery();
                    if (eklekomut.ExecuteNonQuery() == 1)
                        MessageBox.Show("Kayıt eklendi");
                    else
                        MessageBox.Show("Kayıt eklenmedi");


                }
                baglanti.Close();



            }
            Form1_Load(this, null);
        }

        private void Arabtn_Click(object sender, EventArgs e)
        {
            if (Idtxt.Text=="")
            {
                MessageBox.Show("Lütfen aranacak veriyi giriniz");
                return;
            }
            string sorgu = "select * from Ogrenci where id = " + Idtxt.Text;
            using (SqlConnection baglanti = new SqlConnection())
            {
                baglanti.ConnectionString = BaglantiCumlesi;
                using (SqlDataAdapter adapter = new SqlDataAdapter(sorgu,baglanti))
                {
                    using (DataSet ds = new DataSet())
                    {
                        adapter.Fill(ds, "Ogrenci");
                        dataGridView1.DataSource = ds.Tables["Ogrenci"];
                    }
                }
            }
                
                    
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Adıtxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            soyadıtxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Idtxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
        void temizle()
        {
            Adıtxt.Clear();
            soyadıtxt.Clear();
            Idtxt.Clear();


        }

        private void TumLbtn_Click(object sender, EventArgs e)
        {
            Form1_Load(this, null);
            temizle();
        }

        private void Guncellebtn_Click(object sender, EventArgs e)
        {
            if (Idtxt.Text == "")
            {
                MessageBox.Show("Lütfen aranacak veriyi giriniz");
                return;
            }
            using (SqlConnection baglanti = new SqlConnection())
            {
                baglanti.ConnectionString = BaglantiCumlesi;
                baglanti.Open();
                using (SqlCommand guncellekomut = new SqlCommand())
                {
                    guncellekomut.Connection = baglanti;
                    guncellekomut.CommandType = CommandType.Text;
                    guncellekomut.CommandText = "Update Ogrenci set Soyadi " +
                        "= @Soyadi,Adi =@Adi where id = @id";
                    guncellekomut.Parameters.AddWithValue("@Adi", Adıtxt.Text);
                    guncellekomut.Parameters.AddWithValue("@Soyadi", soyadıtxt.Text);
                    guncellekomut.Parameters.AddWithValue("@id", Idtxt.Text);
                    //guncellekomut.ExecuteNonQuery();


                    if (guncellekomut.ExecuteNonQuery() == 1)
                        MessageBox.Show("Kayıt Güncellendi");
                    else
                        MessageBox.Show("Kayıt Güncellenmedi");

                }
                baglanti.Close();
            }
            Form1_Load(this, null);
        }

        private void Silbtn_Click(object sender, EventArgs e)
        {
            if (Idtxt.Text == "")
            {
                MessageBox.Show("Lütfen aranacak veriyi giriniz");
                return;
                using (SqlConnection baglanti = new SqlConnection())
                {
                    baglanti.ConnectionString = BaglantiCumlesi;
                    baglanti.Open();
                    using (SqlCommand silkomut = new SqlCommand())
                    {
                        silkomut.Connection = baglanti;
                        silkomut.CommandType = CommandType.Text;
                        silkomut.CommandText = "Delete Ogrenci  where id = @id";                       
                        silkomut.Parameters.AddWithValue("@id", Idtxt.Text);
                        if (silkomut.ExecuteNonQuery() == 1)
                            MessageBox.Show("Kayıt silindi");
                        else
                            MessageBox.Show("Kayıt silinmedi");

                    }
                    baglanti.Close();
                }
                Form1_Load(this, null);
                temizle();
            }
            
        }
    }
}
