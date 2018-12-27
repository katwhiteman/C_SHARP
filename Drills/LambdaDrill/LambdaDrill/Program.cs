using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDrill
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> Employees = new List<Employee>();
            Employees.Add(new Employee { fname = "Joe", lname = "Smith", id = 1 });
            Employees.Add(new Employee { fname = "James", lname = "Hamilton", id = 2 });
            Employees.Add(new Employee { fname = "Sarah", lname = "Johnson", id = 3 });
            Employees.Add(new Employee { fname = "Ted", lname = "Allen", id = 4 });
            Employees.Add(new Employee { fname = "Joe", lname = "Schmoe", id = 5 });
            Employees.Add(new Employee { fname = "Laura", lname = "Williams", id = 6 });
            Employees.Add(new Employee { fname = "George", lname = "Peterson", id = 7 });
            Employees.Add(new Employee { fname = "Jessica", lname = "Lacey", id = 8 });
            Employees.Add(new Employee { fname = "Rick", lname = "Thompson", id = 9 });
            Employees.Add(new Employee { fname = "Joe", lname = "Doe", id = 10 });


            foreach (Employee joeName in Employees)
            {
                if (joeName.fname == "Joe")
                {
                    List<string> nameJoe = new List<string>();
                    nameJoe.Add(joeName.fname + " " + joeName.lname);
                    Console.WriteLine(joeName.fname + " " + joeName.lname);
                }
            }

            List<Employee> Joes = Employees.Where(x => x.fname == "Joe").ToList();
            foreach (Employee joe in Joes)
            {
                Console.WriteLine(joe.fname + " " + joe.lname);
            }

            List<Employee> idNo = Employees.Where(x => x.id > 5).ToList();
            foreach (Employee id in idNo)
            {
                Console.WriteLine(id.fname + " " + id.lname + "," + id.id);
            }

            Console.ReadLine();





        }
    }
}
