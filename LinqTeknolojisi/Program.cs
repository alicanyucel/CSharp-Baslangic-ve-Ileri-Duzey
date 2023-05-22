using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTeknolojisi
{
    internal class Program
    {
        static bool funcDelegateKullanimi1(Musteri musteri)
        {
            if (musteri.isim[0] == 'A')
                return true;
            else
                return false;
        }

        static bool predicateDelegateMetot(Musteri m)
        {
            if (m.dogumTarihi.Year > 1990)
                return true;
            else
                return false;
        }
        static void musteriListele(Musteri m)
        {
            Console.WriteLine($"{m.isim} {m.soyisim}");
        }

        static void Main(string[] args)
        {
            DataSource dataSource = new DataSource();
            List<Musteri> musteriListe = dataSource.musteriListesi();

            #region Başlarken
            // A ile başlayan müşterilerin adedini verin...

            int bulunanToplam = 0;
            for (int i = 0; i < musteriListe.Count; i++)
            {
                if (musteriListe[i].isim[0] == 'A')
                {
                    bulunanToplam++;
                }
            }

            Console.WriteLine("Liste içerisinde isim değeri A ile başlayan kayıt sayısı : " + bulunanToplam);

            Console.WriteLine(musteriListe.Count);

            bulunanToplam = 0;

            bulunanToplam = musteriListe.Where(i => i.isim.StartsWith("A")).Count();
            Console.WriteLine(("Liste içerisinde isim değeri A ile başlayan kayıt sayısı : " + bulunanToplam));

            Console.Clear();
            #endregion

            #region Linq Sorgulama Çeşitleri
            // I. Yol
            int toplamMusteriAdetI = musteriListe.Where(I => I.isim.StartsWith("A")).Count();

            var toplamMusteriBulunan = (from I in musteriListe
                                        where I.isim.StartsWith("A")
                                        select I);
            int toplamMusteriAdetII = toplamMusteriBulunan.Count();

            Console.Clear();
            #endregion

            #region Alistirmalar
            // 1: Musteriler içerisinde ülke değeri A ile başlayan müşterileri Linq to metot kullanarak bulalım.
            IEnumerable<Musteri> musteriListeAlistirma1 = musteriListe.Where(I => I.ulke.StartsWith("A"));
            Console.WriteLine(musteriListeAlistirma1.Count());

            // 2: Musteriler içerisindeki kayıtlardan isminin içinde b harfi geçen ve ulke değeri içinde A harfi geçen müşterilerin listesini getirin. &&
            var musteriListeAlistirma2 = musteriListe.Where(I => I.isim.Contains("b") && I.ulke.Contains("a")).ToList();

            // 3: Musteriler içerisindeki kayıtlardan doğum yılı 1990 dan büyük olan ve isminin içerisinde a harfi geçen 2.yol ile link to query ile bulalım.
            var musteriListeAlistirma3 = from I in musteriListe
                                         where I.dogumTarihi.Year > 1990 && I.isim.Contains("a")
                                         select I;

            Console.WriteLine(musteriListeAlistirma3.Count());

            // 4: Musteriler içerisindeki kayıtlardan doğum yılı 1990 dan büyük olan veya isminin içerisinde a harfi geçen 2.yol ile link to query ile bulalım.

            var musteriListeAlistirma4 = from I in musteriListe
                                         where I.dogumTarihi.Year > 1990 || I.isim.Contains("a")
                                         select I;

            Console.WriteLine(musteriListeAlistirma4.Count());

            Console.Clear();
            #endregion

            #region Linq Sorgularında Delegate Kullanımı = Func Delegate // Geriye farklı değerler dönebilir
            var DelegateKullanimi1 = musteriListe.Where(I => I.isim.StartsWith("A"));
            Func<Musteri, bool> funcDelegate1 = new Func<Musteri, bool>(funcDelegateKullanimi1);

            var DelegateKullanimi2 = musteriListe.Where(funcDelegate1);

            DelegateKullanimi2 = musteriListe.Where(funcDelegateKullanimi1);

            var DelegateKullanimi3 = musteriListe.Where(new Func<Musteri, bool>(funcDelegateKullanimi1));

            var DelegateKullanimi4 = musteriListe.Where(delegate (Musteri m) { return m.isim[0] == 'A' ? true : false; });

            var DelegateKullanimi5 = musteriListe.Where((Musteri M) => { return M.isim[0] == 'A' ? true : false; });

            var DelegateKullanimi6 = musteriListe.Where((m) => { return m.isim[0] == 'A' ? true : false; });

            var DelegateKullanimi7 = musteriListe.Where(m => m.isim[0] == 'A'); // =>

            Console.Clear();
            #endregion

            #region Linq sorgularında Delegate Kullanımı = Predicate Delegate // Geriye bool döner
            Predicate<Musteri> predicate = new Predicate<Musteri>(predicateDelegateMetot);

            var DelegateKullanimiPredicate1 = musteriListe.FindAll(predicate);

            var DelegateKullanimiPredicate2 = musteriListe.FindAll(new Predicate<Musteri>(predicateDelegateMetot));

            var DelegateKullanimiPredicate3 = musteriListe.FindAll(delegate (Musteri m) { return m.dogumTarihi.Year > 1990; });

            var DelegateKullanimiPredicate4 = musteriListe.FindAll((Musteri m) => { return m.dogumTarihi.Year > 1990; });

            var DelegateKullanimiPredicate5 = musteriListe.FindAll((m) => { return m.dogumTarihi.Year > 1990; });

            var DelegateKullanimiPredicate6 = musteriListe.FindAll(m => m.dogumTarihi.Year > 1990);

            Console.Clear();
            #endregion

            #region Action Delegate
            Action<Musteri> actionMusteri = new Action<Musteri>(musteriListele);

            musteriListe.ForEach(actionMusteri);

            musteriListe.ForEach(new Action<Musteri>(musteriListele));

            musteriListe.ForEach(delegate (Musteri m) { Console.WriteLine($"{m.isim} {m.soyisim}"); });

            musteriListe.ForEach((Musteri m) => { Console.WriteLine($"{m.isim} {m.soyisim}"); });

            musteriListe.ForEach((m) => { Console.WriteLine($"{m.isim} {m.soyisim}"); });

            Console.Clear();
            #endregion

            #region Linq Inceleme ve Ara Ödevler
            // Müşteri listesi içerisinde bulunan kayıtlardan ismi a ile başlayan soyisim değerinin içinde e olan ve doğum yılı 1985 den büyük olan kayıtları getirin.
            var odevAlistirma1 = from I in musteriListe
                                 where
                                 I.isim.StartsWith("A") &&
                                 I.soyisim.Contains("e") &&
                                 I.dogumTarihi.Year > 1985
                                 select I;

            Console.WriteLine(odevAlistirma1.Count());

            var odevAlistirma2 = musteriListe.Where(I => I.isim.StartsWith("A") && I.soyisim.Contains("e") && I.dogumTarihi.Year > 1985).Select(I => I);

            Console.WriteLine(odevAlistirma2.Count());

            #endregion
        }
    }
}
