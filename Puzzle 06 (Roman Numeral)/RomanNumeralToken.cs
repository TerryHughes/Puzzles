//-----------------------------------------------------------------------
// <copyright file="RomanNumeralToken.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.RomanNumeral
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents a roman numeral.
    /// </summary>
    internal sealed class RomanNumeralToken : Token
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RomanNumeralToken"/> class.
        /// </summary>
        /// <param name="lexeme">A block of text corresponding to this <see cref="RomanNumeralToken" />.</param>
        /// <param name="numericValue">A numeric value corresponding to this <see cref="RomanNumeralToken" />.</param>
        private RomanNumeralToken(string lexeme, int numericValue) : base(lexeme)
        {
            this.NumericValue = numericValue;
        }

        /// <summary>
        /// Gets the roman numeral tokens.
        /// </summary>
        internal static IEnumerable<RomanNumeralToken> Tokens
        {
            get
            {
                yield return new RomanNumeralToken("I", 1);
                yield return new RomanNumeralToken("V", 5);
            }
        }

        /// <summary>
        /// Gets the numeric value corresponding to the roman numeral token.
        /// </summary>
        internal int NumericValue { get; private set; }
    }
}