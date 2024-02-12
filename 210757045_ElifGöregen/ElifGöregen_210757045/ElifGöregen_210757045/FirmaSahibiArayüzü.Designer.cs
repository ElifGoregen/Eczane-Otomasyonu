namespace ElifGöregen_210757045
{
    partial class FirmaSahibiArayüzü
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirmaSahibiArayüzü));
            this.ComboBoxSigortaTürü = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxToplamFiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCiroHesapla = new System.Windows.Forms.Button();
            this.btnİlacBilgisiGoster = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxilacadedi = new System.Windows.Forms.TextBox();
            this.textBoxilacadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ilactakipDataSet3 = new ElifGöregen_210757045.ilactakipDataSet3();
            this.tblilacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ilacTableAdapter = new ElifGöregen_210757045.ilactakipDataSet3TableAdapters.Tbl_ilacTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recetekoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacsirketiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacadediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacucretiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilactarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilactakipDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblilacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxSigortaTürü
            // 
            this.ComboBoxSigortaTürü.FormattingEnabled = true;
            this.ComboBoxSigortaTürü.Items.AddRange(new object[] {
            "SGK",
            "Bağkur",
            "Özel",
            "Yok"});
            this.ComboBoxSigortaTürü.Location = new System.Drawing.Point(138, 115);
            this.ComboBoxSigortaTürü.Name = "ComboBoxSigortaTürü";
            this.ComboBoxSigortaTürü.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxSigortaTürü.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Sigorta Türü:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ilacadiDataGridViewTextBoxColumn,
            this.recetekoduDataGridViewTextBoxColumn,
            this.ilacsirketiDataGridViewTextBoxColumn,
            this.ilacadediDataGridViewTextBoxColumn,
            this.ilacucretiDataGridViewTextBoxColumn,
            this.ilactarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblilacBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(733, 137);
            this.dataGridView1.TabIndex = 32;
            // 
            // textBoxToplamFiyat
            // 
            this.textBoxToplamFiyat.Location = new System.Drawing.Point(138, 78);
            this.textBoxToplamFiyat.Name = "textBoxToplamFiyat";
            this.textBoxToplamFiyat.Size = new System.Drawing.Size(121, 20);
            this.textBoxToplamFiyat.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Toplam Fiyat :";
            // 
            // buttonCiroHesapla
            // 
            this.buttonCiroHesapla.Location = new System.Drawing.Point(42, 160);
            this.buttonCiroHesapla.Name = "buttonCiroHesapla";
            this.buttonCiroHesapla.Size = new System.Drawing.Size(186, 55);
            this.buttonCiroHesapla.TabIndex = 29;
            this.buttonCiroHesapla.Text = "Ciro Hesapla";
            this.buttonCiroHesapla.UseVisualStyleBackColor = true;
            this.buttonCiroHesapla.Click += new System.EventHandler(this.buttonCiroHesapla_Click);
            // 
            // btnİlacBilgisiGoster
            // 
            this.btnİlacBilgisiGoster.Location = new System.Drawing.Point(42, 221);
            this.btnİlacBilgisiGoster.Name = "btnİlacBilgisiGoster";
            this.btnİlacBilgisiGoster.Size = new System.Drawing.Size(186, 56);
            this.btnİlacBilgisiGoster.TabIndex = 28;
            this.btnİlacBilgisiGoster.Text = "İlaç Bilgisi Göster";
            this.btnİlacBilgisiGoster.UseVisualStyleBackColor = true;
            this.btnİlacBilgisiGoster.Click += new System.EventHandler(this.btnİlacBilgisiGoster_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxilacadedi
            // 
            this.textBoxilacadedi.Location = new System.Drawing.Point(138, 47);
            this.textBoxilacadedi.Name = "textBoxilacadedi";
            this.textBoxilacadedi.Size = new System.Drawing.Size(121, 20);
            this.textBoxilacadedi.TabIndex = 26;
            // 
            // textBoxilacadi
            // 
            this.textBoxilacadi.Location = new System.Drawing.Point(138, 10);
            this.textBoxilacadi.Name = "textBoxilacadi";
            this.textBoxilacadi.Size = new System.Drawing.Size(121, 20);
            this.textBoxilacadi.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(30, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "İlaç Adedi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "İlaç Adı:";
            // 
            // ilactakipDataSet3
            // 
            this.ilactakipDataSet3.DataSetName = "ilactakipDataSet3";
            this.ilactakipDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblilacBindingSource
            // 
            this.tblilacBindingSource.DataMember = "Tbl_ilac";
            this.tblilacBindingSource.DataSource = this.ilactakipDataSet3;
            // 
            // tbl_ilacTableAdapter
            // 
            this.tbl_ilacTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // ilacadiDataGridViewTextBoxColumn
            // 
            this.ilacadiDataGridViewTextBoxColumn.DataPropertyName = "ilacadi";
            this.ilacadiDataGridViewTextBoxColumn.HeaderText = "ilacadi";
            this.ilacadiDataGridViewTextBoxColumn.Name = "ilacadiDataGridViewTextBoxColumn";
            // 
            // recetekoduDataGridViewTextBoxColumn
            // 
            this.recetekoduDataGridViewTextBoxColumn.DataPropertyName = "recetekodu";
            this.recetekoduDataGridViewTextBoxColumn.HeaderText = "recetekodu";
            this.recetekoduDataGridViewTextBoxColumn.Name = "recetekoduDataGridViewTextBoxColumn";
            // 
            // ilacsirketiDataGridViewTextBoxColumn
            // 
            this.ilacsirketiDataGridViewTextBoxColumn.DataPropertyName = "ilacsirketi";
            this.ilacsirketiDataGridViewTextBoxColumn.HeaderText = "ilacsirketi";
            this.ilacsirketiDataGridViewTextBoxColumn.Name = "ilacsirketiDataGridViewTextBoxColumn";
            // 
            // ilacadediDataGridViewTextBoxColumn
            // 
            this.ilacadediDataGridViewTextBoxColumn.DataPropertyName = "ilacadedi";
            this.ilacadediDataGridViewTextBoxColumn.HeaderText = "ilacadedi";
            this.ilacadediDataGridViewTextBoxColumn.Name = "ilacadediDataGridViewTextBoxColumn";
            // 
            // ilacucretiDataGridViewTextBoxColumn
            // 
            this.ilacucretiDataGridViewTextBoxColumn.DataPropertyName = "ilacucreti";
            this.ilacucretiDataGridViewTextBoxColumn.HeaderText = "ilacucreti";
            this.ilacucretiDataGridViewTextBoxColumn.Name = "ilacucretiDataGridViewTextBoxColumn";
            // 
            // ilactarihiDataGridViewTextBoxColumn
            // 
            this.ilactarihiDataGridViewTextBoxColumn.DataPropertyName = "ilactarihi";
            this.ilactarihiDataGridViewTextBoxColumn.HeaderText = "ilactarihi";
            this.ilactarihiDataGridViewTextBoxColumn.Name = "ilactarihiDataGridViewTextBoxColumn";
            // 
            // FirmaSahibiArayüzü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(741, 442);
            this.Controls.Add(this.ComboBoxSigortaTürü);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxToplamFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCiroHesapla);
            this.Controls.Add(this.btnİlacBilgisiGoster);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxilacadedi);
            this.Controls.Add(this.textBoxilacadi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "FirmaSahibiArayüzü";
            this.Text = "FirmaSahibiArayüzü";
            this.Load += new System.EventHandler(this.FirmaSahibiArayüzü_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilactakipDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblilacBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxSigortaTürü;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxToplamFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCiroHesapla;
        private System.Windows.Forms.Button btnİlacBilgisiGoster;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxilacadedi;
        private System.Windows.Forms.TextBox textBoxilacadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private ilactakipDataSet3 ilactakipDataSet3;
        private System.Windows.Forms.BindingSource tblilacBindingSource;
        private ilactakipDataSet3TableAdapters.Tbl_ilacTableAdapter tbl_ilacTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recetekoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacsirketiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacadediDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacucretiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilactarihiDataGridViewTextBoxColumn;
    }
}