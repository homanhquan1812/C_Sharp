using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Min, Max value of each type of variable
            Console.WriteLine("Min Int is: " + int.MinValue);
            Console.WriteLine("Max Int is: " + int.MaxValue);
            Console.WriteLine("Min Double is: " + double.MinValue);
            Console.WriteLine("Max Double is: " + double.MaxValue);
            Console.WriteLine("Min Float is: " + float.MinValue);
            Console.WriteLine("Max Float is: " + float.MaxValue);

            Console.WriteLine();

            // Integer
            int age = 23;

            Console.WriteLine("Your age is " + age);

            Console.WriteLine();

            // Float, Double
            float score1 = 9.5F; // Add "F" for Float.
            double score2 = 9.75D; // Add "D" for Double.

            Console.WriteLine("Score 1 is " + score1 + " and Score 2 is " + score2);

            Console.WriteLine();

            // String, Char
            string fullName = "Ho Manh Quan";
            char letter = 'a';

            Console.WriteLine("Your full name is " + fullName);
            Console.WriteLine("This letter is " + letter);

            Console.WriteLine();

            // Boolean
            bool a = true;
            bool b = false;

            Console.WriteLine("Bool a is " + a);
            Console.WriteLine("Bool b is " + b);

            Console.WriteLine();

            // Store data
            Console.Write("Enter your address: ");
            string? address = Console.ReadLine();
            Console.WriteLine("Your address is " + address);

            Console.WriteLine();

            Console.Write("Enter your year of birth: ");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You were born in " + yearOfBirth);
        }
    }
}