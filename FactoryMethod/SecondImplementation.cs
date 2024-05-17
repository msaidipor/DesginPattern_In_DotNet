using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondImpementation
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

    public abstract class Creator { 
        public abstract ISendMessage CreateMethod();
    

        public void Send(string message)
        {
            this.CreateMethod().Send(message);
        }
    
    }

    public class CreatorEmailSendMessage() : Creator
    {
        public override ISendMessage CreateMethod()
        {
            return new EmailSendMessage();
        }
    }

    public class CreatorSmsSendMessage() : Creator
    {
        public override ISendMessage CreateMethod()
        {
            return new SmsSendMessage();
        }
    }
}
