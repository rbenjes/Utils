using System;
using System.Collections.Generic;

namespace Utils
{
    public class LambdaEqualityComparer
    {
        public static LambdaEqualityComparer<T> Create<T>(Func<T, T, bool> comparer)
        {
            return new LambdaEqualityComparer<T>(comparer);
        }
    }
    public class LambdaEqualityComparer<T> : EqualityComparer<T>
    {
        Func<T, T, bool> comparer;
        public LambdaEqualityComparer(Func<T, T, bool> comparer)
        {
            this.comparer = comparer;
        }
        public override bool Equals(T x, T y)
        {
            return comparer(x, y);
        }

        public override int GetHashCode(T obj)
        {
            return 0;
        }
    }
}
