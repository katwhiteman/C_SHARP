using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            //const variable
            const string name = "Kat";
            Console.WriteLine("Hi, my name is {0}", name);

            //using 'var'
            var names = new List<string>() { "Kat", "Cole", "Kevin", "Casey"};
            Console.WriteLine(names[0]);

            //chaining constructors
            Employee x = new Employee("Kat");

            Console.ReadLine();
        }
    }
}
