using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public sealed class SingletonUsingLazyT
    {
        // reading this will initialize the instance
        public static readonly Lazy<SingletonUsingLazyT> _lazy = new Lazy<SingletonUsingLazyT>(() => new SingletonUsingLazyT());
        public static SingletonUsingLazyT Instance
        {
            get
            {
                Console.WriteLine("Instance called.");
                return _lazy.Value;
            }
        }

        private SingletonUsingLazyT()
        {
            // cannot be created except within this class
            Console.WriteLine("Constructor invoked.");
        }
    }
}
