namespace kullanicigiriş
{
    partial class sUnuttum
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.ileriBtn = new System.Windows.Forms.Button();
            this.geriButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adını Giriniz";
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(59, 70);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(144, 20);
            this.TxtKullaniciAdi.TabIndex = 1;
            // 
            // ileriBtn
            // 
            this.ileriBtn.Location = new System.Drawing.Point(95, 165);
            this.ileriBtn.Name = "ileriBtn";
            this.ileriBtn.Size = new System.Drawing.Size(64, 23);
            this.ileriBtn.TabIndex = 3;
            this.ileriBtn.Text = "İleri";
            this.ileriBtn.UseVisualStyleBackColor = true;
            this.ileriBtn.Click += new System.EventHandler(this.ileriBtn_Click);
            // 
            // geriButton
            // 
            this.geriButton.BackColor = System.Drawing.Color.Transparent;
            this.geriButton.FlatAppearance.BorderSize = 0;
            this.geriButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geriButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.geriButton.Location = new System.Drawing.Point(3, 194);
            this.geriButton.Margin = new System.Windows.Forms.Padding(0);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(61, 43);
            this.geriButton.TabIndex = 4;
            this.geriButton.Text = "◀️ Geri";
            this.geriButton.UseVisualStyleBackColor = false;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtMail);
            this.groupBox1.Controls.Add(this.geriButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ileriBtn);
            this.groupBox1.Controls.Add(this.TxtKullaniciAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 237);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifre Yenileme";
            // 
            // TxtMail
            // 
            this.TxtMail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtMail.Location = new System.Drawing.Point(59, 128);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(144, 20);
            this.TxtMail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mail Adresini Giriniz";
            // 
            // sUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(280, 257);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(296, 296);
            this.MinimumSize = new System.Drawing.Size(296, 296);
            this.Name = "sUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifremi unuttum";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
        private System.Windows.Forms.Button ileriBtn;
        private System.Windows.Forms.Button geriButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label2;
    }
}