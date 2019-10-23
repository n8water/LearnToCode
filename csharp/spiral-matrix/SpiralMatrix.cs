using System;

public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        int arraySize = size - 1;
        int[,] result = new int[arraySize, arraySize];

        result[2, 1] = 6;
        result[0, 0] = 1;

        return result;
        throw new NotImplementedException("You need to implement this function.");
    }
}
