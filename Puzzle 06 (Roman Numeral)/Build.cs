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
    using System.Linq;

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

        internal static IEnumerable<Tuple<string, int>> OneToNine()
        {
            return BuildIncrement(OneToFour(), new Tuple<string, int>("V", 5));
        }

        internal static IEnumerable<Tuple<string, int>> OneToNineteen()
        {
            return BuildIncrement(OneToNine(), new Tuple<string, int>("X", 10));
        }

        internal static IEnumerable<Tuple<string, int>> OneToThirtyNine()
        {
            return BuildIncrement(OneToNineteen(), new Tuple<string, int>("XX", 20));
        }

        internal static IEnumerable<Tuple<string, int>> OneToFourtyNine()
        {
            return BuildIncrement(OneToThirtyNine(), new Tuple<string, int>("X", 10), false);
        }

        internal static IEnumerable<Tuple<string, int>> OneToNinetyNine()
        {
            return BuildIncrement(OneToFourtyNine(), new Tuple<string, int>("L", 50));
        }

        internal static IEnumerable<Tuple<string, int>> OneToOneHundredNinetyNine()
        {
            return BuildIncrement(OneToNinetyNine(), new Tuple<string, int>("C", 100));
        }

        internal static IEnumerable<Tuple<string, int>> OneToThreeHundredNinetyNine()
        {
            return BuildIncrement(OneToOneHundredNinetyNine(), new Tuple<string, int>("CC", 200));
        }

        internal static IEnumerable<Tuple<string, int>> OneToFourHundredNinetyNine()
        {
            return BuildIncrement(OneToThreeHundredNinetyNine(), new Tuple<string, int>("C", 100), false);
        }

        internal static IEnumerable<Tuple<string, int>> OneToNineHundredNinetyNine()
        {
            return BuildIncrement(OneToFourHundredNinetyNine(), new Tuple<string, int>("D", 500));
        }

        internal static IEnumerable<Tuple<string, int>> OneToOneThousandNineHundredNinetyNine()
        {
            return BuildIncrement(OneToNineHundredNinetyNine(), new Tuple<string, int>("M", 1000));
        }

        internal static IEnumerable<Tuple<string, int>> OneToTwoThousandNineHundredNinetyNine()
        {
            return BuildIncrement(OneToOneThousandNineHundredNinetyNine(), new Tuple<string, int>("M", 1000), false);
        }

        [SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1400:AccessModifierMustBeDeclared", Justification = "Reviewed. Suppression is OK here.")]
        static IEnumerable<Tuple<string, int>> BuildIncrement(IEnumerable<Tuple<string, int>> tuples, Tuple<string, int> increment, bool doIncrement = true)
        {
            foreach (var tuple in tuples)
            {
                yield return tuple;
            }

            if (doIncrement)
            {
                yield return increment;
            }

            foreach (var tuple in tuples.Reverse().Take(increment.Item2).Reverse())
            {
                yield return new Tuple<string, int>(increment.Item1 + tuple.Item1, increment.Item2 + tuple.Item2);
            }
        }
    }
}