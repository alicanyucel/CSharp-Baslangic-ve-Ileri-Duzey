using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udemy.TelefonRehberi
{
    public partial class Form1 : Form
    {
        BusinessLogicLayer.BLL bll;
        public Form1()
        {
            InitializeComponent();
            bll = new BusinessLogicLayer.BLL();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            int ReturnValues = bll.SistemKontrol(txt_kullaniciadi.Text, txt_sifre.Text);

            if (ReturnValues > 0)
            {
                AnaForm AF = new AnaForm();
                AF.Show();
            }

            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
