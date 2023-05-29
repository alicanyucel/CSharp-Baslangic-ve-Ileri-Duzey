using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SHASifrelemeIslemleri
{
    public static class SHA
    {
        public static string SHA256Sifrele(string deger)
        {
            SHA256 sha256 = SHA256Managed.Create();
            byte[] DegerByte = Encoding.UTF8.GetBytes(deger);
            byte[] sha256Byte = sha256.ComputeHash(DegerByte);

            return HastToByte(sha256Byte);
        }

        public static string SHA512Sifrele(string deger)
        {
            SHA512 sha512 = SHA512Managed.Create();
            byte[] DegerByte = Encoding.UTF8.GetBytes(deger);
            byte[] sha512Byte = sha512.ComputeHash(DegerByte);

            return string.Empty;
        }

        private static string HastToByte(byte[] hash)
        {
            StringBuilder sonuc = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sonuc.Append(hash[i].ToString("X2"));
            }

            return sonuc.ToString();
        }
    }
}
