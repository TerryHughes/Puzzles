//-----------------------------------------------------------------------
// <copyright file="MultiplyOperator.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.MathExpression.Operators
{
    using THughes.Puzzles.MathExpression.Operations;

    /// <summary>
    /// Represents a multiple operator.
    /// </summary>
    internal class MultiplyOperator : Operator
    {
        /// <summary>
        /// Returns the result of the current <see cref="MultiplyOperator" />.
        /// </summary>
        /// <param name="a">The first <see cref="Operand" />.</param>
        /// <param name="b">The second <see cref="Operand" />.</param>
        /// <returns>The result of the current <see cref="MultiplyOperator" />.</returns>
        public Operand Operate(Operand a, Operand b)
        {
            return a * b;
        }
    }
}