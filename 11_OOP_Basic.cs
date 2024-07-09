using System;

namespace OOP_Basic
{
    class Program
    {
        // Class
        class Person
        {
            // Fields
            private string name;
            public int age;

            // Constructor
            public Person(string name, int age)
            {
                // Method 1
                this.name = name;
                this.age = age;

                // Method 2: Properties in the constructor
                Name = name;
                Age = age;
            }

            public string getName()
            {
                return name;
            }
            public void setName(string value)
            {
                name = value;
            }

            // Properties (Don't write these properties if you choose Method 1)
            public string Name { get; set; }
            public int Age { get; set; }

            // Methods
            public void Information()
            {
                Console.WriteLine($"Your information includes name: {name} and age: {age}");
            }
        }

        /*
         * Ta có thể dùng cách khác ngắn gọn hơn khi viết Class (Cách viết này không dùng được Properties):
         * 
            class Person(string name, int age)
            {
                // Fields
                private string name = name;
                public int age = age;
         
                // Methods
                public void Information()
                {
                    Console.WriteLine($"Your information includes name: {name} and age: {age}");
                }
            }
         *
        */

        static void Main(string[] args)
        {
            string myName = "Ho Manh Quan";
            int myAge = 23;

            Person Person1 = new Person(myName, myAge); // Object

            Console.WriteLine($"My name is {Person1.getName()} and I'm {Person1.age} years old.");

            Person Person2 = new Person("Sussy Boy", 25); // Object

            Console.WriteLine($"My name is {Person2.Name} and I'm {Person2.Age} years old.");

            Person2.setName("Sussy Among Us Boy");
            Person2.Age = 27;

            Console.WriteLine($"My name is {Person2.getName()} and I'm {Person2.Age} years old.");

            Person2.Information();
        }
    }
}