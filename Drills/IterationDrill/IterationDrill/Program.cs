using System;
using System.Linq;
using System.Collections.Generic;



namespace IterationDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step One - user created string array
            string[] favorites = new string[5];
            Console.WriteLine("What is your favorite color?");
            favorites[0] = Console.ReadLine();
            Console.WriteLine("What is your favorite number?");
            favorites[1] = Console.ReadLine();
            Console.WriteLine("What is your favorite food?");
            favorites[2] = Console.ReadLine();
            Console.WriteLine("What is your favorite holiday?");
            favorites[3] = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            favorites[4] = Console.ReadLine();
            for (int i = 0; i < favorites.Length; i++)
            {
                Console.WriteLine(favorites[i]);
            }
            Console.ReadLine();

            //Step Two - infinite loop
            //while (true)
            //{
            //    Console.WriteLine("I'm afraid I can't do that, Dave.");
            //}


            //Step Three - fixed infinite loop
            while (true)
            {
                Console.WriteLine("I'm afraid I CAN do that, Dave.");
                break;
            }
            Console.ReadLine();

            //Step Four - comparison loop with <
            int[] lessThan = new int[] { 1, 2, 3, 4, 5 };
            for (int j = 0; j < lessThan.Length; j++)
            {
                if (lessThan[j] < 3)
                {
                    Console.WriteLine("Numbers less than three:" + lessThan[j]);
                }
            }
            Console.ReadLine();

            //Step Five - comparison loop with <=
            int[] lessThanEqual = new int[] { 10, 20, 15, 11, 18, 21 };
            for (int k = 0; k < lessThanEqual.Length; k++)
            {
                if (lessThanEqual[k] <= 15)
                {
                    Console.WriteLine("Numbers less than or equal to fifteen: " + lessThanEqual[k]);
                }
            }
            Console.ReadLine();


            //Step Six & Seven & Eight - unique string list with user input to display index
            List<string> states = new List<string>();
            states.Add("Alabama");
            states.Add("Alaska");
            states.Add("Arizona");
            states.Add("Arkansas");
            Console.WriteLine("Please type in a state beginning with \"A\":");
            string input = Console.ReadLine();
            foreach (string state in states)
            {
                if (states.Contains(input))
                {
                    Console.WriteLine("Index number is: " + states.IndexOf(input));
                    break;
                }
                else
                {
                    Console.WriteLine("That state is not found.");
                    break;
                }
            }
            Console.ReadLine();

            //Step Nine & Ten - identical string list with user input & returns indices
            List<string> animals = new List<string>();
            animals.Add("Dog");
            animals.Add("Cat");
            animals.Add("Hamster");
            animals.Add("Cat");
            animals.Add("Dog");
            animals.Add("Goldfish");
            animals.Add("Hamster");
            animals.Add("Goldfish");
            Console.WriteLine("Please type in a pet.");
            string pet = Console.ReadLine();
            foreach (string animal in animals)
            {
                if (animals.Contains(pet))
                {
                    Console.WriteLine("This pet occurs at: " + animals.IndexOf(pet) + ", " + animals.LastIndexOf(pet));
                    break;
                }
                else
                {
                    Console.WriteLine("That pet is not on the list.");
                    break;
                }
            }
            Console.ReadLine();

            //Step Eleven
            List<string> colors = new List<string>();
            colors.Add("Red");
            colors.Add("Yellow");
            colors.Add("Blue");
            colors.Add("Green");
            colors.Add("Blue");
            colors.Add("Purple");
            colors.Add("Green");
            colors.Add("Orange");
            colors.Add("Yellow");
            Console.WriteLine("Pick a color to see if it in the list");
            string _color = Console.ReadLine();
            int _repeated = 0;
            foreach (string c in colors)
            {
                if (_color == c)
                {
                    _repeated = (_repeated + 1);
                }
            }
            Console.WriteLine(_color + " is repeated in the list " + _repeated + " times.");
            Console.ReadLine();
        }
    }
}