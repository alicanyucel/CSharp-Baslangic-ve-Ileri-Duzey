using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KalitimNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Kalıtım Nedir?
            temelTip T1 = new temelTip();
            T1.TemelTipMetot1();

            Egitmen E1 = new Egitmen();
            Console.WriteLine("Eğitmen nesnesi örneklendi.");
            E1.TemelTipMetot1();

            // Özel Tiplerde Boxing ve Unboxing

            // Bizim object nesnemiz nedir?
            // Temel Tip
            temelTip T2;
            // Hangi nesnelerde temltip object görevi görür
            // Personel, Eğitmen, Öğrenci
            // Temel Tip nesnesinden türedikleri için temel tip nesnesi bu nesnelerde object gibi davranır.
            T2 = E1; // Eğitmen nesnesini Temel Tip nesnesine atadık.

            E1 = (Egitmen)T2; // Unboxing

            Personel P1 = new Personel();
            T2 = P1; // Personel nesnesini Temel Tip nesnesine atadık. 
            P1 = (Personel)T2;

            Ogrenci O1 = new Ogrenci();
            T2 = O1; // Öğrenci nesnesini Temel Tip nesnesine atadık. 

            O1 = (Ogrenci)T2;

            object O3 = T2;

            // Boxing -- Unboxing

            //object O1 = E1; // Boxing
            //E1 = (Egitmen)O1; // Unboxing
            Console.Clear();
            #endregion

            #region Sealed

            Personel Personel1 = new Personel();
            P1.TemelTipMetot1();

            Ogrenci Ogrenci1 = new Ogrenci();
            O1.TemelTipMetot1();

            object obj1 = Ogrenci1;
            obj1 = P1;
            Personel1 = (Personel)obj1;

            // Ben istiyorum ki türemiş olan tiplerim türeyemesin.
            // object => temelTip => Personel => 
            //                    => Ogrenci  => x
            //                    => Egitmen  => x

            //Test test = new Test();
            //T1.

            // Hangi nesnemizin kalıtılmasını istemiyoruz.
            // Eğitmen sealed
            Console.Clear();

            #endregion

            #region Kalıtılan nesne içerisinde kalıtım yapmak
            Egitmen egitmen1 = new Egitmen();

            // Eğitmen => Personel => TemelTip => Object
            // Object => TemelTip => Personel => Eğitmen
            #endregion

            #region Protected Kullanımı
            /*
             * Public    : Uygulamanın içerisinde veya dışarısında ulaşılabilir anlamını taşır.
             * Private   : Sadece tanımlandığı class çerisinden erişilebilir olur.
             * Protected : Normal kullanımda private olarak davranır. Kalıtım yolu ile başka bir class içerisinde public olarak kullanılır.
             * 
             */

            temelTip temelTip1 = new temelTip();

            Ogrenci ogrenci = new Ogrenci();

            #endregion
        }
    }
}
