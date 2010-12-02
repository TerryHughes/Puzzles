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
        It contains_one_token =()=> tokens.Count().ShouldEqual(1);
        It contains_a_single_token_for_I_that_equals_1 =()=>
        {
            Func<RomanNumeralToken, bool> predicate = t => t.Lexeme == "I";

            tokens.Count(predicate).ShouldEqual(1);
            tokens.First(predicate).NumericValue.ShouldEqual(1);
        };

// ReSharper restore InconsistentNaming
#pragma warning restore 169
    }
}