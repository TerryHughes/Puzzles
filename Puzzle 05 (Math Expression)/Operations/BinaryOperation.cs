//-----------------------------------------------------------------------
// <copyright file="BinaryOperation.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.MathExpression.Operations
{
    using THughes.Puzzles.MathExpression.Operators;

    /// <summary>
    /// Represents a binary operation.
    /// </summary>
    internal class BinaryOperation : Operation
    {
        /// <summary>
        /// The left hand <see cref="Operation" /> for the current <see cref="BinaryOperation" />.
        /// </summary>
        private readonly Operation left;

        /// <summary>
        /// The <see cref="Operator" /> for the current <see cref="BinaryOperation" />.
        /// </summary>
        private readonly Operator op;

        /// <summary>
        /// The right hand <see cref="Operation" /> for the current <see cref="BinaryOperation" />.
        /// </summary>
        private readonly Operation right;

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryOperation" /> class.
        /// </summary>
        /// <param name="left">The left hand value for this <see cref="BinaryOperation" />.</param>
        /// <param name="op">The <see cref="Operator" /> for this <see cref="BinaryOperation" />.</param>
        /// <param name="right">The right hand value for this <see cref="BinaryOperation" />.</param>
        protected BinaryOperation(double left, Operator op, double right) : this(new OperandOperation(left), op, new OperandOperation(right))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryOperation" /> class.
        /// </summary>
        /// <param name="left">The left hand <see cref="Operation" /> for this <see cref="BinaryOperation" />.</param>
        /// <param name="op">The <see cref="Operator" /> for this <see cref="BinaryOperation" />.</param>
        /// <param name="right">The right hand value for this <see cref="BinaryOperation" />.</param>
        protected BinaryOperation(Operation left, Operator op, double right) : this(left, op, new OperandOperation(right))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryOperation" /> class.
        /// </summary>
        /// <param name="left">The left hand value for this <see cref="BinaryOperation" />.</param>
        /// <param name="op">The <see cref="Operator" /> for this <see cref="BinaryOperation" />.</param>
        /// <param name="right">The right hand <see cref="Operation" /> for this <see cref="BinaryOperation" />.</param>
        protected BinaryOperation(double left, Operator op, Operation right) : this(new OperandOperation(left), op, right)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryOperation" /> class.
        /// </summary>
        /// <param name="left">The left hand <see cref="Operation" /> for this <see cref="BinaryOperation" />.</param>
        /// <param name="op">The <see cref="Operator" /> for this <see cref="BinaryOperation" />.</param>
        /// <param name="right">The right hand <see cref="Operation" /> for this <see cref="BinaryOperation" />.</param>
        protected BinaryOperation(Operation left, Operator op, Operation right)
        {
            this.left = left;
            this.op = op;
            this.right = right;
        }

        /// <summary>
        /// Returns the <see cref="Operand" /> of the current <see cref="BinaryOperation" />.
        /// </summary>
        /// <returns>The <see cref="Operand" /> of the current <see cref="BinaryOperation" />.</returns>
        internal override Operand Operand()
        {
            return this.op.Operate(this.left.Operand(), this.right.Operand());
        }
    }
}