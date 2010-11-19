//-----------------------------------------------------------------------
// <copyright file="Finder.cs" company="THughes">
//     Copyright (c) THughes. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace THughes.Puzzles.MissingNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Finds various things.
    /// </summary>
    public static class Finder
    {
        /// <summary>
        /// Determines what numbers, if any, are missing from the array.
        /// </summary>
        /// <param name="array">An array of numbers.</param>
        /// <param name="size">The size that the sequence should be.</param>
        /// <returns>The missing numbers, if any.</returns>
        public static IEnumerable<int> GetMissingNumbers(int[] array, int size)
        {
            ////return ThisIsHowAwesomeLinqIs(array, size);
            return TerrysImplementation(array, size);
            ////return JohnsWickedFastSolution(array, size);
            ////return InPlaceSwapThanksToGoogle(array, size);
        }

        /// <summary>
        /// Sorts an array of <see cref="Int32" />.
        /// </summary>
        /// <param name="array">An unsorted array.</param>
        /// <returns>A sorted list.</returns>
        internal static IList<int> RadixSort(int[] array)
        {
            var queues = new[]
                {
                    new Queue<int>(), new Queue<int>(), new Queue<int>(), new Queue<int>(), new Queue<int>(),
                    new Queue<int>(), new Queue<int>(), new Queue<int>(), new Queue<int>(), new Queue<int>()
                };

            var list = array.ToList();

            foreach (var powerOfTen in new[] { 1, 10, 100, 1000, 10000, 100000, 1000000, 10000000 })
            {
                foreach (var item in list)
                {
                    queues[(item / powerOfTen) % 10].Enqueue(item);
                }

                list.Clear();

                foreach (var queue in queues)
                {
                    while (queue.Count > 0)
                    {
                        list.Add(queue.Dequeue());
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// Determines what numbers, if any, are missing from the array.
        /// </summary>
        /// <param name="array">An array of numbers.</param>
        /// <param name="size">The size that the sequence should be.</param>
        /// <returns>The missing numbers, if any.</returns>
        private static IEnumerable<int> ThisIsHowAwesomeLinqIs(int[] array, int size)
        {
            return Enumerable.Range(1, size).Except(array);
        }

        /// <summary>
        /// Determines what numbers, if any, are missing from the array.
        /// </summary>
        /// <param name="array">An array of numbers.</param>
        /// <param name="size">The size that the sequence should be.</param>
        /// <returns>The missing numbers, if any.</returns>
        private static IEnumerable<int> TerrysImplementation(int[] array, int size)
        {
            /*
            var ints = array.ToList();
            ints.Sort();
            */
            var ints = RadixSort(array);
            var index = 0;

            for (var i = 1; i < size + 1; i++)
            {
                while ((index < ints.Count) && (ints[index] < i))
                {
                    index++;
                }

                if ((index == ints.Count) || ((index < ints.Count) && (ints[index] > i)))
                {
                    yield return i;
                }
            }
        }

        /// <summary>
        /// Determines what numbers, if any, are missing from the array.
        /// </summary>
        /// <param name="array">An array of numbers.</param>
        /// <param name="size">The size that the sequence should be.</param>
        /// <returns>The missing numbers, if any.</returns>
        private static IEnumerable<int> JohnsWickedFastSolution(int[] array, int size)
        {
            /*
            var list = array.ToList();
            for (var i = list.Count; i < size; i++)
            {
                list.Add(0);
            }
            */
            var found = new bool[size + 1];

            foreach (var item in array)
            {
                found[item] = true;
            }

            for (var i = 1; i < found.Length; i++)
            {
                if (!found[i])
                {
                    yield return i;
                }
            }
        }

        /// <summary>
        /// Determines what numbers, if any, are missing from the array.
        /// </summary>
        /// <param name="array">An array of numbers.</param>
        /// <param name="size">The size that the sequence should be.</param>
        /// <returns>The missing numbers, if any.</returns>
        private static IEnumerable<int> InPlaceSwapThanksToGoogle(int[] array, int size)
        {
            var list = array.ToList();
            for (var i = list.Count; i < size; i++)
            {
                list.Add(0);
            }

            for (var i = 0; i < size; i++)
            {
                while (list[i] != i + 1)
                {
                    if (list[i] < 1 || list[i] > size || list[i] == list[list[i] - 1])
                    {
                        list[i] = -1;
                        break;
                    }

                    var temp = list[list[i] - 1];
                    list[list[i] - 1] = list[i];
                    list[i] = temp;
                }
            }

            for (var i = 0; i < size; i++)
            {
                if (list[i] < 0)
                {
                    yield return i + 1;
                }
            }
        }
    }
}