using System;
using System.Collections.Generic;

public static class Triangle
{
    private static List<double> inputValues;
    //A _scalene_ triangle has all sides of different lengths.
    public static bool IsScalene(double side1, double side2, double side3)
    {
        inputValues = new List<double>() { side1, side2, side3 };

        if (OneSideZero() || TriangleInequalityViolated())
            return false;
                
        return (side1 != side2 && side1 != side3 && side2 != side3);
    }

    //An _isosceles_ triangle has at least two sides the same length.
    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        inputValues = new List<double>() { side1, side2, side3 };

        if (OneSideZero() || TriangleInequalityViolated())
            return false;

        return (side1 == side2 || side1 == side3 || side2 == side3);
    }

    //An _equilateral_ triangle has all three sides the same length.
    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
        inputValues = new List<double>() { side1, side2, side3 };

        if (OneSideZero() || TriangleInequalityViolated())
            return false;

        return (side1 == side2 && side2 == side3 && side1 == side3);
    }

    private static bool OneSideZero()
    {
        if (inputValues.Contains(0))
            return true;
        else
            return false;
    }
    
    private static bool TriangleInequalityViolated()
    {

        if (inputValues[0] > inputValues[1] + inputValues[2] 
            || inputValues[1] > inputValues[0] + inputValues[2]
            || inputValues[2] > inputValues[0] + inputValues[1])
            return true;
        else
            return false;
    }

}