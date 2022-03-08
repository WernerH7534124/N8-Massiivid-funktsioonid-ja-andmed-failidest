using System;

namespace FridayNightRandom
{
    class Program
    {
        static void Main(string[] args)
        {

            string randomFood, randomDrink, randomMovie;
            string[] foods = { "Pizza", "Pasta", "Sushi", "BBQ", "Salad" };
            string[] drinks = { "Water", "Sprite", "Wine", "Juice", "Beer" };
            string[] movies = { "LotR", "Cars", "Green Mile", "Home Alone", "Die Hard" };

            randomFood = PickRandomElementFromArray(foods);
            randomDrink = PickRandomElementFromArray(drinks);
            randomMovie = PickRandomElementFromArray(movies);

            Console.WriteLine($"Tonight you are having {randomFood} with {randomDrink}, while watching {randomMovie}!");
        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }
        private static string PickRandomElementFromArray(string[] someArray)
        {
            string randomElement = someArray[GenerateRandomIndex(someArray)];
            return randomElement;
        }
    }
}
