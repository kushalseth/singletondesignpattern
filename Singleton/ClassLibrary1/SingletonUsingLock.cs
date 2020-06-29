using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class SingletonUsingLock
    {
        private static SingletonUsingLock _instance = null;
        private static readonly object padlock = new object();

        public static SingletonUsingLock Instance
        {
            get
            {
                Console.WriteLine("Instance called.");
                lock (padlock) // this lock is used on *every* reference to Singleton
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonUsingLock();
                    }
                    return _instance;
                }
            }
        }

        private SingletonUsingLock()
        {
            // cannot be created except within this class
            Console.WriteLine("Constructor invoked.");
        }
    }
}
