using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDrill
{
    class Program
    {
        static void Main(string[] args)
        {

                try
                {
                    Console.WriteLine("Please enter your age:");
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age == 0) throw new ZeroException();
                    if (age < 0) throw new NegativeException();
                    Console.WriteLine("You were born in the year {0}.", 2018 - age);
                    Console.ReadLine();
                }

                catch (ZeroException)
                {    
                }
                catch (NegativeException)
                {  
                }
                catch (Exception x)
                {
                    Console.WriteLine("That is an invalid age.", x);
                    Console.ReadLine();
                    return;       
                }
        }
    }
}
