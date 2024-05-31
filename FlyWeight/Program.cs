// See https://aka.ms/new-console-template for more information
using Flyweight;

Console.WriteLine("Flyweight");


FontFactory fontFactory = new FontFactory{

};

// Get shared flyweight objects
IFont font1 = fontFactory.GetFont("Arial");
IFont font2 = fontFactory.GetFont("Times New Roman");
IFont font3 = fontFactory.GetFont("Arial");

// Set intrinsic state
font1.SetSize(12);
font1.SetStyle("Regular");
font1.SetColor("Black");

font2.SetSize(14);
font2.SetStyle("Italic");
font2.SetColor("Red");

// Use flyweight objects
font1.Display("Hello, Flyweight Pattern!");
font2.Display("Hello, Flyweight Pattern!");
font3.Display("Hello, Flyweight Pattern!");

Console.ReadKey();