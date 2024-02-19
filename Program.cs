/*
 *    Author:     Christopher Lopez
 *    Course:     COMP-003A
 *    Purpose:    Code for Assignment5
 */
namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main()
        {
            PrintSeparator();
            Console.Write("Enter a character: ");
            char inputCharacter = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Enter a positive whole number: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            IsoscelesTriangleBuilder(inputCharacter, size);

            PrintSeparator("Favorite Characters");

            CharacterInfo("Chris", 1985);
            CharacterInfo("Zach", 1990);
            CharacterInfo("Lucas", 1995);
            CharacterInfo("Aj", 2000);
            CharacterInfo("Jayda", 2005);
        }

        /// <summary>
        /// Prints a separator line of 50 asterisks.
        /// </summary>
        static void PrintSeparator()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("                 Triangle Section                 ");
            Console.WriteLine("**************************************************");
        }

        /// <summary>
        /// Prints a separator line with the specified string.
        /// </summary>
        /// <param name="text">The string to be displayed in the separator line.</param>
        static void PrintSeparator(string text)
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine($"                 {text}                ");
            Console.WriteLine("**************************************************");
        }

        /// <summary>
        /// Builds an isosceles triangle using the specified character and size.
        /// </summary>
        /// <param name="inputCharacter">The character to be used for building the triangle.</param>
        /// <param name="size">The size of the triangle.</param>
        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            for (int i = 1; i <= size; i++)
            {
                string line = new string(inputCharacter, i);
                Console.WriteLine(line);
            }

            for (int i = size - 1; i >= 1; i--)
            {
                string line = new string(inputCharacter, i);
                Console.WriteLine(line);
            }
        }

        /// <summary>
        /// Calculates and returns the age based on the specified year.
        /// </summary>
        /// <param name="year">The birth year.</param>
        /// <returns>The calculated age.</returns>
        static int AgeCalculator(int year)
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - year;
        }

        /// <summary>
        /// Prints the name and calculated age of a character based on the birth year.
        /// </summary>
        /// <param name="name">The name of the character.</param>
        /// <param name="birthYear">The birth year or the year of first appearance.</param>
        static void CharacterInfo(string name, int birthYear)
        {
            int age = AgeCalculator(birthYear);
            Console.WriteLine($"{name} turns {age} this year!");
        }
    }
}