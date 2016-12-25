using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    abstract class Handler
    {
        protected Handler successor = null;
        // added END of Chain Responsibility handler
        protected delegate void ERROR();
        
        public abstract void HandleRequest(int request);

        public Handler SetSuccessor
        {
            set { successor = value; }
        }

        protected Handler GetSuccessor
        {
            get { return successor; }
        }
    }
}
