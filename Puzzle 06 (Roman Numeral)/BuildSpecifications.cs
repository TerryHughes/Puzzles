//-----------------------------------------------------------------------
// <copyright file="BuildSpecifications.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.RomanNumeral
{
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using Machine.Specifications;

    [SuppressMessage("Microsoft.StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1400:AccessModifierMustBeDeclared", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("Microsoft.StyleCop.CSharp.NamingRules", "SA1310:FieldNamesMustNotContainUnderscore", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("Microsoft.StyleCop.CSharp.SpacingRules", "SA1003:SymbolsMustBeSpacedCorrectly", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("Microsoft.StyleCop.CSharp.SpacingRules", "SA1009:ClosingParenthesisMustBeSpacedCorrectly", Justification = "Reviewed. Suppression is OK here.")]
    public class BuildSpecifications
    {
#pragma warning disable 169
// ReSharper disable InconsistentNaming
        It can_build_individual_values =()=>
        {
            var tuples = Build.IndividualValues().ToList();

            tuples.Count.ShouldEqual(7);
            tuples[0].Item1.ShouldEqual("I");
            tuples[0].Item2.ShouldEqual(1);
            tuples[1].Item1.ShouldEqual("V");
            tuples[1].Item2.ShouldEqual(5);
            tuples[2].Item1.ShouldEqual("X");
            tuples[2].Item2.ShouldEqual(10);
            tuples[3].Item1.ShouldEqual("L");
            tuples[3].Item2.ShouldEqual(50);
            tuples[4].Item1.ShouldEqual("C");
            tuples[4].Item2.ShouldEqual(100);
            tuples[5].Item1.ShouldEqual("D");
            tuples[5].Item2.ShouldEqual(500);
            tuples[6].Item1.ShouldEqual("M");
            tuples[6].Item2.ShouldEqual(1000);
        };

// ReSharper restore InconsistentNaming
#pragma warning restore 169
    }
}