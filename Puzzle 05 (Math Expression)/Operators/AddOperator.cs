//-----------------------------------------------------------------------
// <copyright file="AddOperator.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.MathExpression.Operators
{
    using THughes.Puzzles.MathExpression.Operations;

    /// <summary>
    /// Represents an add operator.
    /// </summary>
    internal class AddOperator : Operator
    {
        /// <summary>
        /// Returns the result of the current <see cref="AddOperator" />.
        /// </summary>
        /// <param name="a">The first <see cref="Operand" />.</param>
        /// <param name="b">The second <see cref="Operand" />.</param>
        /// <returns>The result of the current <see cref="AddOperator" />.</returns>
        public Operand Operate(Operand a, Operand b)
        {
            return a + b;
        }
    }
}