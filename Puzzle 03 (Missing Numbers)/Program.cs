//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.MissingNumbers
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    /// <summary>
    /// Validates an algorithm that determines what numbers are missing from a sequence of numbers.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static void Main()
        {
            var results1 = Finder.GetMissingNumbers(new[] { 5, 1, 4, 3 }, 5);
            Assert(results1.Count() == 1, true, "5,1,4,3 count == 1");
            Assert(results1.Contains(2), true, "5,1,4,3 contains 2");

            var result2 = Finder.GetMissingNumbers(new[] { 2, 6, 4, 5 }, 6);
            Assert(result2.Count() == 2, true, "2,6,4,5 count == 2");
            Assert(result2.Contains(1), true, "2,6,4,5 contains 1");
            Assert(result2.Contains(3), true, "2,6,4,5 contains 3");

            var result3 = Finder.GetMissingNumbers(new[] { 4, 1, 3, 2 }, 6);
            Assert(result3.Count() == 2, true, "4,1,3,2 count == 2");
            Assert(result3.Contains(5), true, "4,1,3,2 contains 5");
            Assert(result3.Contains(6), true, "4,1,3,2 contains 6");

            var result4 = Finder.GetMissingNumbers(new int[] { }, 2);
            Assert(result4.Count() == 2, true, "{} count == 2");
            Assert(result4.Contains(1), true, "{} contains 1");
            Assert(result4.Contains(2), true, "{} contains 2");

            var result5 = Finder.GetMissingNumbers(new[] { 1, 2, 3, 4, 5 }, 5);
            Assert(result5.Count() == 0, true, "4,1,3,2 count == 0");

            var result6 = Finder.GetMissingNumbers(Enumerable.Range(1, 10.Million()).ToArray(), 10.Million());
            Assert(result6.Count() == 0, true, "10 million count == 0");

            var result7 = Finder.GetMissingNumbers(Enumerable.Range(1, 10.Million()).ToArray(), 15.Million());
            Assert(result7.Count() == 5.Million(), true, "10 million count == 5 million");

            var array = Enumerable.Range(1, 5.Million()).ToArray();
            var time = Timed(() => Finder.GetMissingNumbers(array, 7.Million()).ToList());
            Console.WriteLine("7 million in: " + time + " milliseconds");
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

        /// <summary>
        /// Times how long an action takes.
        /// </summary>
        /// <param name="action">The <see cref="Action" /> to time.</param>
        /// <returns>How long (in milliseconds) it took for the action to complete.</returns>
        private static long Timed(Action action)
        {
            var watch = Stopwatch.StartNew();
            action();
            watch.Stop();

            return watch.ElapsedMilliseconds;
        }
    }
}