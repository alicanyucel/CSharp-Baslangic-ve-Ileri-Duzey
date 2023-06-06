using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Udemy.WebServisOrnekUygulama.Entities
{
    public class Guvenlik : System.Web.Services.Protocols.SoapHeader
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        //public string ClientKey { get; set; }
        //public string TokenTime { get; set; }
        //public int PrivateValue { get; set; }

        public bool Kontrol()
        {
            if (KullaniciAdi == "Demo" && Sifre == "Demo")
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}