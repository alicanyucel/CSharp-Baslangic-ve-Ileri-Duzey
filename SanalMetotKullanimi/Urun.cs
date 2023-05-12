using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMetotKullanimi
{
    public class Urun : baseClass
    {
        public Urun()
        {
            Console.WriteLine("Ürün");
        }

        public override void EkranaYaz(string data)
        {
            Console.WriteLine("Ürün => " + data);
        }
    }
}
