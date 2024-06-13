using System;

namespace ObjectOrientedProgramming
{
    class Program
    {
        /*
         *-------------------------------------------------------------------*
         *********************** Inheritance (Kế thừa) ***********************
         *-------------------------------------------------------------------*
         * Khái niệm: Cho phép một hoặc nhiều lớp (Derived class - Lớp dẫn   *
         * xuất) kế thừa thuộc tính và phương thức của một lớp khác (Base    *
         * class - Lớp cơ sở) để tăng khả năng tái sử dụng và giảm thiểu việc*
         * lặp lại code.                                                     *
         *                                                                   *
         * Có 5 loại kế thừa (Đọc thêm):                                     *
         * - Đơn kế thừa (Single inheritance).                               *
         * - Đa kế thừa (Multiple inheritance).                              *
         * - Kế thừa đa cấp (Multi-level inheritance).                       *
         * - Kế thừa phân cấp (Hierachical inheritance).                     *
         * - Kế thừa lai (Hybrid inheritance).                               *
         *                                                                   *
         * Ví dụ thực tế:                                                    *
         * - Lớp cha là smartphone, gồm các thuộc tính như : màu sắc, bộ nhớ,*
         * hệ điều hành,...                                                  *
         * - Lớp con là các hãng như iPhone, Samsung, Xiaomi có các thuộc    *
         * tính tương tự.                                                    *
         *-------------------------------------------------------------------*
        */

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

        /*
         *----------------------------------------------------------------------*
         *********************** Encapsulation (Đóng gói) ***********************
         *----------------------------------------------------------------------*
         * Khái niệm: Che giấu thông tin chi tiết của các đối tượng, chỉ cho    *
         * phép truy cập thông qua phương thức public.                          *
         *                                                                      *
         * Tính đóng gói được khai triển bằng cách sử dụng Access modifier, gồm:*
         * - public: Có thể truy cập từ bất cứ đâu.                             *
         * - private: Chỉ có thể truy cập ở bên trong class.                    *
         * - protected: Chỉ có thể truy cập ở bên trong class và các class kế   *
         * thừa từ class đó.                                                    *
         * - internal: Giống như public nhưng chỉ hạn chế trong 1 assembly (Đọc *
         * thêm).                                                               *
         *----------------------------------------------------------------------*
        */

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

        /*
         *----------------------------------------------------------------------*
         ************************ Polymorphism (Đa hình) ************************
         *----------------------------------------------------------------------*
         * Khái niệm: Cho phép các đối tượng thuộc các lớp khác nhau được xử lý *
         * bởi cùng một phương thức.                                            *
         *----------------------------------------------------------------------*
        */

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

        /*
         *----------------------------------------------------------------------*
         *********************** Abstraction (Trừu tượng) ***********************
         *----------------------------------------------------------------------*
         * Khái niệm: Che giấu thông tin chi tiết bên trong của một đối tượng,  *
         * chỉ thể hiện ra những thông tin bên ngoài, từ đây ta có thể hiểu được*
         * đối tượng đó làm gì. Tính chất này được thể hiện qua việc sử dụng    *
         * Giao diện (Interface) hoặc Lớp trừu tượng (Abstract Class).          *
         *                                                                      *
         * -> Nói tóm gọn: Abstraction dùng để ẩn chi tiết, thể hiện tổng quan. *
         *----------------------------------------------------------------------*
        */

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
            Person Person1 = new Person();

            // Person1.name = "Ho Manh Quan"; -> Got error due to private

            Person1.SetName("Ho Manh Quan");
            Console.WriteLine("Your name is: " + Person1.GetName());

            Console.WriteLine();

            // Polymorphism
            Shape Shape1 = new Circle();
            Shape Shape2 = new Rectangle();

            Shape1.Draw();
            Shape2.Draw();
        }
    }
}