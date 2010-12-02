//-----------------------------------------------------------------------
// <copyright file="Build.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.RomanNumeral
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    [SuppressMessage("Microsoft.StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Reviewed. Suppression is OK here.")]
    internal static class Build
    {
        internal static IEnumerable<Tuple<string, int>> IndividualValues()
        {
            yield return new Tuple<string, int>("I", 1);
            yield return new Tuple<string, int>("V", 5);
            yield return new Tuple<string, int>("X", 10);
            yield return new Tuple<string, int>("L", 50);
            yield return new Tuple<string, int>("C", 100);
            yield return new Tuple<string, int>("D", 500);
            yield return new Tuple<string, int>("M", 1000);
        }

        internal static IEnumerable<Tuple<string, int>> OneToFour()
        {
            var roman = String.Empty;

            for (var i = 1; i < 5; i++)
            {
                yield return new Tuple<string, int>(roman += "I", i);
            }
        }
    }
}