using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listboxDoldurV1();
            listboxDoldurV2();
        }

        void listboxDoldurV1()
        {
            foreach (var item in Database.UrunTablo)
            {
                lstUrunler.Items.Add(item);
            }
        }

        void listboxDoldurV2()
        {
            lstUrunler.DisplayMember = "urunAdi";
            //lstUrunler.ValueMember = "id";
            lstUrunler.DataSource = Database.UrunTablo;
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int urunSecimAdet = lstUrunler.SelectedItems.Count;

            if (urunSecimAdet == 1)
            {
                ListBox lbox = (ListBox)sender;
                // lbox = sender as ListBox;

                Urun u1 = (Urun)lstUrunler.SelectedItem;
                pctUrunResim.Image = Image.FromFile(u1.urunResim);
                pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;

                txtUrunAdi.Text = u1.urunAdi;
                txtKategori.Text = u1.urunKategori;
                txtStokAdet.Text = u1.stokAdet.ToString();
                txtYazar.Text = u1.yazar;
                txtUrunAciklama.Text = u1.aciklama;
            }

            else if (urunSecimAdet > 1)
            {
                List<Urun> secilenUrunListe = new List<Urun>();
                foreach (var item in lstUrunler.SelectedItems)
                {
                    secilenUrunListe.Add(item as Urun);
                }

                UrunSecimKullanici secimKullanici = new UrunSecimKullanici(secilenUrunListe.ToArray());
                secimKullanici.ShowDialog();
            }

            else
            {
                MessageBox.Show("Lütfen detayını görmek istediğiniz ürünü seçiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
