namespace learningCSharp.Projects;
// Discount Calculation:
//
// A store offers discounts based on the total purchase amount. If the total is over $100, give a 10% discount;
// if it's over $500, give a 20% discount. Otherwise, no discount. Write a program to calculate the final price.
public class DiscountCalculation
{
    public void calculatePrice()
    {
        Console.Write("Enter the total amount price: ");

        if (double.TryParse(Console.ReadLine(), out double totalAmount))
        {
            double finalAmount = totalAmount;

            if (totalAmount > 500)
            {
                finalAmount = totalAmount * 0.8;
                Console.WriteLine("20% discount applied.");
            }else if (totalAmount > 100)
            {
                finalAmount = totalAmount * 0.9;
                Console.WriteLine("10% discount applied.");
            }
            else
            {
                Console.WriteLine("No discount applied.");
            }

            Console.WriteLine($"Final amount is: ${finalAmount:F2}");
        }
        else
        {
            Console.WriteLine("Invalid Input. Please, enter the valid number");
        }
    }
}