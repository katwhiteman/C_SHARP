using System;
using System.Collections.Generic;

namespace ArraysAndListsDrill
{
    class Program
    {
        static void Main()
        {
            //Step One
            string[] myString = { "Ken", "Kim", "Kevin", "Cole", "Casey" };
            Console.WriteLine("Please input an index number between 0 and 4.");
            int stringIndex = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("The name at your chose index is:");
            Console.WriteLine(myString[stringIndex]);
            Console.ReadLine();

            //Step Two & Three
            int[] myInt = { 4, 8, 15, 16, 23, 42 };
            Console.WriteLine("Please input an index number.");
            int intIndex = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("The number at your chose index is:");
            if (intIndex > 4)
                Console.WriteLine("That index does not exist. Please try again.");
            else
            Console.WriteLine(myInt[intIndex]);
            Console.ReadLine();
           
            //Step Four
            List<string> stringList = new List<string>();
            stringList.Add("Jack");
            stringList.Add("Kate");
            stringList.Add("Sawyer");
            stringList.Add("Charlie");
            stringList.Add("Locke");
            Console.WriteLine("Please input a list index number between 0 and 4:");
            int listIndex = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(stringList[listIndex]);
            Console.ReadLine();

        }
    }
}
