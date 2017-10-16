using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class ConcreteElementA : Element
    {
        public override void Accept(Visitor v)
        {
            v.VisitConcreteElementA(this);
        }

        public void OperationA()
        {
            Console.WriteLine("Hello from Operation A");
        }
    }
}
