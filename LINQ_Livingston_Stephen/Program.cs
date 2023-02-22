using System;
using System.Linq;
namespace LINQ_Livingston_Stephen
{
    class Program
    {
        static void Main(string[] args)
        {
            Game[] games = new Game[] // creates an array that is initialized with 10 games.
            {
               new Game("Minecraft", 'E', "Action-Adventure"),
               new Game("Overwatch", 'T', "Hero-Shooter"),
               new Game("Hammerwatch", 't', "Dungeon-crawler"),
               new Game("SOMA", 'M', "Survival-Horror"),
               new Game("ARBS", 'E', "Sandbox"),
               new Game("Balders Gate 3", 'M', "RPG-Strategy"),
               new Game("Divinity 2", 'M', "RPG-Stragety"),
               new Game("Carrion", 'M', "Reverse-Horror"),
               new Game("Crawl", 'T', "Dungeon-crawler/Beat'em up"),
               new Game("Prey", 'M', "FPS-Action"),
           };

            var shortGames = from game in games // delcaring range variable to traverse games.
                             where game.Title.Length < 9 // checks the game class Title parameter for a index length that is less than 9.
                             select $"Game Title: {game.Title.ToUpper()}";
            foreach (var game in shortGames) // loops through the query and prints each element.
            {
                Console.WriteLine(game);
            }

            var mineCraft = games.Where(game => game.Title == "Minecraft") // LINQ method query that finds "Minecraft" from the games array and asigns it to var and prints 
                            .Select(game => $"Title: {game.Title}, ESRB: {game.ESRB}, Genre: {game.Genre}");    // selects the Title, ESRB and Genre from the selected game.
            Console.WriteLine(mineCraft.FirstOrDefault()); // prints all the game properties by using the FirstOrDefault.

            var tRated = from game in games // checks for T rated games and prints the title.
                         where game.ESRB == 'T'
                         select game.Title;

            Console.WriteLine("T Rated Games");

                foreach(var game in tRated) // loops through tRated and prints each element to the console.
                {
                Console.WriteLine(game);
                }

            var eRated = from game in games // checks for E rated games and prints the title.
                         where game.ESRB == 'E'
                         select game.Title;

            Console.WriteLine("E Rated Games");

            foreach (var game in eRated) // loops through eRated and prints each element to the console.
            {
                Console.WriteLine(game);
            }


        }







    }                
}
