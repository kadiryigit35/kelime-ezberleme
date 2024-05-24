namespace kullanicigiriş
{
    partial class sinav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sinav));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnOku = new System.Windows.Forms.Button();
            this.txtTr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBitir = new System.Windows.Forms.Button();
            this.btnGec = new System.Windows.Forms.Button();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblKullaniciNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(12, 367);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(75, 23);
            this.btnBasla.TabIndex = 3;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnOku
            // 
            this.btnOku.FlatAppearance.BorderSize = 0;
            this.btnOku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOku.Image = ((System.Drawing.Image)(resources.GetObject("btnOku.Image")));
            this.btnOku.Location = new System.Drawing.Point(171, 288);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(63, 59);
            this.btnOku.TabIndex = 10;
            this.btnOku.UseVisualStyleBackColor = false;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // txtTr
            // 
            this.txtTr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTr.Location = new System.Drawing.Point(12, 306);
            this.txtTr.Name = "txtTr";
            this.txtTr.Size = new System.Drawing.Size(142, 22);
            this.txtTr.TabIndex = 11;
            this.txtTr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // btnBitir
            // 
            this.btnBitir.Location = new System.Drawing.Point(255, 367);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(75, 23);
            this.btnBitir.TabIndex = 13;
            this.btnBitir.Text = "Bitir";
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // btnGec
            // 
            this.btnGec.Location = new System.Drawing.Point(93, 367);
            this.btnGec.Name = "btnGec";
            this.btnGec.Size = new System.Drawing.Size(75, 23);
            this.btnGec.TabIndex = 14;
            this.btnGec.Text = "Geç";
            this.btnGec.UseVisualStyleBackColor = true;
            this.btnGec.Click += new System.EventHandler(this.btnGec_Click);
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(174, 367);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(75, 23);
            this.btnKontrol.TabIndex = 15;
            this.btnKontrol.Text = "Kontrol Et";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(119, 9);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(35, 13);
            this.lblKullaniciAdi.TabIndex = 16;
            this.lblKullaniciAdi.Text = "label2";
            // 
            // lblKullaniciNo
            // 
            this.lblKullaniciNo.AutoSize = true;
            this.lblKullaniciNo.Location = new System.Drawing.Point(119, 27);
            this.lblKullaniciNo.Name = "lblKullaniciNo";
            this.lblKullaniciNo.Size = new System.Drawing.Size(35, 13);
            this.lblKullaniciNo.TabIndex = 17;
            this.lblKullaniciNo.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Aktif Kullanıcı Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Aktif Kullanıcı NO :";
            // 
            // sinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(352, 452);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKullaniciNo);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.btnGec);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTr);
            this.Controls.Add(this.btnOku);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.pictureBox1);
            this.Name = "sinav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sinav";
            this.Load += new System.EventHandler(this.sinav_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnOku;
        private System.Windows.Forms.TextBox txtTr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.Button btnGec;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblKullaniciNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}