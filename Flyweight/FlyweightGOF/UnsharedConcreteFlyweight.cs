using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightGOF
{
    class UnsharedConcreteFlyweight : Flyweight
    {
        int allState;
        public override void Operation(int extrState)
        {
            allState = extrState;
        }
    }
}
