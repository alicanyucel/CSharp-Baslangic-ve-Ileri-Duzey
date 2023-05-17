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
    }
}
