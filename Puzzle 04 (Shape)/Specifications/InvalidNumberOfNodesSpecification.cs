//-----------------------------------------------------------------------
// <copyright file="InvalidNumberOfNodesSpecification.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.Shape.Specifications
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Reprensents an invalid number of nodes unit of logic that can be evaluated.
    /// </summary>
    internal class InvalidNumberOfNodesSpecification : PredicateSpecification<IList<int>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidNumberOfNodesSpecification" /> class.
        /// </summary>
        internal InvalidNumberOfNodesSpecification() : base(l => !new[] { 3, 4, 6 }.Contains(l.Count))
        {
        }
    }
}