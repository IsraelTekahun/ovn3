using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övn3
{
    class Person
    {
        private int age;
        private String fName;
        private String lName;
        private double height;
        private double weight;

        public Person()
        {
        }

        public Person(int age, string fname, string lname, double height, double weight)
        {
            this.age = age;
            fName = fname;
            lName = lname;
            this.height = height;
            this.weight = weight;
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if(value > 0)
                    age = value;
                else
                    throw new ArgumentException("0 or less is given as age, this fired an error!");
            }
        }


        public String FName
        {
            get
            {
                return fName;
            }

            set
            {
                if (value.Length >= 2 || value.Length <= 10)
                    fName = value;
                else
                    throw new ArgumentException("wrong first name length given, this fired an error!");
            }
        }

        public String LName
        {
            get
            {
                return lName;
            }

            set
            {
                if (value.Length >= 3 || value.Length <= 15)
                    lName = value;
                else
                    throw new ArgumentException("wrong last name length given, this fired an error!");
            }
        }


        public override string ToString()
        {
            return fName + lName;
        }

    }
}
