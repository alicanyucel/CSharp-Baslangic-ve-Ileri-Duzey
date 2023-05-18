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
    public partial class UrunSecimKullanici : Form
    {
        Urun[] urunListe;
        public UrunSecimKullanici(Urun[] secilenUrunler)
        {
            InitializeComponent();
            urunListe = secilenUrunler;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UrunSecimKullanici_Load(object sender, EventArgs e)
        {
            foreach (var item in urunListe)
            {
                Button btn = new Button();
                btn.Text = item.urunAdi;
                btn.Name = "btn" + item.id.ToString();
                btn.Size = new System.Drawing.Size(142, 33);
                btn.Tag = item;
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Urun u1 = btn.Tag as Urun;

            Form F1 = Application.OpenForms["Form1"];
            GroupBox F1GBOX = (GroupBox)F1.Controls["groupBox1"];

            ((PictureBox)F1GBOX.Controls["pctUrunResim"]).Image = Image.FromFile(u1.urunResim);
            ((TextBox)F1GBOX.Controls["txtUrunAdi"]).Text = u1.urunAdi;
            ((TextBox)F1GBOX.Controls["txtKategori"]).Text = u1.urunKategori;
            ((TextBox)F1GBOX.Controls["txtStokAdet"]).Text = u1.stokAdet.ToString();
            ((TextBox)F1GBOX.Controls["txtYazar"]).Text = u1.yazar;
            ((RichTextBox)F1GBOX.Controls["txtUrunAciklama"]).Text = u1.aciklama;

            this.Close();
        }
    }
}
