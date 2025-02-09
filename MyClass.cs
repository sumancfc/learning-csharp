namespace learningCSharp;

// Class Members: Fields and methods inside classes are often referred to as "class members".
public class Car
{
     string model;
     string color;
     int year;

     public static void MyCar()
     {
         Car Ford = new Car();
         Ford.model = "Mustang";
         Ford.color = "red";
         Ford.year = 1969;

         Car Opel = new Car();
         Opel.model = "Astra";
         Opel.color = "white";
         Opel.year = 2005;

         Console.WriteLine($"My car is a {Ford.year} {Ford.color} {Ford.model}.");
         Console.WriteLine($"My other car is a {Opel.year} {Opel.color} {Opel.model}.");
     }
}