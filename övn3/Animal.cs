using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övn3
{
    abstract class Animal
    {
        String name;
        int age;
        double weight;


        public Animal(string name, int age, double weight)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
        }


        public String Name
        {
            get
            {
                return name;
            }
        }

        public virtual String Stats()
        {
            return String.Format("{0,-10} | {1,-10} | {2,-8} | ", name, age, weight);
        }

        public abstract void DoSound();
    }

}
