// See https://aka.ms/new-console-template for more information
using FactoryMethod;
using SecondImpementation;

Console.WriteLine("Hello, World!");

SendMessageCreator factory = new SendMessageCreator();   
FactoryMethod.ISendMessage sms=factory.FactoryMethod(FactoryMethod.SendMessageEnum.Sms);

sms.Send("Test Message");

FactoryMethod.ISendMessage email = factory.FactoryMethod(FactoryMethod.SendMessageEnum.Email);

email.Send("Test Message");


#region Second     
var em = new CreatorEmailSendMessage();
em.Send("second test email");

var sm = new CreatorSmsSendMessage();
sm.Send("second test sms");

#endregion



Console.ReadKey();