namespace ElifGöregen_210757045
{
    partial class FormAraYüzSeç
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAraYüzSeç));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxarayüz = new System.Windows.Forms.ComboBox();
            this.ButtonAraYüzSeç = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 327);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(311, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ara yüz :";
            // 
            // ComboBoxarayüz
            // 
            this.ComboBoxarayüz.FormattingEnabled = true;
            this.ComboBoxarayüz.Location = new System.Drawing.Point(402, 140);
            this.ComboBoxarayüz.Name = "ComboBoxarayüz";
            this.ComboBoxarayüz.Size = new System.Drawing.Size(150, 21);
            this.ComboBoxarayüz.TabIndex = 14;
            // 
            // ButtonAraYüzSeç
            // 
            this.ButtonAraYüzSeç.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonAraYüzSeç.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonAraYüzSeç.Location = new System.Drawing.Point(337, 212);
            this.ButtonAraYüzSeç.Name = "ButtonAraYüzSeç";
            this.ButtonAraYüzSeç.Size = new System.Drawing.Size(228, 72);
            this.ButtonAraYüzSeç.TabIndex = 15;
            this.ButtonAraYüzSeç.Text = "ARA YÜZ SEÇ";
            this.ButtonAraYüzSeç.UseVisualStyleBackColor = false;
            this.ButtonAraYüzSeç.Click += new System.EventHandler(this.ButtonAraYüzSeç_Click);
            // 
            // FormAraYüzSeç
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(638, 417);
            this.Controls.Add(this.ButtonAraYüzSeç);
            this.Controls.Add(this.ComboBoxarayüz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAraYüzSeç";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormAraYüzSeç_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxarayüz;
        private System.Windows.Forms.Button ButtonAraYüzSeç;
    }
}

