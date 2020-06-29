using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public sealed class SingletonUsingInstanceNull
    {
        private static SingletonUsingInstanceNull _instance = null;
        private static readonly object padlock = new object();

        public static SingletonUsingInstanceNull Instance
        {
            get
            {
                Console.WriteLine("Instance called.");
                if (_instance == null) // only get a lock if the instance is null
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new SingletonUsingInstanceNull();
                        }
                    }
                }
                return _instance;
            }
        }

        private SingletonUsingInstanceNull()
        {
            // cannot be created except within this class
            Console.WriteLine("Constructor invoked.");
        }
    }
}
