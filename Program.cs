using System;
using System.Linq;

namespace Deliverable2 {
    internal class Program {
        static void Main(string[] args)
        {
            string drink1 = "wine";
            int numOfDrink1 = 0;
            const double priceForDrink1 = 2.00;
            string drink2 = "water";
            int numOfDrink2 = 0;
            int maxPeople = 6;
            int numOfPeople = 0;
            const double pricePerPerson = 9.99;
            //bool test = false;

            Console.WriteLine($"Hello, Welcome to the best buffet ever. All you can eat for ${pricePerPerson:0.00}!\nWe do charge {priceForDrink1:0.00} extra for {drink1} but {drink2} is on the house.");
            Console.WriteLine($"How many will be joining us tonight? The most we can seat is {maxPeople}");

            numOfPeople = int.Parse(Console.ReadLine());
            if(!Enumerable.Range(1, 6).Contains(numOfPeople))
            {
                Environment.Exit(0);
            }

            //while(!test)
            //{
            //    test = int.TryParse(Console.ReadLine(), out numOfPeople);
            //    if(!Enumerable.Range(1, 6).Contains(numOfPeople) || !test)
            //    {
            //        Console.WriteLine($"Sorry we only have room for partys of up to {maxPeople} people.");
            //        Console.WriteLine("How many will really be joining us tonight?");
            //        test = false;
            //    }
            //}

            Console.WriteLine($"\nA table for {numOfPeople}! Please follow me and take a seat.");
            Console.WriteLine($"Let's get everyone started with some drinks. We've got {drink1} or {drink2}.\n");

            for(int i = 1; i <= numOfPeople; i++)
            {
                Console.WriteLine($"Alright person number {i}, {drink1} or {drink2}?");

                string drink = Console.ReadLine();
                
                if(drink == drink1)
                {
                    Console.WriteLine($"{drink1}, a good choice.\n");
                    numOfDrink1++;
                }else if (drink == drink2)
                {
                    Console.WriteLine($"{drink2}, a good choice.\n");
                    numOfDrink2++;
                }
                else
                {
                    Console.WriteLine("Sorry we don't have that drink.\n");
                }
            }

            Console.WriteLine($"Okay, so that's {numOfDrink1} {drink1} and {numOfDrink2} {drink2}. I'll be right back. Feel free to grab your food!\n");
        }
    }
}