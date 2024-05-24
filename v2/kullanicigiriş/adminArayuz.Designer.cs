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
            this.ekleBtn = new System.Windows.Forms.Button();
            this.btnKullaniciGoruntule = new System.Windows.Forms.Button();
            this.btnOturumuKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(95, 201);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(119, 23);
            this.ekleBtn.TabIndex = 2;
            this.ekleBtn.Text = "Soru Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // btnKullaniciGoruntule
            // 
            this.btnKullaniciGoruntule.Location = new System.Drawing.Point(95, 172);
            this.btnKullaniciGoruntule.Name = "btnKullaniciGoruntule";
            this.btnKullaniciGoruntule.Size = new System.Drawing.Size(119, 23);
            this.btnKullaniciGoruntule.TabIndex = 3;
            this.btnKullaniciGoruntule.Text = "Kullanıcıları Görüntüle";
            this.btnKullaniciGoruntule.UseVisualStyleBackColor = true;
            this.btnKullaniciGoruntule.Click += new System.EventHandler(this.btnKullaniciGoruntule_Click);
            // 
            // btnOturumuKapat
            // 
            this.btnOturumuKapat.Location = new System.Drawing.Point(95, 230);
            this.btnOturumuKapat.Name = "btnOturumuKapat";
            this.btnOturumuKapat.Size = new System.Drawing.Size(119, 23);
            this.btnOturumuKapat.TabIndex = 4;
            this.btnOturumuKapat.Text = "Oturumu Kapat";
            this.btnOturumuKapat.UseVisualStyleBackColor = true;
            this.btnOturumuKapat.Click += new System.EventHandler(this.btnOturumuKapat_Click);
            // 
            // adminArayuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 293);
            this.Controls.Add(this.btnOturumuKapat);
            this.Controls.Add(this.btnKullaniciGoruntule);
            this.Controls.Add(this.ekleBtn);
            this.Name = "adminArayuz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminArayuz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Button btnKullaniciGoruntule;
        private System.Windows.Forms.Button btnOturumuKapat;
    }
}