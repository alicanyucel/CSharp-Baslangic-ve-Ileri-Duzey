using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using Udemy.WebServisOrnekUygulama.Context;
using Udemy.WebServisOrnekUygulama.Entities;
using Udemy.WebServisOrnekUygulama.GuvenlikIslemleri;

namespace Udemy.WebServisOrnekUygulama
{
    /// <summary>
    /// Summary description for UrunServis
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UrunServis : System.Web.Services.WebService
    {

        //[WebMethod]
        //public OutputType UrunKayitYeni(Urun U, Guvenlik G)
        //{
        //    string sifrelenmisData = "E4A2B952-E203-4586-ADC4-D79FE01E3C2F" + G.PrivateValue.ToString() + G.TokenTime;

        //    if (G.ClientKey == SHA.SHA256Olustur(sifrelenmisData))
        //    {
        //        using (DatabaseLogicLayer DLL = new DatabaseLogicLayer())
        //        {
        //            if (DLL.UrunKimlikKontrol(U.UrunKimlik) == OutputType.YeniUrun)
        //            {
        //                return DLL.UrunKayitYeni(U);
        //            }

        //            else
        //            {
        //                return OutputType.KayitliUrun;
        //            }
        //        }
        //    }

        //    else
        //    {
        //        return OutputType.GuvenlikHatasi;
        //    }
        //}

        public Guvenlik GuvenlikSoapHeader;

        [WebMethod]
        [SoapHeader("GuvenlikSoapHeader", Required = true)]
        public OutputType UrunKayitDuzenle(Urun U)
        {
            if (GuvenlikSoapHeader.Kontrol())
            {
                using (DatabaseLogicLayer DLL = new DatabaseLogicLayer())
                {
                    if (DLL.UrunKimlikKontrol(U.UrunKimlik) == OutputType.KayitliUrun)
                    {
                        return DLL.UrunKayitDuzenle(U);
                    }

                    else
                    {
                        return OutputType.UrunBulunamadi;
                    }
                }
            }

            else
            {
                return OutputType.GuvenlikHatasi;
            }

        }

        [WebMethod]
        [SoapHeader("GuvenlikSoapHeader", Required = true)]
        public OutputType UrunKayitSil(string UrunKimlik)
        {
            using (DatabaseLogicLayer DLL = new DatabaseLogicLayer())
            {
                if (DLL.UrunKimlikKontrol(UrunKimlik) == OutputType.KayitliUrun)
                {
                    return DLL.UrunKayitSil(UrunKimlik);
                }

                else
                {
                    return OutputType.UrunBulunamadi;
                }
            }
        }

        [WebMethod]
        public List<Urun> UrunTumListe()
        {
            using (DatabaseLogicLayer DLL = new DatabaseLogicLayer())
            {
                return DLL.UrunKayitListe();
            }
        }

        [WebMethod]
        public Urun UrunGetir(string UrunKimlik)
        {
            if (GuvenlikSoapHeader.Kontrol())
            {
                using (DatabaseLogicLayer DLL = new DatabaseLogicLayer())
                {
                    if (DLL.UrunKimlikKontrol(UrunKimlik) == OutputType.KayitliUrun)
                    {
                        return DLL.UrunKayitListe(UrunKimlik);
                    }

                    else
                    {
                        return null;
                    }
                }
            }

            else
            {
                return new Urun();
            }
        }
    }
}
