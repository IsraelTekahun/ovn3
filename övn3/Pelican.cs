using System;

namespace övn3
{
    class Pelican : Bird
    {
        private bool isRegistered;
        public Pelican(string name, int age, double weight, bool isRegistered, int wingSpan) : base(name, age, weight, wingSpan)
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

}
