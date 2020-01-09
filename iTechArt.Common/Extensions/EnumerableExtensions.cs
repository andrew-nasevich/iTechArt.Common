using System;
using System.Collections.Generic;

namespace TicTacToe.Common.Extensions
{
    public static class EnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T, int> action)
        {
            var index = 0;
            foreach (var el in collection)
            {
                action(el, index++);
            }
        }

        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var el in collection)
            {
                action(el);
            }
        }
    }
}