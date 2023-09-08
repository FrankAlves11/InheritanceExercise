using System;
using System.Numerics;
using System.Xml.Linq;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird George = new Bird()
            {
                Name = "George",
                Age = 22,
                Legs = 2,
                HasBackBone = true, 
                Wings = true,
                Type = "chicken",
                CrossedTheRoad = true, 
                HasFeathers = "luscious",
            };

            Console.WriteLine($"{George.Name} is a {George.Type} that is {George.Age} years young");
            Console.WriteLine($"It is true that he has {George.Legs} Legs, it is {George.CrossedTheRoad} that he uses those little two legs to cross the road.");
            Console.WriteLine($"It is sad but {George.Wings} that little George lost his wings in his last road crossing accident.");
            Console.WriteLine($"Yes it's {George.HasBackBone} his powerful backbone, and his {George.HasFeathers} feathers allow him to keep his dream alive of crossing roads.");

            Reptile Gary = new Reptile()
            {
                Age = 600,
                Legs = 4,
                HasBackBone = true,
                Name = "Gary",
                IsColdBlooded = true,
                Environment = "Tropical",
                HasScales = true,
                IsAFastBoy = true,
            };

            Console.WriteLine();
            Console.WriteLine($"{Gary.Name} is a reptile");
            Console.WriteLine($"He has {Gary.Legs}");
            Console.WriteLine($"It is {Gary.HasBackBone} he has a backbone");
            Console.WriteLine($"Gary is old as {Gary.Age}");
            Console.WriteLine($"Gary is a cold blooded person {Gary.IsColdBlooded}");
            Console.WriteLine($"Gary likes to live in a {Gary.Environment}");
            Console.WriteLine($"It is {Gary.HasScales} that Gary has scales");
            Console.WriteLine($"It is {Gary.IsAFastBoy} that Gary is a fast boy");
            Console.WriteLine();
                


















            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
