using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntalyaKart_Uygulaması
{
    public partial class Form4 : Form
    {
         int eskipara;
        //Bu cs dosyası tamamen değişecek
        string path = Application.StartupPath;
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            SqlConnection conn = new SqlConnection("Data Source=AHMET;Initial Catalog=AntalyaKartDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            conn.Open();
            string sorgu = String.Format("SELECT * FROM Kartlar WHERE TcKimlik={0}",Form3.tckimlik);
            SqlCommand komut = new SqlCommand(sorgu,conn);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr.GetValue(0));

            }
            conn.Close();
        }

        private void kaydetbutton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=AHMET;Initial Catalog=AntalyaKartDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            conn.Open();
            string sorgu = String.Format("INSERT INTO Kartlar VALUES('{0}','{1}','{2}')", kartekletxt.Text, Form3.tckimlik, 0);
            SqlCommand komut = new SqlCommand(sorgu, conn);
            try
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Kartınız başırılı bir şekilde kaydedildi.");
            }
            catch(Exception)
            {
                MessageBox.Show("Kartınız kaydedilemedi. Lütfen tekrar deneyiniz!");
            }
            conn.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=AHMET;Initial Catalog=AntalyaKartDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            conn.Open();
            string verialmasorgu = String.Format("SELECT * from Kartlar WHERE KartNo='{0}'", comboBox2.Text);
            SqlCommand verialkomut = new SqlCommand(verialmasorgu, conn);
            SqlDataReader dr = verialkomut.ExecuteReader();
            if (dr.Read())
            {
                eskipara = Convert.ToInt32(dr.GetValue(2));
                label3.Text = eskipara.ToString();
            }
            conn.Close();

        }

        private void paraeklebutton_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox1.SelectedIndex = -1;
            int eklenecekpara;
            int para = radioparaekle();
            SqlConnection conn = new SqlConnection("Data Source=AHMET;Initial Catalog=AntalyaKartDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            conn.Open();
            eklenecekpara = para + eskipara;
            string sorgu = String.Format("UPDATE Kartlar set KartBakiye={0} WHERE KartNo='{1}'",eklenecekpara , comboBox2.Text);
            
            SqlCommand komut = new SqlCommand(sorgu, conn);
            if (comboBox2.Text!="")
            {
                try
                {
                    komut.ExecuteNonQuery();

                    MessageBox.Show(String.Format("Tebrikler.{0} nolu kartınıza başarılı bir şekilde bakiye yüklediniz.", comboBox2.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                comboBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen bakiye eklenecek bir kart seçiniz.");
            }
            conn.Close();
            
            rd10.Checked = false; rd25.Checked = false; rd50.Checked = false; rd75.Checked = false; rd100.Checked = false;
            rd125.Checked = false; rd150.Checked = false; rd175.Checked = false; rd200.Checked = false;

        }

        public int radioparaekle()
        {
            int para = 0;

            if (rd10.Checked)
            {
                para = 10;
            }
            else if (rd25.Checked)
            {
                para = 25;
            }
            else if (rd50.Checked)
            {
                para = 50;
            }
            else if (rd75.Checked)
            {
                para = 75;
            }
            else if (rd100.Checked)
            {
                para = 100;
            }
            else if (rd125.Checked)
            {
                para = 125;
            }
            else if (rd150.Checked)
            {
                para = 150;
            }
            else if (rd175.Checked)
            {
                para = 175;
            }
            else if (rd200.Checked)
            {
                para = 200;
            }
            else
            {
                para = 0;
            }

            return para;
            
        }

  

      

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            SqlConnection conn = new SqlConnection("Data Source=AHMET;Initial Catalog=AntalyaKartDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            conn.Open();
            string sorgu = String.Format("SELECT * FROM Kartlar WHERE TcKimlik={0}", Form3.tckimlik);
            SqlCommand komut = new SqlCommand(sorgu, conn);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr.GetValue(0));

            }
            conn.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label2.Text ="Hoşgeldiniz Sayın, " + Form3.adsoyad;
            SqlConnection conn = new SqlConnection("Data Source=AHMET;Initial Catalog=AntalyaKartDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            conn.Open();
            string verialmasorgu = String.Format("SELECT KartBakiye from Kartlar WHERE KartNo='{0}'", comboBox2.Text);
            SqlCommand verialkomut = new SqlCommand(verialmasorgu, conn);
            SqlDataReader dr = verialkomut.ExecuteReader();
            while (dr.Read())
            {
                label2.Text = dr.GetValue(0).ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=AHMET;Initial Catalog=AntalyaKartDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            conn.Open();
            string verialmasorgu = String.Format("SELECT KartBakiye from Kartlar WHERE KartNo='{0}'", comboBox1.Text);
            SqlCommand verialkomut = new SqlCommand(verialmasorgu, conn);
            SqlDataReader dr = verialkomut.ExecuteReader();
            if(dr.Read())
            {
                bakiyelabel.Text = dr.GetValue(0).ToString()+" TL";
            }
            conn.Close();
        }

        private void anamenubutton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            Form3.tckimlik = "";
            Form3.adsoyad = "";
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
