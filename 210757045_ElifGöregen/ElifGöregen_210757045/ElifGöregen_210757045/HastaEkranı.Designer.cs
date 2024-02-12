namespace ElifGöregen_210757045
{
    partial class HastaEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaEkranı));
            this.comboBoxSiralamaKriteri = new System.Windows.Forms.ComboBox();
            this.btnSırala = new System.Windows.Forms.Button();
            this.btnilacsuresisorgula = new System.Windows.Forms.Button();
            this.btnilacsorgusu = new System.Windows.Forms.Button();
            this.textRecetekoduu = new System.Windows.Forms.TextBox();
            this.textilacadii = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewIlaclar = new System.Windows.Forms.DataGridView();
            this.ilactakipDataSet1 = new ElifGöregen_210757045.ilactakipDataSet1();
            this.tblilacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ilacTableAdapter = new ElifGöregen_210757045.ilactakipDataSet1TableAdapters.Tbl_ilacTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recetekoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacsirketiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacadediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacucretiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilactarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIlaclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilactakipDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblilacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSiralamaKriteri
            // 
            this.comboBoxSiralamaKriteri.FormattingEnabled = true;
            this.comboBoxSiralamaKriteri.Location = new System.Drawing.Point(179, 176);
            this.comboBoxSiralamaKriteri.Name = "comboBoxSiralamaKriteri";
            this.comboBoxSiralamaKriteri.Size = new System.Drawing.Size(167, 21);
            this.comboBoxSiralamaKriteri.TabIndex = 22;
            // 
            // btnSırala
            // 
            this.btnSırala.Location = new System.Drawing.Point(8, 157);
            this.btnSırala.Name = "btnSırala";
            this.btnSırala.Size = new System.Drawing.Size(165, 52);
            this.btnSırala.TabIndex = 21;
            this.btnSırala.Text = "Sırala";
            this.btnSırala.UseVisualStyleBackColor = true;
            this.btnSırala.Click += new System.EventHandler(this.btnSırala_Click);
            // 
            // btnilacsuresisorgula
            // 
            this.btnilacsuresisorgula.Location = new System.Drawing.Point(179, 99);
            this.btnilacsuresisorgula.Name = "btnilacsuresisorgula";
            this.btnilacsuresisorgula.Size = new System.Drawing.Size(167, 51);
            this.btnilacsuresisorgula.TabIndex = 20;
            this.btnilacsuresisorgula.Text = "İlaç Süresi Sorgula";
            this.btnilacsuresisorgula.UseVisualStyleBackColor = true;
            this.btnilacsuresisorgula.Click += new System.EventHandler(this.btnilacsuresisorgula_Click);
            // 
            // btnilacsorgusu
            // 
            this.btnilacsorgusu.Location = new System.Drawing.Point(9, 98);
            this.btnilacsorgusu.Name = "btnilacsorgusu";
            this.btnilacsorgusu.Size = new System.Drawing.Size(164, 53);
            this.btnilacsorgusu.TabIndex = 19;
            this.btnilacsorgusu.Text = "İlaç Bilgisi Sorgula";
            this.btnilacsorgusu.UseVisualStyleBackColor = true;
            this.btnilacsorgusu.Click += new System.EventHandler(this.btnilacsorgusu_Click);
            // 
            // textRecetekoduu
            // 
            this.textRecetekoduu.Location = new System.Drawing.Point(191, 58);
            this.textRecetekoduu.Name = "textRecetekoduu";
            this.textRecetekoduu.Size = new System.Drawing.Size(128, 20);
            this.textRecetekoduu.TabIndex = 18;
            // 
            // textilacadii
            // 
            this.textilacadii.Location = new System.Drawing.Point(191, 11);
            this.textilacadii.Name = "textilacadii";
            this.textilacadii.Size = new System.Drawing.Size(128, 20);
            this.textilacadii.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Reçete kodu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "İlaç adı:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(377, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewIlaclar
            // 
            this.dataGridViewIlaclar.AllowUserToDeleteRows = false;
            this.dataGridViewIlaclar.AutoGenerateColumns = false;
            this.dataGridViewIlaclar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridViewIlaclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIlaclar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ilacadiDataGridViewTextBoxColumn,
            this.recetekoduDataGridViewTextBoxColumn,
            this.ilacsirketiDataGridViewTextBoxColumn,
            this.ilacadediDataGridViewTextBoxColumn,
            this.ilacucretiDataGridViewTextBoxColumn,
            this.ilactarihiDataGridViewTextBoxColumn});
            this.dataGridViewIlaclar.DataSource = this.tblilacBindingSource;
            this.dataGridViewIlaclar.GridColor = System.Drawing.Color.Black;
            this.dataGridViewIlaclar.Location = new System.Drawing.Point(30, 236);
            this.dataGridViewIlaclar.Name = "dataGridViewIlaclar";
            this.dataGridViewIlaclar.ReadOnly = true;
            this.dataGridViewIlaclar.Size = new System.Drawing.Size(616, 126);
            this.dataGridViewIlaclar.TabIndex = 24;
            // 
            // ilactakipDataSet1
            // 
            this.ilactakipDataSet1.DataSetName = "ilactakipDataSet1";
            this.ilactakipDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblilacBindingSource
            // 
            this.tblilacBindingSource.DataMember = "Tbl_ilac";
            this.tblilacBindingSource.DataSource = this.ilactakipDataSet1;
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
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ilacadiDataGridViewTextBoxColumn
            // 
            this.ilacadiDataGridViewTextBoxColumn.DataPropertyName = "ilacadi";
            this.ilacadiDataGridViewTextBoxColumn.HeaderText = "ilacadi";
            this.ilacadiDataGridViewTextBoxColumn.Name = "ilacadiDataGridViewTextBoxColumn";
            this.ilacadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recetekoduDataGridViewTextBoxColumn
            // 
            this.recetekoduDataGridViewTextBoxColumn.DataPropertyName = "recetekodu";
            this.recetekoduDataGridViewTextBoxColumn.HeaderText = "recetekodu";
            this.recetekoduDataGridViewTextBoxColumn.Name = "recetekoduDataGridViewTextBoxColumn";
            this.recetekoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ilacsirketiDataGridViewTextBoxColumn
            // 
            this.ilacsirketiDataGridViewTextBoxColumn.DataPropertyName = "ilacsirketi";
            this.ilacsirketiDataGridViewTextBoxColumn.HeaderText = "ilacsirketi";
            this.ilacsirketiDataGridViewTextBoxColumn.Name = "ilacsirketiDataGridViewTextBoxColumn";
            this.ilacsirketiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ilacadediDataGridViewTextBoxColumn
            // 
            this.ilacadediDataGridViewTextBoxColumn.DataPropertyName = "ilacadedi";
            this.ilacadediDataGridViewTextBoxColumn.HeaderText = "ilacadedi";
            this.ilacadediDataGridViewTextBoxColumn.Name = "ilacadediDataGridViewTextBoxColumn";
            this.ilacadediDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ilacucretiDataGridViewTextBoxColumn
            // 
            this.ilacucretiDataGridViewTextBoxColumn.DataPropertyName = "ilacucreti";
            this.ilacucretiDataGridViewTextBoxColumn.HeaderText = "ilacucreti";
            this.ilacucretiDataGridViewTextBoxColumn.Name = "ilacucretiDataGridViewTextBoxColumn";
            this.ilacucretiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ilactarihiDataGridViewTextBoxColumn
            // 
            this.ilactarihiDataGridViewTextBoxColumn.DataPropertyName = "ilactarihi";
            this.ilactarihiDataGridViewTextBoxColumn.HeaderText = "ilactarihi";
            this.ilactarihiDataGridViewTextBoxColumn.Name = "ilactarihiDataGridViewTextBoxColumn";
            this.ilactarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // HastaEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(706, 387);
            this.Controls.Add(this.dataGridViewIlaclar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxSiralamaKriteri);
            this.Controls.Add(this.btnSırala);
            this.Controls.Add(this.btnilacsuresisorgula);
            this.Controls.Add(this.btnilacsorgusu);
            this.Controls.Add(this.textRecetekoduu);
            this.Controls.Add(this.textilacadii);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HastaEkranı";
            this.Text = "HastaEkranı";
            this.Load += new System.EventHandler(this.HastaEkranı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIlaclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilactakipDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblilacBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSiralamaKriteri;
        private System.Windows.Forms.Button btnSırala;
        private System.Windows.Forms.Button btnilacsuresisorgula;
        private System.Windows.Forms.Button btnilacsorgusu;
        private System.Windows.Forms.TextBox textRecetekoduu;
        private System.Windows.Forms.TextBox textilacadii;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewIlaclar;
        private ilactakipDataSet1 ilactakipDataSet1;
        private System.Windows.Forms.BindingSource tblilacBindingSource;
        private ilactakipDataSet1TableAdapters.Tbl_ilacTableAdapter tbl_ilacTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recetekoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacsirketiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacadediDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacucretiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilactarihiDataGridViewTextBoxColumn;
    }
}