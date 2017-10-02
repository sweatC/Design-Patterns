using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ConcreteDecorator1 : Decorator
    {
        string newState = "NEW State";
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine(newState);
        }
    }
}
