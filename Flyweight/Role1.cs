using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    // Unshared
    class Role1 : Flyweight
    {
        Flyweight flyweight;

        public Role1(Flyweight f)
        {
            flyweight = f;
        }

        public override void Greeting(string speech)
        {
            flyweight.Greeting(speech);
        }
    }
}
