using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Udemy.Entities;

namespace Udemy.TelefonRehberi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btn_yeni_kayit_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
            int ReturnValue = BLL.KayitEkle(txt_isim.Text, txt_soyisim.Text, txt_telefon1.Text, txt_telefon2.Text, txt_telefon3.Text, txt_emailadres.Text, txt_website.Text, txt_adres.Text, txt_aciklama.Text);

            if (ReturnValue > 0)
            {
                MessageBox.Show("Yeni kayıt başarılı bir şekilde eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("İsim, Soyisim ve Telefon1 alanlarının dolu olduğundan emin olunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            ListeDoldur();
        }

        private void ListeDoldur()
        {
            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
            List<Rehber> RehberListesi = BLL.KayitListe();

            if (RehberListesi != null && RehberListesi.Count > 0)
            {
                lst_liste.DataSource = RehberListesi;
            }
        }

        private void lst_liste_DoubleClick(object sender, EventArgs e)
        {
            ListBox LST = (ListBox)sender;
            Rehber SecilenKayit = (Rehber)lst_liste.SelectedItem;
            if (SecilenKayit != null)
            {
                txt_isim.Text = SecilenKayit.Isim;
                txt_soyisim.Text = SecilenKayit.Soyisim;
                txt_telefon1.Text = SecilenKayit.TelefonI;
                txt_telefon2.Text = SecilenKayit.TelefonII;
                txt_telefon3.Text = SecilenKayit.TelefonIII;
                txt_emailadres.Text = SecilenKayit.EmailAdres;
                txt_adres.Text = SecilenKayit.Adres;
                txt_website.Text = SecilenKayit.Website;
                txt_aciklama.Text = SecilenKayit.Aciklama;
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            Guid ID = ((Rehber)lst_liste.SelectedItem).ID;
            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
            int ReturnValues = BLL.KayitDuzenle(ID, txt_isim.Text, txt_soyisim.Text, txt_telefon1.Text, txt_telefon2.Text, txt_telefon3.Text, txt_emailadres.Text, txt_website.Text, txt_adres.Text, txt_aciklama.Text);

            if (ReturnValues > 0)
            {
                ListeDoldur();
                MessageBox.Show("Kayıt başarılı bir şekilde güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Guid ID = ((Rehber)lst_liste.SelectedItem).ID;
            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
            int ReturnValue = BLL.KayitSil(ID);

            if (ReturnValue > 0)
            {
                ListeDoldur();
                MessageBox.Show("Kayıt başarılı bir şekilde silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
