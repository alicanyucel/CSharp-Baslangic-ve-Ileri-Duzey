using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIOWinForm
{
    public class Personel
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }
        public string firmaAdi { get; set; }
        public string ulke { get; set; }

        public override string ToString()
        {
            return isim + " " + soyisim;
        }

        public string personelBilgiGetir()
        {
            return string.Format("İsim: {0}\nSoyisim: {1}\nEmail: {2}\nFirma: {3}\nÜlke: {4}", isim, soyisim, emailAdres, firmaAdi, ulke);
        }
    }
}
