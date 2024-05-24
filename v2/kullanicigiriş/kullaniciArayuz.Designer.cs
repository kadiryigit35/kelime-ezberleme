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
            this.baslaBtn = new System.Windows.Forms.Button();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.btnOturumuKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // baslaBtn
            // 
            this.baslaBtn.Location = new System.Drawing.Point(72, 142);
            this.baslaBtn.Name = "baslaBtn";
            this.baslaBtn.Size = new System.Drawing.Size(119, 23);
            this.baslaBtn.TabIndex = 0;
            this.baslaBtn.Text = "Sınava Başla";
            this.baslaBtn.UseVisualStyleBackColor = true;
            this.baslaBtn.Click += new System.EventHandler(this.baslaBtn_Click);
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(72, 171);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(119, 23);
            this.ekleBtn.TabIndex = 1;
            this.ekleBtn.Text = "Soru Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // btnOturumuKapat
            // 
            this.btnOturumuKapat.Location = new System.Drawing.Point(72, 200);
            this.btnOturumuKapat.Name = "btnOturumuKapat";
            this.btnOturumuKapat.Size = new System.Drawing.Size(119, 23);
            this.btnOturumuKapat.TabIndex = 2;
            this.btnOturumuKapat.Text = "Oturumu Kapat";
            this.btnOturumuKapat.UseVisualStyleBackColor = true;
            this.btnOturumuKapat.Click += new System.EventHandler(this.btnOturumuKapat_Click);
            // 
            // kullaniciArayuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 299);
            this.Controls.Add(this.btnOturumuKapat);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.baslaBtn);
            this.Name = "kullaniciArayuz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "arayuz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button baslaBtn;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Button btnOturumuKapat;
    }
}