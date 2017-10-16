using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStructure structure = new ObjectStructure();
            structure.Attach(new ConcreteElementA());
            structure.Attach(new ConcreteElementB());

            structure.Accept(new ConcreteVisitor1());
        }
    }
}
