using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableGenelKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable H1 = new Hashtable();

            #region Yeni Değer Ekleme
            H1.Add("Car", "Araba");
            H1.Add("House", "Ev");

            H1.Add("Cars", "Araba");
            // H1.Add("Cars", "Arabalar"); Key değeri benzersiz olmak zorundadır.
            #endregion

            #region Yazdımcı Metotlar
            bool Kontrol1 = H1.Contains("House");
            bool Kontrol2 = H1.Contains("Door");

            bool kontrol3 = H1.ContainsKey("House");
            bool kontrol4 = H1.ContainsValue("Araba");

            H1.Clear(); // Koleksiyon içerisindeki tüm datayı temizler.
            // H1.CopyTo(); Farklı bir array verip şu indeksten başla şu kadar kopyala diyebiliriz.
            int koleksiyonIçindekiToplamDeger = H1.Count;
            H1.Remove("Cars");
            H1["House"] = "Villa"; // House = Ev iken Villa olacak.
            #endregion


        }
    }
}
