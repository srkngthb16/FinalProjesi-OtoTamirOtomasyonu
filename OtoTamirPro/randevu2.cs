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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Common;

namespace OtoTamirPro
{
    public partial class randevu2 : Form
    {
        public randevu2()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-VNCQEJA;Initial Catalog=OtoTamirPro;Integrated Security=True");
        private void randevu2_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter verigetir = new SqlDataAdapter("select * from randevu2", baglan);
            DataTable dataTable = new DataTable();
            verigetir.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglan.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sqlkomut = "INSERT INTO randevu2 (r_ad, r_soyad, r_tel, r_tarih, r_saat, r_mesaj) VALUES (@r_ad, @r_soyad, @r_tel, @r_tarih, @r_saat, @r_mesaj)";
                SqlCommand komut = new SqlCommand(sqlkomut, baglan);

                komut.Parameters.AddWithValue("@r_ad", textBox1.Text);
                komut.Parameters.AddWithValue("@r_soyad", textBox2.Text);
                komut.Parameters.AddWithValue("@r_tel", textBox8.Text);
                komut.Parameters.AddWithValue("@r_tarih", textBox4.Text);
                komut.Parameters.AddWithValue("@r_saat", textBox5.Text);
                komut.Parameters.AddWithValue("@r_mesaj", textBox7.Text);

                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Müşteri Ekleme İşlemi Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sqlkomut = "INSERT INTO randevu2 (r_ad, r_soyad, r_tel, r_tarih, r_saat, r_mesaj) VALUES (@r_ad, @r_soyad, @r_tel, @r_tarih, @r_saat, @r_mesaj)";
                SqlCommand komut = new SqlCommand(sqlkomut, baglan);

                komut.Parameters.AddWithValue("@r_ad", textBox1.Text);
                komut.Parameters.AddWithValue("@r_soyad", textBox2.Text);
                komut.Parameters.AddWithValue("@r_tel", textBox8.Text);
                komut.Parameters.AddWithValue("@r_tarih", textBox4.Text);
                komut.Parameters.AddWithValue("@r_saat", textBox5.Text);
                komut.Parameters.AddWithValue("@r_mesaj", textBox7.Text);

                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Müşteri Ekleme İşlemi Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            randevu randevu = new randevu();
            randevu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            randevu randevu = new randevu();
            randevu.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            arac_bakim arac_Bakim = new arac_bakim();
            arac_Bakim.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            arac_bakim arac_Bakim = new arac_bakim();
            arac_Bakim.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            stok stok = new stok();
            stok.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            stok stok = new stok();
            stok.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sqlkomut = "SELECT * FROM randevu2 WHERE r_id=@id";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlkomut, baglan);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@id", textBox3.Text);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    textBox1.Text = dataTable.Rows[0]["r_ad"].ToString();
                    textBox2.Text = dataTable.Rows[0]["r_soyad"].ToString();
                    textBox8.Text = dataTable.Rows[0]["r_tel"].ToString();
                    textBox4.Text = dataTable.Rows[0]["r_tarih"].ToString();
                    textBox5.Text = dataTable.Rows[0]["r_saat"].ToString();
                    textBox7.Text = dataTable.Rows[0]["r_mesaj"].ToString();
                }
                else
                {
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    textBox8.Text = string.Empty;
                    textBox4.Text = string.Empty;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sqlkomut = "SELECT * FROM randevu2 WHERE r_id=@id";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlkomut, baglan);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@id", textBox3.Text);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    textBox1.Text = dataTable.Rows[0]["r_ad"].ToString();
                    textBox2.Text = dataTable.Rows[0]["r_soyad"].ToString();
                    textBox8.Text = dataTable.Rows[0]["r_tel"].ToString();
                    textBox4.Text = dataTable.Rows[0]["r_tarih"].ToString();
                    textBox5.Text = dataTable.Rows[0]["r_saat"].ToString();
                    textBox7.Text = dataTable.Rows[0]["r_mesaj"].ToString();
                }
                else
                {
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    textBox8.Text = string.Empty;
                    textBox4.Text = string.Empty;
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
                string y_ad = textBox1.Text;
                string y_soyad = textBox2.Text;
                string y_tel = textBox8.Text;
                string y_tarih = textBox4.Text;
                string y_saat = textBox5.Text;
                string y_mesaj = textBox7.Text;
                int id;

                if (int.TryParse(textBox3.Text, out id))
                {
                    baglan.Open();
                    string sqlkomut = "UPDATE randevu2 SET r_ad=@y_ad, r_soyad=@y_soyad, r_tel=@y_tel, r_tarih=@y_tarih, r_saat=@y_saat, r_mesaj=@y_mesaj WHERE r_id=@id";
                    SqlCommand komut = new SqlCommand(sqlkomut, baglan);

                    komut.Parameters.AddWithValue("@y_ad", y_ad);
                    komut.Parameters.AddWithValue("@y_soyad", y_soyad);
                    komut.Parameters.AddWithValue("@y_tel", y_tel);
                    komut.Parameters.AddWithValue("@y_tarih", y_tarih);
                    komut.Parameters.AddWithValue("@y_saat", y_saat);
                    komut.Parameters.AddWithValue("@y_mesaj", y_mesaj);
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

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            try
            {
                string y_ad = textBox1.Text;
                string y_soyad = textBox2.Text;
                string y_tel = textBox8.Text;
                string y_tarih = textBox4.Text;
                string y_saat = textBox5.Text;
                string y_mesaj = textBox7.Text;
                int id;

                if (int.TryParse(textBox3.Text, out id))
                {
                    baglan.Open();
                    string sqlkomut = "UPDATE randevu2 SET r_ad=@y_ad, r_soyad=@y_soyad, r_tel=@y_tel, r_tarih=@y_tarih, r_saat=@y_saat, r_mesaj=@y_mesaj WHERE r_id=@id";
                    SqlCommand komut = new SqlCommand(sqlkomut, baglan);

                    komut.Parameters.AddWithValue("@y_ad", y_ad);
                    komut.Parameters.AddWithValue("@y_soyad", y_soyad);
                    komut.Parameters.AddWithValue("@y_tel", y_tel);
                    komut.Parameters.AddWithValue("@y_tarih", y_tarih);
                    komut.Parameters.AddWithValue("@y_saat", y_saat);
                    komut.Parameters.AddWithValue("@y_mesaj", y_mesaj);
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
                string sqlkomut = "DELETE FROM randevu2 WHERE r_id=@id";
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

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlkomut = "DELETE FROM randevu2 WHERE r_id=@id";
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

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            fatura fatura = new fatura();
            fatura.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            fatura fatura = new fatura();
            fatura.Show();
        }
    }
}
