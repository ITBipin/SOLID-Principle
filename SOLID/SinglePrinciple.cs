using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public partial class SinglePrinciple
    {
        //Violating SRP
        public class Notification
        {
            public string SendEmail(string message)
            {
                return "Send Email";
            }
            public string SaveToDatabase(string message)
            {
                return "Save to Database";
            }
        }

        //Adhering to SRP
        public class SingleResponsibility
        {
            public string SendEmail(string message)
            {
                return "Send Email";
            }
        }

        //WITHOUT OCP(Violation)
        public class NotificationWithoutOCP
        {
            public string SendEmail(string message)
            {
                return "Send Email";
            }
            public string SendSMS(string message)
            {
                return "Send SMS";
            }
        }

        //WITH OCP(Adhering)
        public interface INotification
        {
            void Send(string message);
        }
        public class EmailNotification : INotification
        {
            public void Send(string message)
            {
                Console.WriteLine("Sending Email: " + message);
            }
        }
        public class SMSNotification : INotification
        {
            public void Send(string message)
            {
                Console.WriteLine("Sending SMS: " + message);
            }
        }
        // With liskov Substitution Principle
        // Parent class
        public class Bird
        {
            public virtual void Fly()
            {
                Console.WriteLine("This bird can fly.");
            }
        }

        // Child class 1
        public class Sparrow : Bird
        {
            public override void Fly()
            {
                Console.WriteLine("Sparrow is flying.");
            }
        }

        // Child class 2 (but doesn't really fly)
        public class Penguin : Bird
        {
            public override void Fly()
            {
                throw new NotImplementedException("Penguins can't fly!");
            }
        }


        // With ISP
        public interface IEmailNotification
        {
            void Email();
        }
        public interface ISMSNotificatioon
        {
            void SMS();
        }
        public class NotificatioonCenter : IEmailNotification, ISMSNotificatioon
        {
            public void Email()
            {
                Console.WriteLine("Email notification is sending");
            }
            public void SMS()
            {
                Console.WriteLine("Sms notification is sending");
            }
        }
    }
}
