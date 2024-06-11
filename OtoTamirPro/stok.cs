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

namespace OtoTamirPro
{
    public partial class stok : Form
    {
        public stok()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-VNCQEJA;Initial Catalog=OtoTamirPro;Integrated Security=True;");

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sqlkomut = "INSERT INTO stok (parca_adı, miktar) VALUES (@parca_adı, @miktar)";
                SqlCommand komut = new SqlCommand(sqlkomut, baglan);

                komut.Parameters.AddWithValue("@parca_adı", textBox1.Text);
                komut.Parameters.AddWithValue("@miktar", textBox2.Text);
               
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Müşteri Ekleme İşlemi Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void stok_Load(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sqlkomut = "SELECT * FROM stok";
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
                string sqlkomut = "SELECT * FROM stok WHERE stok_no=@id";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlkomut, baglan);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@id", textBox3.Text);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    textBox1.Text = dataTable.Rows[0]["parca_adı"].ToString();
                    textBox2.Text = dataTable.Rows[0]["miktar"].ToString();                    
                }
                else
                {
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;                   
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
                string yenimiktar = textBox2.Text;
                int id;

                if (int.TryParse(textBox3.Text, out id))
                {
                    baglan.Open();
                    string sqlkomut = "UPDATE stok SET parca_adı=@yeniisim, miktar=@yenimiktar WHERE stok_no=@id";
                    SqlCommand komut = new SqlCommand(sqlkomut, baglan);

                    komut.Parameters.AddWithValue("@yeniisim", yeniisim);
                    komut.Parameters.AddWithValue("@yenimiktar", yenimiktar);                   
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
                string sqlkomut = "DELETE FROM stok WHERE stok_no=@id";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sqlkomut = "SELECT * FROM stok WHERE stok_no=@id";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlkomut, baglan);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@id", textBox3.Text);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    textBox1.Text = dataTable.Rows[0]["parca_adı"].ToString();
                    textBox2.Text = dataTable.Rows[0]["miktar"].ToString();
                }
                else
                {
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
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
                string sqlkomut = "INSERT INTO stok (parca_adı, miktar) VALUES (@parca_adı, @miktar)";
                SqlCommand komut = new SqlCommand(sqlkomut, baglan);

                komut.Parameters.AddWithValue("@parca_adı", textBox1.Text);
                komut.Parameters.AddWithValue("@miktar", textBox2.Text);

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
                string yenimiktar = textBox2.Text;
                int id;

                if (int.TryParse(textBox3.Text, out id))
                {
                    baglan.Open();
                    string sqlkomut = "UPDATE stok SET parca_adı=@yeniisim, miktar=@yenimiktar WHERE stok_no=@id";
                    SqlCommand komut = new SqlCommand(sqlkomut, baglan);

                    komut.Parameters.AddWithValue("@yeniisim", yeniisim);
                    komut.Parameters.AddWithValue("@yenimiktar", yenimiktar);
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
                string sqlkomut = "DELETE FROM stok WHERE stok_no=@id";
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
