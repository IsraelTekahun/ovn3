using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övn3
{
    class PersonHandler
    {

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            return new Person(age, fname, lname, height, weight);
        }


        /*4. Fortsätt skapa metoder i PersonHandler för att kunna hantera samtliga operationer som man kan vilja göra med en Person .*/
        public bool isAdult(Person pers)
        {
            return pers.Age >= 18;
        }

        public bool isOverweight(Person pers)
        {
            return pers.Weight >= 300;
        }

        public bool isShort(Person pers)
        {
            return pers.Height < 1.6;
        }
    }
}
 