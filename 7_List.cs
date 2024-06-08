using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            List<int> list = new List<int>() 
            {
                6, 7, 8, 9, 10
            };

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}