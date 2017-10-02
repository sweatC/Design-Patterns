using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            RefinedAbstraction abs = new RefinedAbstraction(new ConcreteImplementorA());
            abs.Operation();
            abs = new RefinedAbstraction(new ConcreteImplementorB());
            abs.Operation();
        }
    }
}
