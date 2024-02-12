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
    public partial class DepoKontrol : Form
    {
        public DepoKontrol()
        {
            InitializeComponent();
        }

        private void DepoKontrol_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ilactakipDataSet2.Tbl_ilac' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_ilacTableAdapter.Fill(this.ilactakipDataSet2.Tbl_ilac);

        }
        //Sql bağlantımı başlattım.
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-8UJ1761G;Initial Catalog=ilactakip;Integrated Security=True");
        private void verileriGoruntule()
        //verileriGoruntule adlı kullanıcı tanımlı fonksiyonum.Veri tabanından bilgileri çekmek için.
        {


            this.tbl_ilacTableAdapter.Fill(this.ilactakipDataSet2.Tbl_ilac);
            //Veri tabanından datayı çekmek için.



        }
        private void btnGoruntule_Click(object sender, EventArgs e)
        //Goruntule butonumun içinde fonksiyonumu çağırdım.
        {
            verileriGoruntule();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Kullanıcının textboxlara girdiği bilgileri kaydetmesi için Kaydet butonum.
            {
                baglanti.Open();
                //Sql ile bağlantımızı başlatıyoruz.
                SqlCommand komutEkle = new SqlCommand("insert into Tbl_ilac (id,ilacadi,recetekodu,ilacsirketi,ilacadedi)values (@k1,@k2,@k3,@k4,@k5)", baglanti);//Bu komut ile Sql'e bağlanarak Tbl_ilac tablomdan değişkenlerimi ekliyorum.
                komutEkle.Parameters.AddWithValue("@k1", textsıra.Text);
                //Bu komut ile SQL komutuna parametreleri ekliyoruz.
                komutEkle.Parameters.AddWithValue("@k2", textilacadi.Text);
                komutEkle.Parameters.AddWithValue("@k3", textrecetekodu.Text);
                komutEkle.Parameters.AddWithValue("@k4", textilacsirketi.Text);
                komutEkle.Parameters.AddWithValue("@k5", textilacadedi.Text);
                komutEkle.ExecuteNonQuery();
                //Komutun çalıştırılması için.

                baglanti.Close();
                MessageBox.Show("İlaç eklendi.");
                //İlacın eklendiğini kullanıcıya bildiriyoruz.
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            //Kullanıcını textboxa girdiği ilgili ilaci silme işlemi için sil butonum.
            {
                baglanti.Open();
                //Sql ile bağlantımızı başlatıyoruz.
                SqlCommand komutSil = new SqlCommand("delete from Tbl_ilac where id=@s1", baglanti);
                komutSil.Parameters.AddWithValue("@s1", textsıra.Text);
                //Bu komut ile SQL komutuna parametreleri ekliyoruz.
                komutSil.ExecuteNonQuery();
                //Komutun çalışmasını sağlıyor.
                baglanti.Close();
                //Bu scope için Sql ile bağlantımızı kapatıyoruz.

                MessageBox.Show("İlaç silindi.");
                //Kullanıcıya ilacın silindiğini gösterecek mesajı yazıyoruz.

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //Sql ile bağlanntımı başlatıyorum.
            SqlCommand komutguncelle = new SqlCommand("update Tbl_ilac set ilacadi=@g1,recetekodu=@g2,ilacsirketi=@g3,ilacadedi=@g4 where id=@g5 ", baglanti);//Komut güncellemek için gereki olan değişkenleri Sqlden ekliyoruz.
            komutguncelle.Parameters.AddWithValue("@g1", textilacadi.Text);
            //Bu komut ile SQL komutuna parametreleri ekliyoruz.
            komutguncelle.Parameters.AddWithValue("@g2", textrecetekodu.Text);
            komutguncelle.Parameters.AddWithValue("@g3", textilacsirketi.Text);
            komutguncelle.Parameters.AddWithValue("@g4", textilacadedi.Text);
            komutguncelle.Parameters.AddWithValue("@g5", textsıra.Text);
            komutguncelle.ExecuteNonQuery();
            //Komutun çalışmasını sağlıyor.
            baglanti.Close();
            //Bu scope için bağlantımı kapatıyorum.
            MessageBox.Show("İlaç bilgisi güncellendi.");
            //İlaç bilgilerinin güncellediğini kullanıcıya bildiriyorum.
        }

        private void btnilacstok_Click(object sender, EventArgs e)
        {
            //İlaç stok takibi butonum.
            {
                {
                    string connectionString = ("Data Source=LAPTOP-8UJ1761G;Initial Catalog=ilactakip;Integrated Security=True");
                    //Sql ile bağlantımı sağlıyorum.
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    //Kayank sızıntısı engellemek için.
                    {
                        connection.Open();
                        //Bağlantımı açıyorum.
                        string queryString = "Select * from Tbl_ilac";
                        //Sql sorgumu string olarak tanımlıyorum.
                        using (SqlCommand command = new SqlCommand(queryString, connection))
                        //Çalıştırıyorum.
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            //Sql sorgusunun sonuçları için.
                            {
                                while (reader.Read())
                                //reader üzerinden gelen sorgularu okumak için.
                                {
                                    int ilacadedi = reader.GetInt32(0);
                                    //ilk sütundaki değeri integer olarak almak için.
                                    if (int.TryParse(textilacadedi.Text, out int ilacadediValue))
                                    //Kullanıcının texte girdiği değeri integere çeviriyorum.
                                    {
                                        try// try-catch olası bir hatayı yakalamak için yazdım.
                                        {
                                            if (ilacadedi == 0)
                                            //Eğer stoktaki ilaç adedi sıfır ise gerekli mesajı yazdırdım.
                                            {
                                                MessageBox.Show("İlaç stoğu yok.Lütfen ecza deposundan isteyiniz.");
                                                //İlaç stoğum yoksa ecza deposundan istyiniz mesajını kullanıcıya verdim
                                            }
                                            else
                                            {

                                            }
                                        }
                                        catch (OverflowException)
                                        {

                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("İlaç stoğu var.");
                                        //Eğer if bloğuna girmezse yani stok varsa bunun bilgisini kullanıcıya verdim.
                                    }
                                }
                            }
                        }

                    }
                }

            }
        }
    }

}
    
