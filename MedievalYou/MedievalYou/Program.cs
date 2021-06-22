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
            if (Console.ReadLine() == "Human")
            {
                Human player1 = new Human (Human.CreateNewHuman());
                

            }



        }
    }
}
