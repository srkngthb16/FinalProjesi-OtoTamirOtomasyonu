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

namespace OtoTamirPro
{
    public partial class arac : Form
    {
        public arac()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-VNCQEJA;Initial Catalog=OtoTamirPro;Integrated Security=True;");

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sqlkomut = "INSERT INTO arac (sasi_no, plaka, marka, model, yıl, renk) VALUES (@sasi_no, @plaka, @marka, @model, @yıl, @renk)";
                SqlCommand komut = new SqlCommand(sqlkomut, baglan);

                komut.Parameters.AddWithValue("@sasi_no", textBox1.Text);
                komut.Parameters.AddWithValue("@plaka", textBox2.Text);
                komut.Parameters.AddWithValue("@marka", textBox8.Text);
                komut.Parameters.AddWithValue("@model", textBox6.Text);
                komut.Parameters.AddWithValue("@yıl", textBox5.Text);
                komut.Parameters.AddWithValue("@renk", textBox7.Text);

                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("arac Ekleme İşlemi Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void musteri_Load(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sqlkomut = "SELECT * FROM arac";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlkomut, baglan);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                baglan.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sqlkomut = "SELECT * FROM arac WHERE arac_no=@id";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlkomut, baglan);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@id", textBox3.Text);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    textBox1.Text = dataTable.Rows[0]["sasi_no"].ToString();
                    textBox2.Text = dataTable.Rows[0]["plaka"].ToString();
                    textBox8.Text = dataTable.Rows[0]["marka"].ToString();
                    textBox6.Text = dataTable.Rows[0]["model"].ToString();
                    textBox5.Text = dataTable.Rows[0]["yıl"].ToString();
                    textBox7.Text = dataTable.Rows[0]["renk"].ToString();
                }
                else
                {
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    textBox8.Text = string.Empty;
                    textBox6.Text = string.Empty;
                    textBox5.Text = string.Empty;
                    textBox7.Text = string.Empty;
                    MessageBox.Show("Veri bulunamadı.");
                }
                baglan.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string yenisasi_no = textBox1.Text;
                string yeniplaka2 = textBox2.Text;
                string yenimarka = textBox8.Text;
                string yenimodel = textBox6.Text;
                string yeniyıl = textBox5.Text;
                string yenirenk = textBox7.Text;
                int id;

                if (int.TryParse(textBox3.Text, out id))
                {
                    baglan.Open();
                    string sqlkomut = "UPDATE arac SET sasi_no=@yenisasi_no, plaka=@yeniplaka, marka=@yenimarka, model=@yenimodel, yıl=@yeniyıl, renk=@yenirenk WHERE arac_no=@id";
                    SqlCommand komut = new SqlCommand(sqlkomut, baglan);

                    komut.Parameters.AddWithValue("@yenisasi_no", yenisasi_no);
                    komut.Parameters.AddWithValue("@yeniplaka", yeniplaka2);
                    komut.Parameters.AddWithValue("@yenimarka", yenimarka);
                    komut.Parameters.AddWithValue("@yenimodel", yenimodel);
                    komut.Parameters.AddWithValue("@yeniyıl", yeniyıl);
                    komut.Parameters.AddWithValue("@yenirenk", yenirenk);
                    komut.Parameters.AddWithValue("@id", id);

                    komut.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("Güncelleme Gerçekleşti");
                }
                else
                {
                    MessageBox.Show("Geçersiz Kimlik değeri.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlkomut = "DELETE FROM arac WHERE arac" +
                    "" +
                    "No=@id";
                int id;

                if (int.TryParse(textBox3.Text, out id))
                {
                    baglan.Open();
                    SqlCommand komut = new SqlCommand(sqlkomut, baglan);
                    komut.Parameters.AddWithValue("@id", id);
                    komut.ExecuteNonQuery();
                    baglan.Close();

                    MessageBox.Show("Veri silindi.");
                }
                else
                {
                    MessageBox.Show("Geçersiz Kimlik değeri.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arac_bakim arac_Bakim = new arac_bakim();
            arac_Bakim.Show();
            this.Hide();
        }
    }
}
