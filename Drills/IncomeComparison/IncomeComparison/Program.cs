using System;
using System.Threading;

namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Thread.Sleep(1000);
            //Person One
            Console.WriteLine("Information from Person One:");
            Thread.Sleep(1000);
            Console.WriteLine("What is Person One's hourly rate?");
            string payOne = Console.ReadLine();
            Console.WriteLine("How many hours per week does Person One Work?");
            string hoursOne = Console.ReadLine();
            //Person Two

            Console.WriteLine("Information from Person Two:");
            Thread.Sleep(1000);
            Console.WriteLine("What is Person Two's hourly rate?");
            string payTwo = Console.ReadLine();
            Console.WriteLine("How many hours per week does Person Two Work?");
            string hoursTwo = Console.ReadLine();

            Console.WriteLine("The annual salary of Person One is:");
            Int32 annualOne = Convert.ToInt32(payOne) * Convert.ToInt32(hoursOne);
            Console.WriteLine(annualOne * 52);
            Thread.Sleep(1000);
            Console.WriteLine("The annual salary of Person Two is:");
            Int32 annualTwo = Convert.ToInt32(payTwo) * Convert.ToInt32(hoursTwo);
            Console.WriteLine(annualTwo * 52);
            Thread.Sleep(1000);
            Console.WriteLine("Does Person One make more money than Person Two?");
            bool greaterThanTwo = annualOne > annualTwo;
            Console.WriteLine(greaterThanTwo);
            Console.ReadLine();

        }
    }
}
