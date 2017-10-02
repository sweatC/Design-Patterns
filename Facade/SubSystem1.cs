using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class SubSystem1
    {
        private static bool moduleConnection = false;
        

        public void MethodOne()
        {
            SubSystem3 sub3 = new SubSystem3();
            if (sub3.Exception)
                goto END;
            Console.WriteLine("I connect modules");
            moduleConnection = true;
            END:;
        }

        public bool ConnectionOn
        {
            get { return moduleConnection; }
            private set { moduleConnection = value; }
        }
    }
}
