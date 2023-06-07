using NetFramework.S18.D4.ListGenericTodoUygulama.database;
using NetFramework.S18.D4.ListGenericTodoUygulama.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D4.ListGenericTodoUygulama.businessService
{
    public class todoService
    {
        public int kayitKontrol()
        {
            return sanalDatabase.todoTablo.Count;
        }

        public List<todo> kayitListe()
        {
            return sanalDatabase.todoTablo;
        }

        public int kayitYeni(todo data)
        {
            try
            {
                sanalDatabase.todoTablo.Add(data);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
