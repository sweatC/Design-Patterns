<<<<<<< HEAD
﻿using System;
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
=======
﻿using System;
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
>>>>>>> dbcb8d1db99d2bde4cee380e98094da4bc2d70b7
