namespace learningCSharp;

// Create a class Rectangle with properties Length and Width. Add methods to calculate the area and perimeter of the rectangle.
public class ClassRectangle
{
       public int Length;
       public int Width;

        public ClassRectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public void CalculateArea()
        {
            int area = Length * Width;
            Console.WriteLine($"Area of the rectangle is {area}");
        }

        public void CalculatePerimeter()
        {
            int perimeter = 2 * (Length + Width);
            Console.WriteLine($"Perimeter of the rectangle is {perimeter}");
        }
}
