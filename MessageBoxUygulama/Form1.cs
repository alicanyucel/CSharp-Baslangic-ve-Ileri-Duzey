using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            int islemSonuc = YeniMusteriEkle(new Musteri()
            {
                id = Guid.NewGuid(),
                isim = txtIsim.Text,
                soyisim = txtSoyisim.Text,
                email = txtEMail.Text,
                telefon = txtTelefon.Text,
            });

            if (islemSonuc > 0)
            {
                DialogResult res = MessageBox.Show("Müşteri ekleme işlemi başarılı, yeni müşteri kaydı eklemek ister misiniz?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    bildirimCubugu = new NotifyIcon();
                    bildirimCubugu.BalloonTipText = "Toplam müşteri kayıt sayısı : " + SanalDatabase.musteriler.Count.ToString();
                    bildirimCubugu.BalloonTipTitle = "Müşteri adet bilgisi";
                    bildirimCubugu.Visible = true;
                    bildirimCubugu.Icon = SystemIcons.Information;
                    bildirimCubugu.ShowBalloonTip(2000);
                }

                else if (res == DialogResult.No)
                {

                }

                EkranTemizle();
                EkranListele();
            }
            else
            {
                MessageBox.Show("Hata! Kayıt ekleme işlemi yapılamadı.");
            }
        }

        private void EkranListele()
        {
            lstMusteri.DataSource = SanalDatabase.musteriler;
        }

        private void EkranTemizle()
        {
            txtIsim.Text = string.Empty;
            txtSoyisim.Text = string.Empty;
            txtEMail.Text = string.Empty;
            txtTelefon.Text = string.Empty;
        }

        private int YeniMusteriEkle(Musteri data)
        {
            SanalDatabase.musteriler.Add(data);
            return 1;
        }
    }
}
