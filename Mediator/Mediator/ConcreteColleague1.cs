using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator m) : base(m)
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
