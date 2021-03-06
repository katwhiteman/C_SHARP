﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMathDrill
{
    class Program
    {
        static void Main()
        {
            //Step One:
            Console.WriteLine("Please input a number.");
            string timesFifty = Console.ReadLine();
            Console.WriteLine("Your number multiplied by 50 is: ");
            Console.WriteLine(Convert.ToDouble(timesFifty) * 50);
            Console.ReadLine();

            //Step Two:
            Console.WriteLine("Type in any number.");
            string add25 = Console.ReadLine();
            Console.WriteLine("Your number plus 25 is: ");
            Console.WriteLine(Convert.ToInt32(add25) + 25);
            Console.ReadLine();

            //Step Three:
            Console.WriteLine("Input another number.");
            string divide = Console.ReadLine();
            Console.WriteLine("Your input divided by 12.5 is: ");
            Console.WriteLine(Convert.ToDouble(divide) / 12.5);
            Console.ReadLine();

            //Step Four:
            Console.WriteLine("Please input a number.");
            string comparison = Console.ReadLine();
            bool isGreater = Convert.ToDouble(comparison) > 50;
            Console.WriteLine("Is your number greater than 50?");
            Console.WriteLine(isGreater);
            Console.ReadLine();

            //Step Five:
            Console.WriteLine("Type in a final number.");
            string remainder = Console.ReadLine();
            Console.WriteLine("Your number divided by 7 has a remainder of: ");
            Console.WriteLine(Convert.ToDecimal(remainder) % 7);
            Console.ReadLine();
        }
    }
}
