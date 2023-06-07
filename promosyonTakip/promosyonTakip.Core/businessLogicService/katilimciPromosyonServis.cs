using promosyonTakip.Core.entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promosyonTakip.Core.businessLogicService
{
    public class katilimciPromosyonServis:baseServis<katilimciPromosyon>
    {
        database.promosyonSepeti db;
        public katilimciPromosyonServis()
        {
            db = new database.promosyonSepeti();
        }

        public int kayitYeni(katilimciPromosyon data)
        {
            cmd = new System.Data.SqlClient.SqlCommand("insert into katilimciPromosyon values (@potansiyelMusteriId,@promosyonUrunId,@olusturmaTarih,@magazaId)");
            cmd.Parameters.Add("@potansiyelMusteriId", SqlDbType.Int).Value = data.potansiyelMusteriId;
            cmd.Parameters.Add("@promosyonUrunId", SqlDbType.Int).Value = data.promosyonUrunId;
            cmd.Parameters.Add("@olusturmaTarih", SqlDbType.DateTime).Value = data.olusturmaTarih;
            cmd.Parameters.Add("@magazaId", SqlDbType.Int).Value = data.magazaId;
            return db.ekleDuzenleSil(cmd);
        }
    }
}
