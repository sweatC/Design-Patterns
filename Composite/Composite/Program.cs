using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component root = new Composite("ROOT");
            Component branch = new Composite("BRANCH");
            Component leaf1 = new Leaf("LEAF-1");
            Component leaf2 = new Leaf("LEAF-2");

            root.Add(branch);
            branch.Add(leaf1);
            branch.Add(leaf2);
            root.Operation();
        }
    }
}
