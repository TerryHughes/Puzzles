//-----------------------------------------------------------------------
// <copyright file="Operation.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.MathExpression.Operations
{
    /// <summary>
    /// Represents an operation.
    /// </summary>
    internal abstract class Operation
    {
        /// <summary>
        /// Returns the <see cref="Operand" /> of the current <see cref="Operation" />.
        /// </summary>
        /// <returns>The <see cref="Operand" /> of the current <see cref="Operation" />.</returns>
        internal abstract Operand Operand();

        /// <summary>
        /// Joins two <see cref="Operation" />s together.
        /// </summary>
        /// <param name="operation">The other <see cref="Operation" /> to add to the current <see cref="Operation" />.</param>
        /// <returns>The joined <see cref="Operation" />s.</returns>
        internal Operation Add(Operation operation)
        {
            return new BinaryAddOperation(this, operation);
        }
    }
}