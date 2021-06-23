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


        /*public Animal()
        {
            this.name = "";
            this.age = 0;
            this.weight = 0;
        }*/

        public Animal(string name, int age, double weight)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
        }

        public virtual String Stats()
        {
            //return $"Name: {name} age: {age} weight: {weight}kg";
            return String.Format("{0,-10} | {1,-10} | {2,-8} | ", name, age, weight);
        }

        public abstract void DoSound();
    }

    class Dog : Animal
    {
        private int speed;

        public Dog(string name, int age, double weight, int speed) : base(name, age, weight)
        {
            this.speed = speed;
        }

        public override void DoSound()
        {
            Console.WriteLine("woof"); ;
        }
        public override String Stats()
        {
            String speedFormat = String.Format("{0,-22} ", "speed: " + speed + "km/h");
            return $"{base.Stats()} {speedFormat}|";
        }
    }


    class Hedgehog : Animal
    {
        private int nrOfSpikes;

        public Hedgehog(string name, int age, double weight, int nrOfSpikes) : base(name, age, weight)
        {
            this.nrOfSpikes = nrOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("Hedgehog sound"); ;
        }
        public override String Stats()
        {            
            String spikesFormat = String.Format("{0,-22} ", "spikes count: " + nrOfSpikes);
            return $"{base.Stats()} {spikesFormat}|";
        }
    }
    

    class Horse : Animal
    {
        private double price;

        public Horse(string name, int age, double weight, int price) : base(name, age, weight)
        {
            this.price = price;
        }
        public override void DoSound()
        {
            Console.WriteLine("horse sound"); ;
        }
        public override String Stats()
        {
            String priceFormat = String.Format("{0,-22} ", "price: " + price + "kr");
            return $"{base.Stats()} {priceFormat}|";
        }
    }

    
    class Wolf : Animal
    {
        private String gender;
        public Wolf(string name, int age, double weight, String gender) : base(name, age, weight)
        {
            this.gender = gender;
        }
        public override void DoSound()
        {
            Console.WriteLine("wolf sound"); ;
        }
        public override String Stats()
        {
            String genderFormat = String.Format("{0,-22} ", "gender: " + gender);
            return $"{base.Stats()} {genderFormat}|";
        }

    }

    class Wolfman : Wolf, IPerson
    {
        private int nrOfChildren;
        public Wolfman(string name, int age, double weight, int nrOfChildren, String gender) : base(name, age, weight, gender)
        {
            this.nrOfChildren = nrOfChildren;
        }
        public void Talk()
        {
            Console.WriteLine("wolfman talking");
        }

        public override String Stats()
        {
            String childrenFormat = String.Format("{0,-22} ", "children count: " + nrOfChildren);
            return $"{base.Stats()} {childrenFormat}|";
        }
    }


    class Worm : Animal
    {
        private bool isPoisonous;
        public Worm(string name, int age, double weight, bool isPoisonous) : base(name, age, weight)
        {
            this.isPoisonous = isPoisonous;
        }

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

            String poisFormat = String.Format("{0,-22} ", "poisonous: " + poisonousStatus);
            return $"{base.Stats()} {poisFormat}|";
        }
    }

    class Bird : Animal
    {
        private double wingSpan;
        public Bird(string name, int age, double weight, int wingSpan) : base(name, age, weight)
        {
            this.wingSpan = wingSpan;
        }

        public override void DoSound()
        {
            Console.WriteLine("Bird sound"); ;
        }
        public override String Stats()
        {
            String wingSpanFormat = String.Format("{0,-22} ", "wingSpan: " + wingSpan + "m.");
            return $"{base.Stats()} {wingSpanFormat}|";
        }
    }

    class Pelican : Bird
    {
        private bool isRegistered;
        public Pelican(string name, int age, double weight, bool isPet, int wingSpan) : base(name, age, weight, wingSpan)
        {
            this.isRegistered = isRegistered;
        }

        public override void DoSound()
        {
            Console.WriteLine("Pelican sound"); ;
        }

        public override String Stats()
        {
            string registrationStatus;

            if (isRegistered)
                registrationStatus = "yes";
            else
                registrationStatus = "no";
            String registerFormat = String.Format("{0,-22} ", "registered status: " + registrationStatus);
            return $"{base.Stats()} {registerFormat}|";
        }
    }

    class Swan : Bird
    {
        private string homeCountry;
        public Swan(string name, int age, double weight, string homeCountry, int wingSpan) : base(name, age, weight, wingSpan)
        {
            this.homeCountry = homeCountry;
        }
        public override void DoSound()
        {
            Console.WriteLine("Swan sound"); ;
        }

        public override String Stats()
        {
            String countryFormat = String.Format("{0,-22} ", "home country: " + homeCountry);
            return $"{base.Stats()} {countryFormat}|";
        }
    }

    class Flamingo : Bird
    {
        private String color;
        public Flamingo(string name, int age, double weight, string color, int wingSpan) : base(name, age, weight, wingSpan)
        {
            this.color = color;
        }
        public override void DoSound()
        {
            Console.WriteLine("Flamingo sound"); ;
        }

        public override String Stats()
        {
            String colorFormat = String.Format("{0,-22} ", "color: " + color);
            return $"{base.Stats()} {colorFormat}|";
        }

    }

}
