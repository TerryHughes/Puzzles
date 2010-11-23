//-----------------------------------------------------------------------
// <copyright file="Runner.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.MathExpression
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using THughes.Puzzles.MathExpression.Operations;
    using THughes.Puzzles.MathExpression.Tokens;

    /// <summary>
    /// Runs things.
    /// </summary>
    internal static class Runner
    {
        /// <summary>
        /// Runs the thing.
        /// </summary>
        internal static void Run()
        {
            var five = new BinaryAddOperation(2, 3);
            Console.WriteLine(five.Operand() + " 5");
            var ten = new BinaryMultiplyOperation(five, 2);
            Console.WriteLine(ten.Operand() + " 10");

            var negativeFour = new UnarySubtractOperation(4);
            Console.WriteLine(negativeFour.Operand() + " -4");
            var four = new UnarySubtractOperation(negativeFour);
            Console.WriteLine(four.Operand() + " 4");

            Console.WriteLine();
            Console.WriteLine(new BinaryAddOperation(3, new BinaryMultiplyOperation(4, 5)).Operand() + " 23");
            Console.WriteLine(new BinaryMultiplyOperation(new BinaryAddOperation(2, 3), 4).Operand() + " 20");

            Console.WriteLine();

            // 2*3+(4-2)*2
            Console.WriteLine(new BinaryAddOperation(new BinaryMultiplyOperation(2, 3), new BinaryMultiplyOperation(new BinarySubtractOperation(4, 2), 2)).Operand() + " 10");

            // 2*(2*2)*2
            Console.WriteLine(new BinaryMultiplyOperation(new BinaryMultiplyOperation(2, new BinaryMultiplyOperation(2, 2)), 2).Operand() + " 16");

            // 1+(2+(3+4)+5)+6
            Console.WriteLine(new BinaryAddOperation(new BinaryAddOperation(1, new BinaryAddOperation(new BinaryAddOperation(2, new BinaryAddOperation(3, 4)), 5)), 6).Operand() + " 21");

            // 1+(2-(3+4)+5)+6
            Console.WriteLine(new BinaryAddOperation(new BinaryAddOperation(1, new BinaryAddOperation(new BinarySubtractOperation(2, new BinaryAddOperation(3, 4)), 5)), 6).Operand() + " 7");

            // 1+(2+(3+4)-5)+6
            Console.WriteLine(new BinaryAddOperation(new BinaryAddOperation(1, new BinarySubtractOperation(new BinaryAddOperation(2, new BinaryAddOperation(3, 4)), 5)), 6).Operand() + " 11");

            // ABCDEFGHIJKLMOP
            // 1+(2+(3+4)*5)+6
            //                    O                      B                  A      E                  D      K                           H                  G  I   L           P
            Console.WriteLine(new BinaryAddOperation(new BinaryAddOperation(1, new BinaryAddOperation(2, new BinaryMultiplyOperation(new BinaryAddOperation(3, 4), 5))), 6).Operand() + " 44");

            // ABCDEFGHIJKLMOP
            // 1+(2+(3+4)*5)+6
            //                    B                  A      O                      E                  D      K                           H                  G  I   L           P
            Console.WriteLine(new BinaryAddOperation(1, new BinaryAddOperation(new BinaryAddOperation(2, new BinaryMultiplyOperation(new BinaryAddOperation(3, 4), 5)), 6)).Operand() + " 44");

            Console.WriteLine();
            Console.WriteLine(Evaluator.Evaluate("2+3") + " 5");
            Console.WriteLine(Evaluator.Evaluate("2+3+5") + " 10");
            Console.WriteLine(Evaluator.Evaluate("2+3+5+10+10") + " 30");

            Console.WriteLine();
            foreach (var token in Tokenize("2+3"))
            {
                Console.WriteLine(token);
            }
        }

        /// <summary>
        /// Tokenizes a <see cref="String" />.
        /// </summary>
        /// <param name="value">The <see cref="String" /> to tokenize.</param>
        /// <returns>The <see cref="Token" />s that represent the <see cref="String" />.</returns>
        private static IEnumerable<Token> Tokenize(string value)
        {
            var temp = String.Empty;
            foreach (var c in value)
            {
                var token = Tokenize(c);
                if (token == null)
                {
                    temp += c;
                }
                else
                {
                    if (temp != String.Empty)
                    {
                        yield return new NumericToken(temp);
                        temp = String.Empty;
                    }

                    yield return token;
                }
            }

            if (temp != String.Empty)
            {
                yield return new NumericToken(temp);
            }
        }

        /// <summary>
        /// Tokenizes a <see cref="Char" />.
        /// </summary>
        /// <param name="value">The <see cref="Char" /> to tokenize.</param>
        /// <returns>The <see cref="Token" /> that represents the <see cref="Char" />.</returns>
        private static Token Tokenize(char value)
        {
            return OperatorToken.Tokens.FirstOrDefault(t => value.ToString() == t.Lexeme);
        }
    }
}