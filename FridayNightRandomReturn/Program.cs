using System;

namespace FridayNightRandomReturn
{
    class Program
    {
        static void Main(string[] args)
        
            {
                DisplayRandomFood();
                DisplayRandomDrink();
                DisplayRandomMovie();
            }

            private static int GenerateRandomIndex(string[] someArray)
            {
                Random rnd = new Random();
                int randomIndex = rnd.Next(0, someArray.Length);
                return randomIndex;
            }

            private static void DisplayRandomFood()
            {
                string[] foods = { "Pizza", "Pasta", "Sushi", "BBQ", "Salad" };
                Console.WriteLine($"Computer has selected: {foods[GenerateRandomIndex(foods)]}");
            }
            private static void DisplayRandomDrink()
            {
                string[] drinks = { "Water", "Sprite", "Wine", "Juice", "Beer" };
                Console.WriteLine($"Computer has selected: {drinks[GenerateRandomIndex(drinks)]}");
            }
            private static void DisplayRandomMovie()
            {
                string[] movies = { "LotR", "Cars", "Green Mile", "Home Alone", "Die Hard" };
                Console.WriteLine($"Computer has selected: {movies[GenerateRandomIndex(movies)]}");
            }
        }
}
