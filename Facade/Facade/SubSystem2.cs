using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class SubSystem2
    {
        private static bool systemOn = false;
        

        public void MethodTwo()
        {
            SubSystem3 sub3 = new SubSystem3();
            if (sub3.Exception)
                goto END;
            Console.WriteLine("I turn on the system");
            systemOn = true;
            END:;
        }

        public bool SystemOn
        {
            get { return systemOn; }
            protected set { systemOn = value; }
        }
    }
}
