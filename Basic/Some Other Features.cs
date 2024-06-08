using System;

namespace Some_Other_Features
{
    class Program
    {
        static void Main(string[] args)
        {
            // Verbaltim String Literal
            string path1 = "C:\\Program Files\\Honkai Impact 3 sea";
            string path2 = @"C:\Program Files\Honkai Impact 3 sea";

            Console.WriteLine(path1);
            Console.WriteLine(path2);

            // String Formatting
            string lastName = "Ho Manh";
            string firstName = "Quan";

            Console.WriteLine("Your full name is " + lastName + " " + firstName);
            Console.WriteLine("Your full name is " + "{0} {1}", lastName, firstName);

            Console.WriteLine();

            Console.Write("Enter your new name: ");
            string? newName = Console.ReadLine();

            if (newName != string.Empty)
            {
                Console.WriteLine("Your new name is " +  newName);
            }
            else
            {
                Console.WriteLine("Your new name is empty.");
            }

            Console.WriteLine();

            string university = "Ho Chi Minh City University of Technology";

            for (int i = 0; i < university.Length; i++)
            {
                Console.Write(university[i]);
                Thread.Sleep(100); // = 0.1 second
            }
            
            if (!string.IsNullOrEmpty(university))
            {
                Console.WriteLine("This university has a name.");
            }
            else
            {
                Console.WriteLine("This university doesn't have a name.");
            }

            // TryPhase

            // Dictionary
        }
    }
}