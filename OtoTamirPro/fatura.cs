﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtoTamirPro
{
    public partial class fatura : Form
    {
        public fatura()
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

        private void button9_Click(object sender, EventArgs e)
        {
            fatura2 fatura2 = new fatura2();
            fatura2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fatura2 fatura2 = new fatura2();
            fatura2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fatura2 fatura2 = new fatura2();
            fatura2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            fatura2 fatura2 = new fatura2();
            fatura2.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            fatura2 fatura2 = new fatura2();
            fatura2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fatura2 fatura2 = new fatura2();
            fatura2.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            fatura2 fatura2 = new fatura2();
            fatura2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fatura2 fatura2 = new fatura2();
            fatura2.Show();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-VNCQEJA;Initial Catalog=OtoTamirPro;Integrated Security=True");
        private void fatura_Load(object sender, EventArgs e)
        {
            baglan.Open();
            string sqlkomut = "SELECT * FROM fatura";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlkomut, baglan);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglan.Close();
        }
    }
}
