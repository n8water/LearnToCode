using System;
using System.Collections.Generic;
using System.Linq;

public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        int[][] result = new int[rows][];
        var rowNumbers = new List<int>();

        if (rows <= 0)
           return result;

        for (int n = 0; n < rows; n++)
        {
            rowNumbers.Clear();

            if (n == 0)
            {
                rowNumbers.Add(1);
            }
            else
            {
                int previousRow = n - 1;
                int columns = n + 1;

                foreach (int k in Enumerable.Range(0, columns))
                {
                    if (k - 1 < 0 || k > previousRow)
                        rowNumbers.Add(1);
                    else
                        rowNumbers.Add(result[previousRow][k] + result[previousRow][k - 1]);
                }
            }
            result[n] = rowNumbers.ToArray();
        }
        return result;
    }
}
