using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is " + yourName);
            //Console.ReadLine();

            //Can't ReadLine for an integer so has to be input as a string (which is fine unless you plan on doing math)
            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //Console.WriteLine("Your favorite number is " + favoriteNumber);
            //Console.ReadLine();

            //Converting string to integer
            //Console.WriteLine("What is your favorite number?");
            //string number = Console.ReadLine();
            //int favNum = Convert.ToInt32(number);
            //int Total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + Total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -23;
            char randomLetter = 'X';
            decimal moneyInBank = 100.5m;
            double heightInCm = 211.302;
            float secondsLeft = 2.62f;
            short temperatureOnMars = -341;
            char questionMark = '\u2103';

            // convert int to string
            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            // convert bool to string
            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();


        }
    }
}
