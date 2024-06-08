using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of the month you want: ");
            int month = Convert.ToInt32(Console.ReadLine());

            switch(month)
            {
                case 1:
                    Console.WriteLine("This month is January.");
                    break;
                case 2:
                    Console.WriteLine("This month is February.");
                    break;
                case 3:
                    Console.WriteLine("This month is March.");
                    break;
                case 4:
                    Console.WriteLine("This month is April.");
                    break;
                case 5:
                    Console.WriteLine("This month is May.");
                    break;
                case 6:
                    Console.WriteLine("This month is June.");
                    break;
                case 7:
                    Console.WriteLine("This month is July.");
                    break;
                case 8:
                    Console.WriteLine("This month is August.");
                    break;
                case 9:
                    Console.WriteLine("This month is September.");
                    break;
                case 10:
                    Console.WriteLine("This month is October.");
                    break;
                case 11:
                    Console.WriteLine("This month is November.");
                    break;
                case 12:
                    Console.WriteLine("This month is December.");
                    break;
                default:
                    Console.WriteLine("Invalid month number.");
                    break;
            }
        }
    }
}