using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> s = new Employee<string>();
            s.Things = new List<string>() { "Car", "Bus", "Train", "Airplane", "Bike" };
            Employee<int> i = new Employee<int>();
            i.Things = new List<int>() { 1, 2, 3, 4, 5 };

            s.listThings();
            i.listThings();
            Console.ReadLine();
        }
    }
}
