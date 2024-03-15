using System;

namespace WorkingWithHashSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> food = new HashSet<string>();
            food.Add("Pizza");
            food.Add("Tacos");
            food.Add("Gummies");
            food.Add("Cereal");
            food.Add("Eggs");

            HashSet<string> drink = new HashSet<string>();
            drink.Add("Kool-Aid");
            drink.Add("Chocolate Milk");
            drink.Add("Orange Juice");
            drink.Add("Apple Juice");
            drink.Add("Water");

            HashSet<string> more = new HashSet<string>();
            more.Add("Pizza");
            more.Add("Chocolate Milk");
            more.Add("Hotel Watermelon Juice");
            more.Add("Orange");
            more.Add("Apple");

            Console.WriteLine("food and drink:");
            food.UnionWith(drink);
            foreach (string foods in food)
            {
                Console.WriteLine(foods);
            }
            Console.WriteLine();

            Console.WriteLine("Drinks only!");
            HashSet<string> bothLists = new HashSet<string>();
            bothLists = food;
            bothLists.IntersectWith(drink);
            foreach (string foods in bothLists)
            {
                Console.WriteLine(foods);
            }
        }
    }
}
