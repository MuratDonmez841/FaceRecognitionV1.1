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
using FaceRecognition.Pages;
namespace FaceRecognition.Pages
{
    public partial class OgrKayit : Form
    {
        BusinessRecognition recognition = new BusinessRecognition("D:\\", "Yüz", "yuz.xml");
        Classifier_Train train = new Classifier_Train("D:\\", "Yüz", "yuz.xml");
        T_OGR t_OGR = new T_OGR();
        T_DERS t_DERS= new T_DERS();
        T_KEY t_KEY = new T_KEY();
        Services services = new Services();
        int fotosayisi = 0;
        public OgrKayit()
        {
            InitializeComponent();
            updateComboBoxClass();
            Capture capture = new Capture();
            capture.Start();
            if (capture == null)
            {
                MessageBox.Show("Kamera Açılamadı");
            }
            else
            {
                capture.ImageGrabbed += (a, b) =>
                {
                    var image = capture.RetrieveBgrFrame();
                    var grayimage = image.Convert<Gray, byte>();
                    HaarCascade haaryuz = new HaarCascade("haarcascade_frontalface_default.xml");
                    MCvAvgComp[][] Yuzler = grayimage.DetectHaarCascade(haaryuz, 1.2, 5, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(15, 15));
                    MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 0.5, 0.5);
                    foreach (MCvAvgComp yuz in Yuzler[0])
                    {
                        var sadeyuz = grayimage.Copy(yuz.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                        image.Draw(yuz.rect, new Bgr(Color.Red), 2);
                        pic_kucuk_res.Image = sadeyuz.ToBitmap();
                    }
                    pic_box_kamera.Image = image.ToBitmap();
                };
            }


        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            DialogResult chose = MessageBox.Show("Kaydı Veritabanına Eklemek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ogr_ad_soyad.Text != "" && txt_box_Tc.Text != "" && txt_box_Okul_No.Text != "" && txt_box_Fakülte.Text != "" && txt_box_Bölüm.Text != "")
            {
                if (chose==DialogResult.Yes)
                {
                    t_OGR.OGR_BOLUM = txt_box_Bölüm.Text;
                    t_OGR.OGR_CINSIYET = combo_box_Cinsiyet.Text;
                    t_OGR.OGR_DOGUMT = dt_time_Dogum_t.Text;
                    t_OGR.OGR_FAKULTE = txt_box_Fakülte.Text;
                    t_OGR.OGR_ISIM = ogr_ad_soyad.Text;
                    t_OGR.OGR_OKULNU = Convert.ToInt64(txt_box_Okul_No.Text);
                    t_OGR.OGR_TC = Convert.ToInt64(txt_box_Tc.Text);
                    t_KEY.DERS_KODU = combo_Box_Sinif.Text;
                    t_KEY.OGR_OKULNU= Convert.ToInt64(txt_box_Tc.Text);
                    bool verify = false;
                    verify = services.AddNewStudents(t_OGR,t_KEY);
                    if (verify==false)
                    {
                        MessageBox.Show("Kayıt Yapılamadı Ağ Bağlantısını Kontrol Edin");
                    }
                    else
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            fotosayisi++;
                            if (!recognition.SaveTrainingData(pic_kucuk_res.Image, ogr_ad_soyad.Text))
                            {
                                MessageBox.Show("Öğrenci Kaydı Yapılamadı");

                            }

                            label11.Text = (fotosayisi.ToString());
                        }
                        recognition = null;
                        train = null;
                        recognition = new BusinessRecognition("D:\\", "Yüz", "yuz.xml");
                        train = new Classifier_Train("D:\\", "Yüz", "yuz.xml");
                        MessageBox.Show("Kayıt Başarılı Bir Şekilde Tamamlandı!");
                        fotosayisi = 0;
                        label11.Text = (fotosayisi.ToString());
                        txt_box_Okul_No.Clear();
                        txt_box_Tc.Clear();
                        ogr_ad_soyad.Clear();
                        txt_box_Bölüm.Clear();
                        txt_box_Fakülte.Clear();
                       
                    }
                }
            }
            else
            {
                MessageBox.Show("Bütün alanları Doldurunuz!");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult chose = MessageBox.Show("Kaydı Veritabanında Güncellemek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ogr_ad_soyad.Text != "" && txt_box_Tc.Text != "" && txt_box_Okul_No.Text != "" && txt_box_Fakülte.Text != "" && txt_box_Bölüm.Text != "")
            {
                if (chose==DialogResult.Yes)
                {
                    t_OGR.OGR_BOLUM = txt_box_Bölüm.Text;
                    t_OGR.OGR_CINSIYET = combo_box_Cinsiyet.Text;
                    t_OGR.OGR_DOGUMT = dt_time_Dogum_t.Text;
                    t_OGR.OGR_FAKULTE = txt_box_Fakülte.Text;
                    t_OGR.OGR_ISIM = ogr_ad_soyad.Text;
                    t_OGR.OGR_OKULNU = Convert.ToInt64(txt_box_Okul_No.Text);
                    t_OGR.OGR_TC = Convert.ToInt64(txt_box_Tc.Text);

                    bool verify = false;
                    verify = services.UpdateStudents(t_OGR);
                    if (verify==false)
                    {
                        MessageBox.Show("Güncelleme Yapılamadı Kayıt Yok!");
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci Güncellemesi Başarılı Bir Şekilde Yapıldı!");
                        txt_box_Okul_No.Clear();
                        txt_box_Tc.Clear();
                        ogr_ad_soyad.Clear();
                        txt_box_Bölüm.Clear();
                        txt_box_Fakülte.Clear();
                        combo_box_Cinsiyet.SelectedIndex = -1;
                        combo_Box_Sinif.SelectedIndex = -1;
                    }

                }
            }
            else
            {
                MessageBox.Show("Bütün alanları Doldurunuz!");
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult chose = MessageBox.Show("Kaydı Veritabanından silmek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (txt_box_Tc.Text!="")
            {
                if (chose==DialogResult.Yes)
                {
                    bool verify = false;
                    services.delStudents(Convert.ToInt64(txt_box_Tc.Text));
                    if (verify==false)
                    {
                        MessageBox.Show("Kayıt Silinemedi!");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Başarılı Bir Şekilde Silindi!");
                        txt_box_Okul_No.Clear();
                        txt_box_Tc.Clear();
                        ogr_ad_soyad.Clear();
                        txt_box_Bölüm.Clear();
                        txt_box_Fakülte.Clear();
                        combo_box_Cinsiyet.SelectedIndex = -1;
                        combo_Box_Sinif.SelectedIndex = -1;
                    }
                }

            }
            else
            {
                MessageBox.Show("TCNU BOŞ KALAMAZ!");
            }
        }

        public void updateComboBoxClass() {

            combo_Box_Sinif.SelectedIndex = -1;
            var sinifkodlist = services.GetDersKod();
            foreach (var item in sinifkodlist)
            {
                combo_Box_Sinif.Items.Add(item);
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            BreakPage breakPage = new BreakPage();
            breakPage.Show();
            this.Hide();

        }

        private void ogr_ad_soyad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                  && !char.IsSeparator(e.KeyChar);
        }

        private void txt_box_Fakülte_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txt_box_Tc_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_box_Okul_No_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
