using System;

namespace övn3
{
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

}
