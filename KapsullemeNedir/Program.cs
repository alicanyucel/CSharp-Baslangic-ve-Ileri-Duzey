using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            //M1.id = 1;
            //M1.Name = "Efrun";
            //M1.Surname = "Evdi";

            /*
             * Field değer ataması yapılamasın ama değer okunabilsin.
             * Field içerisine değer ataması yapılsın ama değer okunamasın.
             * Field içerisine değer ataması yapılsın ama değerin ilk 4 hanesi okunsun.
             * Field ataması ve okuma işlemleri yapılsın ama bu iki işlemde bizim belirlediğimiz bir süreçten geçsin veri daha sonra gösterilsin.
             */

            // Class
            // Field

            // Property
            // Get & Set

            // M1.emailaddress = "efruncetkin@gmail.com"; ( Field )
            // M1.EmailAddress = "efruncetkin@gmail.com";

            Console.WriteLine(M1.EmailAddress);

            #region Field değer ataması yapılamasın ama değer okunabilsin.
            Console.WriteLine("Müşteri ID Değeri = " + M1.ID.ToString());

            // M1.ID = 10; Değer atanamıyor ama okunabiliyor.
            #endregion

            #region Verileri Kapsülleme Ödev
            M1.TCkimliknumarasi = "12345678912";
            Console.WriteLine(M1.TCkimliknumarasi);
            #endregion

            #region
            /*
             * İsim ve Soyisim
             * İsim ve Soyisim [Soyisim] = set
             * 
             * Email Adresi
             * Email get cengizatilla@gmail.com
             * set : private
             * 
             */

            M1.Name = "Efrun";
            M1.Surname = "Evdi";
            Console.WriteLine(M1.EmailAddress);

            #endregion
        }
    }
}
