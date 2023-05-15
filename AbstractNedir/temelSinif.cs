using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractNedir
{
    public abstract class temelSinif // Şablon olarak kullanılcak
    {
        public DateTime kayitTarih { get; set; }
        public DateTime guncellemeTarih { get; set; }

        public temelSinif()
        {
            kayitTarih = DateTime.Now;
            guncellemeTarih = DateTime.Now;
        }

        public void Test()
        {
            Console.WriteLine("Temel Sınıf => Test");
        }

        public abstract void testAbstract(); // Metot imzası
    }
}
