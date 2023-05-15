using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassNedir
{
    public partial class Ogrenci
    {
        public int yeniKayit(Ogrenci o)
        {
            Console.WriteLine("Kayıt işlemi başarılı");
            return 1;
        }

        public int kayitGuncelle(Ogrenci o)
        {
            Console.WriteLine("Kayıt güncelleme işlemi başarılı");
            return 1;
        }

        public int kayitSil(Ogrenci o)
        {
            Console.WriteLine("Kayıt silme işlemi başarılı");
            return 1;
        }
    }
}
