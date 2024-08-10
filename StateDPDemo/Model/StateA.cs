using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateDPDemo.Global_Interface;

namespace StateDPDemo.Model
{
    public class StateA : IStateBase
    {
        public void Change(Context context)

        {

            //Change state of context from A to B.

            context.State = new StateB();

            Console.WriteLine("Change state from A to B.");

        }
    }
}
