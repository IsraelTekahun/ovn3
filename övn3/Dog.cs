using System;

namespace övn3
{
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
        public String getString()
        {
            return $"string from {base.Name}'s class";
        }
    }

}
