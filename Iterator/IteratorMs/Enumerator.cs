using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorMs
{
    class Enumerator : IEnumerator
    {
        int current = -1;
        Enumerable enumerable;

        public Enumerator(Enumerable e)
        {
            enumerable = e;
        }

        public object Current
        {
            get { return enumerable[current]; }
        }

        public bool MoveNext()
        {
            if(current < enumerable.Count - 1)
            {
                current++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            current = -1;
        }
    }
}
