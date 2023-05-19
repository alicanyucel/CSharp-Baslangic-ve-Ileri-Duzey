using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIO.FileIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Kontrol = FileExist("D:\\Udemy\\Merhaba.txt");

            if (Kontrol)
            {
                Console.WriteLine("Belirtmiş olduğunuz dosya sistem içerisinde bulunmaktadır.");
            }
            else
            {
                //FileCreate("D:\\Udemy\\Merhaba.txt");
            }

            string metinDegeri = FileReadAllText("D:\\Udemy\\Merhaba.txt");
            Console.WriteLine(metinDegeri);

            FileAppendText("D:\\Udemy\\Merhaba.txt", "Merhaba TXT");

            FileCopy("D:\\Udemy2\\Merhaba.txt", "D:\\Udemy\\Merhaba.txt");

            FileMove("D:\\Udemy\\Merhaba.txt", "D:\\Udemy2\\Merhaba.txt");

            //FileDelete("D:\\Udemy\\Merhaba.txt");
        }

        static void FileCreate(string path) // Dosya oluşturur.
        {
            FileStream fileStream = File.Create(path);
            fileStream.Close();
        }

        static bool FileExist(string path) // Var mı diye kontrol eder.
        {
            return File.Exists(path);
        }

        static void FileDelete(string path)
        {
            File.Delete(path);
        }

        static void FileMove(string kaynak, string hedef) // İstediğimiz yere taşıyor.
        {
            File.Move(kaynak, hedef);
        }

        static void FileCopy(string kaynak, string hedef) // Kopyalama işlemi
        {
            File.Copy(kaynak, hedef);
        }

        static void FileAppendText(string path, string deger) // İçerisine istediğimiz yazdık
        {
            File.AppendAllText(path, deger);
        }

        static string FileReadAllText(string path) // İçindeki metin değerini okur.
        {
            string metinDegeri = File.ReadAllText(path);
            return metinDegeri;
        }
    }
}
