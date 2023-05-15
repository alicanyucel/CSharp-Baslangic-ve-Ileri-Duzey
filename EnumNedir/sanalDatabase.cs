using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumNedir
{
    public class sanalDatabase
    {
        ArrayList sanalDB = new ArrayList();

        public MusteriReturnValue musteriYeniKayit(Musteri M)
        {
            // Kayıt kontrol, parametre kontrol yapabilirdik.
            sanalDB.Add(M);
            return MusteriReturnValue.kayitBasarili;
        }
    }
}
