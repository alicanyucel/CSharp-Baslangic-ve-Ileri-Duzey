using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenlerinDavranislari
{
    class Program
    {
        static void Main(string[] args)
        {
            string degiskenVal1 = "Cengiz Atilla";
            string degiskenVal2 = "Mustafa Taş";

            degiskenVal1 = degiskenVal2;

            degiskenVal2 = "Erol Sevinç";
        }
    }
}
