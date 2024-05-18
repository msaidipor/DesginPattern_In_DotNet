// See https://aka.ms/new-console-template for more information
using Singleton;
Console.WriteLine("Singleton");

SingletonClass s1 = SingletonClass.Instance;

SingletonClass s2 = SingletonClass.Instance;

Console.WriteLine(s1.Id == s2.Id);


Console.ReadKey();
