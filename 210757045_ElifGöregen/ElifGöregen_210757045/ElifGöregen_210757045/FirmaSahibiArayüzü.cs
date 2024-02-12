using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElifGöregen_210757045
{
    public partial class FirmaSahibiArayüzü : Form
    {
        public FirmaSahibiArayüzü()
        {
            InitializeComponent();
        }

        private void FirmaSahibiArayüzü_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ilactakipDataSet3.Tbl_ilac' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           // this.tbl_ilacTableAdapter.Fill(this.ilactakipDataSet3.Tbl_ilac);

        }

        private void buttonCiroHesapla_Click(object sender, EventArgs e)
        {
            string ilacAdi = textBoxilacadi.Text;
            if (!int.TryParse(textBoxilacadedi.Text, out int ilacAdedi))
            {
                MessageBox.Show("Lütfen geçerli bir ilaç adedi girin.");
                return;
            }

            string sigortaTuru = ComboBoxSigortaTürü.Text;
            decimal indirimOrani = 0;
            decimal ilacUcreti = 0;
            string connectionString = "Data Source=LAPTOP-8UJ1761G;Initial Catalog=ilactakip;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // İndirim oranını hesaplayan SP'yi çağır
                using (SqlCommand cmdIndirim = new SqlCommand("HesaplaIndirimOrannni", conn))
                {
                    cmdIndirim.CommandType = CommandType.StoredProcedure;
                    cmdIndirim.Parameters.AddWithValue("@sigortaTuru", sigortaTuru);
                    SqlParameter indirimOraniParam = new SqlParameter("@indirimOrani", SqlDbType.Decimal)
                    {
                        Precision = 3,//toplamda kaç basamak
                        Scale = 2, //ondalık max 2 olmalı.
                        Direction = ParameterDirection.Output//çıktı
                    };
                    cmdIndirim.Parameters.Add(indirimOraniParam);

                    cmdIndirim.ExecuteNonQuery();
                    indirimOrani = (decimal)indirimOraniParam.Value;
                    MessageBox.Show("İndirim Oranı:  ", indirimOrani.ToString());
                    MessageBox.Show("Sigorta Türü: " + sigortaTuru);

                }

                // İlaç ücretini çeken SP'yi çağır
                using (SqlCommand cmdCiro = new SqlCommand("CirooHesaplaa", conn))
                {
                    cmdCiro.CommandType = CommandType.StoredProcedure;
                    cmdCiro.Parameters.AddWithValue("@ilacadi", ilacAdi);
                    SqlParameter ilacUcretiParam = new SqlParameter("@ilacucreti", SqlDbType.Decimal)
                    {
                        Precision = 10,//toplamda kaç basamak
                        Scale = 2,//ondalık max 2 olmalı
                        Direction = ParameterDirection.Output//çıktı
                    };
                    cmdCiro.Parameters.Add(ilacUcretiParam);

                    cmdCiro.ExecuteNonQuery();
                    ilacUcreti = (decimal)ilacUcretiParam.Value;
                }


                // İndirimli ücreti hesapla
                decimal indirimliUcret = ilacUcreti * (1 - indirimOrani);

                // Toplam fiyatı bul
                decimal toplamFiyat = ilacAdedi * indirimliUcret;
                textBoxToplamFiyat.Text = "Toplam Fiyat: " + toplamFiyat.ToString("C");
            }

        }

        private void btnİlacBilgisiGoster_Click(object sender, EventArgs e)
        {

            this.tbl_ilacTableAdapter.Fill(this.ilactakipDataSet3.Tbl_ilac);
            string ilacAdi = textBoxilacadi.Text;

            string connectionString = "Data Source=LAPTOP-8UJ1761G;Initial Catalog=ilactakip;Integrated Security=True"; // Veritabanı bağlantı dizenizi buraya girin
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("ilacBilgisiGetir", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ilacAdi", ilacAdi);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt; // İlaç bilgilerini DataGridView kontrolünde gösterir
              
                DepoKontrol depoKontrol= new DepoKontrol();
                depoKontrol.ShowDialog();
            }
        }
    }
    }
    

