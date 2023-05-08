using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotGenelTanim
{
    public class Ogrenci
    {
        public void selamlaOgrenci()
        {
            Console.WriteLine("Merhaba Öğrenci");
        }

        /*
         * [ErişimBelirleyicisi] <GeriDönüşDeğeri> MetotAdı (Parametreler)
         * {
         *      // Metot için gereken kodlar..
         * }
         * 
         * Erişim Belirleyicisi
         * 
         * Public
         * Private
         * Protected
         * Internal
         * Internal Protected
         */

        private void OgrenciMetot1(string ogrenciAdi, string ogrenciSoyadi)
        {
            Console.WriteLine("Öğrenci Bilgileri : {0} {1}", ogrenciAdi, ogrenciSoyadi);
        }

        public void OgrenciMetot2()
        {
            OgrenciMetot1("Efrun", "Evdi");
        }
    }
}
