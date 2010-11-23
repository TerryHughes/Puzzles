//-----------------------------------------------------------------------
// <copyright file="SubtractOperator.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.MathExpression.Operators
{
    using THughes.Puzzles.MathExpression.Operations;

    /// <summary>
    /// Represents a subtract operator.
    /// </summary>
    internal class SubtractOperator : Operator
    {
        /// <summary>
        /// Returns the result of the current <see cref="SubtractOperator" />.
        /// </summary>
        /// <param name="a">The first <see cref="Operand" />.</param>
        /// <param name="b">The second <see cref="Operand" />.</param>
        /// <returns>The result of the current <see cref="SubtractOperator" />.</returns>
        public Operand Operate(Operand a, Operand b)
        {
            return a - b;
        }
    }
}