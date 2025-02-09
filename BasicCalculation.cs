namespace learningCSharp;
/*Basic Calculations: Ask the user for two numbers and
             print their sum, difference, product, and quotient. Handle potential division by zero.
            */
public class BasicCalculation
{
    public static void Calculation()
    {
        Console.Write("Enter a first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter a second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Sum: {num1 + num2}");
        Console.WriteLine($"Difference: {num1 - num2}");
        Console.WriteLine($"Product:  {num1 * num2}");
        if (num2 != 0)
        {
            Console.WriteLine($"Quotient: {num1 / num2}");
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
}