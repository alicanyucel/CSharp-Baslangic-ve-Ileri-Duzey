using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelUygulamasi
{
    public class Personel
    {
        public static string domainAdres;
        public string Isim { get; set; }
        public string Soyisim { get; set; }

        private string _emailadres;
        public string EmailAdres
        {
            get
            {
                return this._emailadres;
            }
            set
            {
                this._emailadres = value.ToLower() + "@" + Personel.domainAdres;
            }
        }
        public int Cinsiyet { get; set; }

        public Personel()
        {
            Console.WriteLine("Her örneklemede çalışan metot");
        }

        static Personel()
        {
            domainAdres = "firmam.com";
        }
    }
}
