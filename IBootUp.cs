using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Maxey_Andrew
{
    //interface that turns anything on or off
    internal interface IBootUp
    {
        //property that changes from off to on and vise versa (true = on) (false = off)
        public bool IsOn { get; set; }
        //Method that calls the IsOn property to true or false
        public void PowerOnOff();

    }
}
