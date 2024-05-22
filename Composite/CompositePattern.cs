using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Composite
{

    /// <summary>
    /// Component
    /// </summary>
    public  abstract class FileComponent
    {
        public string Name { get; set; }
        public FileComponent(string name)
        {
            Name = name;
        }

        public virtual void Add(FileComponent component)
        {
            Console.WriteLine("add");
        }

        public virtual void Remove(FileComponent component)
        {
            Console.WriteLine("remove");
        }

        public virtual void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
        }
    }

    /// <summary>
    /// composite
    /// </summary>
    public class DirectoryComposite(string name) : FileComponent(name)
    {
        private List<FileComponent> _children = new List<FileComponent>();

      

        public override void Add(FileComponent component)
        {
            _children.Add(component);
        }

        public override void Remove(FileComponent component)
        {
            _children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + "Directory: " + Name);
            foreach (FileComponent component in _children)
            {
                component.Display(depth + 2);
            }
        }
    }


    /// <summary>
    /// leaf
    /// </summary>
    public class FileLeaf(string name) : FileComponent(name)
    {
       
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + "File: " + Name);
        }
    }
}
