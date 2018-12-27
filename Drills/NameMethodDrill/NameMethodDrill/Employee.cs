using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameMethodDrill
{
    public class Employee : Person
    {
        public List<string> EmployeeId { get; set; }
        public int Id { get; set; }

        public static bool operator ==(Employee x, Employee y)
        {
            if (x.Id == y.Id)
            {
                Console.WriteLine("They are equal.");
                return true;
            }
            else
            {
                Console.WriteLine("They are not equal.");
                return false;
            }
        }

        public static bool operator !=(Employee x, Employee y)
        {
            if (x.Id != y.Id)
            {
                Console.WriteLine("They are not equal.");
                return true;
            }
            else
            {
                Console.WriteLine("They are equal.");
                return false;
            }
        }

        public override bool Equals(object o)
        {
            return base.Equals(o);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

