<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightGOF
{
    class FlyweightFactory
    {
        Hashtable pool = new Hashtable
        {
            {"1", new ConcreteFlyweight() },
            {"2", new ConcreteFlyweight() }
        };

        public Flyweight GetFlyweight(string key)
        {
            if (!pool.Contains(key))
                pool.Add(key, new ConcreteFlyweight());

            return pool[key] as Flyweight;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightGOF
{
    class FlyweightFactory
    {
        Hashtable pool = new Hashtable
        {
            {"1", new ConcreteFlyweight() },
            {"2", new ConcreteFlyweight() }
        };

        public Flyweight GetFlyweight(string key)
        {
            if (!pool.Contains(key))
                pool.Add(key, new ConcreteFlyweight());

            return pool[key] as Flyweight;
        }
    }
}
>>>>>>> dbcb8d1db99d2bde4cee380e98094da4bc2d70b7
