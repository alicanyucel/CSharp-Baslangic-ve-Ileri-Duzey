using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalFunctionKullanimi(12, 22);
        }

        static void LocalFunctionKullanimi(int sayi1, int sayi2)
        {
            int topla(int gelensayi1, int gelensayi2)
            {
                return gelensayi1 + gelensayi2;
            }

            int toplamDeger = topla(sayi1, sayi2);

            Console.WriteLine(toplamDeger);
        }
    }
}
