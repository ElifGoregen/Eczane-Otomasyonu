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
    public partial class İlacSorgula : Form
    {
        public İlacSorgula()
        {
            InitializeComponent();
        }

        private void İlacSorgula_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ilactakipDataSet.Tbl_ilac' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
          //  this.tbl_ilacTableAdapter.Fill(this.ilactakipDataSet.Tbl_ilac);

        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            //İlaç sorgula butonum.
            {
                this.tbl_ilacTableAdapter.Fill(this.ilactakipDataSet.Tbl_ilac);
                //Data set için.
                string connectionString = ("Data Source=LAPTOP-8UJ1761G;Initial Catalog=ilactakip;Integrated Security=True");
                //Bağlantımı kurdum.
                using (SqlConnection connection = new SqlConnection(connectionString))
                //veri bağlantısını yönetmek için.
                {
                    connection.Open();
                    //Bağlantımı açtım.
                    string queryString = "Select * from Tbl_ilac";
                    //Sqlde ilac tablomdan verileri çekip stirng bileşenine atadım. 
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            //Sorgu sonuçlarını okudum.
                            while (reader.Read())
                            {
                                //Döngü okunan her satır için işlem yaptım.
                                int recetekodu = reader.GetInt32(0);
                                //Her satırın ilk sütunudaki veriyi aldım.
                                if (int.TryParse(txtReceteKodu.Text, out int receteKoduValue))
                                //Kullanıcı tarafından girilen bilgiyi integere çevirdim.
                                {
                                    try
                                    {
                                        if (recetekodu == receteKoduValue)
                                        //Girilen reçete kodunun veri tabanında olup olmadığını kontrol ettim.
                                        {
                                            MessageBox.Show("Hatalı giriş yaptınız.Lütfen tekrar deneyiniz");

                                        }
                                        else
                                        {

                                        }
                                    }
                                    catch (OverflowException)
                                    //Herhanagi bir tam sayı taşması durumu için.
                                    {

                                    }
                                }
                                else
                                {


                                }

                            }



                        }



                    }
                }

            }
        }

        private void cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           

                int selectedIndex = cmbBox.SelectedIndex;//Seçilen indexe göre if else bloklarına girer ya da girmez.
                {
                    if (selectedIndex == 0) //Eğer seçilen index 0 ise giriş yapma seçeneklerinden reçete kodu seçilirse:
                    {
                        MessageBox.Show("Reçete kodu Giriniz:");
                        txtHastaTC.Enabled = false;
                        txtReceteKodu.Enabled = true;
                    }
                    else //Eğer seçilen index 1 ise giriş yapma seçeneklerinden TC  seçilirse:
                    {
                        MessageBox.Show("TC ile giriş yapın.");
                        txtReceteKodu.Enabled = false;
                        txtHastaTC.Enabled = true;
                    }
                }
            }

        private void cmbBoxSigortaTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedIndex = cmbBoxSigortaTuru.SelectedIndex; //Comboxtan sigorta türü seçme indexi. 
            if (selectedIndex == 0) //Eğer index 0 ise sigorta sgk.
            {
                MessageBox.Show("SİGORTA:SGK");

            }
            if (selectedIndex == 1) //Eğer indeks 1 ise sigorta Bağkur.
            {
                MessageBox.Show("SİGORTA:BAĞKUR");
            }
            if (selectedIndex == 2) //Eğer indeks 2 ise sigorta Özel.
            {
                MessageBox.Show("SİGORTA:ÖZEL");
            }
            if (selectedIndex == 3) //Eğer indeks 3 ise sigorta yoktur.
            {
                MessageBox.Show("SİGORTA:YOK");
            }
        }
    }
    }


