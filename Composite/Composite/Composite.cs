using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Composite : Component
    {
        private ArrayList nodes = null;

        public Composite(string name) : base(name)
        {
            nodes = new ArrayList();
        }

        public override void Add(Component c)
        {
            nodes.Add(c);
        }

        public override Component GetChild(int index)
        {
            return (Component)nodes[index];
        }

        public override void Operation()
        {
            Console.WriteLine(this.name);

            foreach (var item in nodes)
            {
                (item as Component).Operation();
            }
        }

        public override void Remove(Component c)
        {
            nodes.Remove(c);
        }
    }
}
