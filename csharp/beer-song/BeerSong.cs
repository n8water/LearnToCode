using System;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        string vers = string.Format("{0} bottles of beer on the wall, {0} bottles of beer.\n" +
            "Take {1} down and pass it around, {2} bottles of beer on the wall.");

        string endofSong = string.Format("1 bottle of beer on the wall, 1 bottle of beer.\n" +
            "Take it down and pass it around, no more bottles of beer on the wall.\n" +
            "\nNo more bottles of beer on the wall, no more bottles of beer.\n" +
            "Go to the store and buy some more, 99 bottles of beer on the wall.");




    }
}