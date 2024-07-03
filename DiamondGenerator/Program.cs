using System;

namespace DiamondGenerator
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                Console.Write("Enter a character (A-Z): ");
                char inputChar = Console.ReadKey().KeyChar;
                Console.WriteLine(); // Move to the next line

                var inputValidator = new InputValidator();
                if (!inputValidator.IsValidInput(inputChar))
                {
                    Console.WriteLine($"Error: Invalid input. Please provide an uppercase letter.");
                    return;
                }

                var diamond = new Diamond(inputValidator);
                Console.WriteLine(diamond.Create(inputChar));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
