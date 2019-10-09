using System;
using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        int c = sum;
        var result = new List<(int a, int b, int c)>();

        for (int a = 0; a < sum / 3; a++)
        {
            for (int b = a + 1; b < sum / 2; b++)
            {
                c = sum - a - b;

                if ((c > b) && (a * a + b * b == c * c))
                    result.Add((a, b, c));                
            }
        }

        // My first try, I oversaw the simpler way

        //for (int ia = a; ia < sum / 3; ia++)
        //{
        //    for (int ib = ia + 1; ib < b; ib++)
        //    {
        //        for (int ic = ib + 1; ic < c; ic++)
        //        {
        //            if (ia + ib + ic == sum && (ia * ia + ib * ib == ic * ic))
        //            {
        //                result.Add((ia, ib, ic));
        //                a = ia;
        //                b = ib;
        //                c = ic;
        //            }

        //        }
        //    }
        //}

        return result;
    }
}