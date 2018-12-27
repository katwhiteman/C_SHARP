using System;

namespace MethodDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            //method displaying one integer and doing a math operation with the second integer.
            Class1 a = new Class1();
            int x, y;
            a.Math(out x, out y);
            Console.WriteLine("The two values are: {0}, {1}", x, y);
            Console.ReadLine();

            //method passing in two numbers
            Console.WriteLine("Please input two numbers.");
            Class1 m = new Class1();
            int d, f;
            m.Math2(out d, out f);
            Console.WriteLine("The numbers are now: {0}, {1}", d, f);
            Console.ReadLine();

            //method with named parameters
            Console.WriteLine("Please type in two values:");
            Class1 n = new Class1();
            int g, h;
            n.Math2(a: out g, b: out h);
            Console.WriteLine("The values are now: {0}, {1}", g, h);
            Console.ReadLine();
        }
    }
}
