using System;

namespace Switch
{
    class Loop
    {
        static void Main(string[] args)
        {
            // For
            Console.WriteLine("Example of \"for\": ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            // Foreach
            Console.WriteLine("Example of \"foreach\": ");
            foreach (int i in 0)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            // While
            Console.WriteLine("Example of \"while\": ");
            int k = 0;
            while (k < 10)
            {
                Console.WriteLine(k);
                k++;
            }

            Console.WriteLine();

            // Do while
            Console.WriteLine("Example of \"do while\": ");
            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 10);
        }
    }
}