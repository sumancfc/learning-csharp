namespace learningCSharp.Projects;
/*(Display four patterns using loops) Use nested loops that display the following patterns in four separate programs:
Pattern A            Pattern B            Pattern C          Pattern D
1                    1 2 3 4 5 6                  1          1 2 3 4 5 6
1 2                  1 2 3 4 5                  2 1            1 2 3 4 5
1 2 3                1 2 3 4                  3 2 1              1 2 3 4
1 2 3 4              1 2 3                  4 3 2 1                1 2 3
1 2 3 4 5            1 2                  5 4 3 2 1                  1 2
1 2 3 4 5 6          1                  6 5 4 3 2 1                    1
*/
public class DesignPatterns
{
    private void GeneratePatternA(int rows)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }

    private void GeneratePatternB(int rows)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= rows - i + 1; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }

    private void GeneratePatternC(int rows)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write("  ");
            }
            for (int j = i; j >= 1; j--)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }

    private void GeneratePatternD(int rows)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j < i; j++)
            {
                Console.Write("  ");
            }
            for (int j = 1; j <= rows - i + 1; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }

    public void RunPatterns()
    {
        Console.Write("Enter the number of rows for all patterns: ");
        if (int.TryParse(Console.ReadLine(), out int rows))
        {
            Console.WriteLine("\nPattern A:");
            GeneratePatternA(rows);

            Console.WriteLine("\nPattern B:");
            GeneratePatternB(rows);

            Console.WriteLine("\nPattern C:");
            GeneratePatternC(rows);

            Console.WriteLine("\nPattern D:");
            GeneratePatternD(rows);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}