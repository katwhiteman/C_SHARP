using System;


    class Program
    {
        static void Main(string[] args)
        {

            //exception handling for inputting a string instead of int (format exception)
            //using a try-catch block
            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals" + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex) //input format error
            {
                Console.WriteLine("Please type a whole number."); //Can also specify our own message, ex. "Please type a number."
            }
            catch (DivideByZeroException ex) //divide by zero error
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            finally //can use this to log an action, ex. credit card transaction that went through.
            {
                Console.ReadLine();
            }
            Console.ReadLine();
            


        }
    }

