using System;

namespace OOP_Advanced
{
    class Program
    {
        // Inheritance (Thừa kế)
        public class Animal // Base class
        {
            public string? name;

            public void eat()
            {
                Console.WriteLine($"{name} is eating.");
            }
        }

        public class Dog : Animal // Derived Class
        {
            public void bark()
            {
                Console.WriteLine($"{name} is barking.");
            }
        }

        public class Cat : Animal // Derived Class
        {
            public void meow()
            {
                Console.WriteLine($"{name} is meowing.");
            }
        }


        // Encapsulation (Đóng gói)
        public class Person
        {
            private string? name; // Hidden variable

            public void SetName(string newName)
            {
                if (!string.IsNullOrEmpty(newName))
                {
                    name = newName;
                }
                else
                {
                    Console.WriteLine("Invalid name.");
                }
            }

            public string GetName()
            {
                return name;
            }
        }


        // Polymorphism (Đa hình)
        // Method overloading
        public class Math
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
            public double Add(double a, double b, double c)
            {
                return a + b + c;
            }
        }

        // Operator overloading
        public class Complex
        {
            public int Real { get; set; }
            public int Imaginary { get; set; }

            public Complex(int real, int imaginary)
            {
                Real = real;
                Imaginary = imaginary;
            }

            public static Complex operator +(Complex a, Complex b)
            {
                return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
            }
        }

        // Method Overriding
        public class Shape // Base class
        {
            // Virtual Method
            public virtual void Draw()
            {
                Console.WriteLine("Drawing a shape.");
            }
        }

        public class Circle : Shape // Derived class
        {
            // Override
            public override void Draw()
            {
                Console.WriteLine("Drawing a circle.");
            }
        }

        public class Rectangle : Shape // Derived class
        {
            // Override
            public override void Draw()
            {
                Console.WriteLine("Drawing a rectangle.");
            }
        }


        // Abstract (Trừu tượng)
        // Abstract class
        public abstract class Animal_AC
        {
            // Phương thức trừu tượng (không có thân hàm)
            public abstract void MakeSound();

            // Phương thức thông thường (có thân hàm)
            public void Sleep()
            {
                Console.WriteLine("Sleeping");
            }
        }

        public class Dog_AC : Animal_AC
        {
            public override void MakeSound()
            {
                Console.WriteLine("Woof");
            }
        }

        public class Cat_AC : Animal_AC
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow");
            }
        }

        // Interface
        public interface Animal_I
        {
            // Phương thức trừu tượng (không có phần thân)
            void MakeSound();

            // Phương thức mặc định (có phần thân)
            void Sleep()
            {
                Console.WriteLine("Sleeping");
            }
        }

        public class Dog_I : Animal_I
        {
            public void MakeSound()
            {
                Console.WriteLine("Woof");
            }
        }

        public class Cat_I : Animal_I
        {
            public void MakeSound()
            {
                Console.WriteLine("Meow");
            }
        }

        public static void Main(string[] args)
        {
            // Inheritance
            Console.WriteLine("Inheritance: ");
            Dog myDog = new Dog();
            Cat myCat = new Cat();

            myDog.name = "Sussy Dog";
            myCat.name = "Sussy Cat";

            myDog.eat();
            myDog.bark();

            Console.WriteLine();

            myCat.eat();
            myCat.meow();

            Console.WriteLine();

            // Encapsulation
            Console.WriteLine("Encapsulation: ");
            Person Person1 = new Person();

            // Person1.name = "Ho Manh Quan"; -> Got error due to private

            Person1.SetName("Ho Manh Quan");
            Console.WriteLine("Your name is: " + Person1.GetName());

            Console.WriteLine();

            // Polymorphism
            Console.WriteLine("Polymorphism: ");
            Console.WriteLine("1. Method overloading: ");
            Math Math1 = new Math();
            Console.WriteLine("Total sum of a and b is: " + Math1.Add(1, 2));
            Console.WriteLine("Total sum of a and b and c is: " + Math1.Add(1, 2, 3));

            Console.WriteLine();

            Console.WriteLine("2. Operator overloading: ");
            Complex a = new Complex(1, 2);
            Complex b = new Complex(3, 4);
            Complex result = a + b;
            Console.WriteLine($"Real: {result.Real}, Imaginary: {result.Imaginary}");

            Console.WriteLine();

            Console.WriteLine("3. Method overriding: ");
            Shape Shape3 = new Circle();
            Shape Shape4 = new Rectangle();

            Shape3.Draw();
            Shape4.Draw();

            Console.WriteLine();

            // Abstraction
            Console.WriteLine("Abstraction: ");
            Console.WriteLine("1. Abstract class: ");
            Animal_AC myDog_AC = new Dog_AC();
            myDog_AC.MakeSound();
            myDog_AC.Sleep();

            Animal_AC myCat_AC = new Cat_AC();
            myCat_AC.MakeSound();

            Console.WriteLine();

            Console.WriteLine("2. Interface: ");
            Animal_I myDog_I = new Dog_I();
            myDog_I.MakeSound();
            myDog_I.Sleep();

            Animal_I myCat_I = new Cat_I();
            myCat_I.MakeSound();

        }
    }
}