using promosyonTakip.Core.entities;
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
    public partial class hediyeGoster : Form
    {
        public hediyeGoster(promosyonUrun data)
        {
            InitializeComponent();

            lblHediyeAciklama.Text = data.tanim + " " + data.aciklama + " Kazandınız"; 
        }

        private void hediyeGoster_Load(object sender, EventArgs e)
        {

        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            Form anaEkranFrm = Application.OpenForms["anaEkran"];
            anaEkranFrm.Close();

            anaEkran anaForm = new anaEkran();
            anaForm.Show();
            this.Close();
        }
    }
}
