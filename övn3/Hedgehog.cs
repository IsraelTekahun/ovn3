using System;

namespace övn3
{
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

}
