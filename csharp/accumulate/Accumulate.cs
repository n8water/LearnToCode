using System;
using System.Linq;
using System.Collections.Generic;

public static class AccumulateExtensions
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        Type type = collection.GetType();
        Type function = func.GetType();

        return 
    }


}