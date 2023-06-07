using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelOkuWinApp
{
    public static class ExcelIslemleri
    {
        public static List<Urun> ExcelOku(string DosyaYol)
        {
            List<Urun> urunlerim = new List<Urun>();
            Urun temp = null;

            FileStream fileStream = File.Open(DosyaYol, FileMode.Open, FileAccess.Read);
            IExcelDataReader reader = ExcelDataReader.ExcelReaderFactory.CreateReader(fileStream);
            while (reader.Read())
            {
                if (reader[0] != null)
                {
                    temp = new Urun();
                    temp.Numara = reader.IsDBNull(0) ? 0 : int.Parse(reader[0].ToString());
                    temp.Baslik = reader.IsDBNull(1) ? string.Empty : reader[1].ToString();
                    temp.Debit = reader.IsDBNull(2) ? 0m : decimal.Parse(reader[2].ToString());
                    temp.Credit = reader.IsDBNull(3) ? 0m : decimal.Parse(reader[3].ToString());
                    if (temp.Numara > 0 && !string.IsNullOrEmpty(temp.Baslik))
                    {

                        if (temp.Numara > 0 && !string.IsNullOrEmpty(temp.Baslik) && temp.Debit > 0) temp.Bilgilendirme = "D";
                        else if (temp.Numara > 0 && !string.IsNullOrEmpty(temp.Baslik) && temp.Credit > 0) temp.Bilgilendirme = "C";

                        urunlerim.Add(temp);
                    }
                }

            }

            return urunlerim;

        }

    }
}
