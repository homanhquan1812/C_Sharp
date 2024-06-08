using System;

namespace Struct
{
    class Program
    {
        struct Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }
        static void Main(string[] args)
        {
            string myName = "Ho Manh Quan";
            int myAge = 23;

            Person Person1;

            Person1.name = myName;
            Person1.age = myAge;

            Console.WriteLine($"My name is {Person1.name} and I'm {Person1.age} years old.");

            Person Person2 = new Person("Sussy Boy", 25);

            Console.WriteLine($"My name is {Person2.name} and I'm {Person2.age} years old.");
        }
    }
}