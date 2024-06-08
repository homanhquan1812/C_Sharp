using System;

namespace Class
{
    class Program
    {
        class Person(string name, int age)
        {
            public string name = name;
            public int age = age;

            public string Information()
            {
                return $"Your information includes name: {name} and age: {age}";
            }
        }
        static void Main(string[] args)
        {
            string myName = "Ho Manh Quan";
            int myAge = 23;

            Person Person1 = new Person(myName, myAge);

            Console.WriteLine($"My name is {Person1.name} and I'm {Person1.age} years old.");

            Person Person2 = new Person("Sussy Boy", 25);

            Console.WriteLine($"My name is {Person2.name} and I'm {Person2.age} years old.");
            Console.WriteLine(Person2.Information());
        }
    }
}