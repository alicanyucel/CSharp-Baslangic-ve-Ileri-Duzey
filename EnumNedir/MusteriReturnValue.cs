using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumNedir
{
    public enum MusteriReturnValue // Tamamen kodu daha okunaklı yapmak için kullanılır.
    {
        kayitBasarili = 717770001,
        kayitBasarisiz = 717770002,
        varolanMusteri = 717770003,
        parametreHatasi = 717770004,
        calismaZamaniHatasi = 717770005

        // İstediğimiz değeri verebiliriz.
    }
}
