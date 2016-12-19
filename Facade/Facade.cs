using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Facade
    {
        private SubSystem1 sub1 = new SubSystem1();
        private SubSystem2 sub2 = new SubSystem2();
        private SubSystem3 sub3 = new SubSystem3();
        private SubSystem4 sub4 = new SubSystem4();

        public void MethodOne()
        {
            sub1.MethodOne();
            sub2.MethodTwo();
        }

        public void MethodTwo()
        {
            sub3.MethodThree();
            sub4.MethodFour();
        }
    }
}
