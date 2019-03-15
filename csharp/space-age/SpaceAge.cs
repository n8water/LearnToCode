using System;

public class SpaceAge
{
    private readonly int _seconds;
    private const int EarthYear = 31557600;

    public SpaceAge(int seconds)
    {
        this._seconds = seconds;
    }

    private double CalculateAge(double factor)
    {
        double age = ((double)_seconds / EarthYear) / factor;
        Math.Round(age, 2);
        return age;
    }

    public double OnEarth()
    {
        return CalculateAge(1);
    }

    public double OnMercury()
    {
        return CalculateAge(0.2408467);
    }

    public double OnVenus()
    {
        return CalculateAge(0.61519726);
    }

    public double OnMars()
    {
        return CalculateAge(1.8808158);
    }

    public double OnJupiter()
    {
        return CalculateAge(11.862615);
    }

    public double OnSaturn()
    {
        return CalculateAge(29.447498);
    }

    public double OnUranus()
    {
        return CalculateAge(84.016846);
    }

    public double OnNeptune()
    {
        return CalculateAge(164.79132);
    }


}