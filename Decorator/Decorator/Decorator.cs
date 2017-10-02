using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Decorator : Component
    {
        protected Component component;

        public override void Operation()
        {
            if(component != null)
                component.Operation();
        }

        public Component Component
        {
            get { return component; }
            set { component = value; }
        }
    }
}
