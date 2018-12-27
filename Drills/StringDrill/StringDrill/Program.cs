using System;
using System.Text;

namespace StringDrill
{
    class Program
    {
        static void Main()
        {
            //Concatenate three strings
            string One = "Hello world. ";
            string Two = "How are you? ";
            string Three = "Hope all is well.";
            Console.WriteLine(One + Two + Three);
            Console.ReadLine();

            //Convert lower to uppercase
            string upperCase = "lets go from lowercase to uppercase!";
            upperCase = upperCase.ToUpper();
            Console.WriteLine(upperCase);
            Console.ReadLine();

            //Stringbuilder
            StringBuilder myString = new StringBuilder("Happy birthday to you!");
            myString.Append("\nHappy birthday to you!");
            myString.Append("\nYou look like a monkey,");
            myString.Append("\nAnd you smell like one too!");
            Console.WriteLine(myString);
            Console.ReadLine();


        }
    }
}

