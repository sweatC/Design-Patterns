using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class ConcretePrototype : Prototype
    {
        public ConcretePrototype(int id) : base(id)
        {
            Console.WriteLine(this.GetHashCode());
        }

        public override Prototype Clone(int id)
        {
            if (this.Id == id)
                throw new Exception("Hello bitch :)");
            return new ConcretePrototype(id);
        }

        public override void GetId()
        {
            Console.WriteLine(this.Id);
        }
    }
}
