using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ConcreteMediator : Mediator
    {
        ConcreteColleague1 colleague1;
        ConcreteColleague2 colleague2;


        public override void Send(string message, Colleague colleague)
        {
            if(Colleague1 == colleague)
                Colleague2.Notify(message);
            else
                Colleague1.Notify(message);
        }

        public ConcreteColleague1 Colleague1
        {
            get { return colleague1; }
            set
            {
                if (value is Colleague)
                    colleague1 = value;
            }
        }

        public ConcreteColleague2 Colleague2
        {
            get { return colleague2; }
            set
            {
                if (value is Colleague)
                    colleague2 = value;
            }
        }
    }
}
