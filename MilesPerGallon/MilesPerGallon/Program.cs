using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            int miles;
            int gallons;
            string milesInput;
            string gallonsInput;

            Console.WriteLine("How many miles have you driven?");

            milesInput = Console.ReadLine();
            miles = int.Parse(milesInput);

            Console.WriteLine("How much gas have you consumed (in gallons)?");

            gallonsInput = Console.ReadLine();
            gallons = int.Parse(gallonsInput);

            Console.WriteLine("Your gas mileage: " + miles / gallons + " miles per gallon");


        }
    }
}
