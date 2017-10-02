using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Abstarction
    {
        protected Implementor imp = null;

        public abstract void Operation();
    }
}
