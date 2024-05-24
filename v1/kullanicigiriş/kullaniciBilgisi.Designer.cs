namespace kullanicigiriş
{
    partial class kullaniciBilgisi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.istatistiklerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullanicilarDataSet12 = new kullanicigiriş.kullanicilarDataSet12();
            this.kelimelerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kullanicilarDataSet9 = new kullanicigiriş.kullanicilarDataSet9();
            this.bilinenTabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullanicilarDataSet3 = new kullanicigiriş.kullanicilarDataSet3();
            this.geriButton = new System.Windows.Forms.Button();
            this.bilinenTabloTableAdapter = new kullanicigiriş.kullanicilarDataSet3TableAdapters.bilinenTabloTableAdapter();
            this.kullanicilarDataSet8 = new kullanicigiriş.kullanicilarDataSet8();
            this.kelimelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kelimelerTableAdapter = new kullanicigiriş.kullanicilarDataSet8TableAdapters.KelimelerTableAdapter();
            this.kelimelerTableAdapter1 = new kullanicigiriş.kullanicilarDataSet9TableAdapters.KelimelerTableAdapter();
            this.istatistiklerTableAdapter = new kullanicigiriş.kullanicilarDataSet12TableAdapters.istatistiklerTableAdapter();
            this.kelimeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ezberSeviyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hatırlatmaTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ezberTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ezberAyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ezberDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.istatistiklerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimelerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilinenTabloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimelerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kelimeNoDataGridViewTextBoxColumn,
            this.kullaniciNoDataGridViewTextBoxColumn,
            this.ezberSeviyeDataGridViewTextBoxColumn,
            this.hatırlatmaTarihiDataGridViewTextBoxColumn,
            this.ezberTarihiDataGridViewTextBoxColumn,
            this.ezberAyDataGridViewTextBoxColumn,
            this.ezberDurumDataGridViewCheckBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.istatistiklerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(728, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // istatistiklerBindingSource
            // 
            this.istatistiklerBindingSource.DataMember = "istatistikler";
            this.istatistiklerBindingSource.DataSource = this.kullanicilarDataSet12;
            // 
            // kullanicilarDataSet12
            // 
            this.kullanicilarDataSet12.DataSetName = "kullanicilarDataSet12";
            this.kullanicilarDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kelimelerBindingSource1
            // 
            this.kelimelerBindingSource1.DataMember = "Kelimeler";
            this.kelimelerBindingSource1.DataSource = this.kullanicilarDataSet9;
            // 
            // kullanicilarDataSet9
            // 
            this.kullanicilarDataSet9.DataSetName = "kullanicilarDataSet9";
            this.kullanicilarDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bilinenTabloBindingSource
            // 
            this.bilinenTabloBindingSource.DataMember = "bilinenTablo";
            this.bilinenTabloBindingSource.DataSource = this.kullanicilarDataSet3;
            // 
            // kullanicilarDataSet3
            // 
            this.kullanicilarDataSet3.DataSetName = "kullanicilarDataSet3";
            this.kullanicilarDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // geriButton
            // 
            this.geriButton.BackColor = System.Drawing.Color.Transparent;
            this.geriButton.FlatAppearance.BorderSize = 0;
            this.geriButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geriButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.geriButton.Location = new System.Drawing.Point(9, 165);
            this.geriButton.Margin = new System.Windows.Forms.Padding(0);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(61, 43);
            this.geriButton.TabIndex = 5;
            this.geriButton.Text = "◀️ Geri";
            this.geriButton.UseVisualStyleBackColor = false;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // bilinenTabloTableAdapter
            // 
            this.bilinenTabloTableAdapter.ClearBeforeFill = true;
            // 
            // kullanicilarDataSet8
            // 
            this.kullanicilarDataSet8.DataSetName = "kullanicilarDataSet8";
            this.kullanicilarDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kelimelerBindingSource
            // 
            this.kelimelerBindingSource.DataMember = "Kelimeler";
            this.kelimelerBindingSource.DataSource = this.kullanicilarDataSet8;
            // 
            // kelimelerTableAdapter
            // 
            this.kelimelerTableAdapter.ClearBeforeFill = true;
            // 
            // kelimelerTableAdapter1
            // 
            this.kelimelerTableAdapter1.ClearBeforeFill = true;
            // 
            // istatistiklerTableAdapter
            // 
            this.istatistiklerTableAdapter.ClearBeforeFill = true;
            // 
            // kelimeNoDataGridViewTextBoxColumn
            // 
            this.kelimeNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.kelimeNoDataGridViewTextBoxColumn.DataPropertyName = "kelimeNo";
            this.kelimeNoDataGridViewTextBoxColumn.HeaderText = "kelimeNo";
            this.kelimeNoDataGridViewTextBoxColumn.Name = "kelimeNoDataGridViewTextBoxColumn";
            this.kelimeNoDataGridViewTextBoxColumn.Width = 76;
            // 
            // kullaniciNoDataGridViewTextBoxColumn
            // 
            this.kullaniciNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kullaniciNoDataGridViewTextBoxColumn.DataPropertyName = "kullaniciNo";
            this.kullaniciNoDataGridViewTextBoxColumn.HeaderText = "kullaniciNo";
            this.kullaniciNoDataGridViewTextBoxColumn.Name = "kullaniciNoDataGridViewTextBoxColumn";
            // 
            // ezberSeviyeDataGridViewTextBoxColumn
            // 
            this.ezberSeviyeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ezberSeviyeDataGridViewTextBoxColumn.DataPropertyName = "EzberSeviye";
            this.ezberSeviyeDataGridViewTextBoxColumn.HeaderText = "EzberSeviye";
            this.ezberSeviyeDataGridViewTextBoxColumn.Name = "ezberSeviyeDataGridViewTextBoxColumn";
            // 
            // hatırlatmaTarihiDataGridViewTextBoxColumn
            // 
            this.hatırlatmaTarihiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hatırlatmaTarihiDataGridViewTextBoxColumn.DataPropertyName = "HatırlatmaTarihi";
            this.hatırlatmaTarihiDataGridViewTextBoxColumn.HeaderText = "HatırlatmaTarihi";
            this.hatırlatmaTarihiDataGridViewTextBoxColumn.Name = "hatırlatmaTarihiDataGridViewTextBoxColumn";
            // 
            // ezberTarihiDataGridViewTextBoxColumn
            // 
            this.ezberTarihiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ezberTarihiDataGridViewTextBoxColumn.DataPropertyName = "EzberTarihi";
            this.ezberTarihiDataGridViewTextBoxColumn.HeaderText = "EzberTarihi";
            this.ezberTarihiDataGridViewTextBoxColumn.Name = "ezberTarihiDataGridViewTextBoxColumn";
            // 
            // ezberAyDataGridViewTextBoxColumn
            // 
            this.ezberAyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ezberAyDataGridViewTextBoxColumn.DataPropertyName = "EzberAy";
            this.ezberAyDataGridViewTextBoxColumn.HeaderText = "EzberAy";
            this.ezberAyDataGridViewTextBoxColumn.Name = "ezberAyDataGridViewTextBoxColumn";
            this.ezberAyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ezberDurumDataGridViewCheckBoxColumn
            // 
            this.ezberDurumDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ezberDurumDataGridViewCheckBoxColumn.DataPropertyName = "EzberDurum";
            this.ezberDurumDataGridViewCheckBoxColumn.HeaderText = "EzberDurum";
            this.ezberDurumDataGridViewCheckBoxColumn.Name = "ezberDurumDataGridViewCheckBoxColumn";
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // kullaniciBilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(752, 213);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kullaniciBilgisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kullaniciBilgisi";
            this.Load += new System.EventHandler(this.kullaniciBilgisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.istatistiklerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimelerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilinenTabloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimelerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button geriButton;
        private kullanicilarDataSet3 kullanicilarDataSet3;
        private System.Windows.Forms.BindingSource bilinenTabloBindingSource;
        private kullanicilarDataSet3TableAdapters.bilinenTabloTableAdapter bilinenTabloTableAdapter;
        private kullanicilarDataSet8 kullanicilarDataSet8;
        private System.Windows.Forms.BindingSource kelimelerBindingSource;
        private kullanicilarDataSet8TableAdapters.KelimelerTableAdapter kelimelerTableAdapter;
        private kullanicilarDataSet9 kullanicilarDataSet9;
        private System.Windows.Forms.BindingSource kelimelerBindingSource1;
        private kullanicilarDataSet9TableAdapters.KelimelerTableAdapter kelimelerTableAdapter1;
        private kullanicilarDataSet12 kullanicilarDataSet12;
        private System.Windows.Forms.BindingSource istatistiklerBindingSource;
        private kullanicilarDataSet12TableAdapters.istatistiklerTableAdapter istatistiklerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kelimeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ezberSeviyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hatırlatmaTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ezberTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ezberAyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ezberDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
    }
}