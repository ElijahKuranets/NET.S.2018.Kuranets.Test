﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Test6.Solution
{
    public static class Generator<T>
    {
        public static IEnumerable<T> GenerateElements(Func<T, T, T> GenerateElem, T first, T second, int count)
        {
            yield return first;
            yield return second;
            for (int i = 2; i < count; i++)
            {
                T item = GenerateElem(first, second);
                yield return GenerateElem(first, second);
                first = second;
                second = item;
            }
        }
    }
}
