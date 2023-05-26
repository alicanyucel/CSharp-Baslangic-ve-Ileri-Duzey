using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LateBindingIslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly Exec = Assembly.GetExecutingAssembly();
            Type T = Exec.GetType("LateBindingIslemleri.Musteri");

            object MusteriInst = Activator.CreateInstance(T);
            MethodInfo MI = T.GetMethod("MusteriIsimGetir");

            string[] Parametrelerim = new string[2];
            Parametrelerim[0] = "Cengiz";
            Parametrelerim[1] = "Atilla";

            string GelenDeger = (string)MI.Invoke(MusteriInst, Parametrelerim);

            Console.WriteLine(GelenDeger);

            Console.ReadLine();
        }
    }
}
