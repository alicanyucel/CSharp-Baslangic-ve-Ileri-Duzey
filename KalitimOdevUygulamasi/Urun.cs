using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOdevUygulamasi
{
    public class Urun : baseClass
    {
        public string marka { get; set; } // * Belirtmiş olduğumuz markalar içerisinde ürün eklenebilsin.
        public string model { get; set; }

        private decimal _alisFiyat { get; set; }
        public decimal alisFiyat
        {
            get
            {
                return _alisFiyat;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Alış fiyatı 0'dan küçük veya eşit olamaz.");
                }

                else
                {
                    _alisFiyat = value;
                }
            }
        } // * 0 dan küçük olmamalı

        private decimal _satisFiyat { get; set; }
        public decimal satisFiyat
        {
            get
            {
                return _satisFiyat;
            }
            set
            {
                if (value < alisFiyat)
                {
                    Console.WriteLine("Satış fiyatı alış fiyatından küçük olamaz.");
                }

                else
                {
                    _satisFiyat = value;
                }
            }
        } // * Alış fiyatından dan küçük olmamalı

        private decimal _kampanyaFiyat { get; set; }
        public decimal kampanyaFiyat
        {
            get
            {
                return _kampanyaFiyat;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Kampanya fiyatı 0'dan küçük veya eşit olamaz.");
                }

                else
                {
                    _kampanyaFiyat = value;
                }
            }
        } // * Kampanya fiyat değeri 0 dan küçük olmamalı


    }
}
