//-----------------------------------------------------------------------
// <copyright file="BinaryMultiplyOperation.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.MathExpression.Operations
{
    using THughes.Puzzles.MathExpression.Operators;

    /// <summary>
    /// Represents a binary multiply operation.
    /// </summary>
    internal class BinaryMultiplyOperation : BinaryOperation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryMultiplyOperation" /> class.
        /// </summary>
        /// <param name="left">The left hand value.</param>
        /// <param name="right">The right hand value.</param>
        internal BinaryMultiplyOperation(double left, double right) : base(left, new MultiplyOperator(), right)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryMultiplyOperation" /> class.
        /// </summary>
        /// <param name="left">The left hand <see cref="Operation" />.</param>
        /// <param name="right">The right hand value.</param>
        internal BinaryMultiplyOperation(Operation left, double right) : base(left, new MultiplyOperator(), right)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryMultiplyOperation" /> class.
        /// </summary>
        /// <param name="left">The left hand value.</param>
        /// <param name="right">The right hand <see cref="Operation" />.</param>
        internal BinaryMultiplyOperation(double left, Operation right) : base(left, new MultiplyOperator(), right)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryMultiplyOperation" /> class.
        /// </summary>
        /// <param name="left">The left hand <see cref="Operation" />.</param>
        /// <param name="right">The right hand <see cref="Operation" />.</param>
        internal BinaryMultiplyOperation(Operation left, Operation right) : base(left, new MultiplyOperator(), right)
        {
        }
    }
}