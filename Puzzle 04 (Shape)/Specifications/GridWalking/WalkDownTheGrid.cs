//-----------------------------------------------------------------------
// <copyright file="WalkDownTheGrid.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.Shape.Specifications.GridWalking
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a walk down the grid unit of logic that can be evaluated.
    /// </summary>
    internal class WalkDownTheGrid : GridWalker
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalkDownTheGrid" /> class.
        /// </summary>
        /// <param name="pointRow">The row the point is on.</param>
        /// <param name="rowDifference">The difference between the point row and the target row.</param>
        /// <param name="point">The point.</param>
        /// <param name="walker">The walker.</param>
        /// <param name="adjustment">The adjustment for every row walked.</param>
        /// <param name="evaluator">The evaluator.</param>
        internal WalkDownTheGrid(int pointRow, int rowDifference, int point, double walker, double adjustment, Func<IEnumerable<int>, double, bool> evaluator) : base(pointRow, rowDifference, point, walker, adjustment, evaluator)
        {
        }

        /// <summary>
        /// Gets the value to start walking the grid from.
        /// </summary>
        protected override int StartValue
        {
            get { return 0; }
        }

        /// <summary>
        /// Gets the incrementor for walking the grid.
        /// </summary>
        protected override int Incrementor
        {
            get { return 1; }
        }

        /// <summary>
        /// Determines whether to continue walking the grid.
        /// </summary>
        /// <param name="i">The current grid position.</param>
        /// <param name="value">The grid position to stop at.</param>
        /// <returns>true if grid walking should be continued; otherwise, false.</returns>
        protected override bool Continue(int i, int value)
        {
            return i < value;
        }
    }
}