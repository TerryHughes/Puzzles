//-----------------------------------------------------------------------
// <copyright file="ShapeSolver.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.Shape
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using THughes.Puzzles.Shape.Specifications;
    using THughes.Puzzles.Shape.Specifications.GridWalking;

    /// <summary>
    /// Solves shapes.
    /// </summary>
    public static class ShapeSolver
    {
        /// <summary>
        /// The triangluar grid.
        /// </summary>
        private static readonly IDictionary<int, int> Grid = new Dictionary<int, int>();

        /// <summary>
        /// A midpoint evaluator.
        /// </summary>
        private static readonly Func<IEnumerable<int>, double, bool> MidpointEvaluator = (l, w) => l.Sum(n => w - n) == 0;

        /// <summary>
        /// A matching evalutaor.
        /// </summary>
        private static readonly Func<int, Func<IEnumerable<int>, double, bool>> MatchingEvaluator = i => (l, w) => l.Skip(i).First() == w;

        /// <summary>
        /// The specifications.
        /// </summary>
        private static readonly IDictionary<PredicateSpecification<IList<int>>, string> Specifications = new Dictionary<PredicateSpecification<IList<int>>, string>
            {
                { new NullSpecification<IList<int>>(), "Invalid" },
                { new InvalidNumberOfNodesSpecification(), "Invalid" },
                { new HasDuplicatesSpecification(), "Invalid" },
                { new OutsideOfRangeSpecification(1, 500500), "Invalid" },
                { new PredicateSpecification<IList<int>>(Triangle), "Triangle" },
                { new PredicateSpecification<IList<int>>(Parallelogram), "Parallelogram" },
                { new PredicateSpecification<IList<int>>(Hexagon), "Hexagon" },
                { new AlwaysTrueSpecification<IList<int>>(), "Invalid" }
            };

        /// <summary>
        /// The triangle specifications.
        /// </summary>
        private static readonly IDictionary<PredicateSpecification<IList<int>>, Predicate<IList<int>>> TriangleSpecifications = new Dictionary<PredicateSpecification<IList<int>>, Predicate<IList<int>>>
            {
                { new PredicateSpecification<IList<int>>(l => l.Count != 3), l => false },
                { new PredicateSpecification<IList<int>>(l => l.Select(Row).Distinct().Count() != 2), l => false },
                { new AlwaysTrueSpecification<IList<int>>(), l =>
                    {
                        /*
                        verify that the point node is evenly between the others
                          *   * *
                         * *   *
                        */

                        var sorted = l.ToList();
                        sorted.Sort();

                        var dict = sorted.ToDictionary(n => n, Row);
                        var rows = dict.Values;

                        var pointRow = RowCounts(rows).First(p => p.Value == 1).Key;
                        var otherRow = rows.First(r => r != pointRow);
                        var rowDifference = pointRow - otherRow;

                        var point = dict.First(p => p.Value == pointRow).Key;
                        var walker = (double)point;

                        var executor = new Dictionary<PredicateSpecification<int>, PredicateSpecification<IList<int>>>
                            {
                                { new PredicateSpecification<int>(i => i < 0), new CompositePredicateSpecification<IList<int>>(
                                    new WalkDownTheGrid(pointRow, rowDifference, point, walker, 0.5, MidpointEvaluator),
                                    new WalkDownTheGrid(pointRow, rowDifference, point, walker, 1, MatchingEvaluator(1)))
                                    },
                                { new AlwaysTrueSpecification<int>(), new CompositePredicateSpecification<IList<int>>(
                                    new WalkUpTheGrid(pointRow, rowDifference, point, walker, 0.5, MidpointEvaluator),
                                    new WalkUpTheGrid(pointRow, rowDifference, point, walker, 1, MatchingEvaluator(0)))
                                    }
                            };

                        return executor.First(p => p.Key.IsSatisfiedBy(rowDifference)).Value.IsSatisfiedBy(sorted);
                    }
                    }
            };

        /// <summary>
        /// The parallelogram specifications.
        /// </summary>
        private static readonly IDictionary<PredicateSpecification<IList<int>>, Predicate<IList<int>>> ParallelogramSpecifications = new Dictionary<PredicateSpecification<IList<int>>, Predicate<IList<int>>>
            {
                { new PredicateSpecification<IList<int>>(l => l.Select(Row).Distinct().Count() == 2), l =>
                    {
                        var doer = new Dictionary<PredicateSpecification<IList<int>>, bool>
                            {
                                { new PredicateSpecification<IList<int>>(n => RowCounts(n.Select(Row)).Any(p => p.Value != 2)), false },
                                { new PredicateSpecification<IList<int>>(n =>
                                    {
                                        /*
                                        verify that the bottom two are shifted equally from the top two
                                         * *    * *
                                          * *  * *
                                        */

                                        var sorted = n.ToList();
                                        sorted.Sort();

                                        return false;
                                    }), true },
                                { new AlwaysTrueSpecification<IList<int>>(), false }
                            };

                        return doer.First(p => p.Key.IsSatisfiedBy(l)).Value;
                    }
                    },
                { new PredicateSpecification<IList<int>>(l => l.Select(Row).Distinct().Count() == 3), l =>
                    {
                        var doer = new Dictionary<PredicateSpecification<IList<int>>, bool>
                            {
                                { new PredicateSpecification<IList<int>>(n =>
                                    {
                                        var rowCounts = RowCounts(n.Select(Row)).Values;
                                        var topDoesNotHaveOne = rowCounts.First() != 1;
                                        var middleDoesNotHaveTwo = rowCounts.Skip(1).First() != 2;
                                        var bottomDoesNotHaveOne = rowCounts.Last() != 1;

                                        return topDoesNotHaveOne || middleDoesNotHaveTwo || bottomDoesNotHaveOne;
                                    }), false },
                                { new PredicateSpecification<IList<int>>(n =>
                                    {
                                        /*
                                        verify that the top and bottom are aligned and the middle are evenly outside
                                          *
                                         * *
                                          *
                                        */

                                        var sorted = n.ToList();
                                        sorted.Sort();

                                        return false;
                                    }), true },
                                { new AlwaysTrueSpecification<IList<int>>(), false }
                            };

                        return doer.First(p => p.Key.IsSatisfiedBy(l)).Value;
                    }
                    },
                { new AlwaysTrueSpecification<IList<int>>(), l => false }
            };

        /// <summary>
        /// The hexagon specifications.
        /// </summary>
        private static readonly IDictionary<PredicateSpecification<IList<int>>, Predicate<IList<int>>> HexagonSpecifications = new Dictionary<PredicateSpecification<IList<int>>, Predicate<IList<int>>>
            {
                { new PredicateSpecification<IList<int>>(l => l.Select(Row).Distinct().Count() != 3), l => false },
                { new PredicateSpecification<IList<int>>(l => RowCounts(l.Select(Row)).Any(p => p.Value != 2)), l => false },
                { new AlwaysTrueSpecification<IList<int>>(), l =>
                    {
                        /*
                        verify top and bottom nodes are aligned and that the middle nodes are evenly outside the others
                          * *
                         *   *
                          * *
                        */

                        var sorted = l.ToList();
                        sorted.Sort();

                        var rowCounts = RowCounts(sorted.Select(Row));
                        var topRow = rowCounts.First().Key;
                        var middleRow = rowCounts.Skip(1).First().Key;
                        var bottomRow = rowCounts.Last().Key;
                        var rowDifferenceToMiddleFromTop = topRow - middleRow;
                        var rowDifferenceToMiddleFromBottom = bottomRow - middleRow;
                        var rowDifferenceToBottom = topRow - bottomRow;

                        Func<int, bool> isAligned = i =>
                            {
                                var point = sorted[i];
                                var walker = (double)point;
                                return new WalkDownTheGrid(topRow, rowDifferenceToBottom, point, walker, 0.5, MatchingEvaluator(i + 3)).IsSatisfiedBy(sorted);
                            };
                        var firstIsAlignedWithFifth = isAligned(0);
                        var secondIsAlignedWithSixth = isAligned(1);

                        Func<int, double> walkDown = p =>
                            {
                                var walker = (double)sorted[p];
                                for (var i = topRow + 0; i < topRow - rowDifferenceToMiddleFromTop; i++)
                                {
                                    walker += i + 0.5;
                                }

                                return sorted[p + 2] - walker;
                            };
                        var distanceBetweenFirstAndThird = walkDown(0);
                        var distanceBetweenSecondAndFourth = walkDown(1);
                        var middleIsEvenlyOutside = distanceBetweenFirstAndThird + distanceBetweenSecondAndFourth == 0;

                        var counter = 0;
                        Func<int, double> walkUp = p =>
                            {
                                var walker = (double)sorted[p];
                                for (var i = bottomRow - 1; i >= bottomRow - rowDifferenceToMiddleFromBottom; i--)
                                {
                                    walker -= i + 0.5;
                                    counter++;
                                }

                                return walker - sorted[p - 2];
                            };

                        var distanceBetweenFifthAndThird = walkUp(4);
                        var sameDistanceToMiddle = Math.Abs(distanceBetweenFirstAndThird) == Math.Abs(distanceBetweenFifthAndThird);

                        var sameDistanceBetweenNodes = sorted[1] - sorted[0] == counter;

                        return firstIsAlignedWithFifth && secondIsAlignedWithSixth && middleIsEvenlyOutside && sameDistanceToMiddle && sameDistanceBetweenNodes;
                    }
                    }
            };

        /// <summary>
        /// Initializes static members of the <see cref="ShapeSolver" /> class.
        /// </summary>
        static ShapeSolver()
        {
            for (int node = 0, row = 1; node <= 500500; row++)
            {
                node += row;
                Grid.Add(node, row);
            }
        }

        /// <summary>
        /// Determines what shape the nodes form.
        /// </summary>
        /// <param name="nodes">The nodes that may form a shape.</param>
        /// <returns>The shape the nodes form.</returns>
        public static string Solve(IList<int> nodes)
        {
            return Specifications.First(p => p.Key.IsSatisfiedBy(nodes)).Value;
        }

        /// <summary>
        /// Determines what row a point is on.
        /// </summary>
        /// <param name="value">The point to determine.</param>
        /// <returns>The row the point is on.</returns>
        private static int Row(int value)
        {
            return Grid.First(p => value <= p.Key).Value;
        }

        /// <summary>
        /// Calculates the number of points on each row.
        /// </summary>
        /// <param name="rows">The rows of the points.</param>
        /// <returns>The number of points on each row.</returns>
        private static IDictionary<int, int> RowCounts(IEnumerable<int> rows)
        {
            var rowCounts = rows.Distinct().ToDictionary(r => r, r => 0);
            foreach (var row in rows)
            {
                rowCounts[row]++;
            }

            return rowCounts;
        }

        /// <summary>
        /// Determines if the nodes form a triangle.
        /// </summary>
        /// <param name="nodes">The nodes that may form a triangle.</param>
        /// <returns>true if the nodes form a triangle; otherwise, false.</returns>
        private static bool Triangle(IList<int> nodes)
        {
            return TriangleSpecifications.First(p => p.Key.IsSatisfiedBy(nodes)).Value(nodes);
        }

        /// <summary>
        /// Determines if the nodes form a parallelogram.
        /// </summary>
        /// <param name="nodes">The nodes that may form a parallelogram.</param>
        /// <returns>true if the nodes form a parallelogram; otherwise, false.</returns>
        private static bool Parallelogram(IList<int> nodes)
        {
            return ParallelogramSpecifications.First(p => p.Key.IsSatisfiedBy(nodes)).Value(nodes);
        }

        /// <summary>
        /// Determines if the nodes form a hexagon.
        /// </summary>
        /// <param name="nodes">THe nodes that may form a hexagon.</param>
        /// <returns>true if the nodes form a hexagon; otherwise, false.</returns>
        private static bool Hexagon(IList<int> nodes)
        {
            return HexagonSpecifications.First(p => p.Key.IsSatisfiedBy(nodes)).Value(nodes);
        }
    }
}