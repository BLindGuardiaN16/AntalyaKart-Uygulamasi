using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AntalyaKart_Uygulaması
{
    public partial class Form2 : Form
    {
        string path = Application.StartupPath;
        bool adibool;
        bool soyadibool;
        bool kimlikbool;
        bool radiobool;
        bool sifrebool;
        string ad, soyad, kimlik, durum, sifre;
        

        private void kaydetbuton_Click(object sender, EventArgs e)
        {
            // Kaydet butonu aynen kalacak
            string message = "Lütfen boş bıraktığınız yerlerdi doldurunuz";

            if (adtxt.Text == "")
            {
                adtxt.BackColor = Color.Red;

            }
            else
            {
                adtxt.BackColor = Color.White;
                adibool = true;
            }
            if (tckimliktxt.Text == "")
            {
                tckimliktxt.BackColor = Color.Red;

            }
            else
            {
                tckimliktxt.BackColor = Color.White;
                soyadibool = true;
            }
            if (soyadtxt.Text == "")
            {
                soyadtxt.BackColor = Color.Red;

            }
            else
            {
                soyadtxt.BackColor = Color.White;
                kimlikbool = true;
            }

            if (sifretxt.Text == "")
            {
                sifretxt.BackColor = Color.Red;

            }
            else
            {
                sifretxt.BackColor = Color.White;
                sifrebool = true;
            }


            if (!normalradio.Checked && !ogrenciradio.Checked && !yasliradio.Checked)
            {
                normalradio.BackColor = Color.Red;
                ogrenciradio.BackColor = Color.Red;
                yasliradio.BackColor = Color.Red;

            }
            else
            {
                normalradio.BackColor = Color.White;
                ogrenciradio.BackColor = Color.White;
                yasliradio.BackColor = Color.White;
                radiobool = true;
            }

            if (adibool == true && soyadibool == true &&
            kimlikbool == true && sifrebool == true && radiobool == true) 
            {
                adlabel.Text = "Adınız:" + adtxt.Text;
                soyadlabel.Text = "Soyadınız:" + soyadtxt.Text;
                tckimliklabel.Text = "Tc Kimliğiniz:" + tckimliktxt.Text;
                sifrelabel.Text = "Şifreniz:" + sifretxt.Text;
                if (normalradio.Checked) { durumlabel.Text = "Durumunuz: Normal"; }
                if (ogrenciradio.Checked) { durumlabel.Text = "Durumunuz: Öğrenci"; }
                if (yasliradio.Checked) { durumlabel.Text = "Durumunuz: +65 Yaş Üstü"; }
                onaylabuton.Visible = true;

            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void anamenubutton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            onaylabuton.Visible = false;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void onaylabuton_Click(object sender, EventArgs e)
        {
            ad = adtxt.Text;//1
            soyad = soyadtxt.Text;//2
            kimlik = tckimliktxt.Text;//0
            sifre = sifretxt.Text;//3
            if (normalradio.Checked) { durum = "Normal"; }
            if (ogrenciradio.Checked) { durum = "Öğrenci"; }  
            if (yasliradio.Checked) { durum = "+65 Yaş Üstü"; }
            // Kartların bilgileri için yeni bir text oluştururuz bir alt satırda
            // Burayı sql ile değiştirilecek
            SqlConnection conn = new SqlConnection("Data Source=AHMET;Initial Catalog=AntalyaKartDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            conn.Open();
            string sorgu = String.Format("INSERT INTO Kullanici VALUES('{0}','{1}','{2}','{3}','{4}')",kimlik,ad,soyad,sifre,durum);
            SqlCommand komutkullanici = new SqlCommand(sorgu, conn);
            try
            {
                komutkullanici.ExecuteNonQuery();
                MessageBox.Show("Kayıtınız Yapıldı");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString());
            }

            conn.Close();
        }


        private void adtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void soyadtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void tckimliktxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
