using System;

public static class Bob
{
    public static string Response(string statement)
    {
        //var punctuation = statement.ToCharArray();

        var punctuation = statement.Substring(statement.Length-2);

        switch (punctuation)
        {
            default:
                break;
        }
        throw new NotImplementedException("You need to implement this function.");
    }
}