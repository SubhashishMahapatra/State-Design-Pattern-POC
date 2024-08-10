using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateDPDemo.Global_Interface;

namespace StateDPDemo.Model
{
    public class Context 
    {
        public IStateBase State { get; set; }


        public Context(IStateBase state)
        {
            State = state;

            Console.WriteLine("Create object of context class with initial State.");
        }

        public void Request()

        {
            State.Change(this);

        }
    }
}
