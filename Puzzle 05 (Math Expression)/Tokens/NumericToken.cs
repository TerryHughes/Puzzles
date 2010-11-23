//-----------------------------------------------------------------------
// <copyright file="NumericToken.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.MathExpression.Tokens
{
    /// <summary>
    /// Represents a numeric token.
    /// </summary>
    internal class NumericToken : Token
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumericToken" /> class.
        /// </summary>
        /// <param name="lexeme">A block of text corresponding to this <see cref="Token" />.</param>
        internal NumericToken(string lexeme) : base(lexeme)
        {
        }
    }
}