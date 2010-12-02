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
            return RomanNumeralToken.Tokens.First(t => value == t.Lexeme).NumericValue;
        }
    }
}