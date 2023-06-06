using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Udemy.WebServisAspNetTest
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UrunServis.UrunServis US = new UrunServis.UrunServis();
            US.GuvenlikValue = new UrunServis.Guvenlik();
            US.GuvenlikValue.KullaniciAdi = "Demo";
            US.GuvenlikValue.Sifre = "Demo";

            US.UrunKayitDuzenle(new UrunServis.Urun()
            {
                ID = 3
            });
        }
    }
}