using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameMethodDrill
{
    public class Person
    {
        public List<string> FirstName { get; set; }
        public List<string> LastName { get; set; }

        public void SayName()
        {
            
            foreach (string fname in FirstName)
            {
                foreach (string lname in LastName)
                {
                    Console.WriteLine("Name: {0} {1}", fname, lname);
                }
            }
        }
    }
}
