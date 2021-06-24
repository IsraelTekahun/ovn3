using System;

namespace övn3
{
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

}
