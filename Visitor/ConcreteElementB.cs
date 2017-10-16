using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class ConcreteElementB : Element
    {
        public override void Accept(Visitor v)
        {
            v.VisitConcreteElementB(this);
        }
        public void OperationB()
        {
            Console.WriteLine("Hello from Operation B");
        }
    }
}
