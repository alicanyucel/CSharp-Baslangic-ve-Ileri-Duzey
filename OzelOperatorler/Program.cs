using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelOperatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mod alma operatörü %

            int s1 = 11;
            int s2 = 2;
            int sonucMod = s1 % s2;
            Console.WriteLine(sonucMod);

            // ++ operatörü 

            int s3 = 10;
            int OperatorSonucI = s3++;
            int OperatorSonucII = ++s3;
            //int OperatorSonucI = s3 + 1;

            // -- operatörü 

            int s4 = 10;
            int OperatorSonucIII = s4--;
            int OperatorSonucVI = --s4;
            Console.WriteLine(OperatorSonucVI);
        }
    }
}
