using System;

public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        int arraySize = size;
        int x = 0;
        int y = 0;
        
        int[,] result = new int[arraySize, arraySize];

        for(int i = 1; i <= size; i++)
        {
            int tempX = x;
            int tempY = y;

            result[tempX, tempY] = i;

            tempX++;
            tempY++;

        }


        return result;
        
    }
}
