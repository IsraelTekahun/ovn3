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
        int weight;


        public Animal()
        {
            this.name = "";
            this.age = 0;
            this.weight = 0;
        }

        public Animal(string name, int age, int weight)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
        }

        public virtual String Stats()
        {
            return $"Name {name} age {age} weight {weight}";
        }

        public abstract void DoSound();
    }

}
