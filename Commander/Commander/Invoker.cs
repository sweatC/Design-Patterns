using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Invoker
    {
        Command command;

        public Command SetCommand
        {
            set { command = value; }
        }

        public void ExecuteCommand()
        {
            command.Execute();
        }
    }
}
