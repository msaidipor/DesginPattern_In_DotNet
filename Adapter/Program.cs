// See https://aka.ms/new-console-template for more information
using Adapter;

Console.WriteLine("Adaper Pattern");

IReport report = new UserReportAdapter();

Console.WriteLine(report.GenerateReport());

Console.ReadKey();



