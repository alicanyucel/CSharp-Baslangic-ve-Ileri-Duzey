using BuyukDatalarIleCalismak.Entities;
using BuyukDatalarIleCalismak.Operasyon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyukDatalarIleCalismak
{
    public partial class Form1 : Form
    {
        Image Img;
        BusinessLogicLayer BLL;

        public Form1()
        {
            InitializeComponent();
            BLL = new BusinessLogicLayer();
            List<Entities.Kisi> Kisiler = BLL.KisilerListe();
            cmb_kisilistesi.DataSource = Kisiler;
        }

        private void btn_resimekle_Click(object sender, EventArgs e)
        {
            OFD.ShowDialog();
            Img = Image.FromFile(OFD.FileName);
            pic_resim.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_resim.Image = Img;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            MemoryStream mem = new MemoryStream();
            Img.Save(mem, System.Drawing.Imaging.ImageFormat.Jpeg);
            int ReturnValue = BLL.KayitEkle(txt_isim.Text, txt_soyisim.Text, txt_eposta.Text, txt_tel.Text, mem.ToArray());

            if (ReturnValue > 0)
            {
                MessageBox.Show("Kayıt başarılı");
            }

            else
            {
                MessageBox.Show("Kayıt başarısız");
            }
        }

        private void cmb_kisilistesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kisi kisi = (Kisi)((ComboBox)sender).SelectedItem;
            kisi = BLL.KisiDetayGetir(kisi.ID);
            txt_dg_isim.Text = kisi.Isim;
            txt_dg_soyisim.Text = kisi.Soyisim;
            txt_dg_eposta.Text = kisi.EmailAdres;
            txt_dg_tel.Text = kisi.TelefonNumarasi;

            MemoryStream mem = new MemoryStream(kisi.Resim);
            Img = Image.FromStream(mem);
            pic_dg_resim.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_dg_resim.Image = Img;
        }
    }
}
