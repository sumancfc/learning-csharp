# OOP Concepts

## Abstraction

`Data abstraction` is a process of hiding the implementation details and showing only the functionality to the user. In other words, it deals with the outside view of an object (interface) rather than the inside view (implementation).

`Keyword abstract` is used to create an abstract class or abstract method. An abstract class is a class that cannot be instantiated and is used as a base class. An abstract method is a method that is declared without an implementation and must be implemented by derived classes.

```csharp
abstract class Animal
{
    // Abstract method (no implementation)
    public abstract void animalSound();
    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}

// Genereate an error if not implemented
Animal myAnimal = new Animal(); // Error
```

To access the abstract class, a class must inherit from it and provide implementations for the abstract methods.

```csharp
// Derived class (inherits from Animal)
class Dog : Animal
{
    // Implementation of the abstract method
    public override void animalSound()
    {
        Console.WriteLine("The dog says: Woof");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog(); // Create a Dog object
        myDog.animalSound(); // Call the abstract method
        myDog.sleep(); // Call the regular method
    }
}
```

Why and when to use `abstraction`?

- To hide certain details and only show the important details of an object.
- To reduce the complexity of the code and make it easier to understand.
- To define a blueprint for other classes.