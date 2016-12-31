using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Aggregate a = new ConcreteAggregate();

            for (var j = 0; j < 3; j++)
                a[j] = "Element " + j;

            Iterator i = a.CreateIterator();

            for(i.First(); !i.IsDone(); i.Next())
                Console.WriteLine(i.CurrentItem());
        }
    }
}
