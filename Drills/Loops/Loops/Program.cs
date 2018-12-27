using System;

namespace Loops
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Guess a number.");
            //int number = Convert.ToInt32(Console.ReadLine());

            ////switch statments revolve around cases. did this happen?
            //switch (number)
            //{
            //    case 62:
            //        Console.WriteLine("You guessed 62. Try again.");
            //        break;
            //    case 29:
            //        Console.WriteLine("You guessed 29. Try again.");
            //        break;
            //    case 55:
            //        Console.WriteLine("You guessed 55. Try again");
            //        break;
            //    case 12:
            //        Console.WriteLine("You guessed 12. That is correct!");
            //        break;
            //    default: //if you don't want to write a response for every case, you can set a default.
            //        Console.WriteLine("You are wrong.");
            //        break;
            //}
            //Console.ReadLine();

            //making a loop for the program so we don't have to rerun it each time.
            //While loop
            Console.WriteLine("Guess a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;

            do //do makes the switch loop occur at least once even if the exact number is guessed first.
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed 12. That is correct!");
                        isGuessed = true;
                        break;
                    default: //if you don't want to write a response for every case, you can set a default.
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);

            Console.ReadLine();



        }
    }
}
