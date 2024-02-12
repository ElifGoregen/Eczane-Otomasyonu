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
    public partial class HastaEkranı : Form
    {
        public HastaEkranı()
        {
            InitializeComponent();
        }

        private void HastaEkranı_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ilactakipDataSet1.Tbl_ilac' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_ilacTableAdapter.Fill(this.ilactakipDataSet1.Tbl_ilac);
            //comboxa bilgileri ekliyorum.
            comboBoxSiralamaKriteri.Items.Add("IlacTarihi");
            comboBoxSiralamaKriteri.Items.Add("IlacAdi");
            comboBoxSiralamaKriteri.Items.Add("ReceteKodu");
        }

        private void btnilacsorgusu_Click(object sender, EventArgs e)
        {
            //İlac sorgusu butonumu ekliyorum.
            {
                //Sqlden Datasetimi çekiyorum.
                this.tbl_ilacTableAdapter.Fill(this.ilactakipDataSet1.Tbl_ilac);
                //Sql ile bağlantımı kuruyorum.
                string connectionString = "Data Source=LAPTOP-8UJ1761G;Initial Catalog=ilactakip;Integrated Security=True";
                string textilacadi = textilacadii.Text;
                //İlaç adını kullanıcıdan textbox aracılığı ila alıyorum.


                bool isReceteKoduInt = int.TryParse(textRecetekoduu.Text, out int recetekoduInt);
                //Reçete kodunu integer'e çeviriyorum.

                if (isReceteKoduInt || !string.IsNullOrWhiteSpace(textilacadi))
                //Textboxun boş olup olmadığını kontrol ediyoruz.
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))//Bağlantım
                    {
                        connection.Open();//Bağlantımı açtım.

                        string query = "SELECT * FROM Tbl_ilac WHERE ilacadi = @ilacadi OR recetekodu = @recetekodu";
                        //Sql sorgumu tanımladım ve tablomdan gerekli değişkenleri çektim.
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@recetekodu", recetekoduInt); // Integer değeri
                            command.Parameters.AddWithValue("@ilacadi", textilacadi);

                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);
                                //Sql sonuçlarımı datatable a dolduruyor.

                                if (dataTable.Rows.Count > 0)//Sorgu sonucu bir veya birden fazla satır içeriyorsa: 
                                {
                                    dataGridViewIlaclar.DataSource = dataTable; // DataTable'ı DataGridView'e bağladım.
                                }
                                else
                                {
                                    MessageBox.Show("İlgili ilaç bilgisi bulunamadı.");//Eğer yoksa kullanıcıya bildirilir.
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen tüm alanları doğru doldurun.");//Kullanıcı yanlış giriş yaparsa hata mesajı verilir.
                }
            }

        }

        private void btnilacsuresisorgula_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-8UJ1761G;Initial Catalog=ilactakip;Integrated Security=True";
            //Bğlantımı tanımlıyorum.
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("Sp_IlacSuresiiSorgula", conn);
                //SP imi çalıştırıyorum.
                command.CommandType = CommandType.StoredProcedure;
                //Komutumun sp oladuğunu belirtiyorum.

                conn.Open();
                //Bağlantımı açıyorum.

                int durum = (int)command.ExecuteScalar();
                //Sp imi çalıştırdım ve tek bir değer döndürdüm.Durum değişkenine atadım.

                if (durum == 1)
                //Eğer durum ilacın süresi dolmuştur.Bunu kullanıcıya bildiririm.
                {
                    MessageBox.Show("İlaç süresi dolmuştur, yeni ilaç alın.");
                }
                else
                //İlacın süresini dolmaışsa kullanıcıya bildirdim.
                {
                    MessageBox.Show("İlaç süresi dolmamıştır, yeni ilaç alamazsınız.");
                }
            }
        }

        private void btnSırala_Click(object sender, EventArgs e)
        {
            string secilenKriter = comboBoxSiralamaKriteri.SelectedItem.ToString();//Comboboxtan secilen öğeyi string olarak aldım.

            // Veritabanı bağlantı stringinizi buraya yazın
            string connectionString = "Data Source=LAPTOP-8UJ1761G;Initial Catalog=ilactakip;Integrated Security=True";
            //Sql bağlantımı tanımladım.
            DataTable dt = new DataTable();
            //verileri tablo formatında tutmak için.
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("ListeleIlacSiralamaSecenegineGore", conn))
                //Sp çalıştırdım.
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SiralamaKriteri", secilenKriter);
                    //Komutun türü saklı prosedür olarak ayarladım ve prosedüre sıralama kriteri olarak kullanıcının seçimini içeren bir parametre ekledim.

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                        //Komutun sonuçlarını datatable a doldurdum.
                    }
                }
            }

            // Sonuçları DataGridView'da gösterdim.
            dataGridViewIlaclar.DataSource = dt;
        }
    }
}
        

