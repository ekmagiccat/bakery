using System;
using BakeryOrder.Models;

namespace BakeryOrder
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Welcome to (っ◔◡◔)っ ♥ Pierre's Bakery♥ !");
            Console.WriteLine("We have fresh baked breads and pastries for you!");
            Console.WriteLine("");
            Console.WriteLine("Pricing: Bread - $5 per loaf or buy 2, get 1 free!");
            Console.WriteLine("How many loaves of bread would you like?");
            string userInput = Console.ReadLine();

            int result = 0;
            if (int.TryParse(userInput, out int userBread))
            {
                Bread breadOutput = new Bread(userBread);
                result = breadOutput.Output(userBread);
                Console.WriteLine("Your bread total will be $" + result);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.WriteLine("Pricing: Pastries - $2 per pastry or buy 3, get 1 free!");
            Console.WriteLine("How many pastries would you like?");
            string userInput2 = Console.ReadLine();

            int result2 = 0;
            if (int.TryParse(userInput2, out int userPastry))
            {
                Pastry pastryOutput = new Pastry(userPastry);
                result2 = pastryOutput.Output2(userPastry);
                Console.WriteLine("Your pastry total will be $" + result2);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            int finalTotal = result + result2;
            Console.WriteLine("Thank you for your order! Your final total will be $" + finalTotal);


        }
    }
}