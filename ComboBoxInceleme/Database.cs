using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxInceleme
{
    public class Database
    {
        public static List<Urun> UrunTablo = new List<Urun>()
        {
            new Urun(){ id = 1, urunAdi = "Bir Ömür Nasıl Yaşanır", stokAdet = 10, urunKategori  = "Roman", aciklama = @"Cesur olun. Kendinizi rahat hissettiğiniz alanın dışında pencereler açın. Farklı dünyalarla ancak böyle tanışırsınız. Ben hep yerimde dursaydım, dünyamı değiştirecek insanları aramasaydım, bugün tanıdığınız ben olmazdım. Bir insanın bittiği an, miskinliğe esir olduğu andır. İnsan, konforundan vazgeçmeyi göze almalıdır. Kendi dünyasını yerinden kendisi oynatmalıdır.", yazar = "İlber Ortaylı", urunResim = @"C:\Users\efrun\source\repos\C#-Baslangic-ve-Ileri-Duzey\ComboBoxInceleme\Resimler\1.jpg"},
            new Urun(){ id = 2, urunAdi ="Metastaz", stokAdet = 10, urunKategori = "Roman", aciklama = @"Menzilci polisler ilk kez göreceğiniz fotoğraflarında ne yapıyordu?
- AKP’li Bakan’ın tarikat şeyhinden özel ricası neydi?
- Devlette FETÖ’den boşalan koltuklara hangi tarikat nasıl yerleşti?
- Nedir bu hüsn-ü şehadet ve FETÖ borsası? 
- Hangi cemaat kim için Cumhurbaşkanı’na mektup yazarak kefil oldu?
- Genelkurmay Başkanı’nın “sahip çıkın” dediği isimler neden tutuklandı?
- “Kurda kuşa yem etmeyin” denilen işadamı nasıl hapisten çıktı?
- FETÖ operasyonlarından çıkarılan imtiyazlı ortaklar kim?
- Hâkim rüşvet alırken gizli bir operasyonla nasıl yakalandı?
- Hangi gazeteci kendisini MİT’çi diye tanıtıp dolandırıcılık yaptı?
", yazar  = "Barış Pehlivan && Barış Terkoğlu", urunResim = @"C:\Users\efrun\source\repos\C#-Baslangic-ve-Ileri-Duzey\ComboBoxInceleme\Resimler\2.jpg" },
            new Urun(){
                 id = 3, urunAdi ="Şeker Portakalı", stokAdet = 10, urunKategori = "Roman", aciklama = @" Ne güzel bir şeker portakalı fidanıymış bu! Hem bak, dikeni de yok. Pek de kişilik sahibiymiş, şeker portakalı olduğu ta uzaktan belli. Ben senin boyunda olsaydım başka şey istemezdim.-", yazar  = "Jose Mauro De Vasconcelos ", urunResim = @"C:\Users\efrun\source\repos\C#-Baslangic-ve-Ileri-Duzey\ComboBoxInceleme\Resimler\3.jpg"
            }
        };
    }
}

