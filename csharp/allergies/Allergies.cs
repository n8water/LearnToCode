using System;
using System.Collections.Generic;

public enum Allergen
{
    Eggs,
    Peanuts,
    Shellfish,
    Strawberries,
    Tomatoes,
    Chocolate,
    Pollen,
    Cats
}

public class Allergies
{
    private int _mask;
    private List<Allergen> allergenList;
    
    
    public Allergies(int mask)
    {
        _mask = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        int allergenValue = (int)Math.Pow(2, (double)allergen);
        bool isAlleric = false;

        int test =  _mask & allergenValue;
        if (test > 0)
            isAlleric = true;
        
        return isAlleric;
    }

    public Allergen[] List()
    {
        int tempAllergen;
        allergenList = new List<Allergen>();

        if (_mask % 2 != 0)
        {
            allergenList.Add((Allergen)0);
        }

        for (int i = 1; i <= _mask; i++)
        {
            tempAllergen = _mask & (int)Math.Pow(2,i);
            if(tempAllergen > 0)
                if(i<8)
                    allergenList.Add((Allergen)i);
        }
        
        return allergenList.ToArray();
    }
}