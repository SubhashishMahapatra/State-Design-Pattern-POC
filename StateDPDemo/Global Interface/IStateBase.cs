using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateDPDemo.Model;

namespace StateDPDemo.Global_Interface
{
    public interface IStateBase
    {
        void Change(Context context);

    }
}
