using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList => Generic versiyonu

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Bir");

            // <T> : T tipi demek .net framework içerisinde olan veya bizim oluşturduğumuz herhangi bir tip demek.

            List<int> ListeGeneric = new List<int>();
            ListeGeneric.Add(1);
            ListeGeneric.Add(2);
            //ListeGeneric.Add("STRİNG"); // Hata

            for (int i = 0; i < ListeGeneric.Count; i++)
            {
                Console.WriteLine(ListeGeneric[i]);
            }

            List<string> isimler = new List<string>();
            isimler.Add("Cengiz");
            isimler.Add("Atilla");
            isimler.Add("Hamza");
            //isimler.Add(İNT); // Hata

            for (int i = 0; i < isimler.Count; i++)
            {
                Console.WriteLine(isimler[i]);
            }

            List<Musteri> musteriListe = new List<Musteri>();
            musteriListe.Add(new Musteri()
            {
                id = 1,
                name = "Cengiz",
                surname = "Atilla"
            });

            foreach (Musteri item in musteriListe)
            {
                Console.WriteLine(item.name);
            }
        }
    }
}
