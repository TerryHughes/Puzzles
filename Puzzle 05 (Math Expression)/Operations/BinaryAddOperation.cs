//-----------------------------------------------------------------------
// <copyright file="BinaryAddOperation.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.MathExpression.Operations
{
    using THughes.Puzzles.MathExpression.Operators;

    /// <summary>
    /// Represents a binary add operation.
    /// </summary>
    internal class BinaryAddOperation : BinaryOperation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryAddOperation" /> class.
        /// </summary>
        /// <param name="left">The left hand value.</param>
        /// <param name="right">The right hand value.</param>
        internal BinaryAddOperation(double left, double right) : base(left, new AddOperator(), right)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryAddOperation" /> class.
        /// </summary>
        /// <param name="left">The left hand <see cref="Operation" />.</param>
        /// <param name="right">The right hand value.</param>
        internal BinaryAddOperation(Operation left, double right) : base(left, new AddOperator(), right)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryAddOperation" /> class.
        /// </summary>
        /// <param name="left">The left hand value.</param>
        /// <param name="right">The right hand <see cref="Operation" />.</param>
        internal BinaryAddOperation(double left, Operation right) : base(left, new AddOperator(), right)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryAddOperation" /> class.
        /// </summary>
        /// <param name="left">The left hand <see cref="Operation" />.</param>
        /// <param name="right">The right hand <see cref="Operation" />.</param>
        internal BinaryAddOperation(Operation left, Operation right) : base(left, new AddOperator(), right)
        {
        }
    }
}