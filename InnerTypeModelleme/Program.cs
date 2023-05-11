using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeModelleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.musteriID = 1;
            M1.tcKimlikNumarasi = "12345678901";
            M1.isim = "Cengiz";
            M1.soyisim = "Atilla";
            M1.olusturmaTarih = DateTime.Now;

            // M1.musteriAdresleri = new MusteriAdres[5];
            // Asla yapma!!

            M1.musteriAdresleri[0] = new MusteriAdres()
            {
                Il = "İstanbul",
                Ilce = "Küçükçekmece",
                Adres = "Adres...",
                adresTip = "İş Yeri"
            };

            M1.musteriSiparisBilgileri[0] = new MusteriSiparisBilgisi()
            {
                siparisNumarasi = "SIP0001"
            };

            M1.musteriAdresleri[0].MusteriAdresTestMetot();

            M1.musteriSiparisBilgileri[0].urunler[0] = new Urun()
            {
                UrunID = 1,
                tanim = "Telefon",
                fiyat = 1500
            };
        }
    }
}
