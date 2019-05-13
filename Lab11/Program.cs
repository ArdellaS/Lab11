using System;
using System.Collections.Generic;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = null;
            do
            {
                Console.Write("What genre would you like to see movies for? We have Animated, Drama, Horror, and Scifi: ");
                var category = Console.ReadLine();

                string[] horrorMovies = new string[5] { "HellRaiser", "Nightmare on Elm Street", "WishMaster", "Wrong Turn", "Candy Man" };
                string[] animatedMovies = new string[5] { "Beauty and the Beast", "Fantasia", "Snow White", "Frozen", "Alice in Wonderland" };
                string[] dramaMovies = new string[5] { "Gone With the Wind", "Twelve Angry Men", "It's a Wonderful Life", "Five Heartbeats", "Mary, Queen if Scots" };
                string[] scifiMovies = new string[5] { "The LawnMower Man", "Total Recall", "Twelve Monkeys", "Star Trek", "Star Wars" };

                if (category.Equals("horror", StringComparison.OrdinalIgnoreCase))
                {
                    foreach (var movie in horrorMovies)
                    {
                        Console.WriteLine(movie);
                    }
                }
                if (category.Equals("drama", StringComparison.OrdinalIgnoreCase))
                {
                    foreach (var movie in dramaMovies)
                    {
                        Console.WriteLine(movie);
                    }
                }
                if (category.Equals("animated", StringComparison.OrdinalIgnoreCase))
                {
                    foreach (var movie in dramaMovies)
                    {
                        Console.WriteLine(movie);
                    }
                }
                if (category.Equals("scifi", StringComparison.OrdinalIgnoreCase))
                {
                    foreach (var movie in scifiMovies)
                    {
                        Console.WriteLine(movie);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }
                Console.WriteLine("Would you like to enter another category?");
                answer = Console.ReadLine();
            } while (answer == "y");

        }
    }
}
