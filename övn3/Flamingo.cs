using System;

namespace övn3
{
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
