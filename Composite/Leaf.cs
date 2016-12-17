using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
            //Because Leaf it is like Composite, but without children.
            // It is important to understand this kind of philosophy.
            // It is not secure, but it is clear for client.
        }

        public override void Add(Component c)
        {
            throw new InvalidOperationException();
        }

        public override Component GetChild(int index)
        {
            throw new InvalidOperationException();
        }

        public override void Operation()
        {
            Console.WriteLine(this.name);
        }

        public override void Remove(Component c)
        {
            throw new InvalidOperationException();
        }
    }
}
