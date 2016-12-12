using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton
    {
        static Singleton unique;
        string name;

        protected Singleton()
        {
        }

        public static Singleton Instance()
        {
            if (unique == null)
                unique = new Singleton();

            return unique;
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

    }
}
