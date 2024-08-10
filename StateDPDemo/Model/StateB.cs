using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateDPDemo.Global_Interface;

namespace StateDPDemo.Model
{
    public class StateB : IStateBase
    {
        public void Change(Context context)

        {

            //Change state of context from B to C.

            context.State = new StateC();

            Console.WriteLine("Change state from B to C.");

        }
    }
}
