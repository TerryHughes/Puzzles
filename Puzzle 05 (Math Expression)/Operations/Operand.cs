//-----------------------------------------------------------------------
// <copyright file="Operand.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.MathExpression.Operations
{
    using System;

    /// <summary>
    /// Represents an operand.
    /// </summary>
    internal class Operand
    {
        /// <summary>
        /// The value of the <see cref="Operand" />.
        /// </summary>
        private readonly double value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Operand" /> class.
        /// </summary>
        /// <param name="value">The value of the <see cref="Operand" />.</param>
        internal Operand(double value)
        {
            this.value = value;
        }

        /// <summary>
        /// Adds two specified <see cref="Operand" />s.
        /// </summary>
        /// <param name="a">The first <see cref="Operand" /> to add.</param>
        /// <param name="b">The second <see cref="Operand" /> to add.</param>
        /// <returns>The result of adding <paramref name="a" /> and <paramref name="b" />.</returns>
        public static Operand operator +(Operand a, Operand b)
        {
            return new Operand(a.value + b.value);
        }

        /// <summary>
        /// Subtracts two specified <see cref="Operand" />s.
        /// </summary>
        /// <param name="a">The minuend.</param>
        /// <param name="b">The subtrahend.</param>
        /// <returns>The result of subtracting <paramref name="b" /> from <paramref name="a" />.</returns>
        public static Operand operator -(Operand a, Operand b)
        {
            return new Operand(a.value - b.value);
        }

        /// <summary>
        /// Multiplies two specified <see cref="Operand" />s.
        /// </summary>
        /// <param name="a">The first <see cref="Operand" /> to multiply.</param>
        /// <param name="b">The second <see cref="Operand" /> to multiply.</param>
        /// <returns>The result of multiplying <paramref name="a" /> and <paramref name="b" />.</returns>
        public static Operand operator *(Operand a, Operand b)
        {
            return new Operand(a.value * b.value);
        }

        /// <summary>
        /// Divides two specified <see cref="Operand" />s.
        /// </summary>
        /// <param name="a">The dividend.</param>
        /// <param name="b">The divisor.</param>
        /// <returns>The result of dividing <paramref name="a" /> by <paramref name="b" />.</returns>
        public static Operand operator /(Operand a, Operand b)
        {
            return new Operand(a.value / b.value);
        }

        /// <summary>
        /// Returns a <see cref="String" /> that represents the current <see cref="Operand" />.
        /// </summary>
        /// <returns>A <see cref="String" /> that represents the current <see cref="Operand" />.</returns>
        public override string ToString()
        {
            return this.value.ToString();
        }
    }
}