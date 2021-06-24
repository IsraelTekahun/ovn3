using System;

namespace övn3
{
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

}
