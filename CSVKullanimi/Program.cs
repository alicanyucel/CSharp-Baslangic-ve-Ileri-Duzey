using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Musteri> Musterilerim = new List<Musteri>();

            for (int i = 0; i < 50; i++)
            {
                Musteri Temp = new Musteri();
                Temp.ID = i.ToString();
                Temp.Isim = FakeData.NameData.GetFirstName();
                Temp.Soyisim = FakeData.NameData.GetSurname();
                Temp.EmailAdres = $"{Temp.Isim}.{Temp.Soyisim}@{FakeData.NetworkData.GetDomain()}";
                Temp.TelefonNumarası = FakeData.PhoneNumberData.GetPhoneNumber();

                Musterilerim.Add(Temp);
            }


            StreamWriter SW = new StreamWriter(@"D:\\Udemy\\Musteriler.csv");

            CsvHelper.CsvWriter Write = new CsvHelper.CsvWriter(SW);
            Write.WriteHeader(typeof(Musteri));

            foreach (var item in Musterilerim)
            {
                Write.WriteRecord(item);
            }

            SW.Close();
            Console.WriteLine("Csv olarak kayıt işlemi tamamlanmıştır.");


            StreamReader SR = new StreamReader(@"D:\\Udemy\\Musteriler.csv");
            CsvHelper.CsvReader Reader = new CsvHelper.CsvReader(SR);
            List<Musteri> OkunanData = Reader.GetRecords<Musteri>().ToList();

            Console.WriteLine("Okuma işlemi tamamlanmıştır.");



            Console.WriteLine($"Toplam Adet : {Musterilerim.Count}");
        }
    }
}
