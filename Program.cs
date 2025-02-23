using System;
using System.Collections.Generic;
using learningCSharp.LibraryManagementSystem;
using learningCSharp.OOP;
using learningCSharp.Projects;

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
            // List<Shape> shapes = new List<Shape>();
            //
            // shapes.Add(new Rectangle(5,10));
            // shapes.Add(new Circle(5));
            //
            // foreach (Shape shape in shapes)
            // {
            //     Console.WriteLine($"{shape.GetShapeType()} Area: {shape.CalculateArea()}");
            // }

            // OOP/ClassBankAccount.cs
            // try
            // {
            //     ClassBankAccount account = new ClassBankAccount("123456789", 9999);
            //
            //     account.Deposit(1000);
            //     account.Withdraw(5000);
            //     account.CheckBalance();
            //
            //     account.Withdraw(10000); // Should throw an exception
            // }
            // catch (ArgumentException ex)
            // {
            //     Console.WriteLine($"Error: {ex.Message}");
            // }
            // catch (InvalidOperationException ex)
            // {
            //     Console.WriteLine($"Error: {ex.Message}");
            // }
            // catch(Exception ex)
            // {
            //     Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            // }
            // finally
            // {
            //     Console.WriteLine("Bank Account operation completed.");
            // }

            //     Library library = new Library();
            //
            //     Book book1 = new Book("The Hitchhiker's Guide to the Galaxy", "Douglas Adams", "978-0345391803", 1979, "Science Fiction");
            //     Book book2 = new Book("Pride and Prejudice", "Jane Austen", "978-0141439518", 1813, "Romance");
            //
            //     library.AddItem(book1);
            //     library.AddItem(book2);
            //
            //     Member member1 = new Member("Alice Smith", "123 Main St", "alice@example.com", "M001");
            //     library.AddMember(member1);
            //
            //     library.DisplayItems();
            //     library.DisplayMembers();
            //
            //     member1.BorrowItem(book1);
            //     library.DisplayItems(); // Show borrowed status
            //
            //     member1.ReturnItem(book1);
            //     library.DisplayItems(); // Show returned status
            //
            //     List<LibraryItem> foundItems = library.FindItem("pride", "title");
            //     foreach (var item in foundItems)
            //     {
            //         Console.WriteLine(item);
            //     }
            //
            //     Console.ReadKey();
            //
            // }

            GuessNumber game = new GuessNumber();
            game.Play();
        }
    }
}

// Custom Exception Class
// public class InvalidOperationException : Exception
// {
//     public InvalidOperationException() : base("Insufficient funds.")
//     {
//     }
//     public InvalidOperationException(string message) : base(message)
//     {
//     }
//     public InvalidOperationException(string message, Exception innerException) : base(message, innerException)
//     {
//     }
// }

/*
 * TODO:
 * Design a system for a library.  You might have classes like Book, Member, Loan, etc.
 * Think about the relationships between these classes (inheritance, composition) and
 * how you would implement methods for borrowing and returning books.
 * Consider using interfaces for common actions (e.g., an IBorrowable interface).
 */