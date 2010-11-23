//-----------------------------------------------------------------------
// <copyright file="BinarySubtractOperation.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.MathExpression.Operations
{
    using THughes.Puzzles.MathExpression.Operators;

    /// <summary>
    /// Represents a binary subtract operation.
    /// </summary>
    internal class BinarySubtractOperation : BinaryOperation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BinarySubtractOperation" /> class.
        /// </summary>
        /// <param name="left">The left hand value.</param>
        /// <param name="right">The right hand value.</param>
        internal BinarySubtractOperation(double left, double right) : base(left, new SubtractOperator(), right)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinarySubtractOperation" /> class.
        /// </summary>
        /// <param name="left">The left hand <see cref="Operation" />.</param>
        /// <param name="right">The right hand value.</param>
        internal BinarySubtractOperation(Operation left, double right) : base(left, new SubtractOperator(), right)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinarySubtractOperation" /> class.
        /// </summary>
        /// <param name="left">The left hand value.</param>
        /// <param name="right">The right hand <see cref="Operation" />.</param>
        internal BinarySubtractOperation(double left, Operation right) : base(left, new SubtractOperator(), right)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinarySubtractOperation" /> class.
        /// </summary>
        /// <param name="left">The left hand <see cref="Operation" />.</param>
        /// <param name="right">The right hand <see cref="Operation" />.</param>
        internal BinarySubtractOperation(Operation left, Operation right) : base(left, new SubtractOperator(), right)
        {
        }
    }
}