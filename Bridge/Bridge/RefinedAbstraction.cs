using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class RefinedAbstraction : Abstarction
    {
        public RefinedAbstraction(Implementor imp)
        {
            this.imp = imp;
        }

        public override void Operation()
        {
            imp.OperationImp();
        }
    }
}
