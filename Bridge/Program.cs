// See https://aka.ms/new-console-template for more information
using Bridge;

Console.WriteLine("Bridge");

Abstraction abstraction =new Abstraction(new ConcreteImplementorA());

Console.WriteLine(abstraction.Operation());
abstraction=new RefinedAbstraction(new ConcreteImplementorB());
Console.WriteLine(abstraction.Operation());

Console.ReadKey();
