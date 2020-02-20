using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace sendMail
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            Console.WriteLine("enter senders mail");
            string From = Console.ReadLine();
            var fromAddress = new MailAddress(From, "from");
            Console.WriteLine("enter receipts mail");
            string To = Console.ReadLine();
            var toAddress = new MailAddress(To, "to");
            Console.WriteLine("enter password");

            string fromPassword = c.pass;
            Console.WriteLine("enter subject");
            string subject = Console.ReadLine();
            Console.WriteLine("enter body");
            string body = Console.ReadLine();

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
