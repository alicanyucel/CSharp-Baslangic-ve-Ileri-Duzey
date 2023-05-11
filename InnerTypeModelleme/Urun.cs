using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeModelleme
{
    public class Urun
    {
        public int UrunID { get; set; }
        public string tanim { get; set;}
        public double fiyat { get; set;}

        public Urun()
        {
            Console.WriteLine("Ürün yapıcı metot çalıştı");
        }

        public void UrunTestMetot()
        {
            Console.WriteLine("UrunTestMetot");
        }
    }
}
