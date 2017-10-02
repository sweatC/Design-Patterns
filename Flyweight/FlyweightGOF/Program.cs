<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightGOF
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            Flyweight flyweight = null;
            FlyweightFactory factory = new FlyweightFactory();

            flyweight = factory.GetFlyweight("1");
            
            flyweight.Operation(a);

            flyweight = new UnsharedConcreteFlyweight();
            flyweight.Operation(a);
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
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            Flyweight flyweight = null;
            FlyweightFactory factory = new FlyweightFactory();

            flyweight = factory.GetFlyweight("1");
            
            flyweight.Operation(a);

            flyweight = new UnsharedConcreteFlyweight();
            flyweight.Operation(a);
        }
    }
}
>>>>>>> dbcb8d1db99d2bde4cee380e98094da4bc2d70b7
