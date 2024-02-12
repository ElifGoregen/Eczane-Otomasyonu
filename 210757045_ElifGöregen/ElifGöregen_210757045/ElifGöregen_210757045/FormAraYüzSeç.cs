using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElifGöregen_210757045
{
    public partial class FormAraYüzSeç : Form
    {
        public FormAraYüzSeç()
        {
            InitializeComponent();
        }

        private void ButtonAraYüzSeç_Click(object sender, EventArgs e)
        {
            ComboBoxarayüz.Items.Add("Hasta Girişi");
            ComboBoxarayüz.Items.Add("Firma Sahibi");
            ComboBoxarayüz.Items.Add("Admin");

            // SelectedIndexChanged olayına bir dinleyici ekleyelim
            ComboBoxarayüz.SelectedIndexChanged += ComboBoxarayüz_SelectedIndexChanged;
        }
        private void ComboBoxarayüz_SelectedIndexChanged(object sender, EventArgs e)
        {

            // ComboBox'tan seçilen değeri aldım.
            string selectedValue = ComboBoxarayüz.SelectedItem.ToString();

            // Seçilen değeri kullanarak işlemleri yaptım.

            MessageBox.Show("Seçilen değer: " + selectedValue);//Seçilen değeri message box ile gösterdim.

            if(selectedValue=="Admin")//Eğer admin girişi ise gereken formu yönlendirdim.

            {
                AdminGirişPaneli fr2 = new AdminGirişPaneli();
                fr2.ShowDialog();
            }

            else if (selectedValue=="Hasta Girişi")//Eğer hasta girişi ise gereken formu yönlendirdim.
            {
              
                HastaEkranı hastaekranı= new HastaEkranı();
                hastaekranı.ShowDialog();
            }
            else if (selectedValue == "Firma Sahibi")//Eğer firma sahibi girişi ise gereken formu gönderdim.
            {
             
                FirmaSahibiArayüzü firmaSahibi=new FirmaSahibiArayüzü();
                firmaSahibi.ShowDialog();
            }
        }

        private void FormAraYüzSeç_Load(object sender, EventArgs e)
        {

        }
    }
}
