using System.Globalization;

namespace learningCSharp;

// Celsius to Fahrenheit: Convert a temperature from Celsius to Fahrenheit. Ask the user for the Celsius value.
class ChangeTemperature
{
    public static void CelsiusToFahrenheit()
    {
        // Set culture to invariant to avoid issues with comma/period in numbers
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter the temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        // Console.WriteLine($"Input Celsius: {celsius}");
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"Temperature in Fahrenheit is {fahrenheit}");
    }
}