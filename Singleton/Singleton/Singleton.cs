using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton
    {
        static Singleton unique;
        static object syncRoot = new object();
        string name;

        protected Singleton()
        {
        }

        public static Singleton Instance()
        {
            Thread.Sleep(500);
            if(unique == null)
            {
                lock(syncRoot)
                {
                    if (unique == null)
                        unique = new Singleton();
                }
            }
            return unique;
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

    }
}
