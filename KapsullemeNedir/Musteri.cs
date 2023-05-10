using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeNedir
{
    internal class Musteri
    {
        public Musteri()
        {
            this.id = IDUret();
        }

        // Class => Field

        int id;
        public int ID
        {
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }


        public string Name;
        private string _surname;

        public string Surname
        {
            get { return this._surname; }
            set
            {
                this._surname = value;
                this.emailaddress = string.Format("{0}.{1}@gmail.com", Name, _surname);
            }
        }

        private string emailaddress;

        // Class => Property

        public string EmailAddress
        {
            // get; // Database veya farklı bir veri kaynağı ... Classı çağıran programcıya datayı gösterdiğimiz kısım.
            // set; // Dış dünyadan alınan datanın içeride private olarak saklanan field içerisine değer atandığı kısım.

            private set
            {
                this.emailaddress = value;
            }

            get
            {
                return this.emailaddress;
            }
        }

        private string _tckimliknumarasi;
        public string TCkimliknumarasi
        {
            get
            {
                return _tckimliknumarasi.Substring(0, 3);
            }

            set
            {
                if (value.Length == 11)
                {
                    bool bayrak = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterKontrol = char.IsNumber(value[i]);
                        if (karakterKontrol)
                        {
                            // sayısal değer demektir... 
                        }
                        else
                        {
                            bayrak = true;
                            break;
                        }
                    }

                    if (bayrak)
                    {
                        Console.WriteLine("TC Kimilik Numarası içindeki değerler sayısal olmalıdır...");
                    }
                    else
                    {
                        this._tckimliknumarasi = value;
                    }
                }
                else
                {
                    Console.WriteLine("TC Kimlik Numarası 11 hane olmalıdır...");
                }
            }
        }

        private int IDUret()
        {
            Random rnd = new Random();
            return rnd.Next(10000, 90000);
        }
    }
}
