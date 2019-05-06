using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata;

public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        return CheckPredicate(collection, predicate, "keep");
    }

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        return CheckPredicate(collection, predicate, "");
    }

    private static IEnumerable<T> CheckPredicate<T>(IEnumerable<T> collection, Func<T, bool> predicate, string callingMethod)
    {
        List<T> keep = new List<T>();
        List<T> discard = new List<T>();

        foreach (var item in collection)
        {
            if (predicate(item))
                keep.Add(item);
            else
                discard.Add(item);
        }

        if (callingMethod == "keep")
            return keep;
        else
            return discard;
    }


    //private static IEnumerable<T> GetCollection<T>(IEnumerable<T> collection, Func<T, bool> predicate)
    //{
    //    var predicateCollection = collection.Where()
    //}
}