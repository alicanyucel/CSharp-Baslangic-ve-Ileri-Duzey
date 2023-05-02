using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmatikselOperatorlerCarpma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Çıkartma operatörü ( * )
            // byte int double float decimal 

            double d1 = 10.4;
            double d2 = 10.6;
            double sonuc = d1 * d2;

            Console.WriteLine(sonuc);

            // Uzun hali
            double sonucDouble = d1 * d2;
            int sonucInt = (int)sonucDouble;

            // Kısa hali
            
            sonucInt = (int)(d1 * d2);

            Console.WriteLine(sonucInt);
        }
    }
}
