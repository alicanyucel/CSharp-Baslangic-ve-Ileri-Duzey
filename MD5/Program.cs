using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MD5
{
    class Program
    {
        static void Main(string[] args)
        {
            string SifrelenecekMetin = "Efrun1Evdi";
            MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();

            byte[] SifrelenecekMetinBytes = System.Text.Encoding.UTF8.GetBytes(SifrelenecekMetin);
            byte[] MD5ComputeBytes = MD5.ComputeHash(SifrelenecekMetinBytes);
            string SifrelenenDeger = Convert.ToBase64String(MD5ComputeBytes);

            Console.WriteLine(SifrelenenDeger); // Tekrar şifreyi eski haline dönüştüremiyoruz. Tek yönlü şifreleme.

        }
    }
}
