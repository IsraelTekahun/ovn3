using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övn3
{
    class Horse : Animal
    {
        private double price;
        public override void DoSound()
        {
            Console.WriteLine("mmmmmm mmmmmm"); ;
        }
    }
}
