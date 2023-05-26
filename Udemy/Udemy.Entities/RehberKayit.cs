using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Entities
{
    public class RehberKayit
    {
        public Guid ID { get; set; }

        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string TelefonI { get; set; }
        public string TelefonII { get; set; }
        public string TelefonIII { get; set; }
        public string Adres { get; set; }
        public string EmailAdres { get; set; }
        public string Website { get; set; }
        public string Aciklama { get; set; }

        public override string ToString()
        {
            return $"{Isim} {Soyisim}";
        }
    }
}
