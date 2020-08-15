namespace FaceRecognition.Pages
{
    partial class YokalmaSistemi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic_kamera = new System.Windows.Forms.PictureBox();
            this.pic_kucuk_res = new System.Windows.Forms.PictureBox();
            this.dataGrid_Liste = new System.Windows.Forms.DataGridView();
            this.btn_control = new System.Windows.Forms.Button();
            this.btn_delList = new System.Windows.Forms.Button();
            this.list_view_var_olanlar = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_kisi_sayisi = new System.Windows.Forms.Label();
            this.combo_Box_Sinif = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_kamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_kucuk_res)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_kamera
            // 
            this.pic_kamera.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pic_kamera.Location = new System.Drawing.Point(790, 12);
            this.pic_kamera.Name = "pic_kamera";
            this.pic_kamera.Size = new System.Drawing.Size(682, 513);
            this.pic_kamera.TabIndex = 0;
            this.pic_kamera.TabStop = false;
            // 
            // pic_kucuk_res
            // 
            this.pic_kucuk_res.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pic_kucuk_res.Location = new System.Drawing.Point(1178, 588);
            this.pic_kucuk_res.Name = "pic_kucuk_res";
            this.pic_kucuk_res.Size = new System.Drawing.Size(148, 150);
            this.pic_kucuk_res.TabIndex = 1;
            this.pic_kucuk_res.TabStop = false;
            this.pic_kucuk_res.Visible = false;
            // 
            // dataGrid_Liste
            // 
            this.dataGrid_Liste.AllowUserToDeleteRows = false;
            this.dataGrid_Liste.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Liste.Location = new System.Drawing.Point(15, 49);
            this.dataGrid_Liste.Name = "dataGrid_Liste";
            this.dataGrid_Liste.ReadOnly = true;
            this.dataGrid_Liste.RowTemplate.Height = 24;
            this.dataGrid_Liste.Size = new System.Drawing.Size(743, 225);
            this.dataGrid_Liste.TabIndex = 2;
            // 
            // btn_control
            // 
            this.btn_control.BackColor = System.Drawing.Color.White;
            this.btn_control.Location = new System.Drawing.Point(790, 531);
            this.btn_control.Name = "btn_control";
            this.btn_control.Size = new System.Drawing.Size(112, 42);
            this.btn_control.TabIndex = 6;
            this.btn_control.Text = "Kontrol";
            this.btn_control.UseVisualStyleBackColor = false;
            this.btn_control.Click += new System.EventHandler(this.btn_control_Click);
            // 
            // btn_delList
            // 
            this.btn_delList.BackColor = System.Drawing.Color.White;
            this.btn_delList.Location = new System.Drawing.Point(1360, 531);
            this.btn_delList.Name = "btn_delList";
            this.btn_delList.Size = new System.Drawing.Size(112, 42);
            this.btn_delList.TabIndex = 7;
            this.btn_delList.Text = "Listeyi Sıfırla";
            this.btn_delList.UseVisualStyleBackColor = false;
            this.btn_delList.Click += new System.EventHandler(this.btn_delList_Click);
            // 
            // list_view_var_olanlar
            // 
            this.list_view_var_olanlar.HideSelection = false;
            this.list_view_var_olanlar.Location = new System.Drawing.Point(210, 328);
            this.list_view_var_olanlar.Name = "list_view_var_olanlar";
            this.list_view_var_olanlar.Size = new System.Drawing.Size(321, 379);
            this.list_view_var_olanlar.TabIndex = 8;
            this.list_view_var_olanlar.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(250, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "VAR OLANLARIN LİSTESİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "SINIF LİSTESİNİ SEÇİNİZ:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(210, 720);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Burada Olan Kişilerin Sayısı:";
            // 
            // lbl_kisi_sayisi
            // 
            this.lbl_kisi_sayisi.AutoSize = true;
            this.lbl_kisi_sayisi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kisi_sayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kisi_sayisi.ForeColor = System.Drawing.Color.Black;
            this.lbl_kisi_sayisi.Location = new System.Drawing.Point(431, 721);
            this.lbl_kisi_sayisi.Name = "lbl_kisi_sayisi";
            this.lbl_kisi_sayisi.Size = new System.Drawing.Size(17, 17);
            this.lbl_kisi_sayisi.TabIndex = 28;
            this.lbl_kisi_sayisi.Text = "0";
            // 
            // combo_Box_Sinif
            // 
            this.combo_Box_Sinif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Box_Sinif.FormattingEnabled = true;
            this.combo_Box_Sinif.Location = new System.Drawing.Point(213, 9);
            this.combo_Box_Sinif.Name = "combo_Box_Sinif";
            this.combo_Box_Sinif.Size = new System.Drawing.Size(545, 24);
            this.combo_Box_Sinif.TabIndex = 29;
            this.combo_Box_Sinif.SelectedIndexChanged += new System.EventHandler(this.combo_Box_Sinif_SelectedIndexChanged_1);
            // 
            // YokalmaSistemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 768);
            this.Controls.Add(this.combo_Box_Sinif);
            this.Controls.Add(this.lbl_kisi_sayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_view_var_olanlar);
            this.Controls.Add(this.btn_delList);
            this.Controls.Add(this.btn_control);
            this.Controls.Add(this.dataGrid_Liste);
            this.Controls.Add(this.pic_kucuk_res);
            this.Controls.Add(this.pic_kamera);
            this.Name = "YokalmaSistemi";
            this.Text = "YokalmaSistemi";
            ((System.ComponentModel.ISupportInitialize)(this.pic_kamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_kucuk_res)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_kamera;
        private System.Windows.Forms.PictureBox pic_kucuk_res;
        private System.Windows.Forms.DataGridView dataGrid_Liste;
        private System.Windows.Forms.Button btn_control;
        private System.Windows.Forms.Button btn_delList;
        private System.Windows.Forms.ListView list_view_var_olanlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_kisi_sayisi;
        private System.Windows.Forms.ComboBox combo_Box_Sinif;
    }
}