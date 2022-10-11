using System;

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
            Bird penguin = new Bird()
            {
                Name = "Happy Feet",
                Age = 22,
                Legs = 2,
                HasBackbone = true,
                IsWarmBlooded = true,
                HasFeathers = true,
                Wings = 2,
                Type = "Flightless",
            };
            Console.WriteLine($"{penguin.Name} is a {penguin.Type} bird that is {penguin.Age} years old, he has {penguin.Legs} legs, and {penguin.Wings} wings");
            Console.WriteLine($"is {penguin.Name} warm blooded with feathers and a backbone?");
            Console.WriteLine($"{penguin.IsWarmBlooded}, {penguin.HasFeathers}, and {penguin.HasBackbone}");
            Console.WriteLine();


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile frog = new Reptile()
            {
                Name = "Kermit",
                Age = 53,
                Legs = 2,
                HasBackbone = true,
                IsColdBlooded = true,
                HasScales = true,
                Environment = "Sesame Street",
                Defense = "Words",
            };

            Console.WriteLine($"{frog.Name} is a {frog.Age} frog with {frog.Legs} legs. He lives on {frog.Environment} and uses {frog.Defense} to defend himself");
            Console.WriteLine($"is {frog.Name} cold blooded with scales and a backbone");
            Console.WriteLine($"{frog.IsColdBlooded}, {frog.HasScales}, and {frog.HasBackbone}");
            Console.WriteLine();
        }
    }
}
