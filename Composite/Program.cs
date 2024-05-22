// See https://aka.ms/new-console-template for more information
using Composite;

Console.WriteLine("composite");


FileComponent rootDirectory = new DirectoryComposite("RootDirectory");
FileComponent file1 = new FileLeaf("File1.txt");
FileComponent subDirectory1 = new DirectoryComposite("SubDirectory1");
FileComponent file2 = new FileLeaf("File2.txt");
FileComponent file3 = new FileLeaf("File3.txt");

rootDirectory.Add(file1);
rootDirectory.Add(subDirectory1);
subDirectory1.Add(file2);
subDirectory1.Add(file3);

rootDirectory.Display(2);
subDirectory1.Display(2);

Console.ReadKey();
