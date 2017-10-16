using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class ObjectStructure
    {
        ArrayList elements = new ArrayList();

        public void Attach(Element el)
        {
            elements.Add(el);
        }

        public void Detach(Element el)
        {
            elements.Remove(el);
        }

        public void Accept(Visitor v)
        {
            foreach (var item in elements)
            {
                (item as Element).Accept(v);
            }
        }
    }
}
