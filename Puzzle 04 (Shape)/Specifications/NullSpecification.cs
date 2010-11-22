//-----------------------------------------------------------------------
// <copyright file="NullSpecification.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.Shape.Specifications
{
    /// <summary>
    /// Represents a null unit of logic that can be evaluated.
    /// </summary>
    /// <typeparam name="T">The type involved in the specification.</typeparam>
    internal class NullSpecification<T> : PredicateSpecification<T> where T : class
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullSpecification{T}" /> class.
        /// </summary>
        internal NullSpecification() : base(x => x == null)
        {
        }
    }
}