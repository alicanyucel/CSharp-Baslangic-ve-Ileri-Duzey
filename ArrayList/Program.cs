using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            int Capacity = 0;
            int Count = 0;

            string[] isimler = new string[10];

            #region Tek değer ekleme
            ArrayList A1 = new ArrayList();
            A1.Add("Cengis Atilla");
            A1.Add(100);

            Capacity = A1.Capacity;
            Count = A1.Count;
            #endregion

            #region Birden fazla değer ekleme
            ArrayList A2 = new ArrayList();
            A2.Add("Yakup");
            A2.Add("Merve");
            A1.Add("Utkan");

            A1.AddRange(A2);

            Capacity = A1.Capacity; // Alınabilcek maksimum değer
            Count = A1.Count; // Mevcut değer sayısı
            #endregion

            #region Koleksiyon içindeki değere ulaşmak
            object O1 = A1[3];
            string S1 = A1[3].ToString();
            int I1 = (int)A1[1];

            A1[3] = "Hamza Atilla";
            #endregion

            #region ArrayList koleksiyonu içerisindeki değeri silme
            A1.Remove("Hamza Atilla");
            A1.RemoveRange(0, 1); // 3. indexten başla 2 eleman sil.
            A1.RemoveAt(3); // indexe göre silme işlemi yapar.
            #endregion

            #region ArrayList Sıralama
            // A-Z Sıralama
            A1.Remove(100);
            A1.Sort();

            //Dizinin mevcut elemanlarını ters olarak sıralama
            A1.Reverse();
            #endregion

            #region 10 elemanlı ( string ) ArrayList içindeki değerleri Z-A olacak şekilde sıralayın.

            ArrayList odev = new ArrayList();
            odev.Add("Ali");
            odev.Add("Efrun");
            odev.Add("Selin");
            odev.Add("Ömür");
            odev.Add("Yaşar");
            odev.Add("Şule");
            odev.Add("Miray");
            odev.Add("Sena");
            odev.Add("Zeynep");
            odev.Add("Alime");

            odev.Sort();
            odev.Reverse();
            #endregion

            #region Koleksiyon yardımcı komutları
            bool Kontrol1 = A1.Contains("Utkan");
            bool Kontrol2 = A1.Contains(900); // Eleman kontrol etme

            if (A1.Contains("Yakup"))
            {
                int indexDeğeri = A1.IndexOf("Yakup");
                A1.RemoveAt(indexDeğeri); // Yakup adlı değer varSA indexini bulup sil.
            }

            A1.Clear(); // Bütün değerleri siler.
            A1.TrimToSize(); // En başta tanımladığımız hale getirir.

            object[] D1 = A1.ToArray(); // Diziye çevirme işlemi.
            #endregion

        }
    }
}
