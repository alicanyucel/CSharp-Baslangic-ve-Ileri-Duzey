using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Urun> urunlerim = new List<Urun>();
            urunlerim.Add(new Urun()
            {
                Id = 1,
                UrunTanim = "Tablet 1",
                ResimYol = @"C:\Users\efrun\source\repos\C#-Baslangic-ve-Ileri-Duzey\ComboBoxInceleme\Resimler\1.jpg"
            });

            urunlerim.Add(new Urun()
            {
                Id = 2,
                UrunTanim = "Tablet 2",
                ResimYol = @"C:\Users\efrun\source\repos\C#-Baslangic-ve-Ileri-Duzey\ComboBoxInceleme\Resimler\2.jpg"
            });

            urunlerim.Add(new Urun()
            {
                Id = 3,
                UrunTanim = "Tablet 3",
                ResimYol = @"C:\Users\efrun\source\repos\C#-Baslangic-ve-Ileri-Duzey\ComboBoxInceleme\Resimler\3.jpg"
            });

            urunlerim.Add(new Urun()
            {
                Id = 4,
                UrunTanim = "Tablet 4",
                ResimYol = string.Empty
            });

            grdUrunler.DataSource = urunlerim;
        }
    }
}
