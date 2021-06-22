using System;
using System.Collections.Generic;
namespace MedievalTextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MEDIEVAL YOU");
            Console.WriteLine("What race are you? \n" +
                "Human \n" +
                "Elf \n" +
                "Goblin");
            if (Console.ReadLine() != "Human")
            {
                Console.WriteLine("FALSE. Elves and goblins do not exist. You are a human.");
            }
            Human player1 = new Human(Human.CreateNewHuman());
            



        }
    }
}
