using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \"Hello, Jesse.\" \n Hello on a new line. \n\t Hello on a tab."; // \n = new line, \t = tab
            //string fileName = "C:\\users\\student"; //have to use two backslashes to print one.
            //string file = @"C:\users\student"; //use the @ to show there's not escape characters being used and the backslash is a regular backslash.

            //bool trueOrFalse = name.Contains("s"); //Contains is a function
            //bool tORf = name.EndsWith("s"); //check for a letter, function EndsWith

            //int length = name.Length; //check how long something is.

            //Console.WriteLine(trueOrFalse);
            //Console.ReadLine();

            //name = name.ToUpper(); //make everything uppercase.
            //name = name.ToLower(); //everything becomes lowercase.


            //string name = "Jesse";
            //name = "Joe"; //you are not updating the original string, you are making a new one!

            //Console.WriteLine(name);
            //Console.ReadLine();

            //works like a string but can be collapsed or expanded as needed by the program
            //it helps save memory space.
            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Jesse");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
