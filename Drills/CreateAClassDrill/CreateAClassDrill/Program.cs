using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAClassDrill
{
    class Program
    {
    static void Main(string[] args)
        {
            Console.WriteLine("Please input a number:");
            int Input = Convert.ToInt32(Console.ReadLine());

            Math a = new Math();
            int x = a.Addition(Input, 5);
            int y = a.Divide(Input, 2);
            int z = a.Multiply(Input, 10);

            Console.WriteLine("Your number plus five is: " + x);
            Console.WriteLine("Your number divided by two is: " + y);
            Console.WriteLine("Your number multiplied by ten is: " + z);
            Console.ReadLine(); 
           
        }
    }
}
