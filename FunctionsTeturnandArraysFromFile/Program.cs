using System;

namespace FunctionsTeturnandArraysFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "Pizza", "Pasta", "Sushi", "BBQ", "Salad" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);

            string randomFood = foods[randomIndex];
            Console.WriteLine($"Computer has selected: {randomFood}");
        }
        private static void DisplayRandomDrink()
        {
            string[] drinks = { "Water", "Sprite", "Wine", "Juice", "Beer" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);

            string randomDrink = drinks[randomIndex];
            Console.WriteLine($"Computer has selected: {randomDrink}");
        }
        private static void DisplayRandomMovie()
        {
            string[] movies = { "LotR", "Cars", "Green Mile", "Home Alone", "Die Hard" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, movies.Length);

            string randomMovie = movies[randomIndex];
            Console.WriteLine($"Computer has selected: {randomMovie}");
        }

    }
}
