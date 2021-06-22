using System;
using System.Collections.Generic;
using System.Text;

namespace MedievalTextGame
{
    public class Human
    {
        private Human human;

        public Human(Human human)
        {
            this.human = human;
        }

        public Human(string firstName, string lastName, int age, string gender, string pronoun, string path)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            Pronoun = pronoun;
            Path = path;

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Pronoun { get; set; }
        public string Path { get; set; }
        public static Human CreateNewHuman()
        {
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();
            Console.Write("What is your surname? ");
            string lastName = Console.ReadLine();
            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your gender?\n" +
                "male \n" +
                "female \n" +
                "other");
            string gender = Console.ReadLine();

            string pronoun = GetPronoun(gender);

            Console.WriteLine("What is your destiny? \n" +
                "Knight \n" +
                "Theif \n" +
                "Druid \n" +
                "Mage");
            string path = Console.ReadLine();

            Console.WriteLine($"{firstName} {lastName} is a {age} year old {gender} human feebly striving to become a {path}.");

            return new Human(firstName, lastName, age, gender, pronoun, path);

        }
        public static string GetPronoun(string gender)
        {

            if (gender == "other")
            {
                Console.Write("*sympithetic wince* You're going to have a hard time. \n" +
                    "What pronoun would you like to use?");
                string pronoun = Console.ReadLine();
                return pronoun;
            }
            else if (gender == "male")
            {
                string pronoun = "he";
                return pronoun;
            }
            else
            {
                string pronoun = "she";
                return pronoun;
            }

        }
       

    }
}
/* public class Car
    {
        public Car()
        {

        }
        public Car(string year)
        {
            Year = year;
        }
        public Car(string year, string make, string model, string engineNoise, string honkNoise, string isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public string IsDriveable { get; set; }

        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }
        public void IsItDriveable()
        {
            if (IsDriveable == "yes")
            {
                Console.WriteLine($"{IsDriveable}, this car is driveable.");
            }
            else
            {
                Console.WriteLine($"{IsDriveable}, this car is not driveable.");

            }
        }
*/