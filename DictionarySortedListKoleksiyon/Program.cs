using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionarySortedListKoleksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generic olmayan koleksiyon davranışı
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "Bir");
            hashtable.Add(2, "İki");
            hashtable.Add(3, true);
            //hashtable.Add(1, "Test"); // Hata!

            // Dictionary<TKey,TValue>
            Dictionary<int, string> DictionaryList = new Dictionary<int, string>();
            DictionaryList.Add(1, "Bir");
            DictionaryList.Add(2, "İki");
            DictionaryList.Add(3, "Üç");
            // DictionaryList.Add(1, "Test"); // Hata!

            bool silmeSonuc = DictionaryList.Remove(2);
            if (silmeSonuc)
            {
                Console.WriteLine("Silindi.");
            }
            else
            {
                Console.WriteLine("Aranan değer bulunamadı silme işlemi başarısız.");
            }

            bool arananKeySonuc = DictionaryList.ContainsKey(1); // Key var mı kontrol eder.
            if (arananKeySonuc)
            {
                string gelenDeger = DictionaryList[1];
                gelenDeger = "Yenilenen değer";
                DictionaryList[1] = gelenDeger;
            }

            else
            {
                Console.WriteLine("Aranan değer koleksiyon içerisinde bulunamadı.");
            }

            bool arananDegerSonuc = DictionaryList.ContainsValue("Bir"); // Değer var mı kontrol eder.

            if (arananDegerSonuc)
            {
                Console.WriteLine("Aranan değer bulundu.");
            }

            else
            {
                Console.WriteLine("Aranan değer bulunamadı.");
            }

            foreach (KeyValuePair<int, string> item in DictionaryList)
            {
                Console.WriteLine("Anahtar : {0} || Değer : {1} ", item.Key, item.Value);
            }

            DictionaryList.Clear();

            SortedList<int, string> sortedListKoleksiyon = new SortedList<int, string>(); // Sıralama yapar K => B
            sortedListKoleksiyon.Add(100, "Yüz");
            sortedListKoleksiyon.Add(50, "Elli");
            sortedListKoleksiyon.Add(1, "Bir");
            sortedListKoleksiyon.Add(1000, "Bin");
        }
    }
}
