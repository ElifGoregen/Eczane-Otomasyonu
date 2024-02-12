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
    public partial class AdminGirişPaneli : Form
    {
        public AdminGirişPaneli()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //Kullanıcı adı ve şifreyi tanımladım.
            string kullaniciAdi, sifre;
            //Kullanıcı adı ve şifreyi kullanıcıdan aldım ve textboxlarına atadım.
            kullaniciAdi = TxtKullaniciAdi.Text;
            sifre = TxtSifre.Text;
            //Güvenlik amaçlı parola kısmını gizledim.
            TxtSifre.PasswordChar = '*';
            //Admin Gİriş Panelinden sonra İlaç sorgula formunun gelmesini sağladım.

            İlacSorgula ilacSorgula = new İlacSorgula();
            ilacSorgula.ShowDialog();
        }

        private void TxtSifre_TextChanged(object sender, EventArgs e)
        {
            TxtSifre.PasswordChar = '*';
        }
    }
}

