//-----------------------------------------------------------------------
// <copyright file="RomanNumeralTokenSpecifications.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.RomanNumeral
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using Machine.Specifications;

    [SuppressMessage("Microsoft.StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1400:AccessModifierMustBeDeclared", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("Microsoft.StyleCop.CSharp.NamingRules", "SA1310:FieldNamesMustNotContainUnderscore", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("Microsoft.StyleCop.CSharp.SpacingRules", "SA1003:SymbolsMustBeSpacedCorrectly", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("Microsoft.StyleCop.CSharp.SpacingRules", "SA1009:ClosingParenthesisMustBeSpacedCorrectly", Justification = "Reviewed. Suppression is OK here.")]
    public class RomanNumeralTokenSpecifications
    {
        static IEnumerable<RomanNumeralToken> tokens;

#pragma warning disable 169
        Because of =()=> tokens = RomanNumeralToken.Tokens;

// ReSharper disable InconsistentNaming
        It contains_five_tokens =()=> tokens.Count().ShouldEqual(5);
        It contains_a_single_token_for_I_that_equals_1 =()=> Verify("I", 1);
        It contains_a_single_token_for_V_that_equals_5 =()=> Verify("V", 5);
        It contains_a_single_token_for_X_that_equals_10 =()=> Verify("X", 10);
        It contains_a_single_token_for_L_that_equals_50 =()=> Verify("L", 50);
        It contains_a_single_token_for_C_that_equals_100 =()=> Verify("C", 100);

// ReSharper restore InconsistentNaming
#pragma warning restore 169

        static void Verify(string lexeme, int numericValue)
        {
            Func<RomanNumeralToken, bool> predicate = t => t.Lexeme == lexeme;

            tokens.Count(predicate).ShouldEqual(1);
            tokens.First(predicate).NumericValue.ShouldEqual(numericValue);
        }
    }
}