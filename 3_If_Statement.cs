using System;

namespace If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Your name is " + name + ". Congratulations! You're an adult.");
            }
            else
            {
                Console.WriteLine("Your name is " + name + " and you're still young.");
            }

            Console.WriteLine();

            // There's another way to use if
            bool confirmation = (name == "Quan") ? true : false;
            // We can write: bool confirmation = (name == "Quan");

            if (confirmation)
            {
                Console.WriteLine("You are Quan.");
            }
            else
            {
                Console.WriteLine("You are not Quan");
            }
        }
    }
}