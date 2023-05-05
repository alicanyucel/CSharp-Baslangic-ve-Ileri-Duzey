using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ogrenciIsimListesi = new string[5];

            // Nasıl değer ekleyebiliriz.
            // 1 2 3 4 ... 10
            // 0 1 2 3 4 ... 10

            /*
             * 5 elemanlı bir dizi oluşturduğumuz zaman
             * [0]
             * [1]
             * [2]
             */

            ogrenciIsimListesi[0] = "Cengiz Atilla";
            ogrenciIsimListesi[1] = "Ahmet Yavuz";
            ogrenciIsimListesi[2] = "Mustafa Sel";
            ogrenciIsimListesi[3] = "Efrun Evdi";
            ogrenciIsimListesi[4] = "Ali Evdi";

            // Console.WriteLine(ogrenciIsimListesi[1]);

            #region Oluşturmuş olduğumuz dizimizin içerisindeki elemanları ekrana yazdıralım.
            foreach (string item in ogrenciIsimListesi)
            {
                Console.WriteLine(item);
            }

            Console.Clear();

            for (int i = 0; i < ogrenciIsimListesi.Length; i++)
            {
                string gelenIsım = ogrenciIsimListesi[i];
                Console.WriteLine(gelenIsım);
            }
            #endregion
        }
    }
}
