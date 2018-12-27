using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new GroceryContext())
            {
                // Create and save a new Grocery item
                Console.WriteLine("Do you have an item to add to your grocery list?");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "yes" || answer.ToLower() == "y")
                {
                    Console.WriteLine("Please enter an item for your grocery list: ");
                    var item = Console.ReadLine();

                    //Save item to db
                    var listItem = new Groceries { Item = item };
                    db.groceryList.Add(listItem);
                    db.SaveChanges();

                    Console.WriteLine("Do you want to have your grocery list displayed?");
                    string reply = Console.ReadLine();
                    if (reply.ToLower() == "yes" || reply.ToLower() == "y")
                    {
                        // Display all items from the database
                        var query = from b in db.groceryList
                                    orderby b.Item
                                    select b;
                        Console.WriteLine("All items on your grocery list:");
                        foreach (var x in query)
                        {
                            Console.WriteLine(x.Item);
                        }
                        Console.ReadLine();
                        Console.WriteLine("Thank you for using your Console Grocery List!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Thank you for using your Console Grocery List!");
                        Console.ReadLine();
                    }
                }                
                else if (answer.ToLower() == "no" || answer.ToLower() == "n")
                {
                    Console.WriteLine("Thank you for using your Console Grocery List!");
                    Console.ReadLine();
                }               
            }
        }
    }

    public class Groceries
    {        
        public int Id { get; set; }
        public string Item { get; set; }

        public virtual List<Groceries> groceryList { get; set; }
    }
   
    public class GroceryContext : DbContext
    {
        public DbSet<Groceries> groceryList { get; set; }
    }
}
