using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Function 1.");

            Function2();

            Console.WriteLine();

            int[] numbers = RandomNumbers();

            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            Console.Write("Enter number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Total sum of these two numbers is: " + Sum(num1, num2));

            Console.WriteLine();

            Information("Ho Manh Quan", 23);
        }
        static void Function2()
        {
            Console.WriteLine("Hello World from Function 2.");
        }

        static int[] RandomNumbers()
        {
            return new int[] { 1, 2, 3, 4, 5 };
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
        
        static void Information(string name, int age)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }
    }
}