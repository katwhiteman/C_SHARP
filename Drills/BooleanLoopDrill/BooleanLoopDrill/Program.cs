using System;
using System.Threading;

namespace BooleanLoopDrill
{
    class Program
    {
        static void Main()
        {
            // While Loop
            Console.WriteLine("How many times will we do this loop?");
            Thread.Sleep(1000);
            int loops = 1;
            while (loops <= 4)
            {
                Console.WriteLine("Loop #" + loops +". We are not done yet!");
                loops++;
                Thread.Sleep(1000);
            }
            Console.WriteLine("We made it! Five loops.");
            Console.ReadLine();

            // Do - While Loop
            Console.WriteLine("What is the perfect amount of dogs?");
            Int32 petsOwned = Convert.ToInt32(Console.ReadLine());
            bool pets = petsOwned == 2;
            do
            {
                switch (petsOwned)
                {
                    case 0:
                        Console.WriteLine("Everyone needs a dog!");
                        Thread.Sleep(1000);
                        Console.WriteLine("What is the perfect amount of dogs");
                        petsOwned = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("That's good but how about one more?");
                        Thread.Sleep(1000);
                        Console.WriteLine("What is the perfect amount of dogs");
                        petsOwned = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("That's a perfect amount of puppy love!");
                        pets = true;
                        break;
                    case 3:
                        Console.WriteLine("You know what they say, three's a crowd.");
                        Thread.Sleep(1000);
                        Console.WriteLine("What is the perfect amount of dogs");
                        petsOwned = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("That may be too many dogs...");
                        Thread.Sleep(1000);
                        Console.WriteLine("What is the perfect amount of dogs");
                        petsOwned = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!pets);
            Console.ReadLine();
        }
    }
}   

