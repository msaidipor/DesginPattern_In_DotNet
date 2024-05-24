// See https://aka.ms/new-console-template for more information
using Decorator;

Console.WriteLine("Decorator");


SimpleRoom room = new SimpleRoom();

Console.WriteLine(room.GetDescription());

WifiDecorator wifiDecorator = new WifiDecorator(room);
Console.WriteLine(wifiDecorator.GetDescription());

BreakfastDecorator breakfastDecorator = new BreakfastDecorator(room);
Console.WriteLine(breakfastDecorator.GetDescription());

breakfastDecorator=new BreakfastDecorator(wifiDecorator);
Console.WriteLine(breakfastDecorator.GetDescription());

Console.ReadKey();
