//-----------------------------------------------------------------------
// <copyright file="PredicateSpecification.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.Shape.Specifications
{
    using System;

    /// <summary>
    /// Represents an anonymous unit of logic that can be evaluated.
    /// </summary>
    /// <typeparam name="T">The type involved in the specification.</typeparam>
    internal class PredicateSpecification<T>
    {
        /// <summary>
        /// The anonymous evaluation.
        /// </summary>
        private readonly Predicate<T> predicate;

        /// <summary>
        /// Initializes a new instance of the <see cref="PredicateSpecification{T}" /> class.
        /// </summary>
        /// <param name="predicate">The anonymous evaluation.</param>
        internal PredicateSpecification(Predicate<T> predicate)
        {
            this.predicate = predicate;
        }

        /// <summary>
        /// Evaluates the specified item with the <see cref="PredicateSpecification{T}" />.
        /// </summary>
        /// <param name="item">The object to evaluate with the <see cref="PredicateSpecification{T}" />.</param>
        /// <returns>true if <paramref name="item" /> is satisfied by the <see cref="PredicateSpecification{T}" />; otherwise, false.</returns>
        internal bool IsSatisfiedBy(T item)
        {
            return this.predicate(item);
        }
    }
}