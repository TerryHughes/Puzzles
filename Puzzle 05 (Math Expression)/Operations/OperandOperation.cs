//-----------------------------------------------------------------------
// <copyright file="OperandOperation.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.MathExpression.Operations
{
    /// <summary>
    /// Represents an operand operation.
    /// </summary>
    internal class OperandOperation : Operation
    {
        /// <summary>
        /// The <see cref="Operand" /> of the current <see cref="OperandOperation" />.
        /// </summary>
        private readonly Operand operand;

        /// <summary>
        /// Initializes a new instance of the <see cref="OperandOperation" /> class.
        /// </summary>
        /// <param name="value">The value for this <see cref="OperandOperation" />.</param>
        internal OperandOperation(double value) : this(new Operand(value))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperandOperation" /> class.
        /// </summary>
        /// <param name="operand">The <see cref="Operand" /> for this <see cref="OperandOperation" />.</param>
        internal OperandOperation(Operand operand)
        {
            this.operand = operand;
        }

        /// <summary>
        /// Returns the <see cref="Operand" /> of the current <see cref="OperandOperation" />.
        /// </summary>
        /// <returns>The <see cref="Operand" /> of the current <see cref="OperandOperation" />.</returns>
        internal override Operand Operand()
        {
            return this.operand;
        }
    }
}