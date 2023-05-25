using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personel> Personellerim = new List<Personel>();

            for (int i = 0; i < 1000; i++)
            {
                Personel P1 = new Personel();
                P1.ID = Guid.NewGuid();
                P1.Isim = FakeData.NameData.GetFirstName();
                P1.Soyisim = FakeData.NameData.GetSurname();
                P1.EmailAdres = $"{P1.Isim},{P1.Soyisim}@{FakeData.NetworkData.GetDomain()}";
                P1.TelefonNumarası = FakeData.PhoneNumberData.GetPhoneNumber();

                Personellerim.Add(P1);
            }
            Console.WriteLine("Bilgilerinizz Json formatında D:\\Udemy\\Personellerim.json olarak kayıt edilecektir.");

            if (Directory.Exists("D:\\Udemy\\"))
            {
                // ilgili klasör var ise herhangi bir işlem yapmıyoruz.
            }
            else
            {
                Directory.CreateDirectory("D:\\Udemy\\");
            }

            string JsonPersonellerim = Newtonsoft.Json.JsonConvert.SerializeObject(Personellerim);
            File.WriteAllText("D:\\Udemy\\Personellerim.json", JsonPersonellerim);

            Console.WriteLine("Json export işlemi tamamlandı.");
        }
    }
}
