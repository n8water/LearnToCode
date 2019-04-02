using System;
using System.Linq;
using System.Collections.Generic;

public static class AccumulateExtensions
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        var type = collection.GetType();
        var function = func.GetType();
        IEnumerable<U> bla =  collection.Where(x => x != null);

        return IEnumerable<U> bla;
    }

    

}

public static class Extension()
    {
        public static void IEnumerable<>
    }