using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmatikselOperatorlerCikarma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Çıkartma operatörü ( - )
            // byte , int  , double , float , decimal 

            int s1 = 100;
            int s2 = 50;

            int sonuc = s1 - s2;
            Console.WriteLine(sonuc);

            byte b1 = 50;
            byte b2 = 100;
            int sonucByte = b1 - b2;

        }
    }
}
