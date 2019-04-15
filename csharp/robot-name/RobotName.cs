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

    public string Name { get { return _name;}}
         
    public void Reset()
    {
        _name = GenerateName();
    }



    public string GenerateName()
    {
        string newName = string.Empty;

        do        
        {
            newName = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                if (i < 2)
                    newName += (char)random.Next(65, 91);
                else
                    newName += random.Next(000, 1000);
            }
        } while (!RobotNames.CheckName(newName));

        RobotNames.Names.Add(newName);        

        return newName;        
    }
 
}

public static class RobotNames
{
    public static HashSet<string> Names;
    static int maxNames1 = 608399;

    public static bool CheckName(string name)
    {
        
        if (RobotNames.Names == null)
        {
            RobotNames.Names = new HashSet<string>();
        }
        else if (RobotNames.Names.Count == maxNames1)
        {
            throw new Exception("No more names available");
        }

        if (RobotNames.Names.Add(name))
            return true;

        return false;                  
    }

}