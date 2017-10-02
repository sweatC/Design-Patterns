using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ConcreteDecorator2 : Decorator
    {
        public void newBehavior()
        {
            Console.WriteLine("NEW Behavior");
        }

        public override void Operation()
        {
            base.Operation();
            newBehavior();
        }
    }
}
