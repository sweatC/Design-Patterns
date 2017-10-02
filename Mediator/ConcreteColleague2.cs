using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator m) : base(m)
        {
        }

        public void Notify(string message)
        {
            Console.WriteLine(message);
        }


        public void Send(string message)
        {
            mediator.Send(message, this);
        }
    }
}
