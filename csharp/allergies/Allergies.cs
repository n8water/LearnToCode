using System;
using System.Collections.Generic;

[Flags]
public enum Allergen
{
    Eggs           = 1 << 0,
    Peanuts        = 1 << 1,
    Shellfish      = 1 << 2,
    Strawberries   = 1 << 3,
    Tomatoes       = 1 << 4,
    Chocolate      = 1 << 5,
    Pollen         = 1 << 6,
    Cats           = 1 << 7,
}

public class Allergies
{
    private int maskValue;
    public Allergies(int mask)
    {
        maskValue = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return ((Allergen)maskValue).HasFlag(allergen);
    }

    public Allergen[] List()
    {
        int value = Enum.GetValues(typeof(Allergen)).Length;
        List<Allergen> allergens = new List<Allergen>();
        var testFor = (Allergen)maskValue;

        for (int i = 0; i < value; i++)
        {
            int temp = (int)Math.Pow(2, i);
            if(testFor.HasFlag((Allergen)temp))            
                allergens.Add((Allergen)temp);
        }
     
        return allergens.ToArray();
    }
}