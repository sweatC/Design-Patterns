<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorMs
{
    class Program
    {
        static void Main(string[] args)
        {
            Enumerable en = new Enumerable();
            IEnumerator enm = en.GetEnumerator();

            for (var j = 0; j < 3; j++)
                en[j] = "Element " + j;

            while (enm.MoveNext())
            {
                Console.WriteLine(enm.Current);
            }

        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorMs
{
    class Program
    {
        static void Main(string[] args)
        {
            Enumerable en = new Enumerable();
            IEnumerator enm = en.GetEnumerator();

            for (var j = 0; j < 3; j++)
                en[j] = "Element " + j;

            while (enm.MoveNext())
            {
                Console.WriteLine(enm.Current);
            }

        }
    }
}
>>>>>>> dbcb8d1db99d2bde4cee380e98094da4bc2d70b7
