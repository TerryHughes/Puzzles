//-----------------------------------------------------------------------
// <copyright file="EvaluatorSpecifications.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.RomanNumeral
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using Machine.Specifications;

    [SuppressMessage("Microsoft.StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1400:AccessModifierMustBeDeclared", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("Microsoft.StyleCop.CSharp.NamingRules", "SA1310:FieldNamesMustNotContainUnderscore", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("Microsoft.StyleCop.CSharp.SpacingRules", "SA1003:SymbolsMustBeSpacedCorrectly", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("Microsoft.StyleCop.CSharp.SpacingRules", "SA1009:ClosingParenthesisMustBeSpacedCorrectly", Justification = "Reviewed. Suppression is OK here.")]
    public class EvaluatorSpecifications
    {
#pragma warning disable 169
// ReSharper disable InconsistentNaming
        It can_evaluate_each_roman_numeral_individually =()=> Verify(Build.IndividualValues());
        It can_evaluate_roman_numerals_that_are_in_order =()=> Verify(Build.OneToThreeThousand());

// ReSharper restore InconsistentNaming
#pragma warning restore 169

        static void Verify(IEnumerable<Tuple<string, int>> tuples)
        {
            foreach (var tuple in tuples)
            {
                Evaluator.Evaluate(tuple.Item1).ShouldEqual(tuple.Item2);
            }
        }
    }
}