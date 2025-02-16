# OOP Concepts

## Interface

An interface in C# is a reference type that defines a contract for classes to implement. It contains only the declaration of the methods, properties, and events, but not the implementation. The classes that implement the interface must provide the implementation for the members defined in the interface.

### Interface Example

```csharp
interface IAnimal
{
    void animalSound(); // Method (does not have a body)
    void run(); // Method (does not have a body)
}
```

It is important to note that an interface cannot contain fields, constructors, destructors, or static members. It is better to start the name of an interface with the letter "I" to indicate that it is an interface.

By default, the members of an interface are public and abstract. The class that implements the interface must use the `public` access modifier for the interface members.

```csharp
interface IAnimal
{
    void animalSound();
}

class Dog : IAnimal
{
    public void animalSound()
    {
        Console.WriteLine("The dog says: Woof");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog(); // Create a Dog object
        myDog.animalSound(); // Call the method
    }
}
```

### Notes on Interfaces:

- Like abstract classes, interfaces cannot be used to create objects (in the example above, it is not possible to create an "IAnimal" object in the Program class)
- Interface methods do not have a body - the body is provided by the "implement" class
- On implementation of an interface, you must override all of its methods
- Interfaces can contain properties and methods, but not fields/variables
- Interface members are by default abstract and public
- An interface cannot contain a constructor (as it cannot be used to create objects)

### Why And When To Use Interfaces?

- To achieve security - hide certain details and only show the important details of an object (interface).
- C# does not support "multiple inheritance" (a class can only inherit from one base class). However, it can be achieved with interfaces, because the class can implement multiple interfaces.

## Multiple Interfaces

A class can inherit from multiple interfaces. This is useful when a class needs to implement multiple contracts.

To implement multiple interfaces, separate them with a comma in the class declaration.

```csharp
interface IFirstInterface
{
    void myMethod(); // interface method
}

interface ISecondInterface
{
    void myOtherMethod(); // interface method
}

class DemoClass : IFirstInterface, ISecondInterface
{
    public void myMethod()
    {
        Console.WriteLine("Some text..");
    }

    public void myOtherMethod()
    {
        Console.WriteLine("Some Other text..");
    }
}

class Program
{
    static void Main(string[] args)
    {
        DemoClass myObj = new DemoClass();
        myObj.myMethod();
        myObj.myOtherMethod();
    }
}
```


