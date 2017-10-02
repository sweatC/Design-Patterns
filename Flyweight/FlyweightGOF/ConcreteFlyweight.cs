<<<<<<< HEAD
﻿using System;
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
=======
﻿using System;
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
>>>>>>> dbcb8d1db99d2bde4cee380e98094da4bc2d70b7
