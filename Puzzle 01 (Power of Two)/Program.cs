//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.PowerOfTwo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Validates an algorithm that determines if an <see cref="Int32" /> is a power of two.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static void Main()
        {
            var powersOfTwo = new List<int>();
            for (var i = 0; Math.Pow(2, i) <= Int32.MaxValue; i++)
            {
                powersOfTwo.Add(Convert.ToInt32(Math.Pow(2, i)));
            }

            foreach (var value in Enumerable.Range(-50, 5000))
            {
                Assert(powersOfTwo.Contains(value), Calculator.IsPowerOfTwo(value), value.ToString());
            }
        }

        /// <summary>
        /// Verifies that two <see cref="Boolean" />s are equal.
        /// </summary>
        /// <param name="expected">The expected value.</param>
        /// <param name="actual">The actual value.</param>
        /// <param name="message">The message to display when the values are not equal.</param>
        private static void Assert(bool expected, bool actual, string message)
        {
            if (expected != actual)
            {
                Console.WriteLine("FAILED: " + message);
            }
        }
    }
}