using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    abstract class Visitor
    {
        abstract public void VisitConcreteElementA(ConcreteElementA elementA);
        abstract public void VisitConcreteElementB(ConcreteElementB elementB);
    }
}
