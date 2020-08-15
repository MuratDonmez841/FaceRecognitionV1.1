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
namespace FaceRecognition.Pages
{
    public partial class BreakPage : Form
    {
        public BreakPage()
        {
            InitializeComponent();
        }

        private void btn_ogrKayit_Click(object sender, EventArgs e)
        {
            OgrKayit ogrKayit = new OgrKayit();
            ogrKayit.Show();
            this.Hide();
        }

        private void btn_Sinifkayit_Click(object sender, EventArgs e)
        {
            CourseOperations courseOperations = new CourseOperations();
            courseOperations.Show();
            this.Hide();
        }
    }
}
