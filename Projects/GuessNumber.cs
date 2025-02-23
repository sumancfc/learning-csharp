namespace learningCSharp.Projects;

public class GuessNumber
{
    private int secretNumber;
    private int guessNumber;
    private int totalAttempts;

    public GuessNumber()
    {
        Random randomNumber = new Random();
        secretNumber = randomNumber.Next(0, 51);
        totalAttempts = 0;
    }

    public void Play()
    {
        Console.WriteLine("Welcome to the Guess Number Game!!!");
        Console.WriteLine("Guess the number between 1 to 50");

        do
        {
            Console.Write("Enter your guess number: ");

            if (int.TryParse(Console.ReadLine(), out guessNumber))
            {
                totalAttempts++;

                if (guessNumber < secretNumber)
                {
                    Console.WriteLine("The number is too low.");
                }else if (guessNumber > secretNumber)
                {
                    Console.WriteLine("The number is too high.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the correct number in {totalAttempts} attempts.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please, enter the number between 1 to 50");
            }
        } while (guessNumber != secretNumber);
    }
}