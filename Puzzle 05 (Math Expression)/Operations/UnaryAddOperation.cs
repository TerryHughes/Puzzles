//-----------------------------------------------------------------------
// <copyright file="UnaryAddOperation.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.MathExpression.Operations
{
    using THughes.Puzzles.MathExpression.Operators;

    /// <summary>
    /// Represents an unary add operation.
    /// </summary>
    internal class UnaryAddOperation : UnaryOperation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnaryAddOperation" /> class.
        /// </summary>
        /// <param name="value">The value for the <see cref="UnaryAddOperation" />.</param>
        internal UnaryAddOperation(double value) : base(new AddOperator(), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnaryAddOperation" /> class.
        /// </summary>
        /// <param name="operation">The <see cref="Operation" /> for the <see cref="UnaryAddOperation" />.</param>
        internal UnaryAddOperation(Operation operation) : base(new AddOperator(), operation)
        {
        }
    }
}