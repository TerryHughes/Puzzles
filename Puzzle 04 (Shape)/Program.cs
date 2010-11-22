//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.Shape
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using THughes.Puzzles.Shape.Specifications;

    /// <summary>
    /// Validates an algorithm that determines whether a list of numbers form a valid shape.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static void Main()
        {
            Func<IList<int>, string> solver = ShapeSolver.Solve;
            Assert("Invalid", solver(null), "null");
            Assert("Invalid", solver(new List<int>()), "0 count");
            Assert("Invalid", solver(new[] { 1 }), "1 count");
            Assert("Invalid", solver(new[] { 1, 2 }), "2 count");
            Assert("Invalid", solver(new[] { 1, 2, 3, 4, 5 }), "5 count");
            Assert("Invalid", solver(new[] { 1, 2, 3, 4, 5, 6, 7 }), "7 count");
            Assert("Invalid", solver(new[] { 1, 2, 2 }), "duplicates");
            Assert("Triangle", solver(new[] { 1, 2, 3 }), "triangle 1,2,3");
            Assert("Triangle", solver(new[] { 3, 2, 1 }), "triangle 3,2,1");
            Assert("Triangle", solver(new[] { 1, 4, 6 }), "triangle 1,4,6");
            Assert("Triangle", solver(new[] { 2, 3, 5 }), "triangle 2,3,5");
            Assert("Triangle", solver(new[] { 4, 6, 13 }), "triangle 4,6,13");
            Assert("Triangle", solver(new[] { 1, 499501, 500500 }), "triangle 1,499501,500500");
            Assert("Invalid", solver(new[] { 1, 3, 4 }), "3 invalid");
            Assert("Invalid", solver(new[] { 1, 3, 6 }), "3 straight line");
            Assert("Invalid", solver(new[] { 4, 5, 13 }), "invalid triangle 4,5,13");
            Assert("Invalid", solver(new[] { 2, 6, 8 }), "invalid triangle 2,6,8");
            Assert("Invalid", solver(new[] { 5, 7, 10 }), "invalid triangle 5,7,10");
            Assert("Invalid", solver(new[] { 1, 8, 9 }), "invalid triangle 1,8,9");
            Assert("Parallelogram", solver(new[] { 2, 3, 5, 6 }), "parallelogram 2,3,5,6");
            Assert("Parallelogram", solver(new[] { 6, 5, 3, 2 }), "parallelogram 6,5,3,2");
            Assert("Parallelogram", solver(new[] { 2, 3, 4, 5 }), "parallelogram 2,3,4,5");
            Assert("Parallelogram", solver(new[] { 4, 6, 13, 15 }), "parallelogram 4,6,13,15");
            Assert("Parallelogram", solver(new[] { 4, 6, 11, 13 }), "parallelogram 4,6,11,13");
            Assert("Parallelogram", solver(new[] { 1, 2, 3, 5 }), "parallelogram 1,2,3,5");
            Assert("Parallelogram", solver(new[] { 1, 4, 6, 13 }), "parallelogram 1,4,6,13");
            Assert("Invalid", solver(new[] { 1, 3, 4, 8 }), "4 invalid");
            Assert("Invalid", solver(new[] { 1, 3, 6, 10 }), "4 straight line");
            Assert("Invalid", solver(new[] { 4, 5, 9, 10 }), "invalid parallelogram 4,5,9,10");
            Assert("Invalid", solver(new[] { 4, 5, 8, 10 }), "invalid parallelogram 4,5,8,10");
            Assert("Invalid", solver(new[] { 2, 3, 7, 8 }), "invalid parallelogram 2,3,7,8");
            Assert("Invalid", solver(new[] { 4, 6, 22, 24 }), "invalid parallelogram 4,6,22,24");
            Assert("Hexagon", solver(new[] { 2, 3, 4, 6, 8, 9 }), "hexagon 2,3,4,6,8,9");
            Assert("Hexagon", solver(new[] { 9, 8, 6, 4, 3, 2 }), "hexagon 9,8,6,4,3,2");
            Assert("Hexagon", solver(new[] { 4, 6, 11, 15, 24, 26 }), "hexagon 4,6,11,15,24,26");
            Assert("Invalid", solver(new[] { 1, 3, 4, 8, 5, 9 }), "6 invalid");
            Assert("Invalid", solver(new[] { 1, 3, 6, 10, 12, 21 }), "6 straight line");
            Assert("Invalid", solver(new[] { 1, 2, 3, 8, 9, 13 }), "invalid hexagon 1,2,3,8,9,13");
            Assert("Invalid", solver(new[] { 2, 3, 7, 10, 17, 18 }), "invalid hexagon 2,3,7,10,17,18");
            Assert("Invalid", solver(new[] { 4, 6, 7, 10, 12, 14 }), "invalid hexagon 4,6,7,10,12,14");

            /*
             * 
             *                  R  N
             *       *          1  1
             *      * *         2  3
             *     * * *        3  6
             *    * * * *       4 10
             *   * * * * *      5 15
             *  * * * * * *     6 21
             * * * * * * * *    7 28
             * 
             */
        }

        /// <summary>
        /// Creates the assert specifications.
        /// </summary>
        /// <typeparam name="T">The type involved in the assert.</typeparam>
        /// <returns>The assert specifications.</returns>
        private static IDictionary<Func<T, PredicateSpecification<T>>, Action<string>> AssertSpecifications<T>() where T : class
        {
            return new Dictionary<Func<T, PredicateSpecification<T>>, Action<string>>
            {
                { actual => new AssertSpecification<T>(actual), message => Console.WriteLine("FAILED: " + message) },
                { x => new AlwaysTrueSpecification<T>(), x => { } }
            };
        }

        /// <summary>
        /// Verifies that two values are equal.
        /// </summary>
        /// <typeparam name="T">The type involved in the assert.</typeparam>
        /// <param name="expected">The expected value.</param>
        /// <param name="actual">The actual value.</param>
        /// <param name="message">The message to display when the values are not equal.</param>
        private static void Assert<T>(T expected, T actual, string message) where T : class
        {
            AssertSpecifications<T>().First(p => p.Key(actual).IsSatisfiedBy(expected)).Value(message);
        }
    }
}