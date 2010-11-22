//-----------------------------------------------------------------------
// <copyright file="CompositePredicateSpecification.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.Shape.Specifications
{
    /// <summary>
    /// Represents the compision of two anonymous units of logic that can be evaluated together.
    /// </summary>
    /// <typeparam name="T">The type involved in the specifications.</typeparam>
    internal class CompositePredicateSpecification<T> : PredicateSpecification<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompositePredicateSpecification{T}" /> class.
        /// </summary>
        /// <param name="left">The left hand side specification.</param>
        /// <param name="right">The right hand side specification.</param>
        internal CompositePredicateSpecification(PredicateSpecification<T> left, PredicateSpecification<T> right) : base(x => left.IsSatisfiedBy(x) && right.IsSatisfiedBy(x))
        {
        }
    }
}