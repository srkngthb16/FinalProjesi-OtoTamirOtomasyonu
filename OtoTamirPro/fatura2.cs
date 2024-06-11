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
    public partial class fatura2 : Form
    {
        public fatura2()
        {
            InitializeComponent();
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
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-VNCQEJA;Initial Catalog=OtoTamirPro;Integrated Security=True");
        private void fatura2_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand stok = new SqlCommand("select * from stok",baglan);
            SqlDataReader oku = stok.ExecuteReader();
            while (oku.Read())
            {
                listBox1.Items.Add(oku[1]);
            }
            baglan.Close();

            baglan.Open();
            SqlCommand musteri = new SqlCommand("select * from Müşteri",baglan);
            SqlDataReader moku = musteri.ExecuteReader();
            while (moku.Read())
            {
                comboBox1.Items.Add(moku[1]);
            }
            baglan.Close();

            baglan.Open();
            SqlCommand arac = new SqlCommand("select * from arac", baglan);
            SqlDataReader aoku = arac.ExecuteReader();
            while (aoku.Read())
            {
                comboBox2.Items.Add(aoku[1]);
            }
            baglan.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand fatura = new SqlCommand("insert into fatura(musteri_ad,musteri_arac)  values('"+comboBox1.SelectedItem.ToString()+"','"+comboBox2.SelectedItem.ToString()+"','"+listBox1.SelectedItems.ToString()+"')",baglan);
            fatura.ExecuteNonQuery();
            baglan.Close();
        }
    }
}
