using System;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        int bottles = startBottles;
        int counter = takeDown;

        string vers = $"{bottles} bottles of beer on the wall, {bottles} bottles of beer.\n" +
                        $"Take one down and pass it around, {bottles - 1} bottles of beer on the wall.";

        string twoBottles = "2 bottles of beer on the wall, 2 bottles of beer.\n" +
            $"Take one down and pass it around, 1 bottle of beer on the wall.";

        string oneBottle = "1 bottle of beer on the wall, 1 bottle of beer.\n" +
            "Take it down and pass it around, no more bottles of beer on the wall.";

        string noBottle = "No more bottles of beer on the wall, no more bottles of beer.\n" +
            "Go to the store and buy some more, 99 bottles of beer on the wall.";

        string result = string.Empty;

        while (counter > 0 && bottles > 2)
        {
            result += vers;
            bottles--;
            counter--;
        }

        if (counter > 0 && bottles == 2)
            result += twoBottles;
        else if (counter > 0 && bottles == 1)
            result += oneBottle;
        else if (counter >= 0 && bottles == 0)
            result += noBottle;

        return result;

    }
}