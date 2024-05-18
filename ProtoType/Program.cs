// See https://aka.ms/new-console-template for more information

using ProtoType;

Employee lissa = new Employee { Name = "Lissa", Age = 50, Department = new Department { Name = "IT" } };
Employee lissaClone = (Employee)lissa.Clone(false);

lissaClone.Department.Name = "HR";

Console.WriteLine("Deep Clone");
Console.WriteLine(lissa.Department.Name);
Console.WriteLine(lissaClone.Department.Name);

Employee anna = new Employee { Name = "Anna", Age = 20, Department = new Department { Name = "IT" } };
Employee annaClone = (Employee)anna.Clone(true);

annaClone.Department.Name = "HR";

Console.WriteLine("Shallow Clone");
Console.WriteLine(anna.Department.Name);
Console.WriteLine(annaClone.Department.Name);

Console.ReadKey();
