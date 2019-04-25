using System;

public enum Allergen
{
    Eggs = 1,
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

    
    public Allergies(int mask)
    {
        _mask = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        int allergenValue = (int)allergen;
        bool isAlleric = false;

        int test =  _mask & allergenValue;
        if (test > 0)
            isAlleric = true;

        //int all = 3;
        //Allergen aller = (Allergen)all;

        return isAlleric;
    }

    public Allergen[] List()
    {
        Allergen[] result = new Allergen[8];

        int temp = 0;


        //if (temp % 2 != 0)
        //{
        //    result[0] = (Allergen)1;
        //    temp -= 1;
        //}

        for (int i = 0; Math.Pow(2,i) <= _mask; i++)
        {
            temp = _mask & (int)Math.Pow(2, i);
            if (temp > 0)
                result[i] = (Allergen)i;
        }

        return result.Length > 0 ? result : throw new ArgumentException();
    }
}