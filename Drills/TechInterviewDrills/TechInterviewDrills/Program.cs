using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechInterviewDrills
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare an array, total the odd numbers
            int[] Numbers = new int[5] { 1, 2, 3, 4, 5 };
            List<int> oddNumbers = new List<int>();
            foreach (int n in Numbers)
            {
                if (n % 2 != 0)
                {
                    oddNumbers.Add(n);
                }
            }
            int oddTotal = oddNumbers.Sum();
            Console.WriteLine("The total of the odd numbers is: {0}", oddTotal);
            Console.ReadLine();


            //declare an array, add the values together (some values will be large)
            Int32[] largeArray = new Int32[5] { 1000, 20000, 300000, 400000, 5000000 };
            Int32 largeTotal = largeArray.Sum();
            Console.WriteLine("The sum of the values in the array is: {0}", largeTotal);
            Console.ReadLine();


            //get a string, reverse it
            Console.WriteLine("Please input your first name.");
            string name = Console.ReadLine();
            string reversedName = new string(name.Reverse().ToArray());
            Console.WriteLine("Your name reversed is: {0}", reversedName);
            Console.ReadLine();

            //given a string, remove any duplicate letters
            string duplicates = "Mississippi";
            string noDuplicates = new string(duplicates.ToArray().Distinct().ToArray());
            Console.WriteLine("The state of Mississippi spelled with no duplicate letters is: {0}", noDuplicates);
            Console.ReadLine();


            //Fizzbuzz
            Console.WriteLine("Let's play Fizzbuzz!");
            for (int i = 1; i < 101; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;
                if (fizz)
                { Console.WriteLine("Fizz!"); }
                else if (buzz)
                { Console.WriteLine("Buzz!"); }
                else if (fizz && buzz)
                { Console.WriteLine("Fizzbuzz!"); }
                else
                { Console.WriteLine(i); }
            }
            Console.ReadLine();
        }
    }
}