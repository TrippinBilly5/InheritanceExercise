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
            Bird robin = new Bird();
            robin.NumberOfLegs = 2;
            robin.HasFur = false;
            robin.BasicColor = "red";
            robin.LivesInNorthAmerica = true;
            robin.NestsInTree = true;
            robin.Species = "Robin";
            robin.Migrates = false;
            robin.EatsMeat = false;
            Console.WriteLine($"The bird {robin.Species} has {robin.NumberOfLegs} legs and is basically {robin.BasicColor} in color.");
            Console.WriteLine($"Some basic info -- " +
                $"Has fur:{robin.HasFur}, " +
                $"Lives in North America:{robin.LivesInNorthAmerica}, " +
                $"Nests in trees:{robin.NestsInTree}, " +
                $"Migrates:{robin.Migrates}, " +
                $"Eats meat:{robin.EatsMeat}");
            Console.WriteLine("***************************");
            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile snake = new Reptile();
            snake.NumberOfLegs = 0;
            snake.HasFur = false;
            snake.BasicColor = "gray";
            snake.LivesInNorthAmerica = true;
            snake.IsVenomous = true;
            snake.CanRegrowTail = false;
            snake.AverageLength = "2.5 feet";
            snake.Hibernates = false;
            Console.WriteLine($"This snake has {snake.NumberOfLegs} legs, is {snake.AverageLength} in length, and is basically {snake.BasicColor} in color.");
            Console.WriteLine($"Some basic info -- " +
                $"Has fur:{snake.HasFur}, " +
                $"Is venomous:{snake.IsVenomous}, " +
                $"Can regrow tail:{snake.CanRegrowTail}, " +
                $"Hibernates:{snake.Hibernates}, " +
                $"Lives in North America:{snake.LivesInNorthAmerica}");
        }
    }
}
