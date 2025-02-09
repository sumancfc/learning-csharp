//Vowel or Consonant: Ask the user for a single character and determine if it's a vowel or a consonant (case-insensitive).
namespace learningCSharp;

class FindVowelConsonant
{
   public static void VowelConsonant()
   {
      Console.Write("Enter a character: ");
      char ch = Console.ReadKey().KeyChar;

      // Check input is alphabet or not
      if (char.IsLetter(ch))
      {
         // Convert input to lower case
         ch = char.ToLower(ch);

         if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
         {
            Console.WriteLine("\nInput character is Vowel.");
         }else{
            Console.WriteLine("\nInput character is Consonant.");
         }
      }else{
         Console.WriteLine("\nInput is not an alphabet.");
      }
   }
}