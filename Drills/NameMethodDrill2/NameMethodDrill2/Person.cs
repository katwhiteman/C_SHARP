﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameMethodDrill2
{
    public abstract class Person
    {
        public List<string> firstName { get; set; }
        public List<string> lastName { get; set; }

        public virtual void SayName()
        {
            foreach (string fname in firstName)
            {
                foreach (string lname in lastName)
                {
                    Console.WriteLine("Name: {0} {1}", fname, lname);
                }
            }
        }

    }
}
