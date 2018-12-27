using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileioDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime yearOfBirth = new DateTime(1989, 6, 20, 4, 27, 14);
            DateTime yearOfGrad = new DateTime(2007, 6, 4, 16, 34, 22);
            TimeSpan ageAtGrad = yearOfGrad - yearOfBirth; //answer is given in days.
            

            Console.WriteLine("Please input a number:");
            string num = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Student\Documents\log.txt", num);
            string num1 = File.ReadAllText(@"C:\Users\Student\Documents\log.txt");
            Console.WriteLine("Your number is: {0}.", num1);
            Console.ReadLine();
        }
    }
}
