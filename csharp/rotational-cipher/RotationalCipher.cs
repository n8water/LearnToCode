using System;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        string rotate = string.Empty;

        foreach (char c in text)
        {
            int temp = (int)c;

            //Gross und Kleinbuchstaben getrennt behandeln sonst können die Zeichen von gross zu klein wechseln
            //das ist nicht erwünscht
            

            if ((temp <= 122 && temp >= 97) || (temp <= 90 && temp >= 65))
            {
                temp += shiftKey;
                if ((temp <= 122 && temp >= 97) || (temp <= 90 && temp >=65))
                {
                    rotate += (char)temp;
                    temp = 0;
                }
                else
                {
                    temp -= 26;
                    rotate += (char)temp;
                    temp = 0;
                }

            }
            else
            {
                rotate += c;
                temp = 0;
            }
        }

        return rotate;
    }
}