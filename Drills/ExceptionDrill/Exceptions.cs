using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDrill
{
    public class FormatException : Exception
    {
        public FormatException()
        {
            Console.WriteLine("That is an invalid age.");
            Console.ReadLine();
            return;
        }
        
    }
    public class ZeroException : Exception
    {
        public ZeroException()
        {
            Console.WriteLine("You cannot input a 0 for your age.");
            Console.ReadLine();
            return;
        }
    }
    public class NegativeException : Exception
    {
        public NegativeException()
        {
            Console.WriteLine("You cannot enter a negative number for your age.");
            Console.ReadLine();
            return;
        }
    }
        
}
