using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarDrill
{
    class Employee
    {
        string _fname = "";
        string _id = "";

        public Employee(string name, string id)
        {
            _fname = name;
            _id = id;
            Console.WriteLine("Employee name and id is: {0}, {1}", name, id);
        }

        public Employee(string name) : this(name, "101")
        {

        }

    }
}
