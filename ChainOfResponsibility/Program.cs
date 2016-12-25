using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler node1 = new ConcreteHandler1();
            Handler node2 = new ConcreteHandler2();

            node1.SetSuccessor = node2;
            node1.HandleRequest(1);
            node1.HandleRequest(4);

        }
    }
}
