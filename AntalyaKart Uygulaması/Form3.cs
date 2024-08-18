using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntalyaKart_Uygulaması
{
    public partial class Form3 : Form
    {
        int Count;
        string path = Application.StartupPath;
        public static string tckimlik;
        string ad, soyad;
        public static string adsoyad;
        public Form3()
        {
            InitializeComponent();
        }

        private void girisbutton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=AHMET;Initial Catalog=AntalyaKartDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            conn.Open();
            string sorgu = 
            String.Format("Select COUNT(TcKimlik),COUNT(Sifre) from Kullanici where TcKimlik='{0}' and Sifre='{1}'",tckimliktxt.Text,sifretxt.Text);
            SqlCommand komut = new SqlCommand(sorgu, conn);
            Count = (int)komut.ExecuteScalar();



            //Burası Ad soyad almak için açıldı
            string adsoyadsorgusu = String.Format("SELECT * FROM Kullanici WHERE TcKimlik = '{0}' and Sifre = '{1}'", tckimliktxt.Text, sifretxt.Text);
            SqlCommand adsoyadkomutu = new SqlCommand(adsoyadsorgusu, conn);
            SqlDataReader dr = adsoyadkomutu.ExecuteReader();
            if (dr.Read())
            {
                adsoyad = dr.GetValue(1).ToString() + dr.GetValue(2).ToString();
            }
            // buraya kadar

            if (Count == 1)
            {
                MessageBox.Show("Oldu deneme");
                tckimlik = tckimliktxt.Text;
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Olmadı la gardas");
                Count = 0;
            }
            conn.Close();

        }

        private void anamenubutton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Count = 0;
        }
    }
}
