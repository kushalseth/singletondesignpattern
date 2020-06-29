using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class SingletonUsingLessy
    {
        private static readonly SingletonUsingLessy _instance = new SingletonUsingLessy();

        // reading this will initialize the _instance
        public static readonly string GREETING = "Hi!";

        // Tell C# compiler not to mark type as beforefieldinit
        // (https://csharpindepth.com/articles/BeforeFieldInit)
        static SingletonUsingLessy()
        {
        }

        public static SingletonUsingLessy Instance
        {
            get
            {
                Console.WriteLine("Instance called.");
                return _instance;
            }
        }

        private SingletonUsingLessy()
        {
            // cannot be created except within this class
            Console.WriteLine("Constructor invoked.");
        }
    }
}
