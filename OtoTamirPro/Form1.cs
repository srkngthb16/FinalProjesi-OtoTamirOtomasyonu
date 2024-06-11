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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
            
        }

        private void button8_Click(object sender, EventArgs e)
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            randevu randevu = new randevu();
            randevu.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            randevu randevu = new randevu();
            randevu.Show();
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            fatura fatura = new fatura();
            fatura.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            fatura fatura = new fatura();
            fatura.Show();
        }
    }
}
