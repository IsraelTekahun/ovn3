using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övn3
{
    class Wolf : Animal
    {
        private double wingSpan;
        private int nrOfChildren;
        public override void DoSound()
        {
            Console.WriteLine("grrrrr"); ;
        }
    }
}
