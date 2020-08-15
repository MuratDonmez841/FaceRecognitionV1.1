using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition.Pages;
namespace FaceRecognition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ogr_kyt_Click(object sender, EventArgs e)
        {
            txtKullanici.Text.ToLower();
            txtSifre.Text.ToLower();
            if (txtKullanici.Text == "admin" && txtSifre.Text == "admin123")
            {

                BreakPage breakPage = new BreakPage();
                breakPage.Show();
                txtKullanici.Clear();
                txtSifre.Clear();
            }
            else if (txtKullanici.Text == "görevli" && txtSifre.Text == "görevli123")
            {

                YokalmaSistemi yoklama_sis = new YokalmaSistemi();
                yoklama_sis.Show();
                txtKullanici.Clear();
                txtSifre.Clear();

            }
            else
            {
                MessageBox.Show("Geçersiz Kullanıcı Adı Veya Şifre!");
            }


        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }
    }
}
