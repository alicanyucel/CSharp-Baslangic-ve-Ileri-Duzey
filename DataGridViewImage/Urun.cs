using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewImage
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunTanim { get; set; }
        public string ResimYol { get; set; }
        public Image UrunResim
        {
            get
            {
                if (!string.IsNullOrEmpty(ResimYol))
                    return Image.FromFile(ResimYol);
                else
                    return Image.FromFile(@"C:\Users\efrun\source\repos\C#-Baslangic-ve-Ileri-Duzey\ComboBoxInceleme\Resimler\5.jpg");
            }
        }
    }
}
