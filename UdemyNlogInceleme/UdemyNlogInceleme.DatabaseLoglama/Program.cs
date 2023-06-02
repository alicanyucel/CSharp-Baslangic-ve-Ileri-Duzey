using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyNlogInceleme.DatabaseLoglama
{
    class Program
    {
        static void Main(string[] args)
        {
            // Database Hazırlığı => SP
            // App.config (Database Yolu)
            // NLog paket dosyaları
            // NLog.config
            // Loglama işlemini test
            try
            {
                int Sayi1 = 0;
                int Sonuc = 10 / Sayi1;
            }
            catch (Exception ex)
            {
                Logger logger = LogManager.GetLogger("databaseLogger");
                logger.Error(ex.Message);
            }
        }
    }
}
