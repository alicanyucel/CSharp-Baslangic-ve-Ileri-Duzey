using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelOkuWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSec_Click(object sender, EventArgs e)
        {

            DialogResult res = OFD.ShowDialog();
            if(res == DialogResult.OK)
            {
                txtDosyaYol.Text = OFD.FileName;
                List<Urun> urunlerim = ExcelIslemleri.ExcelOku(txtDosyaYol.Text);
                if(urunlerim != null && urunlerim.Count>0)
                {
                    grdExcelListe.DataSource = urunlerim;
                    grdExcelListe.Columns[2].Visible = false;
                    grdExcelListe.Columns[2].Visible = true;
                }
            }
        }
    }
}
