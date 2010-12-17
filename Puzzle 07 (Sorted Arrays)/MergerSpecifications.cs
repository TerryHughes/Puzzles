//----------------------------------------------------------------------
// <copyright file="MergerSpecifications.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.SortedArrays
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using Machine.Specifications;

// ReSharper disable InconsistentNaming
    [SuppressMessage("Microsoft.StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1400:AccessModifierMustBeDeclared", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("Microsoft.StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("Microsoft.StyleCop.CSharp.NamingRules", "SA1310:FieldNamesMustNotContainUnderscore", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("Microsoft.StyleCop.CSharp.SpacingRules", "SA1003:SymbolsMustBeSpacedCorrectly", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("Microsoft.StyleCop.CSharp.SpacingRules", "SA1009:ClosingParenthesisMustBeSpacedCorrectly", Justification = "Reviewed. Suppression is OK here.")]
    public class when_one_through_nine_is_divided_into_two_arrays
    {
        static readonly int[] array = Enumerable.Range(1, 9).ToArray();
        static readonly int[] odd = array.Where(i => i % 2 == 1).ToArray();
        static readonly int[] even = array.Where(i => i % 2 == 0).ToArray();
        static int[] result;

#pragma warning disable 169
        Because of =()=> result = Merger.Merge(new[] { odd, even });

        It sorts_the_elements_in_the_array =()=> result.SequenceEqual(array).ShouldBeTrue();
#pragma warning restore 169
    }

    [SuppressMessage("Microsoft.StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1400:AccessModifierMustBeDeclared", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("Microsoft.StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("Microsoft.StyleCop.CSharp.NamingRules", "SA1310:FieldNamesMustNotContainUnderscore", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("Microsoft.StyleCop.CSharp.SpacingRules", "SA1003:SymbolsMustBeSpacedCorrectly", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("Microsoft.StyleCop.CSharp.SpacingRules", "SA1009:ClosingParenthesisMustBeSpacedCorrectly", Justification = "Reviewed. Suppression is OK here.")]
    public class when_one_through_nine_is_divided_into_nine_arrays
    {
        static readonly int[] array = Enumerable.Range(1, 9).ToArray();
        static int[] result;

#pragma warning disable 169
        Because of =()=>
        {
            var arrays = new List<int[]>();
            for (var i = 0; i < array.Length; i++)
            {
                arrays.Add(array.Skip(i).Take(1).ToArray());
            }

            result = Merger.Merge(arrays);
        };

        It sorts_the_elements_in_the_array =()=> result.SequenceEqual(array).ShouldBeTrue();
#pragma warning restore 169
    }

// ReSharper restore InconsistentNaming
}