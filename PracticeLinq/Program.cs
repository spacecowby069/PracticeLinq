using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>() { "BurgerTime", "Star Wars", "Ms. Pac Man", "Donkey Kong", "Asteroids", "Tron" };

            var allGames = games.Where(x => x.Length > 0).OrderByDescending(x => x.Length);

            foreach (var i in allGames)
            {
                Console.WriteLine(i);
            }
        }
    }
}
