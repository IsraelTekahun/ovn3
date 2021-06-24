using System;

namespace övn3
{
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

}
