using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerableSample
{
    public static class IEnumerableExtension
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var x in source)
            {
                action(x);
            }
        }
    }
}
