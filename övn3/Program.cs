using System;
using System.Collections.Generic;

namespace övn3
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonHandler ph = new PersonHandler();
            //Console.WriteLine(ph.CreatePerson(11, "fdss", "fefefe", 12, 33));


            List<Animal> animals = new List<Animal>();


            animals.Add(new Dog("Max", 13, 40, 50));
            animals.Add(new Hedgehog("Cooper", 3, 0.5, 50));
            animals.Add(new Horse("Daisy", 6, 200, 5000));
            animals.Add(new Wolf("Jack", 4, 55, "male"));
            animals.Add(new Worm("Lily", 11, 1, true));
            animals.Add(new Wolfman("Roxy", 7, 28, 4, "female"));
            //animals.Add(new Bird("Rocky", 22, 35, 4));
            animals.Add(new Pelican("Milo", 12, 68, false, 5));
            animals.Add(new Swan("Ellie", 3, 34, "Germany", 2));
            animals.Add(new Flamingo("Winston", 1, 20, "red", 7));



            foreach (var animal in animals)
            {
                Console.Write($"{animal.GetType().Name}: ");
                animal.DoSound();
                if (animal is IPerson wolfman)
                {
                    wolfman.Talk();
                }
            }


            /*
             8. Skapa en lista för hundar.
                List<Dog> dogs = new List<Dog>();

             9. F: Försök att lägga till en häst i listan av hundar.
                dogs.Add(new Horse("Daisy", 6, 200, 5000));
            
                Varför fungerar inte det?
                Det funkar inte för att jag försöker lägga in en häst i en lista som är avsedd för hundar. 
                Listan accepterar enbart objekt av typen Dog
            */

            /*
            10. F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
                S: klassen ska vara av typen Animal
            */

            Console.WriteLine();
            //11. Skriv ut samtliga Animals Stats() genom en foreach loop.
            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-8} | {3,-23} | {4,-22} |", "Name", "Age", "Weight", " Spcific info", "Extra info"));
            Console.WriteLine(String.Format("{0,-10}   {1,-10}   {2,-8}   {3,-23}   {4,-22}  ", "----", "---", "------", " ------------", "----------"));
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Stats());
            }

        }
    }
}
