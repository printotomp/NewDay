using System;

namespace DiamondGenerator
{
    public interface IInputValidator
    {
        /// <summary>
        /// Validates whether the provided character is a valid input for creating a diamond pattern.
        /// </summary>
        /// <param name="target">The target uppercase letter.</param>
        /// <returns><c>true</c> if the input is valid; otherwise, <c>false</c>.</returns>
        bool IsValidInput(char target);
    }
}
