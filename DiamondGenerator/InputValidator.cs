using System;

namespace DiamondGenerator
{
    public class InputValidator : IInputValidator
    {
        public bool IsValidInput(char target)
        {
            try
            {
                // Check if the character is a capital letter
                return target >= 'A' && target <= 'Z';
            }
            catch (Exception ex)
            {
                // Handle any exceptions (e.g., unexpected input)
                Console.WriteLine($"Error: {ex.Message}");
                return false; // Return false to indicate invalid input
            }
        }
    }
}
