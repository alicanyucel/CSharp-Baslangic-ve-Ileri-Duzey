using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonOkuma
{
    class Program
    {
        static void Main(string[] args)
        {
            string JsonOkunanData = File.ReadAllText("D:\\Udemy\\Personellerim.json");
            List<XObject> Data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<XObject>>(JsonOkunanData);

            for (int i = 0; i < Data.Count; i++)
            {
                Console.WriteLine(Data[i]);
            }
        }
    }
}
