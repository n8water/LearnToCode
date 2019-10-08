using System;
using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        int a = 1;
        int b = sum;
        int c = sum;
        int sumAbc;
        var result = new List<(int a, int b, int c)>();

        for (int ia = a; ia < sum / 3; ia++)
        {
            for (int ib = ia + 1; ib <b; ib++)
            {
                for (int ic = ib + 1; ic < c; ic++)
                {
                    if (ia + ib + ic == sum && (ia * ia + ib * ib == ic * ic))
                    {
                        result.Add((ia, ib, ic));
                        a = ia;
                        b = ib;
                        c = ic;
                    }

                }
            }
        }

        //for (int ia = sum / 25; ia < sum / 3; ia++)
        //{
        //    for (int ib = ia + 1; ib < sum / 2; ib++)
        //    {
        //        for (int ic = ib + 1; ic < sum / 2; ic++)
        //        {
        //            if (ia + ib + ic == sum && (ia * ia + ib * ib == ic * ic))
        //            {
        //                result.Add((ia, ib, ic));
        //            }

        //        }
        //    }
        //}

        return result;
        //return new List<(int a, int b, int c)>();
    }
}