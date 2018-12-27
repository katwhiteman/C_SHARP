using System;

namespace MethodDrill2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number.");
            int x = Convert.ToInt32(Console.ReadLine());
            Class c = new Class();
            int total = c.Math1(x, 100);
            Console.WriteLine("The total is: {0}", total);
            Console.ReadLine();

            Console.WriteLine("Please input a decimal.");
            decimal y = Convert.ToDecimal(Console.ReadLine());
            Class d = new Class();
            decimal divided = (d.Math2(y, 10));
            int divide = Convert.ToInt32(divided);
            Console.WriteLine("The divided total is: {0}", divide);
            Console.ReadLine();

            Console.WriteLine("Please input a final number.");
            string z = Console.ReadLine();
            Class n = new Class();
            int multiplied = (n.Math3((Convert.ToInt32(z)), 2));
            Console.WriteLine("Your multiplied total is: {0}", multiplied);
            Console.ReadLine();



        }
    }
}
