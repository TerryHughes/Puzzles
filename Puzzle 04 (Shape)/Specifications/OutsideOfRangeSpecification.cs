//-----------------------------------------------------------------------
// <copyright file="OutsideOfRangeSpecification.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.Shape.Specifications
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents an outside of range unit of logic that can be evaluated.
    /// </summary>
    internal class OutsideOfRangeSpecification : PredicateSpecification<IList<int>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutsideOfRangeSpecification" /> class.
        /// </summary>
        /// <param name="lower">The lower value of the range.</param>
        /// <param name="upper">The upper value of the range.</param>
        internal OutsideOfRangeSpecification(int lower, int upper) : base(x => x.Any(n => n < lower || n > upper))
        {
        }
    }
}