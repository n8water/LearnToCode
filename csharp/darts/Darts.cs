using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double targetRadius = Math.Sqrt(x * x + y * y);

        return GetScore(targetRadius);
    }

    private static int GetScore(double targetRadius)
    {
        int score = 0;

        if (targetRadius <= 1)
            score = 10;
        else if (targetRadius <= 5)
            score = 5;
        else if (targetRadius <= 10)
            score = 1;
        else
            score = 0;

        return score;
    }

}
