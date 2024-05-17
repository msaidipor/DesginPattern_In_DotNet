// See https://aka.ms/new-console-template for more information
using AbstractFactory;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

var client = new Client();

client.Clinet(new AsusFactory());

client.Clinet(new DellFactory());

Console.ReadKey();



public class Client
{
    public void Clinet(IDeviceFactory deviceFactory)
    {
        var loptop =  deviceFactory.CreateLoptop();
        loptop.TurnOn();
        loptop.PlayMusic();
        loptop.ShutDown();

        var tablet=deviceFactory.CreateTablet();
        tablet.TurnOn();
        tablet.Ring();
        tablet.TurnOff();
    }
}
