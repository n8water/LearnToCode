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

    }

    public Allergen[] List()
    {

    }
}

//First working Solution
//public class Allergies
//{
//    private int _mask;
//    private List<Allergen> allergenList;


//    public Allergies(int mask)
//    {
//        _mask = mask;
//    }

//    public bool IsAllergicTo(Allergen allergen)
//    {
//        int allergenValue = (int)Math.Pow(2, (double)allergen);
//        bool isAlleric = false;

//        int test =  _mask & allergenValue;
//        if (test > 0)
//            isAlleric = true;

//        return isAlleric;
//    }

//    public Allergen[] List()
//    {
//        int tempAllergen;
//        allergenList = new List<Allergen>();

//        if (_mask % 2 != 0)
//        {
//            allergenList.Add((Allergen)0);
//        }

//        for (int i = 1; i <= _mask; i++)
//        {
//            tempAllergen = _mask & (int)Math.Pow(2,i);
//            if(tempAllergen > 0)
//                if(i<8)
//                    allergenList.Add((Allergen)i);
//        }

//        return allergenList.ToArray();
//    }
//}