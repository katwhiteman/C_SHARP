﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameMethodDrill2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee name = new Employee();
            //name.firstName = new List<string>() { "Sample" };
            //name.lastName = new List<string>() { "Student" };
            //name.SayName();
            //Console.ReadLine();

            IQuittable quit = new Employee();
            quit.EmployeeQuit = new List<string>() { "John" };
            quit.Quit();
            Console.ReadLine();
        }
    }
}
