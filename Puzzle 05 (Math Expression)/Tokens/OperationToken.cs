//-----------------------------------------------------------------------
// <copyright file="OperationToken.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.MathExpression.Tokens
{
    using THughes.Puzzles.MathExpression.Operations;

    /// <summary>
    /// Represents an operation token.
    /// </summary>
    internal class OperationToken : Token
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationToken" /> class.
        /// </summary>
        /// <param name="left">The left hand <see cref="Token" /> for this <see cref="OperationToken" />.</param>
        /// <param name="op">The operation <see cref="Token" /> for this <see cref="OperationToken" />.</param>
        /// <param name="right">The right hand <see cref="Token" /> for this <see cref="OperationToken" />.</param>
        internal OperationToken(Token left, Token op, Token right) : base(left.Lexeme + op.Lexeme + right.Lexeme)
        {
            ////Operation = new BinaryOperation(new Oper)
        }

        /// <summary>
        /// Gets the <see cref="Operation" /> for the current <see cref="OperationToken" />.
        /// </summary>
        internal Operation Operation { get; private set; }
    }
}