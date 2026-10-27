#region 1 adama mail gondermek

//using System.Net;
//using System.Net.Mail;

//namespace SMTP
//{
//    internal class Program
//    {
//        static string fromMail = "";  //gonderen mail
//        static string appPassword = ""; //onun app passwordu (adi sifre deyil)
//        static string toMail = ""; //kime gonderilecek o adamin maili, alici mail


//        static void Main(string[] args)
//        {

//            var mail = new MailMessage(); //mail formatini yaratmaq ucun
//            mail.From = new MailAddress(fromMail); //hardan gonderilecek

//            mail.To.Add(new MailAddress(toMail)); //kime gonderilecek 
//            mail.Subject = "Salam";
//            mail.Body = "Bu mənim C# ilə ilk göndərdiyim mail-dır...";

//            var smtp = new SmtpClient("smtp.gmail.com"); //gmail.com ucundur
//            smtp.Port = 587;
//            smtp.EnableSsl = true; //sifreleme ucundur 
//            smtp.Credentials = new NetworkCredential(fromMail, appPassword);

//            try
//            {
//                smtp.Send(mail);
//                Console.WriteLine("Mail ugurla gonderildi...");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Xeta: " + ex.Message);
//            }



//        }
//    }
//}




#endregion

#region 1den cox adama mail gondermek

using System.Net;
using System.Net.Mail;

namespace SMTP_Test
{
    internal class Program
    {
        static string fromMail = "";  //gonderen mail
        static string appPassword = ""; //onun app passwordu (adi sifre deyil)
        static string toMail = ""; //kime gonderilecek o adamin maili, alici mail


        static void Main(string[] args)
        {

            var mail = new MailMessage(); //mail formatini yaratmaq ucun
            mail.From = new MailAddress(fromMail); //hardan gonderilecek

            mail.To.Add(new MailAddress("")); //kime gonderilecek 
            mail.To.Add(new MailAddress("")); //kime gonderilecek 
            mail.Subject = "Salam";
            mail.Body = "Bu mənim C# ilə ilk göndərdiyim mail-dır...";

            var smtp = new SmtpClient("smtp.gmail.com"); //gmail.com ucundur
            smtp.Port = 587;
            smtp.EnableSsl = true; //sifreleme ucundur 
            smtp.Credentials = new NetworkCredential(fromMail, appPassword);

            try
            {
                smtp.Send(mail);
                Console.WriteLine("Mail ugurla gonderildi...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xeta: " + ex.Message);
            }
        }
    }
}


#endregion