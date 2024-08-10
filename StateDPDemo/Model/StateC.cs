using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateDPDemo.Global_Interface;

namespace StateDPDemo.Model
{
    internal class StateC : IStateBase
    {
        public void Change(Context context)

        {

            //Change state of context from C to A.

            context.State = new StateA();

            Console.WriteLine("Change state from C to A.");

        }
    }
}
