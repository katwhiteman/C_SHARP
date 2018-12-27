using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now;
            Console.WriteLine("The current date and time is:{0}", current);
            Console.WriteLine("Please input a number: ");
            int user = Convert.ToInt32(Console.ReadLine());
            DateTime later = current.AddHours(user);
            Console.WriteLine("It will be {0} in the number of hours you input.", later);
            Console.ReadLine();

            //Example on how to use DateTime:
            //DateTime yearOfBirth = new DateTime(1989, 6, 20, 4, 27, 14);
            //DateTime yearOfGrad = new DateTime(2007, 6, 4, 16, 34, 22);
            //TimeSpan ageAtGrad = yearOfGrad - yearOfBirth;
        }
    }
}
