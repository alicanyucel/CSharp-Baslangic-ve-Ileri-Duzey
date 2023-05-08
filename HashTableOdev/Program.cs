using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Hashtable içerisine ENG - TR olarak data ekleme
             * 
             * Yeni kayıt eklemek istiyor musunuz? E/H
             * E : Yeni kayıt ekleme işlemi devam etsin.
             * H : Tüm listeyi yazdırsın.
             * 
             * Var olan bir key değeri ekliyor ise kullanıcıya bu değrr daha önceden .. şeklinde sistemizde bulunmaktadır.
             * 
             */

            Hashtable sozlukVeriTabani = new Hashtable();

            do
            {
                Console.Clear();
                Console.WriteLine("Eklemek istediğiniz sözlük değerini yazınız... ");
                Console.Write("English : ");
                string eng = Console.ReadLine();

                bool kontrol = sozlukVeriTabani.ContainsKey(eng);

                if (kontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz {0} kelimesi sözlük içerisinde bulunmaktadır. {1} değeri türkçe karşılığıdır.", eng, sozlukVeriTabani[eng].ToString());
                }

                else
                {
                    Console.Write("{0} türkçe karşılığını yazınız : ", eng);
                    string tr = Console.ReadLine();

                    sozlukVeriTabani.Add(eng, tr);

                    Console.WriteLine("Kelime başarılı bir şekilde eklenmiştir.");
                    System.Threading.Thread.Sleep(2000);
                }

                Console.WriteLine("Yeni bir kelime eklemek istiyor musunuz ? (E/H)");

            } while (Console.ReadLine().ToUpper() != "H");

            foreach (var item in sozlukVeriTabani.Keys)
            {
                Console.WriteLine("EN : {0} = TR : {1}", item, sozlukVeriTabani[item]);
                System.Threading.Thread.Sleep(2000);
            }

            foreach (DictionaryEntry item in sozlukVeriTabani)
            {
                //Console.WriteLine(item.GetType().Name);
                Console.WriteLine("EN : {0} = TR : {1}", item.Key, item.Value);
                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}
