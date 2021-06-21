using System;
using System.Collections.Generic;
namespace MedievalTextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MEDIEVAL YOU");
            Console.WriteLine("What race are you?" +
                "Human" +
                "Elf" +
                "Goblin");
            if (Console.ReadLine() == "Human")
            {
                Human player1 = new Human(Human.CreateNewHuman());
                Console.WriteLine($"You are a Human. These are your stats: {player1}");

            }



        }
    }
}
