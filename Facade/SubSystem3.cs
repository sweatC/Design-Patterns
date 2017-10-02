using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class SubSystem3
    {
        private static int eventNumber = 0;
        private static bool exception = false;


        public void MethodThree()
        {
            SubSystem1 sub1 = new SubSystem1();
            SubSystem2 sub2 = new SubSystem2();

            if (!isConnected(sub1, sub2))
            {
                Console.WriteLine("ERROR, Please invoke MethodOne first and then MethodTwo");
                exception = true;
                return;
            }

            Console.WriteLine("I'm waiting for events");
            eventNumber = 1;
        }

        protected bool isConnected(SubSystem1 sysOn, SubSystem2 modOn)
        {
            if (sysOn.ConnectionOn && modOn.SystemOn)
                return true;

            return false;
        }

        public int EventNum
        {
            get { return eventNumber; }
            protected set { eventNumber = value; }
        }

        public bool Exception
        {
            get
            {
                if (exception)
                    return true;

                return false;
            }
        }
    }
}
