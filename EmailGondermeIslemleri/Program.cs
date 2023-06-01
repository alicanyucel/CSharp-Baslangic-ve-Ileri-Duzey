using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailGondermeIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailGonder("xxx", "Udemy - Email Gönderme İşlemleri", "Merhaba Efrun Evdi!");
        }

        static void EmailGonder(string Kime, string Konu, string Icerik)
        {
            Encoding encode = Encoding.GetEncoding("windows-1254");

            MailAddress To1 = new MailAddress("xxx", "Efrun Evdi", encode);
            MailAddress MailFrom = new MailAddress("xxx", "Kampnaya Bilgilendirme", encode);
            MailMessage Email = new MailMessage();

            Email.From = MailFrom;
            Email.To.Add(Kime);
            Email.To.Add(To1);

            //Email.CC.Add(); // Emaili alan kişi bu liste içerisinde tanımlı olan kişi veya kişileri görebilir.
            Email.CC.Add(new MailAddress("ornek1@cengizatilla.com", "Ornek 1", encode));
            Email.CC.Add(new MailAddress("ornek2@cengizatilla.com", "Ornek 2", encode));
            //Email.Bcc.Add(); // Bu alanda kişi eklenen kişileri göremez.
            Email.Bcc.Add(new MailAddress("ornek3@cengizatilla.com", "Ornek 3", encode));
            Email.Bcc.Add(new MailAddress("ornek4@cengizatilla.com", "Ornek 4", encode));

            Email.Attachments.Add(new Attachment(@"C:\Udemy\ExcelDosyaEmail.xlsx"));

            Email.Subject = Konu;
            Email.Body = Icerik;

            Email.IsBodyHtml = true;

            SmtpClient smtpMail = new SmtpClient("xxx", 587); // 25 olarakta deneyebilirsiniz. Eğer şirketiniz exchange sunucusu üzerinden gönderim yapacaksanız.
            smtpMail.Credentials = new System.Net.NetworkCredential("xxx", "xxx");
            smtpMail.EnableSsl = false;
            smtpMail.Send(Email);
        }
    }
}
