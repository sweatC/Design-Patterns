using System;
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
            Flyweight flyweight = null;
            FlyweightFactory factory = new FlyweightFactory();

            flyweight = factory.GetFlyweight("1");

            flyweight.Operation(5);


        }
    }
}
