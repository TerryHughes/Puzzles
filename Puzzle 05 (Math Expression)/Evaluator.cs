//-----------------------------------------------------------------------
// <copyright file="Evaluator.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.MathExpression
{
    using System;
    using System.Linq;
    using THughes.Puzzles.MathExpression.Operations;

    /// <summary>
    /// Evaluates things.
    /// </summary>
    public static class Evaluator
    {
        /// <summary>
        /// Evaluates the <paramref name="expr" /> into a <see cref="Double" /> value.
        /// </summary>
        /// <param name="expr">The <see cref="String" /> to evaluate.</param>
        /// <returns>The <paramref name="expr" /> as a <see cref="Double" />.</returns>
        public static double? Evaluate(string expr)
        {
            var multi = expr.Split('+').Select(Convert.ToDouble).ToList();

            Operation operation = new BinaryAddOperation(multi[0], multi[1]);
            for (var i = 2; i < multi.Count; i++)
            {
                operation = operation.Add(new UnaryAddOperation(multi[i]));
            }

            return Convert.ToDouble(operation.Operand().ToString());
        }
    }
}