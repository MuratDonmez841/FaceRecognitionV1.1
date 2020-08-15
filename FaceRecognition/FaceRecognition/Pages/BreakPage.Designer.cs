namespace FaceRecognition.Pages
{
    partial class BreakPage
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
            this.btn_ogrKayit = new System.Windows.Forms.Button();
            this.btn_Sinifkayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ogrKayit
            // 
            this.btn_ogrKayit.Location = new System.Drawing.Point(201, 200);
            this.btn_ogrKayit.Name = "btn_ogrKayit";
            this.btn_ogrKayit.Size = new System.Drawing.Size(271, 152);
            this.btn_ogrKayit.TabIndex = 0;
            this.btn_ogrKayit.Text = "Öğrenci Kayıt";
            this.btn_ogrKayit.UseVisualStyleBackColor = true;
            this.btn_ogrKayit.Click += new System.EventHandler(this.btn_ogrKayit_Click);
            // 
            // btn_Sinifkayit
            // 
            this.btn_Sinifkayit.Location = new System.Drawing.Point(539, 200);
            this.btn_Sinifkayit.Name = "btn_Sinifkayit";
            this.btn_Sinifkayit.Size = new System.Drawing.Size(271, 152);
            this.btn_Sinifkayit.TabIndex = 1;
            this.btn_Sinifkayit.Text = "Sınıf Kayıt";
            this.btn_Sinifkayit.UseVisualStyleBackColor = true;
            this.btn_Sinifkayit.Click += new System.EventHandler(this.btn_Sinifkayit_Click);
            // 
            // BreakPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 663);
            this.Controls.Add(this.btn_Sinifkayit);
            this.Controls.Add(this.btn_ogrKayit);
            this.Name = "BreakPage";
            this.Text = "BreakPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ogrKayit;
        private System.Windows.Forms.Button btn_Sinifkayit;
    }
}