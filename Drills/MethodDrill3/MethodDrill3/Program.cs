using System;

namespace MethodDrill3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have the option to input a second number.");
            string y = Console.ReadLine();
            bool input = string.IsNullOrEmpty(y);

            if (input == true)
            {
                OptionalNumber n = new OptionalNumber();
                int z = n.Optional(x);
                Console.WriteLine("Your total is: {0}", z);
            }
            else if (input == false)
            {
                OptionalNumber n = new OptionalNumber();
                int z = n.Optional(x, Convert.ToInt32(y));
                Console.WriteLine("Your total is: {0}", z);
            }
            
            Console.ReadLine();
        }
    }
}
