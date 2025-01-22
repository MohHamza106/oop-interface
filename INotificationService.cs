using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_interface
{
    internal interface INotificationService
    {
        public string message { get; set; }
        public virtual void SendNotification()
        {

        }

    }
    class SmsNotificationService : INotificationService
    {
        public string SMS;
        public string message
        {
            get
            {
                return $"{SMS}";
            }
            set
            {
                SMS = value;
            }

        }
        public SmsNotificationService(string SMS)
        {
            this.SMS = SMS;
        }

        public void SendNotification()
        {
            Console.WriteLine($"SmsNotificationService :{message} ");
        }

    }
    class EmailNotificationService : INotificationService
    {
        public string Email;
        public string message
        {
            get
            {
                return $"{Email}";
            }
            set
            {
                Email = value;
            }

        }
        public EmailNotificationService(string email)
        {
            this.Email = email;
        }

        public void SendNotification()
        {
            Console.WriteLine($"EmailNotificationService:{message} ");
        }

    }
    class PushNotificationService : INotificationService
    {
        public string Push;
        public string message
        {
            get
            {
                return $"{Push}";
            }
            set
            {
                Push = value;
            }

        }
        public PushNotificationService(string Push)
        {
            this.Push = Push;
        }

        public void SendNotification()
        {
            Console.WriteLine($"PushNotificationService:{message} ");
        }

    }
}
