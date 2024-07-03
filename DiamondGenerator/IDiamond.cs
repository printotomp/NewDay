using System;

namespace DiamondGenerator
{
    public interface IDiamond
    {
        /// <summary>
        /// Creates a diamond pattern of uppercase letters centered around the given target letter.
        /// </summary>
        /// <param name="target">The target uppercase letter.</param>
        /// <returns>The diamond pattern as a string.</returns>
        /// <exception cref="ArgumentException">Thrown if an invalid input is provided.</exception>
        string Create(char target);
    }
}
