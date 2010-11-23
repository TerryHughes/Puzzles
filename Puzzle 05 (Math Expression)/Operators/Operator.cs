//-----------------------------------------------------------------------
// <copyright file="Operator.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.MathExpression.Operators
{
    using THughes.Puzzles.MathExpression.Operations;

    /// <summary>
    /// Represents an operator.
    /// </summary>
    internal interface Operator
    {
        /// <summary>
        /// Returns the result of the current <see cref="Operator" />.
        /// </summary>
        /// <param name="a">The first <see cref="Operand" />.</param>
        /// <param name="b">The second <see cref="Operand" />.</param>
        /// <returns>The result of the current <see cref="Operator" />.</returns>
        Operand Operate(Operand a, Operand b);
    }
}