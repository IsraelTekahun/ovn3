using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övn3
{
    class Dog : Animal
    {
        private double name;

        public override void DoSound()
        {
            Console.WriteLine("woof woof"); ;
        }
    }
}
