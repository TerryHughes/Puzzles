//-----------------------------------------------------------------------
// <copyright file="AssertSpecification.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.Shape.Specifications
{
    /// <summary>
    /// Represents an assert unit of logic that can be evaluated.
    /// </summary>
    /// <typeparam name="T">The type involved in the specification.</typeparam>
    internal class AssertSpecification<T> : PredicateSpecification<T> where T : class
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssertSpecification{T}" /> class.
        /// </summary>
        /// <param name="actual">The actual value.</param>
        internal AssertSpecification(T actual) : base(expected => expected != actual)
        {
        }
    }
}