using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciGirisForm
{
    public partial class Anaform : Form
    {
        public Anaform(Kullanici bulunanKullanici)
        {
            InitializeComponent();
            txtIsim.Text = bulunanKullanici.isim;
            txtSoyisim.Text = bulunanKullanici.soyisim;
            txtKullaniciAdi.Text = bulunanKullanici.kullaniciAdi;
            txtKullaniciAdi.Enabled = false;
            txtSifre.Text = bulunanKullanici.sifre;
            txtAciklama.Text = bulunanKullanici.aciklama;

            btnGuncelle.Tag = bulunanKullanici.id;
        }

        private void Anaform_Load(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Button btnGuncelleYakala = (Button)sender;
            int id = (int)btnGuncelle.Tag;

            int index = SanalDatabase.KullaniciTablo.FindIndex(i => i.id == id);
            SanalDatabase.KullaniciTablo[index].isim = txtIsim.Text;
            SanalDatabase.KullaniciTablo[index].soyisim = txtSoyisim.Text;
            SanalDatabase.KullaniciTablo[index].sifre = txtSifre.Text;
            SanalDatabase.KullaniciTablo[index].aciklama = txtAciklama.Text;

        }
    }
}
