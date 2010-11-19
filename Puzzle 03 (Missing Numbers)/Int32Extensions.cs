//-----------------------------------------------------------------------
// <copyright file="Int32Extensions.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.MissingNumbers
{
    using System;

    /// <summary>
    /// Extensions for the <see cref="Int32" /> class.
    /// </summary>
    internal static class Int32Extensions
    {
        /// <summary>
        /// Multiplies the value by a million.
        /// </summary>
        /// <param name="value">The <see cref="Int32" /> to multiple.</param>
        /// <returns>The value multiplied by a million.</returns>
        internal static int Million(this int value)
        {
            return value * 1000000;
        }
    }
}