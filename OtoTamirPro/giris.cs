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
using System.Reflection.Emit;

namespace OtoTamirPro
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-VNCQEJA;Initial Catalog=OtoTamirPro;Integrated Security=True");
        int girsay = 0;
        int suret;
        
        public void sayiuret()
        {
            Random sayi = new Random();
            suret = sayi.Next(1,1000);
            label3.Text = suret.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand giris = new SqlCommand("select * from kullanici where kadi='"+textBox1.Text+"' and sifre='"+textBox2.Text+"' and '"+suret+"'='"+textBox3.Text+"'",baglan);
            SqlDataReader rd = giris.ExecuteReader();
            if(girsay < 3)
            {
                if(rd.Read() == true)
                {
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.Show();
                    
                }
                else MessageBox.Show("hatalı giriş"); girsay++;
                baglan.Close();
            }
            else { MessageBox.Show("uygulama kapanıyor"); Application.Exit(); }

            sayiuret();
        }

        private void giris_Load(object sender, EventArgs e)
        {
            sayiuret();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            kayit kayit = new kayit();
            kayit.Show();
        }
    }
}
