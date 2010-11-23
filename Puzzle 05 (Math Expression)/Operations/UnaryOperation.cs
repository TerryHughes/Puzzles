//-----------------------------------------------------------------------
// <copyright file="UnaryOperation.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.MathExpression.Operations
{
    using THughes.Puzzles.MathExpression.Operators;

    /// <summary>
    /// Represents an unary operation.
    /// </summary>
    internal class UnaryOperation : Operation
    {
        /// <summary>
        /// The <see cref="Operator" /> for the current <see cref="UnaryOperation" />.
        /// </summary>
        private readonly Operator op;

        /// <summary>
        /// The <see cref="Operation" /> for the current <see cref="UnaryOperation" />.
        /// </summary>
        private readonly Operation operation;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnaryOperation" /> class.
        /// </summary>
        /// <param name="op">The <see cref="Operator" /> for this <see cref="UnaryOperation" />.</param>
        /// <param name="value">The value for this <see cref="UnaryOperation" />.</param>
        internal UnaryOperation(Operator op, double value) : this(op, new OperandOperation(value))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnaryOperation" /> class.
        /// </summary>
        /// <param name="op">The <see cref="Operator" /> for this <see cref="UnaryOperation" />.</param>
        /// <param name="operation">The <see cref="Operation" /> for this <see cref="UnaryOperation" />.</param>
        internal UnaryOperation(Operator op, Operation operation)
        {
            this.op = op;
            this.operation = operation;
        }

        /// <summary>
        /// Returns the <see cref="Operand" /> of the current <see cref="UnaryOperation" />.
        /// </summary>
        /// <returns>The <see cref="Operand" /> of the current <see cref="UnaryOperation" />.</returns>
        internal override Operand Operand()
        {
            return this.op.Operate(new Operand(0), this.operation.Operand());
        }
    }
}