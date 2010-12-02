//-----------------------------------------------------------------------
// <copyright file="Evaluator.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.RomanNumeral
{
    using System;
    using System.Linq;

    /// <summary>
    /// Evaluates things.
    /// </summary>
    public static class Evaluator
    {
        /// <summary>
        /// Evaluates the roman numeral text into it's <see cref="Int32" /> value.
        /// </summary>
        /// <param name="value">The roman numeral text.</param>
        /// <returns>The roman numeral text as a <see cref="Int32" />.</returns>
        public static int Evaluate(string value)
        {
            return value.Sum(v => RomanNumeralToken.Tokens.First(t => v.ToString() == t.Lexeme).NumericValue);
        }
    }
}