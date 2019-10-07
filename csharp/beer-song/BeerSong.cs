using System;

public static class BeerSong
{
    static string result;
    public static string Recite(int startBottles, int takeDown)
    {
        #region Variables
        result = string.Empty;

        int bottles = startBottles;
        int counter = takeDown;
        #endregion

        while (counter > 0)
        {
            AddLine(bottles);
            bottles--;
            counter--;
        }

        return result;
    }

    private static void AddLine(int input)
    {

        string vers = $"{input} bottles of beer on the wall, {input} bottles of beer.\n" +
                $"Take one down and pass it around, {input - 1} bottles of beer on the wall.";

        string twoBottles = "2 bottles of beer on the wall, 2 bottles of beer.\n" +
            $"Take one down and pass it around, 1 bottle of beer on the wall.";

        string oneBottle = "1 bottle of beer on the wall, 1 bottle of beer.\n" +
            "Take it down and pass it around, no more bottles of beer on the wall.";

        string noBottle = "No more bottles of beer on the wall, no more bottles of beer.\n" +
            "Go to the store and buy some more, 99 bottles of beer on the wall.";

        if (result != string.Empty)
            result += "\n\n";
               
        if (input > 2)
        {            
            result += vers;
        }
        else if(input == 2)
        {
            result += twoBottles;
        }
        else if(input == 1)
        {
            result += oneBottle;
        }
        else if(input == 0)
        {
            result += noBottle;
        }
    }
}