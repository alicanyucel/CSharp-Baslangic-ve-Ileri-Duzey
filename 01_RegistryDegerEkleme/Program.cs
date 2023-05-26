using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_RegistryDegerEkleme
{
    class Program
    {
        static void Main(string[] args)
        {

            //// Yeni bir değer ekleme işlemi
            //Registry.CurrentUser.SetValue("Anahtar", "Merhaba Registry");

            //// Oluşturulmuş olduğumuz değerimizi okuyalım
            //string GelenDeger = Registry.CurrentUser.GetValue("Anahtar").ToString();
            //Console.WriteLine($"Registry içerisindeki değer : {GelenDeger}");

            //// Değer silme işlemi
            //Registry.CurrentUser.DeleteValue("Anahtar");

            //// Yeni bir klasör ekleme işlemi
            //Registry.CurrentUser.CreateSubKey("XYZProjesi");

            //// Subkey oluşturma işlemi
            //RegistryKey XYZProjesi = Registry.CurrentUser.OpenSubKey("XYZProjesi", true);

            //// Subkey içerisine değer ekleme işlemi
            //XYZProjesi.SetValue("HardDiskSeriNumarasi", "123456789");

            //// Subkey içerisinden değer okuma işlemi
            //string SeriNumarasi = XYZProjesi.GetValue("HardDiskSeriNumarasi").ToString();
            //Console.WriteLine(SeriNumarasi);

            RegistryKey XYZProjesi = Registry.CurrentUser.OpenSubKey("XYZProjesi", false);
            string[] Keys = XYZProjesi.GetValueNames();

            for (int i = 0; i < Keys.Length; i++)
            {
                Console.WriteLine($"Anahtar : {Keys[i]} Value : {XYZProjesi.GetValue(Keys[i])} ");
            }

            Console.Read();
        }
    }
}
