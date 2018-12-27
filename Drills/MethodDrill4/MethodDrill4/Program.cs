using System;

namespace MethodDrill4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class n = new Class();
            n.Method1(20, out int divide);
            Console.WriteLine("The number divided by two is: {0}", divide);

            Class c = new Class();
            Console.WriteLine("\nPlease type in a number:");
            int user = Convert.ToInt32(Console.ReadLine());
            c.Method1(user, out int total);
            Console.WriteLine("Your number divided by two is: {0}", total);
            Console.ReadLine();

        }
    }
}
