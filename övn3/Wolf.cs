using System;

namespace övn3
{
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

}
