using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    // Çalışacak olan kodlar
            //}

            // Şart ne olursa olsun döngü bir kere çalışır.
            do
            {
                Console.WriteLine("Merhaba Do While");
            } while (1 == 2);

            // Do While döngülerindeki en temel fark şartları ne olursa olsun 1 kere kesin çalışır.
        }
    }
}
