using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeModelleme
{
    public class MusteriIletisimBilgisi
    {
        public int IletisimTip { get; set; } // 717770001 : Mobil - 717770002 : Sabit Hat
        public string alankodu { get; set; }
        public string numara { get; set; }
        public bool aktifPasif { get; set; }

        public void MusteriIletisimBilgisiTestMetot()
        {
            Console.WriteLine("MusteriIletisimBilgisiTestMetot");
        }
    }
}
