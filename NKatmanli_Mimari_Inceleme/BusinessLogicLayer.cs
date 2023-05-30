using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKatmanli_Mimari_Inceleme
{
    internal class BusinessLogicLayer
    {
        DataAccessLayer DAL;

        public BusinessLogicLayer()
        {
            DAL = new DataAccessLayer();
        }

        internal int VeriKaydet(int MusteriID, string Isim, string Soyisim)
        {
            if (!string.IsNullOrEmpty(Isim) && !string.IsNullOrEmpty(Soyisim))
            {
                Musteri M1 = new Musteri();
                M1.MusteriID = MusteriID;
                M1.Isim = Isim;
                M1.Soyisim = Soyisim;

                return DAL.VeriKaydet(M1);
            }

            else
            {
                return -1; // Eksik parametre hatası
            }
        }
    }
}
