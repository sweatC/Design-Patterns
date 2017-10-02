using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetchupMediator
{
    abstract class Colleague
    {
        protected Mediator mediator;

        public Colleague(Mediator m)
        {
            mediator = m;
        }
    }
}
