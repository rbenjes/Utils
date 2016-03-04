using System;

namespace Utils
{
    public static class ObjectExtensions
    {
        public static void TryExe<T>(this T source, Action<T> action) where T : class
        {
            if (source != null)
                action(source);
        }
        public static TResult TryEval<TResult, TSource>(this TSource source, Func<TSource, TResult> selector)
        {
            return TryEvalOrDefault(source, selector, () => default(TResult));
        }
        public static TResult TryEvalOrDefault<TResult, TSource>(this TSource source, Func<TSource, TResult> selector, Func<TResult> defaultSelector)
        {
            if (object.Equals(source, default(TSource)))
                return defaultSelector();
            return selector(source);
        }
    }
}
