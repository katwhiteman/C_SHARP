using System;

using System.Threading;

namespace BranchingDrill
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express! Please follow the instructions below.");
            Thread.Sleep(1000);
            Console.WriteLine("What is the package weight?");
            decimal weight = Convert.ToDecimal(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
           else
            {
                Console.WriteLine("What is the package width?");
                decimal width = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("What is the package height?");
                decimal height = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("What is the package length?");
                decimal length = Convert.ToDecimal(Console.ReadLine());

                decimal dimensions = width + height + length;
                if (dimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else if (dimensions <= 50)
                {
                    decimal price = (((width + height + length) * weight) / 100);
                    Console.WriteLine("Your estimated shipping price is: $" + price);
                    Console.ReadLine();
                }
            }

            Console.ReadLine();


        }
    }
}
