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
        It contains_zero_tokens =()=> tokens.Count().ShouldEqual(0);

// ReSharper restore InconsistentNaming
#pragma warning restore 169
    }
}