//-----------------------------------------------------------------------
// <copyright file="GridWalker.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.Shape.Specifications.GridWalking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a grid walker unit of logic that can be evaluated.
    /// </summary>
    internal abstract class GridWalker : PredicateSpecification<IList<int>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GridWalker" /> class.
        /// </summary>
        /// <param name="pointRow">The row the point is on.</param>
        /// <param name="rowDifference">The difference between the point row and the target row.</param>
        /// <param name="point">The point.</param>
        /// <param name="walker">The walker.</param>
        /// <param name="adjustment">The adjustment for every row walked.</param>
        /// <param name="evaluator">The evaluator.</param>
        internal GridWalker(int pointRow, int rowDifference, int point, double walker, double adjustment, Func<IEnumerable<int>, double, bool> evaluator) : base(l => evaluator(l.Where(n => n != point), walker))
        {
// ReSharper disable DoNotCallOverridableMethodsInConstructor
            for (var i = pointRow + this.StartValue; this.Continue(i, pointRow - rowDifference); i += this.Incrementor)
            {
                walker += (i + adjustment) * this.Incrementor;
            }

// ReSharper restore DoNotCallOverridableMethodsInConstructor
        }

        /// <summary>
        /// Gets the value to start walking the grid from.
        /// </summary>
        protected abstract int StartValue { get; }

        /// <summary>
        /// Gets the incrementor for walking the grid.
        /// </summary>
        protected abstract int Incrementor { get; }

        /// <summary>
        /// Determines whether to continue walking the grid.
        /// </summary>
        /// <param name="i">The current grid position.</param>
        /// <param name="value">The grid position to stop at.</param>
        /// <returns>true if grid walking should be continued; otherwise, false.</returns>
        protected abstract bool Continue(int i, int value);
    }
}