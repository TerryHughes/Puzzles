//-----------------------------------------------------------------------
// <copyright file="Merger.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.SortedArrays
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Merges things.
    /// </summary>
    public static class Merger
    {
        /// <summary>
        /// Merges an enumerable of arrays whos elements are sorted into a single sorted array of elements.
        /// </summary>
        /// <param name="arrays">An enumerable of arrays whos elements are sorted.</param>
        /// <returns>A single sorted array of elements.</returns>
        public static int[] Merge(IEnumerable<int[]> arrays)
        {
            return arrays.SelectMany(i => i).OrderBy(i => i).ToArray();
        }
    }
}