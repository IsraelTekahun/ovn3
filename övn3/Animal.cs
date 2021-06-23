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
            return $"Name: {name} age: {age} weight: {weight}";
        }

        public abstract void DoSound();
    }

    class Dog : Animal
    {
        private int speed;

        public override void DoSound()
        {
            Console.WriteLine("Dog sound"); ;
        }
        public override String Stats()
        {
            return $"{base.Stats()} speed: {speed}km/h";
        }
    }


    class Hedgehog : Animal
    {
        private int nrOfSpikes;
        public override void DoSound()
        {
            Console.WriteLine("Hedgehog sound"); ;
        }
        public override String Stats()
        {
            return $"{base.Stats()} spikes count: {nrOfSpikes}";
        }
    }
    

    class Horse : Animal
    {
        private double price;
        public override void DoSound()
        {
            Console.WriteLine("horse sound"); ;
        }
        public override String Stats()
        {
            return $"{base.Stats()} price: {price}";
        }
    }

    
    class Wolf : Animal
    {
        private int nrOfChildren;
        public override void DoSound()
        {
            Console.WriteLine("wolf sound"); ;
        }
        public override String Stats()
        {
            return $"{base.Stats()} children count: {nrOfChildren}";
        }

    }

    class Wolfman : Wolf, IPerson
    {
        public void Talk()
        {
            Console.WriteLine("wolfman sound");
        }
    }


    class Worm : Animal
    {
        private bool isPoisonous;

        public override void DoSound()
        {
            Console.WriteLine("worm sound");
        }
        public override String Stats()
        {
            string poisonousStatus;

            if (isPoisonous)
                poisonousStatus = "yes";
            else
                poisonousStatus = "no";

            return $"{base.Stats()} Posinious status: {poisonousStatus}";
        }
    }

    class Bird : Animal
    {
        private double wingSpan;

        public override void DoSound()
        {
            Console.WriteLine("Bird sound"); ;
        }
        public override String Stats()
        {
            return $"{base.Stats()} wingspan: {wingSpan}";
        }
    }

    class Pelican : Bird
    {
        private bool isPet;

        public override void DoSound()
        {
            Console.WriteLine("Pelican sound"); ;
        }

        public override String Stats()
        {
            string petStatus;

            if (isPet)
                petStatus = "yes";
            else
                petStatus = "no";

            return $"{base.Stats()} wingspan: {petStatus}";
        }
    }

    class Swan : Bird
    {
        private string homeCountry;
        public override void DoSound()
        {
            Console.WriteLine("Swan sound"); ;
        }

        public override String Stats()
        {
            return $"{base.Stats()} home country: {homeCountry}";
        }
    }

    class Flamingo : Bird
    {
        private String color;
        public override void DoSound()
        {
            Console.WriteLine("Flamingo sound"); ;
        }

        public override String Stats()
        {
            return $"{base.Stats()} color: {color}";
        }

    }

}
