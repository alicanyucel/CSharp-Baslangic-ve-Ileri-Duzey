using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Udemy.WebServisOrnekUygulama.GuvenlikIslemleri
{
    public static class SHA
    {
        public static string SHA256Olustur(string sifrelenecekDeger)
        {
            SHA256 sha256 = SHA256Managed.Create();
            byte[] byteDizi = Encoding.UTF8.GetBytes(sifrelenecekDeger);
            byte[] sifreDizi = sha256.ComputeHash(byteDizi);
            string hashString = FormatDuzenle(sifreDizi);

            return hashString;
        }

        private static string FormatDuzenle(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }

            return result.ToString();
        }
    }
}