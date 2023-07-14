using System;
using BakeryOrder.Models;

namespace BakeryOrder
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine("Welcome to (っ◔◡◔)っ ♥ Pierre's Bakery♥ !");
            Console.WriteLine("We have fresh baked breads and pastries for you!");
            Console.WriteLine("");
            Console.WriteLine("Pricing: Bread - $5 per loaf or buy 2, get 1 free!");
            Console.WriteLine("How many loaves of bread would you like?");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int userBread))
            {
                Bread breadOutput = new Bread(userBread);
                int result = breadOutput.Output(userBread);
                Console.WriteLine("Your bread total will be $" + result);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }


            Console.WriteLine("Pricing: Pastries - $2 per pastry or buy 3, get 1 free!");
            Console.WriteLine("How many pastries of would you like?");
            Console.WriteLine("Your pastry total will be $ ");

            Console.WriteLine("Thank you for your order! Your final total will be $ ");


        }
    }
}