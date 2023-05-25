using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonOkuma
{
    public class XObject
    {
        public Guid ID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string EmailAdress { get; set; }
        public string TelefonNumarası { get; set; }
        public string Sehir { get; set; }

        public override string ToString()
        {
            return $"{Isim} {Soyisim}";
        }
    }
}
