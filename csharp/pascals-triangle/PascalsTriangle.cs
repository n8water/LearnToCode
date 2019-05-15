using System;
using System.Collections.Generic;

public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {

        throw new NotImplementedException();
    }

}

/* Notizen
Pascalsches Dreieck

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
