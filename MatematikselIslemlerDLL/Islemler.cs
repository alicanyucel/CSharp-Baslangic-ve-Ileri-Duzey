using System;

namespace MatematikselIslemlerDLL
{
    public class Islemler
    {
        // Dış dünyaya açık olan metotlarım 

        public int Toplama(int Sayi1, int Sayi2)
        {
            return Sayi1 + Sayi2;
        }

        public int Cikartma(int Sayi1, int Sayi2)
        {
            return Sayi1 - Sayi2;
        }

        public int Carpma(int Sayi1, int Sayi2)
        {
            return Sayi1 * Sayi2;
        }

        public int Bolme(int Sayi1, int Sayi2)
        {
            return Sayi1 / Sayi2;
        }

        private void OzelMetot()
        {
            Console.WriteLine("Bu metod DLL referans edildiği zaman çalışmyacaktır.");
        }
    }
}
