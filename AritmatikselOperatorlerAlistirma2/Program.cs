using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmatikselOperatorlerAlistirma2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Sayı 1 değerini giriniz.
             * Sayı 2 değerini giriniz.
             * 
             * + :
             * - :
             * / :
             * * :
             * % :
             * 
             */

            Console.Write("Sayı 1 değerini giriniz : ");
            decimal sayi1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Sayı 2 değerini giriniz : ");
            decimal sayi2 = Convert.ToDecimal(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Toplama : " + (sayi1 + sayi2));
            Console.WriteLine("Çıkarma : " + (sayi1 - sayi2));
            Console.WriteLine("Bölme : " + (sayi1 / sayi2));
            Console.WriteLine("Çarpma : " + (sayi1 * sayi2));
            Console.WriteLine("Mod : " + (sayi1 % sayi2));

            Console.ReadLine();
        }
    }
}
