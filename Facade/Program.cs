// See https://aka.ms/new-console-template for more information
using Facade;

Console.WriteLine("Facade");

IOrderService orderService = new OrderService(new Product(),new Payment(),new Invoice());
orderService.ProccessOrder();

Console.ReadKey();
