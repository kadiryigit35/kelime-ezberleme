namespace kullanicigiriş
{
    partial class soruEkleme
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSoruNo = new System.Windows.Forms.TextBox();
            this.TxtCevap = new System.Windows.Forms.TextBox();
            this.TxtSoru = new System.Windows.Forms.TextBox();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.TxtResim = new System.Windows.Forms.TextBox();
            this.gBtn = new System.Windows.Forms.Button();
            this.gozatBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.soruNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cevapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sorularTabloBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kullanicilarDataSet2 = new kullanicigiriş.kullanicilarDataSet2();
            this.sorularTabloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kullanicilarDataSet1 = new kullanicigiriş.kullanicilarDataSet1();
            this.sorularTabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullanicilarDataSet = new kullanicigiriş.kullanicilarDataSet();
            this.sorularTabloTableAdapter = new kullanicigiriş.kullanicilarDataSetTableAdapters.sorularTabloTableAdapter();
            this.sorularTabloTableAdapter1 = new kullanicigiriş.kullanicilarDataSet1TableAdapters.sorularTabloTableAdapter();
            this.sorularTabloTableAdapter2 = new kullanicigiriş.kullanicilarDataSet2TableAdapters.sorularTabloTableAdapter();
            this.geriButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorularTabloBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorularTabloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorularTabloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soru No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soru :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cevap :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resim :";
            // 
            // TxtSoruNo
            // 
            this.TxtSoruNo.Location = new System.Drawing.Point(94, 36);
            this.TxtSoruNo.Name = "TxtSoruNo";
            this.TxtSoruNo.Size = new System.Drawing.Size(100, 20);
            this.TxtSoruNo.TabIndex = 1;
            // 
            // TxtCevap
            // 
            this.TxtCevap.Location = new System.Drawing.Point(94, 108);
            this.TxtCevap.Name = "TxtCevap";
            this.TxtCevap.Size = new System.Drawing.Size(100, 20);
            this.TxtCevap.TabIndex = 3;
            // 
            // TxtSoru
            // 
            this.TxtSoru.Location = new System.Drawing.Point(94, 74);
            this.TxtSoru.Name = "TxtSoru";
            this.TxtSoru.Size = new System.Drawing.Size(100, 20);
            this.TxtSoru.TabIndex = 2;
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(94, 182);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(75, 23);
            this.ekleBtn.TabIndex = 6;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // TxtResim
            // 
            this.TxtResim.Location = new System.Drawing.Point(94, 140);
            this.TxtResim.Name = "TxtResim";
            this.TxtResim.Size = new System.Drawing.Size(100, 20);
            this.TxtResim.TabIndex = 4;
            // 
            // gBtn
            // 
            this.gBtn.Location = new System.Drawing.Point(94, 223);
            this.gBtn.Name = "gBtn";
            this.gBtn.Size = new System.Drawing.Size(75, 23);
            this.gBtn.TabIndex = 7;
            this.gBtn.Text = "Güncelle";
            this.gBtn.UseVisualStyleBackColor = true;
            this.gBtn.Click += new System.EventHandler(this.gBtn_Click);
            // 
            // gozatBtn
            // 
            this.gozatBtn.Location = new System.Drawing.Point(200, 140);
            this.gozatBtn.Name = "gozatBtn";
            this.gozatBtn.Size = new System.Drawing.Size(26, 20);
            this.gozatBtn.TabIndex = 5;
            this.gozatBtn.Text = "...";
            this.gozatBtn.UseVisualStyleBackColor = true;
            this.gozatBtn.Click += new System.EventHandler(this.gozatBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtCevap);
            this.groupBox1.Controls.Add(this.gozatBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtResim);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ekleBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtSoru);
            this.groupBox1.Controls.Add(this.TxtSoruNo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 275);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Soru Ekleme";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(289, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 195);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soruNoDataGridViewTextBoxColumn,
            this.soruDataGridViewTextBoxColumn,
            this.cevapDataGridViewTextBoxColumn,
            this.resimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sorularTabloBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 186);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // soruNoDataGridViewTextBoxColumn
            // 
            this.soruNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.soruNoDataGridViewTextBoxColumn.DataPropertyName = "soruNo";
            this.soruNoDataGridViewTextBoxColumn.HeaderText = "soruNo";
            this.soruNoDataGridViewTextBoxColumn.Name = "soruNoDataGridViewTextBoxColumn";
            this.soruNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.soruNoDataGridViewTextBoxColumn.Width = 66;
            // 
            // soruDataGridViewTextBoxColumn
            // 
            this.soruDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soruDataGridViewTextBoxColumn.DataPropertyName = "soru";
            this.soruDataGridViewTextBoxColumn.HeaderText = "soru";
            this.soruDataGridViewTextBoxColumn.Name = "soruDataGridViewTextBoxColumn";
            // 
            // cevapDataGridViewTextBoxColumn
            // 
            this.cevapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cevapDataGridViewTextBoxColumn.DataPropertyName = "cevap";
            this.cevapDataGridViewTextBoxColumn.HeaderText = "cevap";
            this.cevapDataGridViewTextBoxColumn.Name = "cevapDataGridViewTextBoxColumn";
            // 
            // resimDataGridViewTextBoxColumn
            // 
            this.resimDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.resimDataGridViewTextBoxColumn.DataPropertyName = "resim";
            this.resimDataGridViewTextBoxColumn.HeaderText = "resim";
            this.resimDataGridViewTextBoxColumn.Name = "resimDataGridViewTextBoxColumn";
            // 
            // sorularTabloBindingSource2
            // 
            this.sorularTabloBindingSource2.DataMember = "sorularTablo";
            this.sorularTabloBindingSource2.DataSource = this.kullanicilarDataSet2;
            // 
            // kullanicilarDataSet2
            // 
            this.kullanicilarDataSet2.DataSetName = "kullanicilarDataSet2";
            this.kullanicilarDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sorularTabloBindingSource1
            // 
            this.sorularTabloBindingSource1.DataMember = "sorularTablo";
            this.sorularTabloBindingSource1.DataSource = this.kullanicilarDataSet1;
            // 
            // kullanicilarDataSet1
            // 
            this.kullanicilarDataSet1.DataSetName = "kullanicilarDataSet1";
            this.kullanicilarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sorularTabloBindingSource
            // 
            this.sorularTabloBindingSource.DataMember = "sorularTablo";
            this.sorularTabloBindingSource.DataSource = this.kullanicilarDataSet;
            // 
            // kullanicilarDataSet
            // 
            this.kullanicilarDataSet.DataSetName = "kullanicilarDataSet";
            this.kullanicilarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sorularTabloTableAdapter
            // 
            this.sorularTabloTableAdapter.ClearBeforeFill = true;
            // 
            // sorularTabloTableAdapter1
            // 
            this.sorularTabloTableAdapter1.ClearBeforeFill = true;
            // 
            // sorularTabloTableAdapter2
            // 
            this.sorularTabloTableAdapter2.ClearBeforeFill = true;
            // 
            // geriButton
            // 
            this.geriButton.BackColor = System.Drawing.Color.Transparent;
            this.geriButton.FlatAppearance.BorderSize = 0;
            this.geriButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geriButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.geriButton.Location = new System.Drawing.Point(12, 482);
            this.geriButton.Margin = new System.Windows.Forms.Padding(0);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(61, 43);
            this.geriButton.TabIndex = 14;
            this.geriButton.Text = "◀️ Geri";
            this.geriButton.UseVisualStyleBackColor = false;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // soruEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(647, 533);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "soruEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.soruEkleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorularTabloBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorularTabloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorularTabloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSoruNo;
        private System.Windows.Forms.TextBox TxtCevap;
        private System.Windows.Forms.TextBox TxtSoru;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.TextBox TxtResim;
        private System.Windows.Forms.Button gBtn;
        private System.Windows.Forms.Button gozatBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kullanicilarDataSet kullanicilarDataSet;
        private System.Windows.Forms.BindingSource sorularTabloBindingSource;
        private kullanicilarDataSetTableAdapters.sorularTabloTableAdapter sorularTabloTableAdapter;
        private kullanicilarDataSet1 kullanicilarDataSet1;
        private System.Windows.Forms.BindingSource sorularTabloBindingSource1;
        private kullanicilarDataSet1TableAdapters.sorularTabloTableAdapter sorularTabloTableAdapter1;
        private kullanicilarDataSet2 kullanicilarDataSet2;
        private System.Windows.Forms.BindingSource sorularTabloBindingSource2;
        private kullanicilarDataSet2TableAdapters.sorularTabloTableAdapter sorularTabloTableAdapter2;
        private System.Windows.Forms.Button geriButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn soruNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cevapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimDataGridViewTextBoxColumn;
    }
}