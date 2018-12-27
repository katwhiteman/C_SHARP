using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            //Original list/loop
            List<int> numList = new List<int>();
            numList.Add(5);
            numList.Add(12);
            numList.Add(8);
            numList.Add(1);
            numList.Add(15);
            Console.WriteLine("Please input a number to divide the list by:");
            int divide = Convert.ToInt32(Console.ReadLine());
            foreach (int number in numList)
            {
                Console.WriteLine("The list divided by your number is: " + number / divide);
            }
            Console.ReadLine();
            //Errors with zero - pulls it out of the program to denote a DivideByZero error.
            //Errors with string - pulls it out of the program to denote the wrong input format was entered.

            //List&loop with a Try-Catch
            try
            {
                List<int> myList = new List<int>();
                myList.Add(5);
                myList.Add(12);
                myList.Add(8);
                myList.Add(1);
                myList.Add(15);
                Console.WriteLine("Please input a number to divide the list by:");
                int myInput = Convert.ToInt32(Console.ReadLine());
                foreach (int userNum in myList)
                {
                    Console.WriteLine("The list divided by your number is: " + userNum / myInput);
                }
            }
            catch (FormatException) //input format error
            {
                Console.WriteLine("Please type an integer.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Zero cannot be used to divide by.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Thank you for your participation.");
            Console.ReadLine();
        }

    }
}
