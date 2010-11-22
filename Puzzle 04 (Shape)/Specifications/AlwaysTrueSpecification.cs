//-----------------------------------------------------------------------
// <copyright file="AlwaysTrueSpecification.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.Shape.Specifications
{
    /// <summary>
    /// Represents an always true unit of logic that can be evaluated.
    /// </summary>
    /// <typeparam name="T">The type involved in the specification.</typeparam>
    internal class AlwaysTrueSpecification<T> : PredicateSpecification<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlwaysTrueSpecification{T}" /> class.
        /// </summary>
        internal AlwaysTrueSpecification() : base(x => true)
        {
        }
    }
}