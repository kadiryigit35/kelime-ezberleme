namespace kullanicigiriş
{
    partial class kullaniciArayuz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullaniciArayuz));
            this.baslaBtn = new System.Windows.Forms.Button();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.btnOturumuKapat = new System.Windows.Forms.Button();
            this.lblKullaniciNo = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // baslaBtn
            // 
            this.baslaBtn.Location = new System.Drawing.Point(60, 129);
            this.baslaBtn.Name = "baslaBtn";
            this.baslaBtn.Size = new System.Drawing.Size(119, 23);
            this.baslaBtn.TabIndex = 0;
            this.baslaBtn.Text = "Sınava Başla";
            this.baslaBtn.UseVisualStyleBackColor = true;
            this.baslaBtn.Click += new System.EventHandler(this.baslaBtn_Click);
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(60, 155);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(119, 23);
            this.ekleBtn.TabIndex = 1;
            this.ekleBtn.Text = "Soru Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // btnOturumuKapat
            // 
            this.btnOturumuKapat.Location = new System.Drawing.Point(60, 184);
            this.btnOturumuKapat.Name = "btnOturumuKapat";
            this.btnOturumuKapat.Size = new System.Drawing.Size(119, 23);
            this.btnOturumuKapat.TabIndex = 2;
            this.btnOturumuKapat.Text = "Oturumu Kapat";
            this.btnOturumuKapat.UseVisualStyleBackColor = true;
            this.btnOturumuKapat.Click += new System.EventHandler(this.btnOturumuKapat_Click);
            // 
            // lblKullaniciNo
            // 
            this.lblKullaniciNo.AutoSize = true;
            this.lblKullaniciNo.Location = new System.Drawing.Point(106, 253);
            this.lblKullaniciNo.Name = "lblKullaniciNo";
            this.lblKullaniciNo.Size = new System.Drawing.Size(35, 13);
            this.lblKullaniciNo.TabIndex = 19;
            this.lblKullaniciNo.Text = "label2";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(106, 225);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(35, 13);
            this.lblKullaniciAdi.TabIndex = 18;
            this.lblKullaniciAdi.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Aktif Kullanıcı Adı :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.baslaBtn);
            this.groupBox1.Controls.Add(this.ekleBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblKullaniciNo);
            this.groupBox1.Controls.Add(this.btnOturumuKapat);
            this.groupBox1.Controls.Add(this.lblKullaniciAdi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 275);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Aktif Kullanıcı NO  :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // kullaniciArayuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(260, 299);
            this.Controls.Add(this.groupBox1);
            this.Name = "kullaniciArayuz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "arayuz";
            this.Load += new System.EventHandler(this.kullaniciArayuz_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button baslaBtn;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Button btnOturumuKapat;
        private System.Windows.Forms.Label lblKullaniciNo;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}