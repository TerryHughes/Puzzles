//-----------------------------------------------------------------------
// <copyright file="BuildSpecifications.cs" company="THughes">
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

        It can_build_values_one_to_four =()=> Verify(Build.OneToFour(), "IIII", 4);
        It can_build_values_one_to_nine =()=> Verify(Build.OneToNine(), "VIIII", 9);
        It can_build_values_one_to_nineteen =()=> Verify(Build.OneToNineteen(), "XVIIII", 19);
        It can_build_values_one_to_thirty_nine =()=> Verify(Build.OneToThirtyNine(), "XXXVIIII", 39);
        It can_build_values_one_to_fourty_nine =()=> Verify(Build.OneToFourtyNine(), "XXXXVIIII", 49);
        It can_build_values_one_to_ninety_nine =()=> Verify(Build.OneToNinetyNine(), "LXXXXVIIII", 99);
        It can_build_values_one_to_one_hundred_ninety_nine =()=> Verify(Build.OneToOneHundredNinetyNine(), "CLXXXXVIIII", 199);
        It can_build_values_one_to_three_hundred_ninety_nine =()=> Verify(Build.OneToThreeHundredNinetyNine(), "CCCLXXXXVIIII", 399);
        It can_build_values_one_to_four_hundred_ninety_nine =()=> Verify(Build.OneToFourHundredNinetyNine(), "CCCCLXXXXVIIII", 499);
        It can_build_values_one_to_nine_hundred_ninety_nine =()=> Verify(Build.OneToNineHundredNinetyNine(), "DCCCCLXXXXVIIII", 999);
        It can_build_values_one_to_one_thousand_nine_hundred_ninety_nine =()=> Verify(Build.OneToOneThousandNineHundredNinetyNine(), "MDCCCCLXXXXVIIII", 1999);
        It can_build_values_one_to_two_thousand_nine_hundred_ninety_nine =()=> Verify(Build.OneToTwoThousandNineHundredNinetyNine(), "MMDCCCCLXXXXVIIII", 2999);
        It can_build_values_one_to_three_thousand =()=> Verify(Build.OneToThreeThousand(), "MMM", 3000);

// ReSharper restore InconsistentNaming
#pragma warning restore 169

        static void Verify(IEnumerable<Tuple<string, int>> tuples, string item1, int item2)
        {
            tuples.Count().ShouldEqual(item2);
            tuples.First().Item1.ShouldEqual("I");
            tuples.First().Item2.ShouldEqual(1);
            tuples.Last().Item1.ShouldEqual(item1);
            tuples.Last().Item2.ShouldEqual(item2);
        }
    }
}