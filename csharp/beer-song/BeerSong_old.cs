using System;
using System.Text;

public static class BeerSong_old
{
    public static string Recite(int startBottles, int takeDown)
    {
        int bottlesOnTheWall = startBottles;
        int counter = 0;
        StringBuilder sb = new StringBuilder();

        string vers = string.Format("{0} bottles of beer on the wall, {0} bottles of beer.\n" +
            "Take one down and pass it around, {1} bottles of beer on the wall.", bottlesOnTheWall, bottlesOnTheWall-1 );

        string twoBottles = string.Format("{0} bottles of beer on the wall, {0} bottles of beer.\n" +
            "Take one down and pass it around, 1 bottle of beer on the wall.", bottlesOnTheWall);

        string lastBottle = string.Format("{0} bottle of beer on the wall, {0} bottle of beer.\n" +
            "Take it down and pass it around, no more bottles of beer on the wall.", bottlesOnTheWall, startBottles );

        string lastLine = "No more bottles of beer on the wall, no more bottles of beer.\n" +
            "Go to the store and buy some more, 99 bottles of beer on the wall.";

        while(counter < takeDown)
        {
            if (bottlesOnTheWall == 0)
            {
                sb.Append(lastLine);
                break;
            }
            else if (bottlesOnTheWall == 1)
            {
                sb.Append(lastBottle);
                bottlesOnTheWall -= 1;
            }
            else if(bottlesOnTheWall == 2)
            {
                sb.Append(twoBottles);
                //sb.Append("\n\n");
                bottlesOnTheWall -= 1;
            }
            else
            {
                sb.Append(vers);
                bottlesOnTheWall -= 1;
            }
            counter++;
        }
               
        return sb.ToString();
    }
}