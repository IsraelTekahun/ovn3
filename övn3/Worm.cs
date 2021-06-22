using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övn3
{
    class Worm : Animal
    {
        private bool isPoisonous;

        //Overide egen implementation av Turn
        public override string DoSound()
        {
            return "Vehicle turns";
        }
    }
}
