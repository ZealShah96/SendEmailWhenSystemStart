using System;

using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace SendEmailWhenLaptopStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // var startTimeSpan = TimeSpan.Zero;
            // var periodTimeSpan = TimeSpan.FromMinutes(1);
            // Console.WriteLine("Write Json of Configuration.");
            // var Input = Console.ReadLine();
            var Input="Zeal Shah";
            // Console.WriteLine(Input);
            MyMethod(Input, 0);

        }

        public static void MyMethod(string json, int i)
        {
            try

            {
                var count = 0;
                var recursionNeeded = false;
                MailMessage mail = new MailMessage();

                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("zealshah96@gmail.com");

                mail.To.Add("zealshah96@gmail.com");

                mail.Subject = "Your system is just been used!!!";

                mail.Body = "Your system is just been used!!!";

                SmtpServer.Port = 587;

                SmtpServer.Credentials = new System.Net.NetworkCredential("zealshah96@gmail.com", "Zaqxswcde1996@");

                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

                Console.WriteLine("mail Send");
                count++;

                if (count < 20 && recursionNeeded)
                {
                    Thread.Sleep(200000);

                    MyMethod(json, count);
                }

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.ToString());

            }
        }
    }
    }

