using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmatikselOperatorlerAlistirma1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Merhaba, 
             * İsminiz :
             * Soyisminiz :
             * Doğum Yılınız :
             * 
             * Ekranı Temizle
             * 
             * Merhaba Cengiz Atilla 35 yaşındasınız...
             */

            Console.WriteLine("Merhaba :)");

            Console.WriteLine("İsminiz : ");
            string isim = Console.ReadLine();

            Console.WriteLine("Soyisminiz : ");
            string soyisim = Console.ReadLine();

            Console.WriteLine("Dogum yılınız : ");
            string yilStr = Console.ReadLine();

            Console.Clear();

            int yil = Convert.ToInt32(yilStr);
            // int mevcutYil = 2023;
            int mevcutYil = DateTime.Now.Year;
            int yas = mevcutYil - yil;

            string mesaj = "Merhaba, " + isim + " " + soyisim + " " + yas + "yaşındasınız...";

            Console.WriteLine(mesaj);
            Console.ReadLine();
        }
    }
}
