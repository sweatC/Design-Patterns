<<<<<<< HEAD
﻿using System;
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
            Console.WriteLine(allState);
        }
    }
}
=======
﻿using System;
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
            Console.WriteLine(allState);
        }
    }
}
>>>>>>> dbcb8d1db99d2bde4cee380e98094da4bc2d70b7
