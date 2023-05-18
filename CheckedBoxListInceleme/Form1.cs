using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedBoxListInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBoxDoldurV1();
        }

        private void checkedListBoxDoldurV1()
        {
            foreach (var item in Database.UrunTablo)
            {
                chkListBox.Items.Add(item);
            }
        }

        private void chkListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedListBox = (CheckedListBox)sender;

            if (e.NewValue == CheckState.Checked)
            {
                Urun secilenUrun = checkedListBox.Items[e.Index] as Urun;

                pctUrunResim.Image = Image.FromFile(secilenUrun.urunResim);
                pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;

                txtUrunAdi.Text = secilenUrun.urunAdi;
                txtKategori.Text = secilenUrun.urunKategori;
                txtStokAdet.Text = secilenUrun.stokAdet.ToString();
                txtYazar.Text = secilenUrun.yazar;
                txtUrunAciklama.Text = secilenUrun.aciklama;
            }
            for (int i = 0; i < chkListBox.Items.Count; i++)
            {
                if (i == e.Index)
                {
                    // Üzerinde bulunan kayıt...
                }

                else
                {
                    chkListBox.SetItemChecked(i, false);
                }
            }
        }
    }
}
