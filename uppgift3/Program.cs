using System;
using System.Collections.Generic;


namespace uppgift3
{
   
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Person CreatePerson = new Person("Patrick", "Malmkvist", 34, 175.5, 70);
            List<UserError> userErrors = new List<UserError>();
            List<Animal> AnimalList = new List<Animal>();
            List<Horse> horseList = new List<Horse>();

            userErrors.Add(new NumericInputError());
            userErrors.Add(new TextInputError());
            userErrors.Add(new IDoMessage());
            

            var horse = new Horse();
            var dog = new Dog();
            var Bird = new Bird();
            dog.DoSound();
            Console.WriteLine(dog.DoSound());
            horse.DoSound();
            Console.WriteLine(horse.DoSound());
            Bird.DoSound();
            Console.WriteLine(Bird.DoSound());

            

            {
                foreach (var error in userErrors)
                {
                    Console.WriteLine(error.DoMessage());
                }
            }

                     
        }
    }
}
