using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimNedir
{
    public class Ogrenci : temelTip
    {
        public string bolum { get; set; }
        public int seviye { get; set; }

        public Ogrenci()
        {
            Console.WriteLine("Öğrenci nesnesinin yapıcı metotu çalıştı.");
            // TemelTipMetot2(); Protected olarak işaretlendiği için ve bu nesne kendisini temeltip nesnesinden kalıttığı için protected seviyesinde olan field veya metotlara erişebilir.
        }
    }
}
