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
            animals.Add(new Dog("Zoey", 7, 64, 20));
            animals.Add(new Wolfman("Roxy", 7, 28, 4, "female"));
            //animals.Add(new Bird("Rocky", 22, 35, 4));
            animals.Add(new Pelican("Milo", 12, 68, false, 5));
            animals.Add(new Swan("Ellie", 3, 34, "Germany", 2));
            animals.Add(new Dog("Oliver", 4, 78, 77));
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
            Console.WriteLine("11. Skriv ut samtliga Animals Stats() genom en foreach loop.");
            Console.WriteLine();

            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-8} | {3,-23} | {4,-22} |", "Name", "Age", "Weight", " Spcific info", "Extra info"));
            Console.WriteLine(String.Format("{0,-10}   {1,-10}   {2,-8}   {3,-23}   {4,-22}  ", "----", "---", "------", " ------------", "----------"));
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Stats());
            }

            /*
             13. F: Förklara vad det är som händer.
                 S: I loopen anropas den mest specialiserade varianten av Stats() metoden
             */

            Console.WriteLine();
            Console.WriteLine("14. Skriv ut Stats() metoden enbart för alla hundar genom en foreach på Animals.");
            Console.WriteLine();

            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-8} | {3,-23} |", "Name", "Age", "Weight", " Spcific info"));
            foreach (var animal in animals)
            {
                if (animal is Dog dog)
                {
                    Console.WriteLine(dog.Stats());
                }
            }

            /*
             16. Kommer du åt den metoden från Animals listan? 

                foreach (var animal in animals)
                {
                    Console.WriteLine(animal.getString());
               
                }

                S: Nej 

             17. F: Varför inte?
                 S: För att alla djur i listan inte har den metoden implementerad 
            */

            Console.WriteLine();
            Console.WriteLine("18. Hitta ett sätt att skriva ut din nya metod för dog genom en foreach på Animals.");
            Console.WriteLine();

            foreach (var animal in animals)
            {
                if (animal is Dog dog)
                {
                    Console.WriteLine(dog.getString());
                }
            }

            Console.WriteLine();
            Console.WriteLine("7. I program.cs Main-metod: Skapa en lista med UserErrors och populera den medinstanser av NumericInputError och TextInputError.");
            Console.WriteLine();

            List<UserError> userErrors = new List<UserError>
            {
                new NumericInputError(), new TextInputError()
            };

            
            Console.WriteLine();
            Console.WriteLine("8. Skriv ut samtliga UserErrors UEMessage() genom en foreach loop.");
            Console.WriteLine();

            foreach (var userError in userErrors)
            {               
                Console.WriteLine(userError.UEMessage());
            }

            Console.WriteLine();
            Console.WriteLine("9. Skapa nu tre egna klasser med tre egna definitioner på UEMessage()");
            Console.WriteLine("10. Testa och se så det fungerar.");
            Console.WriteLine();

            List<UserError> userErrors2 = new List<UserError>
            {
                new NoInput(), new EmptyFileds(), new UnsuccessfulInput()
            };

            foreach (var userError in userErrors2)
            {
                Console.WriteLine(userError.UEMessage());
            }

        }
    }
}
