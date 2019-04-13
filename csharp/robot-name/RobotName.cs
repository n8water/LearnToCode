using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


public class Robot
{
    private string _name;
    Random random = new Random();

    public Robot()
    {
        _name = GenerateName();
    }

    public string Name 
    { 
        get
        {
            return _name; 
        }
    }



    public void Reset()
    {
        _name = GenerateName();
    }



    public string GenerateName()
    {
        string name = string.Empty;

        while (!RobotNames.CheckName(name))
        {
            name = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                if (i < 2)
                    name += (char)random.Next(65, 91);
                else
                    name += random.Next(100, 1000);
            }
        }
        RobotNames.Names.Add(name);        

        return name;        
    }
 
}

public static class RobotNames
{
    public static HashSet<string> Names;

    public static bool CheckName(string name)
    {
        
        if (RobotNames.Names == null)
        {
            RobotNames.Names = new HashSet<string>();
        }

        if (name.Length == 5 && RobotNames.Names.Add(name))
            return true;

        return false;                  
    }

}