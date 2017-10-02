using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Flyweight actor = new Actor();
            actor.Greeting("Hello, my name is Will Smith! :)");
            Flyweight evil = new Role1(actor);
            Flyweight kind = new Role2(actor);
            evil.Greeting("I will destroy U!!!!!!");
            kind.Greeting("I will defend U!!!!!!!!");
        }
    }
}
