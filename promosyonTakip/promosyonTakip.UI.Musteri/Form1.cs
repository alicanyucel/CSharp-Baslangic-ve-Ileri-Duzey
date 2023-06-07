using promosyonTakip.Core.businessLogicService;
using promosyonTakip.Core.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace promosyonTakip.UI.Musteri
{
    public partial class Form1 : Form
    {
      

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKullaniciAdi.Text) && !string.IsNullOrEmpty(txtSifre.Text))
            {
                sistemMagazaServis servisMagaza = new sistemMagazaServis();
                int magazaID = servisMagaza.magazaKullaniciKontrol(txtKullaniciAdi.Text, txtSifre.Text);
                if (magazaID > 0)
                {
                    staticFieldList.magazaID = magazaID;
                    anaEkran _anaEkran = new anaEkran();
                    _anaEkran.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Form alanlarını eksiksiz olarak doldurun", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
