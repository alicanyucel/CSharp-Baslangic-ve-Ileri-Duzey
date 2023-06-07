using NetFramework.S18.D4.ListGenericTodoUygulama.businessService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D4.ListGenericTodoUygulama
{
    public partial class Form1 : Form
    {
        Form T;
        public Form1()
        {
            InitializeComponent();
        }

        private void pnlIslemListesi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButonAcKapa(bool kontrol)
        {
            foreach (Control item in grpBoxIslemListe.Controls)
            {
                if (item is Button)
                {
                    ((Button)item).Enabled = kontrol;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tm_zamanla.Interval = 15000;
            tm_zamanla.Tick += Tm_zamanla_Tick;
            tm_zamanla.Start();

            ButonAcKapa(false);

            sistemGiris kullaniciKontrol = new sistemGiris();
            kullaniciKontrol.MdiParent = this;
            kullaniciKontrol.StartPosition = FormStartPosition.CenterScreen;
            kullaniciKontrol.Show();
        }

        private void Tm_zamanla_Tick(object sender, EventArgs e)
        {
            lblZaman.Text = DateTime.Now.ToString("dd.MM.yyyy hh:mm");
        }

        private void btnUygulamaKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["yeniKayit"] != null)
            {
                T = Application.OpenForms["yeniKayit"];
                T.Focus();
            }
            else
            {
                T = new yeniKayit();
                T.MdiParent = this;
                T.Show();
            }
        }

        private void btnKayitListe_Click(object sender, EventArgs e)
        {
            todoService todoService = new todoService();
            if(todoService.kayitKontrol()>0)
            {
                kayitListe kayitListe = new kayitListe();
                kayitListe.MdiParent = this;
                kayitListe.Show();
            }
            else
            {
                MessageBox.Show("Listelenecek kayıt bulunamadı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
