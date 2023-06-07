using NetFramework.S18.D4.ListGenericTodoUygulama.businessService;
using NetFramework.S18.D4.ListGenericTodoUygulama.entities;
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
    public partial class yeniKayit : Form
    {
        public yeniKayit()
        {
            InitializeComponent();
        }

        private void txtBaslik_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void txtBaslik_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            todoService todoService = new todoService();
            int sonuc = todoService.kayitYeni(new entities.todo()
            {
                id = Guid.NewGuid(),
                baslik = txtBaslik.Text,
                kisaAciklama = txtKisaAciklama.Text,
                aciklama = txtAciklama.Text,
                durumAciklama = cmbDurum.SelectedItem.ToString(),
                onemDerece = int.Parse(txtDerece.Text),
                olusturmaTarih = DateTime.Now
            });
            if (sonuc > 0)
            {
                MessageBox.Show("Kayıt ekleme işlemi başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult result = MessageBox.Show("Yeni kayıt ekleme işlemine devam etmek ister misiniz", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (Control item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            ((TextBox)item).Text = string.Empty;
                        }
                    }
                }
                else
                {
                    Form kayitListe = Application.OpenForms["kayitListe"];
                    if (kayitListe == null)
                    {
                        kayitListe = new kayitListe();
                        kayitListe.MdiParent = Application.OpenForms["Form1"];
                        kayitListe.StartPosition = FormStartPosition.CenterScreen;
                        kayitListe.Show();
                        this.Close();
                    }
                    else
                    {
                        GroupBox Liste = (GroupBox)kayitListe.Controls["grpBoxListe"];
                        DataGridView grdListe = (DataGridView)Liste.Controls["grdListe"];
                        List<todo> GuncelListe = todoService.kayitListe();
                        grdListe.DataSource = null;
                        grdListe.DataSource = GuncelListe;
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Kayıt ekleme işleminde hata", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
