using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 0;
            int number2 = 1;
            int number3 = 2;

            int[] newNumber = [3, 4, 5, 6];

            /*
             * Or we can use:
               int[] newNumber = new int[3];

               newNumber[0] = 3;
               newNumber[1] = 4;
               newNumber[2] = 5;
               newNumber[3] = 6;
            */

            Console.WriteLine($"Old numbers: {number1}, {number2}, {number3}");
            Console.WriteLine($"New numbers: {newNumber[0]}, {newNumber[1]}, {newNumber[2]}, {newNumber[3]}");

            Console.WriteLine();

            int[] randomArray = [9, 2, 3, 7, 8, 5, 4, 1, 0, 10];
            int[] randomArray2 = [9, 2, 3, 7, 8, 5, 4, 1, 0, 10];

            // Sorted Array
            Array.Sort(randomArray);

            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.Write(randomArray[i] + " ");
            }

            Console.WriteLine();

            // Reversed Array
            Array.Reverse(randomArray2);

            for (int i = 0; i < randomArray2.Length; i++)
            {
                Console.Write(randomArray2[i] + " ");
            }

            Console.WriteLine();

            // Cleared Array
            Array.Clear(randomArray, 4, 6); // 0 1 2 3 0 0 0 0 0 0

            foreach (int i in randomArray)
            {
                Console.Write(randomArray[i] + " ");
            }

            Console.WriteLine();

            // IndexOf
            Console.Write("Enter the number you want to search among new numbers: ");
            int search = Convert.ToInt32(Console.ReadLine());
            int position = Array.IndexOf(newNumber, search);

            if (position != 0)
            {
                Console.WriteLine("The position is " + (position + 1));
            }
            else
            {
                Console.WriteLine("This number doesn't exist.");
            }
        }
    }
}