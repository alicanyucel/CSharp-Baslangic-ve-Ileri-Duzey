using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D4.ListGenericTodoUygulama.entities
{
    public class todo
    {
        [DisplayName("ID")]
        public Guid id { get; set; }
        [DisplayName("Başlık")]
        public string baslik { get; set; }
        [DisplayName("Kısa Açıklama")]
        public string kisaAciklama { get; set; }
        [DisplayName("Açıklama")]
        public string aciklama { get; set; }
        [DisplayName("Önem Derecesi")]
        public int onemDerece { get; set; }
        [DisplayName("Durum")]
        public string durumAciklama { get; set; }
        [DisplayName("Oluşturma Tarihi")]
        public DateTime olusturmaTarih { get; set; }
    }
}
