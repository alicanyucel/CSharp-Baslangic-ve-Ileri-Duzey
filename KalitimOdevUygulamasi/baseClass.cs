using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOdevUygulamasi
{
    public class baseClass
    {

        public static int sayac = 1; // İlk oluştuğu zaman 1 değerini otomatik olarak alsın.

        public baseClass()
        {
            _id = sayac;
            sayac = sayac + 1;
        }

        private int _id;

        public int Id
        {
            get
            {
                return _id;
            }

            private set
            {
                // Bir sayaç içerisindeki değerden faydalanmak istiyoruz.
                // _id = sayac;
                // sayac = sayac + 1;
                // nedeni basit set alanı private olarak işaretlendi
            }
        } // *

        private string _barkod;
        public string barkod
        {
            get
            {
                return _barkod;
            }
            set
            {
                bool kontrolIslemi = sanalDatabase.dbBarkodKontrol(value);
                if (!kontrolIslemi) // Değeri sanal database içerisinde bulamadım.
                {
                    _barkod = value;
                }

                else
                {
                    Console.WriteLine("Sanal database içerisinde bu barkod değeri girilmiştir.");
                }
            }
        } // *

        public DateTime olusturmaTarihi { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public int guncelleyenKullanici { get; set; }
        public bool silindi { get; set; }
    }
}
