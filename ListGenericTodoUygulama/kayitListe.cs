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
    public partial class kayitListe : Form
    {
        todoService todoService;
        public kayitListe()
        {
            InitializeComponent();
            todoService = new todoService();
        }

        private void kayitListe_Load(object sender, EventArgs e)
        {
            grdListe.DataSource = TumListe();
            grdListe.Columns["ID"].Visible = false;
        }

        private List<todo> TumListe()
        {
            return todoService.kayitListe();
        }

        private void btnTumListe_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = TumListe();
            grdListe.Columns["ID"].Visible = false;
        }

        private void btnTamamlandi_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = TumListe().Where(x => x.durumAciklama == "Tamamlandı").ToList();
            grdListe.Columns["ID"].Visible = false;
        }

        private void btnTamamlanamadi_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = TumListe().Where(x => x.durumAciklama == "Tamamlanamadı").ToList();
            grdListe.Columns["ID"].Visible = false;
        }

        private void btnIptalEdildi_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = TumListe().Where(x => x.durumAciklama == "İptal Edildi").ToList();
            grdListe.Columns["ID"].Visible = false;
            
        }
    }
}
