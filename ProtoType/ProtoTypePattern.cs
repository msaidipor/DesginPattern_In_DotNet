using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{

    public interface ICloneableObject
    {
        object Clone(bool isShallow);
       
    }
    public class Employee : ICloneableObject
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Department Department { get; set; }
        public object Clone(bool isShallow)
        {
           

            return isShallow ? ShallowCopy() : DeepCopy();
            
        }

        private object ShallowCopy()
        {
            return MemberwiseClone();
        }

        private object DeepCopy()
        {
            Employee clone = (Employee)MemberwiseClone();
            clone.Department = (Department)Department.Clone();
            return clone;
        }
    }

    public class Department : ICloneable
    {
        public string Name { get; set; }

        public object Clone()
        {

            return MemberwiseClone();

        }
    }
}
