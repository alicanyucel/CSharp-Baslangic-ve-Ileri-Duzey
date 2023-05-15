using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGenericInceleme
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilarim = new List<int>();
            sayilarim.Add(1);

            int[] eklenecekData1 = new int[4];
            eklenecekData1[0] = 2;
            eklenecekData1[1] = 3;
            eklenecekData1[2] = 4;
            eklenecekData1[3] = 5;

            // 1. yol (Uzun Yol)
            //for (int i = 0; i < eklenecekData1.Length; i++)
            //{
            //    sayilarim.Add(eklenecekData1[i]);
            //}

            // 2. Yol
            sayilarim.AddRange(eklenecekData1); // Toplu şekilde ekleme

            int capacity = sayilarim.Capacity; // 4 4 artar
            int count = sayilarim.Count; // dizideki eleman sayısı

            sayilarim.TrimExcess(); // Count ve Capacity değerlerini eşitler

            capacity = sayilarim.Capacity;
            count = sayilarim.Count;

            //Soru ? : sayilarim koleksiyonu içerisinde bulunu datayı ekrana yazdırmak istiyorum bunu nasıl yaparsınız.

            sayilarim.ForEach(i => Console.WriteLine(i));
            // ilgili koleksiyon içerisinde arama yap..
            // linq konusu list<T> içerisinde

            int bulunanDeger = sayilarim[3];
            Console.WriteLine("List<T> koleksiyonu içerisinde 3. indexte bulunan değer : {0}", bulunanDeger);

            sayilarim.Insert(3, 100); // 3. Indexe 100 verip o indextekini bir alta kaydırdı.

            bool kontrol1 = sayilarim.Any(); // koleksiyor içerisinde değer varsa true döner.
            bool kontrol2 = sayilarim.Any(i => i > 5); // dizi içinde 5 ten büyük değer varsa true döner.

            sayilarim.Sort(); // 1 -> Z
            sayilarim.Reverse(); // Z-> A 

            int enYuksekDeger = sayilarim.Max(); // en yükseği döndürür.
            int enDusukDeger = sayilarim.Min(); // en düşüğü döndürür.
            int toplamDeger = sayilarim.Sum(); // toplam değeri döndürür.

            // Uygulama Alanı => Bölüm
            // List<T> Uygulama - Windows Form

            bool silmeIslemiSonuc = sayilarim.Remove(100); // 100'ü siler.
            int silinenAdet = sayilarim.RemoveAll(i => i > 3); // 3'ten büyükleri siler.
            sayilarim.RemoveAt(2); // 2 indexinde bulunan değerleri siler.

            sayilarim.Clear(); // Herşeyi siler.
        }
    }
}
