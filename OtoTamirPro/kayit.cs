﻿using System;
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
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-VNCQEJA;Initial Catalog=OtoTamirPro;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand kaydet = new SqlCommand("insert into kullanici (kadi,sifre) values ('"+textBox1.Text.ToString()+"','"+textBox2.Text.ToString()+"')",baglan);
            kaydet.ExecuteNonQuery();
            MessageBox.Show("BAŞARILI ŞEKİLDE KAYIT OLDUNUZ");
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            giris giris = new giris();
            giris.Show();
        }
    }
}

