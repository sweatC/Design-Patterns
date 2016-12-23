using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightGOF
{
    class ConcreteFlyweight : Flyweight
    {
        int instrState;
        public override void Operation(int extrState)
        {
            instrState = extrState;
            Console.WriteLine(instrState);
        }
    }
}
