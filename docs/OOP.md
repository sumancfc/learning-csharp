# OOP (Object Oriented Programming)

## Class and Objects

`Class:` A blueprint or template for creating objects. It defines the properties (data) and methods (behavior) that objects of that class will have.

`Object:` An instance of a class. It's a concrete entity that exists in memory.

```csharp
// Class definition
public class Dog
{
    public string Name { get; set; } // Property
    public string Breed { get; set; } // Property
    public int Age { get; set; }     // Property

    public void Bark()              // Method
    {
        Console.WriteLine("Woof!");
    }

    public void Eat()              // Method
    {
        Console.WriteLine("The dog is eating.");
    }
}

// Creating objects (instances of the Dog class)
Dog myDog = new Dog();
myDog.Name = "Buddy";
myDog.Breed = "Golden Retriever";
myDog.Age = 3;

Dog anotherDog = new Dog();
anotherDog.Name = "Max";
anotherDog.Breed = "German Shepherd";
anotherDog.Age = 5;

myDog.Bark(); // Calling a method on an object
Console.WriteLine(myDog.Name); // Accessing a property
```

## Inheritance

Inheritance is a mechanism in which a new class is created (derived class) that inherits properties and methods from an existing class (base class).

```csharp
// Base class
public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    
    public Animal(string name, int age) // Constructor
    {
        Name = name;
        Age = age;
    }
    
    public virtual void MakeSound() // Virtual method for polymorphism
    {
        Console.WriteLine("Animal sound");
    }
}

// Derived class (inherits from Animal)
public class Dog: Animal
{
    public string Breed { get; set; }
    
    public Dog(string name, int age, string breed): base(name, age) // Call base class constructor
    {
        Breed = breed;
    }
    
    public override void MakeSound() // Override the base class method
    {
        Console.WriteLine("Woof!");
    }
}

Dog myDog = new Dog("Buddy", 3, "Golden Retriever");
myDog.MakeSound(); // Calls the overridden method
Console.WriteLine(myDog.Name); // Accesses the property from the base class
```