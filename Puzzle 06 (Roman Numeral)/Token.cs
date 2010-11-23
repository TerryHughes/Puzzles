//-----------------------------------------------------------------------
// <copyright file="Token.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.RomanNumeral
{
    /// <summary>
    /// Represents a categorized block of text.
    /// </summary>
    internal abstract class Token
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Token" /> class.
        /// </summary>
        /// <param name="lexeme">A block of text corresponding to this <see cref="Token" />.</param>
        protected Token(string lexeme)
        {
            this.Lexeme = lexeme;
        }

        /// <summary>
        /// Gets the block of text corresponding to the current <see cref="Token" />.
        /// </summary>
        internal string Lexeme { get; private set; }
    }
}