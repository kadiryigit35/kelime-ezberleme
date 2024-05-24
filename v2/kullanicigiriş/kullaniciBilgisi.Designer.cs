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
            this.soruNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilinmeSayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilinmeTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilinenTabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullanicilarDataSet3 = new kullanicigiriş.kullanicilarDataSet3();
            this.geriButton = new System.Windows.Forms.Button();
            this.bilinenTabloTableAdapter = new kullanicigiriş.kullanicilarDataSet3TableAdapters.bilinenTabloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilinenTabloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soruNoDataGridViewTextBoxColumn,
            this.kullaniciNoDataGridViewTextBoxColumn,
            this.bilinmeSayısıDataGridViewTextBoxColumn,
            this.bilinmeTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bilinenTabloBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(423, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // soruNoDataGridViewTextBoxColumn
            // 
            this.soruNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.soruNoDataGridViewTextBoxColumn.DataPropertyName = "soruNo";
            this.soruNoDataGridViewTextBoxColumn.HeaderText = "soruNo";
            this.soruNoDataGridViewTextBoxColumn.Name = "soruNoDataGridViewTextBoxColumn";
            this.soruNoDataGridViewTextBoxColumn.Width = 66;
            // 
            // kullaniciNoDataGridViewTextBoxColumn
            // 
            this.kullaniciNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kullaniciNoDataGridViewTextBoxColumn.DataPropertyName = "kullaniciNo";
            this.kullaniciNoDataGridViewTextBoxColumn.HeaderText = "kullaniciNo";
            this.kullaniciNoDataGridViewTextBoxColumn.Name = "kullaniciNoDataGridViewTextBoxColumn";
            // 
            // bilinmeSayısıDataGridViewTextBoxColumn
            // 
            this.bilinmeSayısıDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bilinmeSayısıDataGridViewTextBoxColumn.DataPropertyName = "bilinmeSayısı";
            this.bilinmeSayısıDataGridViewTextBoxColumn.HeaderText = "bilinmeSayısı";
            this.bilinmeSayısıDataGridViewTextBoxColumn.Name = "bilinmeSayısıDataGridViewTextBoxColumn";
            // 
            // bilinmeTarihiDataGridViewTextBoxColumn
            // 
            this.bilinmeTarihiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bilinmeTarihiDataGridViewTextBoxColumn.DataPropertyName = "bilinmeTarihi";
            this.bilinmeTarihiDataGridViewTextBoxColumn.HeaderText = "bilinmeTarihi";
            this.bilinmeTarihiDataGridViewTextBoxColumn.Name = "bilinmeTarihiDataGridViewTextBoxColumn";
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
            // kullaniciBilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 207);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kullaniciBilgisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kullaniciBilgisi";
            this.Load += new System.EventHandler(this.kullaniciBilgisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilinenTabloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button geriButton;
        private kullanicilarDataSet3 kullanicilarDataSet3;
        private System.Windows.Forms.BindingSource bilinenTabloBindingSource;
        private kullanicilarDataSet3TableAdapters.bilinenTabloTableAdapter bilinenTabloTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn soruNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilinmeSayısıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilinmeTarihiDataGridViewTextBoxColumn;
    }
}