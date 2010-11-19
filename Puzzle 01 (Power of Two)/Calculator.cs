//-----------------------------------------------------------------------
// <copyright file="Calculator.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.PowerOfTwo
{
    using System;

    /// <summary>
    /// Performs various calculations.
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// Determines whether the <paramref name="value" /> is a power of two.
        /// </summary>
        /// <param name="value">The <see cref="int" /> to process.</param>
        /// <returns>true if the <paramref name="value" /> is a power of two; otherwise, false.</returns>
        public static bool IsPowerOfTwo(int value)
        {
            var val = Convert.ToDecimal(value);

            while (val > 1)
            {
                val /= 2;
            }

            return val == 1;
        }
    }
}