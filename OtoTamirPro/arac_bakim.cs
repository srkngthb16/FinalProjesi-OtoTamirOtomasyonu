using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoTamirPro
{
    public partial class arac_bakim : Form
    {
        public arac_bakim()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
            
        }

        private void button8_Click(object sender, EventArgs e)
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
            stok stok = new stok();
            stok.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            stok stok = new stok();
            stok.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            musteri muster = new musteri();
            muster.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            musteri muster = new musteri();
            muster.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            araç araç = new araç();
            araç.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            araç araç = new araç();
            araç.Show();
            
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            fatura fatura = new fatura();
            fatura.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            fatura fatura = new fatura();
            fatura.Show();
        }
    }
}
