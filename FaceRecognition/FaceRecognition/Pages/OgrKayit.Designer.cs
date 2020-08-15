namespace FaceRecognition.Pages
{
    partial class OgrKayit
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_kayit = new System.Windows.Forms.Button();
            this.pic_box_kamera = new System.Windows.Forms.PictureBox();
            this.ogr_ad_soyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_box_Tc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_box_Okul_No = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_box_Bölüm = new System.Windows.Forms.TextBox();
            this.txt_box_Fakülte = new System.Windows.Forms.TextBox();
            this.dt_time_Dogum_t = new System.Windows.Forms.DateTimePicker();
            this.pic_kucuk_res = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.combo_box_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.combo_Box_Sinif = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_kamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_kucuk_res)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kayit
            // 
            this.btn_kayit.BackColor = System.Drawing.Color.White;
            this.btn_kayit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kayit.Location = new System.Drawing.Point(399, 416);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(147, 76);
            this.btn_kayit.TabIndex = 4;
            this.btn_kayit.Text = "KAYIT ET";
            this.btn_kayit.UseVisualStyleBackColor = false;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // pic_box_kamera
            // 
            this.pic_box_kamera.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pic_box_kamera.Location = new System.Drawing.Point(612, 12);
            this.pic_box_kamera.Name = "pic_box_kamera";
            this.pic_box_kamera.Size = new System.Drawing.Size(639, 480);
            this.pic_box_kamera.TabIndex = 3;
            this.pic_box_kamera.TabStop = false;
            // 
            // ogr_ad_soyad
            // 
            this.ogr_ad_soyad.Location = new System.Drawing.Point(255, 47);
            this.ogr_ad_soyad.Name = "ogr_ad_soyad";
            this.ogr_ad_soyad.Size = new System.Drawing.Size(291, 22);
            this.ogr_ad_soyad.TabIndex = 5;
            this.ogr_ad_soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ogr_ad_soyad_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Öğrenci Adı Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Öğrenci TC Kimlik Numarası:";
            // 
            // txt_box_Tc
            // 
            this.txt_box_Tc.Location = new System.Drawing.Point(255, 86);
            this.txt_box_Tc.MaxLength = 12;
            this.txt_box_Tc.Name = "txt_box_Tc";
            this.txt_box_Tc.Size = new System.Drawing.Size(291, 22);
            this.txt_box_Tc.TabIndex = 8;
            this.txt_box_Tc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_box_Tc_KeyPress_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Öğrenci Okul Numarası:";
            // 
            // txt_box_Okul_No
            // 
            this.txt_box_Okul_No.Location = new System.Drawing.Point(255, 131);
            this.txt_box_Okul_No.MaxLength = 9;
            this.txt_box_Okul_No.Name = "txt_box_Okul_No";
            this.txt_box_Okul_No.Size = new System.Drawing.Size(291, 22);
            this.txt_box_Okul_No.TabIndex = 10;
            this.txt_box_Okul_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_box_Okul_No_KeyPress_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fakültesi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bölümü:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Doğum Tarihi:";
            // 
            // txt_box_Bölüm
            // 
            this.txt_box_Bölüm.Location = new System.Drawing.Point(255, 212);
            this.txt_box_Bölüm.Name = "txt_box_Bölüm";
            this.txt_box_Bölüm.Size = new System.Drawing.Size(291, 22);
            this.txt_box_Bölüm.TabIndex = 15;
            // 
            // txt_box_Fakülte
            // 
            this.txt_box_Fakülte.Location = new System.Drawing.Point(255, 248);
            this.txt_box_Fakülte.Name = "txt_box_Fakülte";
            this.txt_box_Fakülte.Size = new System.Drawing.Size(291, 22);
            this.txt_box_Fakülte.TabIndex = 16;
            this.txt_box_Fakülte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_box_Fakülte_KeyPress_1);
            // 
            // dt_time_Dogum_t
            // 
            this.dt_time_Dogum_t.Location = new System.Drawing.Point(255, 174);
            this.dt_time_Dogum_t.Name = "dt_time_Dogum_t";
            this.dt_time_Dogum_t.Size = new System.Drawing.Size(291, 22);
            this.dt_time_Dogum_t.TabIndex = 17;
            // 
            // pic_kucuk_res
            // 
            this.pic_kucuk_res.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pic_kucuk_res.Location = new System.Drawing.Point(612, 498);
            this.pic_kucuk_res.Name = "pic_kucuk_res";
            this.pic_kucuk_res.Size = new System.Drawing.Size(121, 119);
            this.pic_kucuk_res.TabIndex = 19;
            this.pic_kucuk_res.TabStop = false;
            this.pic_kucuk_res.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Cinsiyeti:";
            // 
            // combo_box_Cinsiyet
            // 
            this.combo_box_Cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_box_Cinsiyet.FormattingEnabled = true;
            this.combo_box_Cinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.combo_box_Cinsiyet.Location = new System.Drawing.Point(255, 285);
            this.combo_box_Cinsiyet.Name = "combo_box_Cinsiyet";
            this.combo_box_Cinsiyet.Size = new System.Drawing.Size(291, 24);
            this.combo_box_Cinsiyet.TabIndex = 21;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Location = new System.Drawing.Point(209, 416);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(147, 76);
            this.btn_update.TabIndex = 23;
            this.btn_update.Text = "Kaydı Güncelle";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 12);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(174, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Kayıt Olacağı Ders:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(12, 377);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Alınan fotoğraf Sayısı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(206, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "0";
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.White;
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_del.Location = new System.Drawing.Point(12, 416);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(147, 76);
            this.btn_del.TabIndex = 29;
            this.btn_del.Text = "KAYIT SİL";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // combo_Box_Sinif
            // 
            this.combo_Box_Sinif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Box_Sinif.FormattingEnabled = true;
            this.combo_Box_Sinif.Location = new System.Drawing.Point(255, 6);
            this.combo_Box_Sinif.Name = "combo_Box_Sinif";
            this.combo_Box_Sinif.Size = new System.Drawing.Size(291, 24);
            this.combo_Box_Sinif.TabIndex = 30;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Location = new System.Drawing.Point(1183, 626);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(78, 33);
            this.btn_back.TabIndex = 31;
            this.btn_back.Text = "Geri";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // OgrKayit
            // 
            this.ClientSize = new System.Drawing.Size(1273, 662);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.combo_Box_Sinif);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.combo_box_Cinsiyet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pic_kucuk_res);
            this.Controls.Add(this.dt_time_Dogum_t);
            this.Controls.Add(this.txt_box_Fakülte);
            this.Controls.Add(this.txt_box_Bölüm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_box_Okul_No);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_box_Tc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ogr_ad_soyad);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.pic_box_kamera);
            this.Name = "OgrKayit";
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_kamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_kucuk_res)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.PictureBox pic_box_kamera;
        private System.Windows.Forms.TextBox ogr_ad_soyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_box_Tc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_box_Okul_No;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_box_Bölüm;
        private System.Windows.Forms.TextBox txt_box_Fakülte;
        private System.Windows.Forms.DateTimePicker dt_time_Dogum_t;
        private System.Windows.Forms.PictureBox pic_kucuk_res;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combo_box_Cinsiyet;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.ComboBox combo_Box_Sinif;
        private System.Windows.Forms.Button btn_back;
    }
}