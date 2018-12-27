using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameMethodDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee id1 = new Employee();
            Employee id2 = new Employee();
            id1.Id = 57;
            id2.Id = 89;
            bool same = id1 == id2;
           
            Console.ReadLine();




            //Employee name = new Employee();
            //name.FirstName = new List<string>() { "Sample" };
            //name.LastName = new List<string>() { "Student" };

            //name.SayName();
            //Console.ReadLine();

        }
    }
}
