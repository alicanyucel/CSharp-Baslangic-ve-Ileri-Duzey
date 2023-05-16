using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassNedir1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Database | Uygulama
             * MSSQL    | C#
             * 
             * tblMusteri
             * id => int
             * musteriNumara => uniqueidentitfy (Guid)
             * isim nvarchar(50) string
             * soyisim nvarchar(50) string
             * dogumTarih datetime datetime
             * 
             * UnitOfWorks => Generic Class | Generic Interface
             * 
             */

            // GenericRepository<int> intRepository = new GenericRepository<int>();

            GenericRepository<Musteri> repositoryMusteri = new GenericRepository<Musteri>();
            List<Musteri> musterilerim = repositoryMusteri.Getir();
            repositoryMusteri.yeniKayitEkle(null);

            GenericRepository<Urun> repositoryUrun = new GenericRepository<Urun>();
            repositoryUrun.Getir();
            repositoryUrun.yeniKayitEkle(null);
        }
    }
}
