using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarsilastirmaOperatorleriAlistirma1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Kullanıcıdan gelen 3 farklı sınav notunun ortalaması 45 değerine eşit veya büyük mü olarak kontrol edelim.
             */

            Console.Write("Not 1 değerini giriniz : ");
            decimal not1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Not 2 değerini giriniz : ");
            decimal not2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Not 3 değerini giriniz : ");
            decimal not3 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Değerleriniz alındı hesaplama işlemi yapılıyor...");

            decimal ortalama = (not1 + not2 + not3) / 3;

            bool sonuc = ortalama >= 45;
            Console.WriteLine("Ortala değeriniz 45 değerinden büyük veya eşit mi ? : " + sonuc);

            Console.ReadLine();
        }
    }
}
