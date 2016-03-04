using System;

namespace Utils
{
    public static class ObjectExtensions
    {
        public static void DoWith<T>(this T source, Action<T> action) where T : class
        {
            if (source != null)
                action(source);
        }
        public static TResult EvaluateIfNotNull<TResult, TSource>(this TSource source, Func<TSource, TResult> selector)
        {
            return EvaluateOrDefault(source, selector, () => default(TResult));
        }
        public static TResult EvaluateOrDefault<TResult, TSource>(this TSource source, Func<TSource, TResult> selector, Func<TResult> defaultSelector)
        {
            if (object.Equals(source, default(TSource)))
                return defaultSelector();
            return selector(source);
        }
    }
}
