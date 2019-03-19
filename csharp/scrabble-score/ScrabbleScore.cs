using System;
using System.Collections.Generic;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int score = 0;

        Dictionary<char, int> scoreTable = new Dictionary<char, int>();
        scoreTable.Add('a', 1);
        scoreTable.Add('e', 1);
        scoreTable.Add('i', 1);
        scoreTable.Add('o', 1);
        scoreTable.Add('u', 1);
        scoreTable.Add('l', 1);
        scoreTable.Add('n', 1);
        scoreTable.Add('r', 1);
        scoreTable.Add('s', 1);
        scoreTable.Add('t', 1);
        scoreTable.Add('d', 2);
        scoreTable.Add('g', 2);
        scoreTable.Add('b', 3);
        scoreTable.Add('c', 3);
        scoreTable.Add('m', 3);
        scoreTable.Add('p', 3);
        scoreTable.Add('f', 4);
        scoreTable.Add('h', 4);
        scoreTable.Add('v', 4);
        scoreTable.Add('w', 4);
        scoreTable.Add('y', 4);
        scoreTable.Add('k', 5);
        scoreTable.Add('j', 8);
        scoreTable.Add('x', 8);
        scoreTable.Add('q', 10);
        scoreTable.Add('z', 10);

        if (input == null)
            throw new ArgumentException();

        input = input.ToLower();

        foreach (char c in input)
        {
            score += scoreTable.GetValueOrDefault(c);
        }


        return score;
    }
    
}


/*Value Table
Letter                           Value
A, E, I, O, U, L, N, R, S, T       1
D, G                               2
B, C, M, P                         3
F, H, V, W, Y                      4
K                                  5
J, X                               8
Q, Z                               10
*/
