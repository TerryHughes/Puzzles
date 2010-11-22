//-----------------------------------------------------------------------
// <copyright file="HasDuplicatesSpecification.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.Shape.Specifications
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a has duplicates unit of logic that can be evaluated.
    /// </summary>
    internal class HasDuplicatesSpecification : PredicateSpecification<IList<int>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HasDuplicatesSpecification" /> class.
        /// </summary>
        internal HasDuplicatesSpecification() : base(l => l.Distinct().Count() != l.Count)
        {
        }
    }
}