using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{

    /// <summary>
    /// The 'Implementor' interface
    /// </summary>
    public interface Implementor
    {
        string OperationImplementor();
    }

    /// <summary>
    /// The 'Abstraction' class
    /// </summary>
    public class Abstraction(Implementor implementor)
    {
        public virtual string Operation()
        {
            return implementor.OperationImplementor();
        }
    }

    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    public class RefinedAbstraction(Implementor implementor) : Abstraction(implementor)
    {
       
        public override string Operation()
        {
            
            return "Refined Abstraction " + base.Operation();
        }
    }

    /// <summary>
    /// The 'ConcreteImplementor' class
    /// </summary>

    public class ConcreteImplementorA : Implementor
    {
        public string OperationImplementor()
        {
            return "ConcreteImplentorA";
        }
    }

    /// <summary>
    /// The 'ConcreteImplementor' class
    /// </summary>
    public class ConcreteImplementorB : Implementor
    {
        public string OperationImplementor()
        {
            return "ConcreteImplentorB";
        }
    }
}
