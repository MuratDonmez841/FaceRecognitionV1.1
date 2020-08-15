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
using FaceRecognition.Pages;
namespace FaceRecognition.Pages
{
    public partial class YokalmaSistemi : Form
    {
        int kisisayisi;
        Services services = new Services();
        public static string name;
        BusinessRecognition recognition = new BusinessRecognition("D:\\", "Yüz", "yuz.xml");
        Classifier_Train train = new Classifier_Train("D:\\", "Yüz", "yuz.xml");
        List<string> ogrName = new List<string>();
        public YokalmaSistemi()
        {
            InitializeComponent();
            list_view_var_olanlar.Columns.Add("Adı Soyadı", 100);
            ComboBoxUpdate();
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
                        pic_kucuk_res.Image = sadeyuz.ToBitmap();
                        if (train.IsTrained)
                        {
                            name = train.Recognise(sadeyuz);
                            int match_value = (int)train.Get_Eigen_Distance;
                            image.Draw(name + " ", ref font, new Point(yuz.rect.X - 2, yuz.rect.Y - 2), new Bgr(Color.SteelBlue));

                        }
                        image.Draw(yuz.rect, new Bgr(Color.Purple), 2);

                    }
                    pic_kamera.Image = image.ToBitmap();
                };
            }
        }

        private void YokalmaSistemi_Load(object sender, EventArgs e)
        {
            Capture capture1 = new Capture();
            capture1.Start();
            if (capture1 == null)
            {
                MessageBox.Show("Kamera Açılamadı");
            }
            else
            {
                capture1.ImageGrabbed += (a, b) =>
                {
                    var image = capture1.RetrieveBgrFrame();
                    var grayimage1 = image.Convert<Gray, byte>();
                    HaarCascade haaryuz = new HaarCascade("haarcascade_frontalface_default.xml");
                    MCvAvgComp[][] Yuzler = grayimage1.DetectHaarCascade(haaryuz, 1.2, 5, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(15, 15));
                    MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 0.5, 0.5);
                    foreach (MCvAvgComp yuz in Yuzler[0])
                    {
                        var sadeyuz = grayimage1.Copy(yuz.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                        pic_kucuk_res.Image = sadeyuz.ToBitmap();
                        if (train.IsTrained)
                        {
                            name = train.Recognise(sadeyuz);
                            int match_value = (int)train.Get_Eigen_Distance;
                            image.Draw(name + " ", ref font, new Point(yuz.rect.X - 2, yuz.rect.Y - 2), new Bgr(Color.SteelBlue));

                        }
                        image.Draw(yuz.rect, new Bgr(Color.Purple), 2);
                    }
                    pic_kamera.Image = image.ToBitmap();

                };
            }


        }
        private void btn_control_Click(object sender, EventArgs e)
        {
            if (combo_Box_Sinif.Text!=null)
            {
                int control = 0;

                var ogrisimlist = services.GetStudentsName(combo_Box_Sinif.Text);
                foreach (var isim in ogrisimlist)
                {
                    if (name==isim)
                    {
                        control = 1;
                        break;
                    }
                }

                if (control==1)
                {
                    int tekrarkontrolü = 0;
                    foreach (var item in ogrName)
                    {
                        if (item==name)
                        {
                            tekrarkontrolü = 1;
                        }
                    }
                    if (tekrarkontrolü==0)
                    {
                        
                        list_view_var_olanlar.View = View.Details;
                        ListViewItem ögrenci = new ListViewItem(name);
                        list_view_var_olanlar.Items.Add(ögrenci);
                        kisisayisi++;
                        lbl_kisi_sayisi.Text = kisisayisi.ToString();
                        ogrName.Add(name);
                        name = "";
                       
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci Daha Önceden Var Yazılmıştır!");
                    }

                }
                else
                {
                    MessageBox.Show("Öğrenci Listede Bulanmamaktadır!");
                }
            }
            else
            {
                MessageBox.Show("Sınıf Seçiniz!");
            }

        }

        private void btn_delList_Click(object sender, EventArgs e)
        {
            DialogResult chose = MessageBox.Show("Listeyi Temizlemek İstiyor Musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (chose==DialogResult.Yes)
            {
                list_view_var_olanlar.Items.Clear();
                kisisayisi = 0;
                lbl_kisi_sayisi.Text = kisisayisi.ToString();
                ogrName.Clear();
                
            }
        }

        public void ComboBoxUpdate()
        {

            combo_Box_Sinif.SelectedIndex = -1;
            var update = services.GetDersKod();
            foreach (var item in update)
            {
                combo_Box_Sinif.Items.Add(item);
            }

        }

        private void combo_Box_Sinif_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (combo_Box_Sinif.Text != null)
            {
                var siniflistesi = services.GetOgrList(combo_Box_Sinif.Text);
                dataGrid_Liste.DataSource = siniflistesi;
            }
        }
    }
}
