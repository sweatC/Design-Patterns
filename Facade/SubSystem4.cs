using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class SubSystem4
    {
        private const int EVENT_NUMBER = 1;
        private SubSystem3 sub3 = null;

        public SubSystem4()
        {
            sub3 = new SubSystem3();
        }

        public void MethodFour()
        {
            Console.WriteLine("I handle events");
            if(Handler())
                Console.WriteLine("Event was handled");
            else
                Console.WriteLine("Event was not handled, ERROR!!!!");
        }

        public bool Handler()
        {
            if (sub3.EventNum.Equals(EVENT_NUMBER))
                return true;

            return false;
        }
    }
}
