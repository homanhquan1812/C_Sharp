using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine($"This number is: {number}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}