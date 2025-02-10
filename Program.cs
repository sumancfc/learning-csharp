using System;
using System.Collections.Generic;
using learningCSharp.OOP;

namespace learningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hello World: Write a program that prints "Hello, World!" to the console.
            Console.WriteLine("Learning C# is fun!");

            /*Name and Age: Ask the user for their name and age,
             then print a message like "Hello, [name]! You are [age] years old."*/
            // Console.Write("What is your name? ");
            // string name = Console.ReadLine();
            // Console.Write("How old are you? ");
            // string age = Console.ReadLine();
            // Console.WriteLine($"Hello, {name}! You are {age} years old.");

            // Basic Calculation: Write a program that asks the user for two numbers and then prints the sum, difference, and product of those numbers.
            // BasicCalculation.Calculation();
            // ChangeTemperature.CelsiusToFahrenheit();
            // FindVowelConsonant.VowelConsonant();

            //
            // List<Animal> animals = new List<Animal>(); // Polymorphism: List of base class can hold derived class objects
            //
            // Dog myDog = new Dog("Budy", "Brown", 5, "Golden Retriever");
            // Cat myCat = new Cat("Whiskers", "White", 3, "Black");
            // Animal myAnimal = new Animal("Generic", "Animal", "Rainbow", 6);
            //
            // animals.Add(myDog);
            // animals.Add(myCat);
            // animals.Add(myAnimal);
            //
            // foreach (Animal animal in animals)
            // {
            //     Console.WriteLine(animal);
            //     animal.MakeSound();
            //
            //     if(animal is Dog dog)
            //     {
            //         dog.Fetch();
            //     }else if (animal is Cat cat)
            //     {
            //         cat.Purr();
            //     }
            //     Console.WriteLine();
            // }

            // ClassRectangle
            // ClassRectangle rectangle = new ClassRectangle(5, 10);
            // rectangle.CalculateArea();
            // rectangle.CalculatePerimeter();

            // OOP/Shape.cs
            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Rectangle(5,10));
            shapes.Add(new Circle(5));

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.GetShapeType()} Area: {shape.CalculateArea()}");
            }

        }
    }
}