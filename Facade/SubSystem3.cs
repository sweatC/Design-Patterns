using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class SubSystem3
    {
        private int eventNumber = 0;

        public void MethodThree()
        {
            Console.WriteLine("I'm waiting for events");
            eventNumber = 1;
        }

        public int EventNum
        {
            get { return eventNumber; }
            protected set { eventNumber = value; }
        }
    }
}
