//-----------------------------------------------------------------------
// <copyright file="OperatorToken.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.MathExpression.Tokens
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents an operator token.
    /// </summary>
    internal class OperatorToken : Token
    {
        /// <summary>
        /// The left paran operator.
        /// </summary>
        private static readonly Token LeftParan = new OperatorToken("(");

        /// <summary>
        /// The right paran operator.
        /// </summary>
        private static readonly Token RightParan = new OperatorToken(")");

        /// <summary>
        /// The multiply operator.
        /// </summary>
        private static readonly Token Multiply = new OperatorToken("*");

        /// <summary>
        /// The divide operator.
        /// </summary>
        private static readonly Token Divide = new OperatorToken("/");

        /// <summary>
        /// The subtract operator.
        /// </summary>
        private static readonly Token Subtract = new OperatorToken("-");

        /// <summary>
        /// The add operator.
        /// </summary>
        private static readonly Token Add = new OperatorToken("+");

        /// <summary>
        /// Initializes a new instance of the <see cref="OperatorToken" /> class.
        /// </summary>
        /// <param name="lexeme">A block of text corresponding to this <see cref="OperatorToken" />.</param>
        private OperatorToken(string lexeme) : base(lexeme)
        {
        }

        /// <summary>
        /// Gets the operator tokens.
        /// </summary>
        public static IEnumerable<Token> Tokens
        {
            get
            {
                yield return LeftParan;
                yield return RightParan;
                yield return Multiply;
                yield return Divide;
                yield return Subtract;
                yield return Add;
            }
        }
    }
}