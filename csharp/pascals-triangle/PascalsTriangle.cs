using System;
using System.Collections.Generic;
using System.Linq;

public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        int[][] result = new int[rows][];

        int test = result.Length;

        if (rows <= 0)
           return result;

        for (int n = 0; n < rows; n++)
            if (n == 0)
            {
                int number = n + 1 ;
                result[0] = new int[number] { 1 };
            }
            else if (n == 1)
                result[n] = new int[2] { n, n };

        //var result = new int[0];

        //if (rows <= 0)
        //    yield return int[0];

        //for (int n = 0; n < rows; n++)
        //    if (n == 0)
        //        result.Add(new int[n]);
        //    //for(int k = 0; k <= n; k++)






        //result.Add(new List<int>());

        return result;
        //throw new NotImplementedException();
    }

}

/* Notizen
Pascalsches Dreieck

    \binom{n+1}{k+1} = \binom{n}{k} + \binom{n}{k+1}

Dabei kann die Variable n als Zeilenindex und k als Spaltenindex interpretiert werden, 
wobei die Zählung mit Null beginnt (also erste Zeile n=0, erste Spalte k=0). 
Beginnt man an den Rändern mit Einträgen mit dem Wert 1, so ergeben sich dadurch genau 
die Binomialkoeffizienten.

Die Zeilen
Die Summe der Einträge einer Zeile wird als Zeilensumme bezeichnet. Von oben nach unten 
verdoppeln sich die Zeilensummen von Zeile zu Zeile. Dies rührt vom Bildungsgesetz des 
pascalschen Dreiecks her. Jeder Eintrag einer Zeile wird in der folgenden Zeile zur 
Berechnung zweier Einträge verwendet. Hierbei muss man das Bildungsgesetz durch das 
Hinzufügen von gedachten Nullen links und rechts von jeder Zeile verallgemeinern, so 
dass auch die äußeren Einsen jeder Zeile durch die Addition der darüberliegenden Einträge 
generiert werden. Da die Zeilensumme der ersten Zeile gleich eins ist, ist die Zeilensumme 
der n-ten Zeile gleich 2^{n-1}. */
