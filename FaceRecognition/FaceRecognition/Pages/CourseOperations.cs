using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Capture = Emgu.CV.Capture;
using Emgu.CV.CvEnum;
using FaceRecognition.Classes;
using FaceRecognition.Model;
namespace FaceRecognition.Pages
{
    public partial class CourseOperations : Form
    {
        Services services = new Services();
        T_DERS t_DERS = new T_DERS();
        public CourseOperations()
        {
            InitializeComponent();
            ComboBoxUpdate();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult chose = MessageBox.Show("Kaydı Veritabanında Eklemek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (txt_dersakademisyeni.Text!=""&&txt_dersblock.Text!=""&&txt_dersismi.Text!=""&&txt_derskodu.Text!=""&&txt_derslik_kodu.Text!="")
            {
                if (chose==DialogResult.Yes)
                {
                    t_DERS.DERS_AKADEMİSYENI = txt_dersakademisyeni.Text;
                    t_DERS.DERS_BLOCK = txt_dersblock.Text;
                    t_DERS.DERS_ISMI = txt_dersismi.Text;
                    t_DERS.DERS_KODU = txt_derskodu.Text;
                    t_DERS.DERS_SINIF_KOD = txt_derslik_kodu.Text;
                    bool verify = false;
                    verify = services.AddnewClass(t_DERS);
                    if (verify==false)
                    {
                        MessageBox.Show("Ders Kaydı Yapılamadı!");
                    }
                    else
                    {
                        MessageBox.Show("Ders Kaydı Başarıyla Yapıldı!");
                        txt_dersakademisyeni.Clear();
                        txt_dersblock.Clear();
                        txt_dersismi.Clear();
                        txt_derskodu.Clear();
                        txt_derslik_kodu.Clear();

                    }

                    ComboBoxUpdate();
                }
                else
                {
                    MessageBox.Show("Bütün Alanları Doldurunuz!");
                }
            }
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult chose = MessageBox.Show("Kaydı Veritabanında Güncellemek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (txt_dersakademisyeni.Text != "" && txt_dersblock.Text != "" && txt_dersismi.Text != "" && txt_derskodu.Text != "" && txt_derslik_kodu.Text != "") {
                if (chose==DialogResult.Yes)
                {
                    t_DERS.DERS_AKADEMİSYENI = txt_dersakademisyeni.Text;
                    t_DERS.DERS_BLOCK = txt_dersblock.Text;
                    t_DERS.DERS_ISMI = txt_dersismi.Text;
                    t_DERS.DERS_KODU = txt_derskodu.Text;
                    t_DERS.DERS_SINIF_KOD = txt_derslik_kodu.Text;
                    bool verify = false;
                    verify = services.UpdateClass(t_DERS);
                    if (verify == false)
                    {
                        MessageBox.Show("Ders kKaydı Yapılamadı!");
                    }
                    else
                    {
                        txt_dersakademisyeni.Clear();
                        txt_dersblock.Clear();
                        txt_dersismi.Clear();
                        txt_derskodu.Clear();
                        txt_derslik_kodu.Clear();
                        ComboBoxUpdate();
                        MessageBox.Show("Ders Güncellemesi Başarıyla Yapıldı!");
                    }
              
                }
            }
            else
            {
                MessageBox.Show("Bütün Alanları Doldurunuz!");
            }
               
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult chose = MessageBox.Show("Kaydı Veritabanından Silmek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (txt_derslik_kodu.Text!="")
            {
                if (chose==DialogResult.Yes)
                {
                    bool verify = false;
                    verify = services.delClass(txt_derskodu.Text);
                    if (verify==false)
                    {
                        MessageBox.Show("Ders Silinemiyor!");
                    }
                    else
                    {
                        MessageBox.Show("Ders Başarıyla Silindi!");
                        ComboBoxUpdate();
                    }
          
                }
            }
           
        }

        public void ComboBoxUpdate() {

            cb_dersler.SelectedIndex = -1;
            var update = services.GetDersKod();
            foreach (var item in update)
            {
                cb_dersler.Items.Add(item);
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            BreakPage breakPage = new BreakPage();
            breakPage.Show();
            this.Hide();

        }
    }
}
