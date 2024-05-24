namespace kullanicigiriş
{
    partial class adminArayuz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminArayuz));
            this.ekleBtn = new System.Windows.Forms.Button();
            this.btnKullaniciGoruntule = new System.Windows.Forms.Button();
            this.btnOturumuKapat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(87, 204);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(119, 23);
            this.ekleBtn.TabIndex = 2;
            this.ekleBtn.Text = "Soru Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // btnKullaniciGoruntule
            // 
            this.btnKullaniciGoruntule.Location = new System.Drawing.Point(87, 175);
            this.btnKullaniciGoruntule.Name = "btnKullaniciGoruntule";
            this.btnKullaniciGoruntule.Size = new System.Drawing.Size(119, 23);
            this.btnKullaniciGoruntule.TabIndex = 3;
            this.btnKullaniciGoruntule.Text = "Kullanıcıları Görüntüle";
            this.btnKullaniciGoruntule.UseVisualStyleBackColor = true;
            this.btnKullaniciGoruntule.Click += new System.EventHandler(this.btnKullaniciGoruntule_Click);
            // 
            // btnOturumuKapat
            // 
            this.btnOturumuKapat.Location = new System.Drawing.Point(87, 233);
            this.btnOturumuKapat.Name = "btnOturumuKapat";
            this.btnOturumuKapat.Size = new System.Drawing.Size(119, 23);
            this.btnOturumuKapat.TabIndex = 4;
            this.btnOturumuKapat.Text = "Oturumu Kapat";
            this.btnOturumuKapat.UseVisualStyleBackColor = true;
            this.btnOturumuKapat.Click += new System.EventHandler(this.btnOturumuKapat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnKullaniciGoruntule);
            this.groupBox1.Controls.Add(this.btnOturumuKapat);
            this.groupBox1.Controls.Add(this.ekleBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 269);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // adminArayuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(318, 293);
            this.Controls.Add(this.groupBox1);
            this.Name = "adminArayuz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminArayuz";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Button btnKullaniciGoruntule;
        private System.Windows.Forms.Button btnOturumuKapat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}