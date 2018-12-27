﻿using System;

namespace BooleanDrill
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Car Insurance Approval Questionnaire");

            Console.WriteLine("What is your age?");
            string Age = Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI? True or false.");
            string DUI = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string Tickets = Console.ReadLine();

            Console.WriteLine("Insurance Application Approved?");
            int yearsOld = Convert.ToInt16(Age);
            bool hadDUI = Convert.ToBoolean(DUI);
            int numberTickets = Convert.ToInt16(Tickets);
            bool Approved = (yearsOld > 15 && hadDUI == false && numberTickets <= 3);
            Console.WriteLine(Approved);
            Console.ReadLine();
        }
    }
}