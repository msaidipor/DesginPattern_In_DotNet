using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonClass
    {
        private static readonly object lockObject = new object();
        private static SingletonClass instance = null;

        public int Id;
        public SingletonClass()
        {
                Id=Random.Shared.Next();
        }


        public static SingletonClass Instance
        {
            get
            {
                lock(lockObject)
                {
                    if (instance == null)  instance = new SingletonClass();
                    return instance;
                    
                }

                //for test
                //return new SingletonClass();
            }
        }
    }
}
