using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{

    public enum SendMessageEnum
    {
        Email, Sms
    }

    public interface ISendMessage
    {
        void Send(string message);
    }

    public class EmailSendMessage : ISendMessage
    {
        public void Send(string message)
        {
            Console.WriteLine("Email:" + message);
        }
    }

    public class SmsSendMessage : ISendMessage
    {
        public void Send(string message)
        {
            Console.WriteLine("Sms:" + message);
        }
    }



    public class SendMessageCreator
    {
        public  ISendMessage FactoryMethod(SendMessageEnum Enum)
        {
            switch (Enum)
            {
                case SendMessageEnum.Email:
                    return new EmailSendMessage();
                case SendMessageEnum.Sms:
                    return new SmsSendMessage();
                default:
                    throw new ApplicationException(string.Format("SendMessage '{0}' cannot be created", Enum));
            }
        }
    }

}
