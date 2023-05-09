using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Araç Sınıfı İnceleme
            Arac A1 = new Arac("Opel", "Corsa", 2010, 56000);

            A1.AlisFiyati = 20000;
            A1.SatisFiyati = 32000;
            A1.MaxIndirimTutari = 1500;

            //A1.Fiyat= Kapsülleme konusu...

            A1.FiyatAta(30000);
            A1.BilgileriGoruntule();

            #endregion





            //Musteri M1 = new Musteri();
            Musteri M1 = new Musteri("123456792", "Murat");
            M1.TCkimliknumara = "123456789";
            M1.isim = "Efrun";
            M1.soyisim = "Evdi";
            M1.cinsiyet = 717770001;

            Musteri M2 = M1;

            M2.isim = "Murat";
            M1.TCkimliknumara = "123456790";

            bool musteriKontrol = M1.MusteriKontrol();

            //M2 = null;
            //M1 = null;

            //string isim = M2.isim; // = new demediğimiz için hata aldık.
        }
    }

    //class Musteri
    //{

    //}
}
