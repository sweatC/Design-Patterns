using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetchupMediator
{
    abstract class Mediator
    {
        public abstract void Send(string msg, Colleague col);
    }
}
