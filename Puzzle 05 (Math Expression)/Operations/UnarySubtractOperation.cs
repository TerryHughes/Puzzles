//-----------------------------------------------------------------------
// <copyright file="UnarySubtractOperation.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.MathExpression.Operations
{
    using THughes.Puzzles.MathExpression.Operators;

    /// <summary>
    /// Represents an unary subtract operation.
    /// </summary>
    internal class UnarySubtractOperation : UnaryOperation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnarySubtractOperation" /> class.
        /// </summary>
        /// <param name="value">The value for the <see cref="UnarySubtractOperation" />.</param>
        internal UnarySubtractOperation(double value) : base(new SubtractOperator(), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnarySubtractOperation" /> class.
        /// </summary>
        /// <param name="operation">The <see cref="Operation" /> for the <see cref="UnarySubtractOperation" />.</param>
        internal UnarySubtractOperation(Operation operation) : base(new SubtractOperator(), operation)
        {
        }
    }
}