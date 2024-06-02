// See https://aka.ms/new-console-template for more information
using Proxy;

Console.WriteLine("Proxy");

IDatabase database = new ProxyDatabase(new Database());

Console.WriteLine(database.GetData());
Console.WriteLine(database.GetData());


Console.ReadKey();
