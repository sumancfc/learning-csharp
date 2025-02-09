// Base Class: Animal
public class Animal
{
    public string Name { get; set; }
    public string Species { get; set; }
    public string Color { get; set; }
    public int Age { get; set; }

    public Animal(string name, string species, string color, int age)
    {
        Name = name;
        Species = species;
        Color = color;
        Age = age;
    }

    public virtual void MakeSound() // Virtual for overriding in derived classes
    {
        Console.WriteLine("Generic animal sound");
    }

    public override string ToString() // Override ToString for better output
    {
        return $"Name: {Name}, Species: {Species}, Color: {Color}, Age: {Age}";
    }
}

// Derived Class: Dog (inherits from Animal)
public class Dog : Animal
{
  public string Breed { get; set; }

  public Dog(string name, string color, int age, string breed) : base(name, "Canine", color, age)
  {
      Breed = breed;
  }

  public override void MakeSound() // Override the base class method
  {
      Console.WriteLine("Woof!");
  }

  public void Fetch()
  {
      Console.WriteLine($"{Name} is fetching the ball!");
  }
}

// Derived Class: Cat (inherits from Animal)
public class Cat : Animal
{
    public string EyeColor { get; set; }

    public Cat(string name, string color, int age, string eyeColor) : base(name, "Feline", color, age)
    {
        EyeColor = eyeColor;
    }

    public override void MakeSound() // Override the base class method
    {
        Console.WriteLine("Meow!");
    }

    public void Purr()
    {
        Console.WriteLine($"{Name} is purring.");
    }
}
