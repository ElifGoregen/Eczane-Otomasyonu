namespace ElifGöregen_210757045
{
    partial class DepoKontrol
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
            this.btnilacstok = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.textilacadedi = new System.Windows.Forms.TextBox();
            this.textilacsirketi = new System.Windows.Forms.TextBox();
            this.textrecetekodu = new System.Windows.Forms.TextBox();
            this.textilacadi = new System.Windows.Forms.TextBox();
            this.textsıra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.ilactakipDataSet2 = new ElifGöregen_210757045.ilactakipDataSet2();
            this.tblilacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ilacTableAdapter = new ElifGöregen_210757045.ilactakipDataSet2TableAdapters.Tbl_ilacTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recetekoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacsirketiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacadediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacucretiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilactarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilactakipDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblilacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnilacstok
            // 
            this.btnilacstok.BackColor = System.Drawing.Color.DarkGray;
            this.btnilacstok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnilacstok.Location = new System.Drawing.Point(353, 342);
            this.btnilacstok.Name = "btnilacstok";
            this.btnilacstok.Size = new System.Drawing.Size(160, 55);
            this.btnilacstok.TabIndex = 35;
            this.btnilacstok.Text = "İLAÇ STOK KONTROL";
            this.btnilacstok.UseVisualStyleBackColor = false;
            this.btnilacstok.Click += new System.EventHandler(this.btnilacstok_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.DarkGray;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(435, 280);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(163, 61);
            this.btnGuncelle.TabIndex = 34;
            this.btnGuncelle.Text = "İLAÇ GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.DarkGray;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(431, 202);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(162, 69);
            this.btn_sil.TabIndex = 33;
            this.btn_sil.Text = "İLAÇ SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(51, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 181);
            this.dataGridView1.TabIndex = 32;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(262, 276);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(167, 60);
            this.btnKaydet.TabIndex = 31;
            this.btnKaydet.Text = "İLAÇ KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // textilacadedi
            // 
            this.textilacadedi.Location = new System.Drawing.Point(122, 321);
            this.textilacadedi.Name = "textilacadedi";
            this.textilacadedi.Size = new System.Drawing.Size(100, 20);
            this.textilacadedi.TabIndex = 30;
            // 
            // textilacsirketi
            // 
            this.textilacsirketi.Location = new System.Drawing.Point(122, 293);
            this.textilacsirketi.Name = "textilacsirketi";
            this.textilacsirketi.Size = new System.Drawing.Size(100, 20);
            this.textilacsirketi.TabIndex = 29;
            // 
            // textrecetekodu
            // 
            this.textrecetekodu.Location = new System.Drawing.Point(122, 262);
            this.textrecetekodu.Name = "textrecetekodu";
            this.textrecetekodu.Size = new System.Drawing.Size(100, 20);
            this.textrecetekodu.TabIndex = 28;
            // 
            // textilacadi
            // 
            this.textilacadi.Location = new System.Drawing.Point(122, 233);
            this.textilacadi.Name = "textilacadi";
            this.textilacadi.Size = new System.Drawing.Size(100, 20);
            this.textilacadi.TabIndex = 27;
            // 
            // textsıra
            // 
            this.textsıra.Location = new System.Drawing.Point(122, 203);
            this.textsıra.Name = "textsıra";
            this.textsıra.Size = new System.Drawing.Size(100, 20);
            this.textsıra.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "İlaç Adedi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "İlaç Şirketi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Reçete Kodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "İlaç adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sıra:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.BackColor = System.Drawing.Color.DarkGray;
            this.btnGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoruntule.Location = new System.Drawing.Point(262, 203);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(167, 67);
            this.btnGoruntule.TabIndex = 19;
            this.btnGoruntule.Text = "TÜM İLAÇLARI GÖRÜNTÜLE";
            this.btnGoruntule.UseVisualStyleBackColor = false;
            // 
            // ilactakipDataSet2
            // 
            this.ilactakipDataSet2.DataSetName = "ilactakipDataSet2";
            this.ilactakipDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblilacBindingSource
            // 
            this.tblilacBindingSource.DataMember = "Tbl_ilac";
            this.tblilacBindingSource.DataSource = this.ilactakipDataSet2;
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
            // DepoKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(689, 400);
            this.Controls.Add(this.btnilacstok);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.textilacadedi);
            this.Controls.Add(this.textilacsirketi);
            this.Controls.Add(this.textrecetekodu);
            this.Controls.Add(this.textilacadi);
            this.Controls.Add(this.textsıra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGoruntule);
            this.Name = "DepoKontrol";
            this.Text = "DepoKontrol";
            this.Load += new System.EventHandler(this.DepoKontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilactakipDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblilacBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnilacstok;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox textilacadedi;
        private System.Windows.Forms.TextBox textilacsirketi;
        private System.Windows.Forms.TextBox textrecetekodu;
        private System.Windows.Forms.TextBox textilacadi;
        private System.Windows.Forms.TextBox textsıra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGoruntule;
        private ilactakipDataSet2 ilactakipDataSet2;
        private System.Windows.Forms.BindingSource tblilacBindingSource;
        private ilactakipDataSet2TableAdapters.Tbl_ilacTableAdapter tbl_ilacTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recetekoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacsirketiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacadediDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacucretiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilactarihiDataGridViewTextBoxColumn;
    }
}