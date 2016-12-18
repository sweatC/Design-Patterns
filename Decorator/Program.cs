using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Component sys = new ConcreteComponent();

            Decorator decorState = new ConcreteDecorator1();
            Decorator decorBehavior = new ConcreteDecorator2();

            decorState.Component = sys;
            decorBehavior.Component = decorState;
            
            decorBehavior.Operation();
        }
    }
}
