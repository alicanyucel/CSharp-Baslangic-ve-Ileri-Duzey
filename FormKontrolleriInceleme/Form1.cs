using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormKontrolleriInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Button => this.controls.Add(); // control ...
            //foreach (Control item in this.Controls)
            //{
            //    MessageBox.Show(item.Name);
            //}
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            DialogResult resultEnum = MessageBox.Show("Form içerisinde bulunan değerleri silmek istediğinden emin misiniz?", "Form Temizleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultEnum == DialogResult.Yes)
            {
                // FormTemizle();
                FormElemanIndexTemizle();
            }
            else
            {

            }
        }

        private void FormTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox) // item Control == TextBox
                {
                    TextBox T = (TextBox)item;
                    T.Text = string.Empty;
                }
            }
        }

        private void FormElemanIndexTemizle()
        {
            ((TextBox)this.Controls["txtIsim"]).Text = string.Empty;
            ((TextBox)this.Controls["txtSoyisim"]).Text = string.Empty;
            ((TextBox)this.Controls["txtEmail"]).Text = string.Empty;
            ((TextBox)this.Controls["txtTelefon"]).Text = string.Empty;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int islemSonuc = YeniMusteriEkle(new Musteri()
            {
                id = Guid.NewGuid(),
                isim = txtIsim.Text,
                soyisim = txtSoyisim.Text,
                email = txtEmail.Text,
                telefon = txtTelefon.Text,
            });

            FormTemizle();
        }

        private void btnOnizleme_Click(object sender, EventArgs e)
        {
            FrmOnizlemeKayit onizlemeKayit = new FrmOnizlemeKayit();
            ((TextBox)onizlemeKayit.Controls["txtIsim"]).Text = txtIsim.Text;
            ((TextBox)onizlemeKayit.Controls["txtSoyisim"]).Text = txtSoyisim.Text;
            ((TextBox)onizlemeKayit.Controls["txtEmail"]).Text = txtEmail.Text;
            ((TextBox)onizlemeKayit.Controls["txtTelefon"]).Text = txtTelefon.Text;
            onizlemeKayit.ShowDialog();

        }

        public class Musteri
        {
            public Guid id { get; set; }
            public string isim { get; set; }
            public string soyisim { get; set; }
            public string email { get; set; }
            public string telefon { get; set; }

            public override string ToString()
            {
                return isim + " " + soyisim;
            }
        }

        public static class SanalDatabase
        {
            public static List<Musteri> musteriler { get; set; }

            static SanalDatabase()
            {
                musteriler = new List<Musteri>();
            }
        }

        private int YeniMusteriEkle(Musteri data)
        {
            SanalDatabase.musteriler.Add(data);
            return 1;
        }
    }
}
