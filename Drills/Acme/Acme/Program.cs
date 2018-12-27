using System;
using System.Threading;

namespace Acme
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Acme Accounting Systems");
            Thread.Sleep(1000); //I wanted to add a delay between lines
            Console.WriteLine("Remember, we're accounting on you!");
            Console.ReadLine();
        }
    }
}
