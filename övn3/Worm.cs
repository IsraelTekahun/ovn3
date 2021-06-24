using System;

namespace övn3
{
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

}
