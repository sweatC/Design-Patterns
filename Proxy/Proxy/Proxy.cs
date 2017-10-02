using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Proxy : Subject
    {
        Subject subject = null;

        public Proxy(RealSubject s)
        {
            subject = s;        
        }
        public Subject Subject { get { return subject; } }
        public override void Request()
        {
            subject.Request();
        }
    }
}
