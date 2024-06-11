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
    public partial class musteri : Form

    {
        public musteri()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-VNCQEJA;Initial Catalog=OtoTamirPro;Integrated Security=True;");

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sqlkomut = "INSERT INTO Müşteri (isim, soyisim, email, telefonNo, evTelefonNo, Adres) VALUES (@isim, @soyisim, @email, @telefonNo, @evTelefonNo, @Adres)";
                SqlCommand komut = new SqlCommand(sqlkomut, baglan);

                komut.Parameters.AddWithValue("@isim", textBox1.Text);
                komut.Parameters.AddWithValue("@soyisim", textBox2.Text);
                komut.Parameters.AddWithValue("@email", textBox8.Text);
                komut.Parameters.AddWithValue("@telefonNo", textBox6.Text);
                komut.Parameters.AddWithValue("@evTelefonNo", textBox5.Text);
                komut.Parameters.AddWithValue("@Adres", textBox7.Text);

                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Müşteri Ekleme İşlemi Başarılı");
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
                string sqlkomut = "SELECT * FROM Müşteri";
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
                string sqlkomut = "SELECT * FROM Müşteri WHERE MüşteriNo=@id";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlkomut, baglan);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@id", textBox3.Text);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    textBox1.Text = dataTable.Rows[0]["isim"].ToString();
                    textBox2.Text = dataTable.Rows[0]["soyisim"].ToString();
                    textBox8.Text = dataTable.Rows[0]["email"].ToString();
                    textBox6.Text = dataTable.Rows[0]["telefonNo"].ToString();
                    textBox5.Text = dataTable.Rows[0]["evTelefonNo"].ToString();
                    textBox7.Text = dataTable.Rows[0]["Adres"].ToString();
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
                string yeniisim = textBox1.Text;
                string yenisoyisim2 = textBox2.Text;
                string yeniemail = textBox8.Text;
                string yenitelefonNo = textBox6.Text;
                string yenievTelefonNo = textBox5.Text;
                string yeniAdres = textBox7.Text;
                int id;

                if (int.TryParse(textBox3.Text, out id))
                {
                    baglan.Open();
                    string sqlkomut = "UPDATE Müşteri SET isim=@yeniisim, soyisim=@yenisoyisim, email=@yeniemail, telefonNo=@yenitelefonNo, evTelefonNo=@yenievTelefonNo, Adres=@yeniAdres WHERE MüşteriNo=@id";
                    SqlCommand komut = new SqlCommand(sqlkomut, baglan);

                    komut.Parameters.AddWithValue("@yeniisim", yeniisim);
                    komut.Parameters.AddWithValue("@yenisoyisim", yenisoyisim2);
                    komut.Parameters.AddWithValue("@yeniemail", yeniemail);
                    komut.Parameters.AddWithValue("@yenitelefonNo", yenitelefonNo);
                    komut.Parameters.AddWithValue("@yenievTelefonNo", yenievTelefonNo);
                    komut.Parameters.AddWithValue("@yeniAdres", yeniAdres);
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
                string sqlkomut = "DELETE FROM Müşteri WHERE MüşteriNo=@id";
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            arac_bakim arac_Bakim = new arac_bakim();
            arac_Bakim.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            arac_bakim arac_Bakim = new arac_bakim();
            arac_Bakim.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            stok stok = new stok();
            stok.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            stok stok = new stok();
            stok.Show();
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sqlkomut = "SELECT * FROM Müşteri WHERE MüşteriNo=@id";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlkomut, baglan);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@id", textBox3.Text);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    textBox1.Text = dataTable.Rows[0]["isim"].ToString();
                    textBox2.Text = dataTable.Rows[0]["soyisim"].ToString();
                    textBox8.Text = dataTable.Rows[0]["email"].ToString();
                    textBox6.Text = dataTable.Rows[0]["telefonNo"].ToString();
                    textBox5.Text = dataTable.Rows[0]["evTelefonNo"].ToString();
                    textBox7.Text = dataTable.Rows[0]["Adres"].ToString();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sqlkomut = "INSERT INTO Müşteri (isim, soyisim, email, telefonNo, evTelefonNo, Adres) VALUES (@isim, @soyisim, @email, @telefonNo, @evTelefonNo, @Adres)";
                SqlCommand komut = new SqlCommand(sqlkomut, baglan);

                komut.Parameters.AddWithValue("@isim", textBox1.Text);
                komut.Parameters.AddWithValue("@soyisim", textBox2.Text);
                komut.Parameters.AddWithValue("@email", textBox8.Text);
                komut.Parameters.AddWithValue("@telefonNo", textBox6.Text);
                komut.Parameters.AddWithValue("@evTelefonNo", textBox5.Text);
                komut.Parameters.AddWithValue("@Adres", textBox7.Text);

                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Müşteri Ekleme İşlemi Başarılı");
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
                string yeniisim = textBox1.Text;
                string yenisoyisim2 = textBox2.Text;
                string yeniemail = textBox8.Text;
                string yenitelefonNo = textBox6.Text;
                string yenievTelefonNo = textBox5.Text;
                string yeniAdres = textBox7.Text;
                int id;

                if (int.TryParse(textBox3.Text, out id))
                {
                    baglan.Open();
                    string sqlkomut = "UPDATE Müşteri SET isim=@yeniisim, soyisim=@yenisoyisim, email=@yeniemail, telefonNo=@yenitelefonNo, evTelefonNo=@yenievTelefonNo, Adres=@yeniAdres WHERE MüşteriNo=@id";
                    SqlCommand komut = new SqlCommand(sqlkomut, baglan);

                    komut.Parameters.AddWithValue("@yeniisim", yeniisim);
                    komut.Parameters.AddWithValue("@yenisoyisim", yenisoyisim2);
                    komut.Parameters.AddWithValue("@yeniemail", yeniemail);
                    komut.Parameters.AddWithValue("@yenitelefonNo", yenitelefonNo);
                    komut.Parameters.AddWithValue("@yenievTelefonNo", yenievTelefonNo);
                    komut.Parameters.AddWithValue("@yeniAdres", yeniAdres);
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

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlkomut = "DELETE FROM Müşteri WHERE MüşteriNo=@id";
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
