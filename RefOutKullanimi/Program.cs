using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ref ve Out anahtar sözcüklerinde eski .Net Framework versiyonlarında 1 fark vardı. Mevcut Framework versiyorun 7.0 olanlar bu farktan etkilenmyecekler.

            int sayi1 = 0;
            degerAta(ref sayi1);

            topla(5, 9, 20, 45, 22, 12, 11, 56);
        }

        static void degerAta(ref int gelenDeger)
        {
            gelenDeger = 10;
        }

        static void topla(params int[] sayilar)
        {
            int toplam = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            Console.WriteLine("Toplam = {0}", toplam);
        }
    }
}
