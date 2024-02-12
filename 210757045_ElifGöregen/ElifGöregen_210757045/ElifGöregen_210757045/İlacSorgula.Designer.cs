namespace ElifGöregen_210757045
{
    partial class İlacSorgula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(İlacSorgula));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.cmbBoxSigortaTuru = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHastaTC = new System.Windows.Forms.TextBox();
            this.txtReceteKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBox = new System.Windows.Forms.ComboBox();
            this.lblRecete = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ilactakipDataSet = new ElifGöregen_210757045.ilactakipDataSet();
            this.tblilacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ilacTableAdapter = new ElifGöregen_210757045.ilactakipDataSetTableAdapters.Tbl_ilacTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recetekoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacsirketiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacadediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacucretiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilactarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilactakipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblilacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(403, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnSorgula
            // 
            this.btnSorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSorgula.Location = new System.Drawing.Point(49, 176);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(231, 62);
            this.btnSorgula.TabIndex = 21;
            this.btnSorgula.Text = "SORGULA";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // cmbBoxSigortaTuru
            // 
            this.cmbBoxSigortaTuru.FormattingEnabled = true;
            this.cmbBoxSigortaTuru.Items.AddRange(new object[] {
            "SGK",
            "BAĞKUR",
            "ÖZEL",
            "YOK"});
            this.cmbBoxSigortaTuru.Location = new System.Drawing.Point(148, 149);
            this.cmbBoxSigortaTuru.Name = "cmbBoxSigortaTuru";
            this.cmbBoxSigortaTuru.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxSigortaTuru.TabIndex = 20;
            this.cmbBoxSigortaTuru.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSigortaTuru_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(45, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Sigorta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(45, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Hasta TC:";
            // 
            // txtHastaTC
            // 
            this.txtHastaTC.Location = new System.Drawing.Point(150, 113);
            this.txtHastaTC.Name = "txtHastaTC";
            this.txtHastaTC.Size = new System.Drawing.Size(119, 20);
            this.txtHastaTC.TabIndex = 17;
            // 
            // txtReceteKodu
            // 
            this.txtReceteKodu.Location = new System.Drawing.Point(150, 78);
            this.txtReceteKodu.Name = "txtReceteKodu";
            this.txtReceteKodu.Size = new System.Drawing.Size(119, 20);
            this.txtReceteKodu.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Reçete Kodu:";
            // 
            // cmbBox
            // 
            this.cmbBox.FormattingEnabled = true;
            this.cmbBox.Items.AddRange(new object[] {
            "VAR",
            "YOK"});
            this.cmbBox.Location = new System.Drawing.Point(150, 39);
            this.cmbBox.Name = "cmbBox";
            this.cmbBox.Size = new System.Drawing.Size(119, 21);
            this.cmbBox.TabIndex = 14;
            this.cmbBox.SelectedIndexChanged += new System.EventHandler(this.cmbBox_SelectedIndexChanged);
            // 
            // lblRecete
            // 
            this.lblRecete.AutoSize = true;
            this.lblRecete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRecete.Location = new System.Drawing.Point(45, 39);
            this.lblRecete.Name = "lblRecete";
            this.lblRecete.Size = new System.Drawing.Size(63, 18);
            this.lblRecete.TabIndex = 13;
            this.lblRecete.Text = "Reçete :";
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
            this.dataGridView1.Location = new System.Drawing.Point(28, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(702, 142);
            this.dataGridView1.TabIndex = 23;
            // 
            // ilactakipDataSet
            // 
            this.ilactakipDataSet.DataSetName = "ilactakipDataSet";
            this.ilactakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblilacBindingSource
            // 
            this.tblilacBindingSource.DataMember = "Tbl_ilac";
            this.tblilacBindingSource.DataSource = this.ilactakipDataSet;
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
            // İlacSorgula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(736, 377);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.cmbBoxSigortaTuru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHastaTC);
            this.Controls.Add(this.txtReceteKodu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBox);
            this.Controls.Add(this.lblRecete);
            this.Name = "İlacSorgula";
            this.Text = "İlacSorgula";
            this.Load += new System.EventHandler(this.İlacSorgula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilactakipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblilacBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.ComboBox cmbBoxSigortaTuru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHastaTC;
        private System.Windows.Forms.TextBox txtReceteKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBox;
        private System.Windows.Forms.Label lblRecete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ilactakipDataSet ilactakipDataSet;
        private System.Windows.Forms.BindingSource tblilacBindingSource;
        private ilactakipDataSetTableAdapters.Tbl_ilacTableAdapter tbl_ilacTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recetekoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacsirketiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacadediDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacucretiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilactarihiDataGridViewTextBoxColumn;
    }
}