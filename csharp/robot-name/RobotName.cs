using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


public class Robot
{
    private string _name;
    Random random = new Random();
    string newName = string.Empty;

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
        do        
        {
            MakeNewName();            
        } while (!RobotNames.CheckName(newName));

        RobotNames.Names.Add(newName); 

        return newName;        
    }
 
    public void MakeNewName()
    {
        string name = string.Empty;

        for (int i = 0; i < 5; i++)
        {
            if (i < 2)
                name += (char)random.Next(65, 91);
            else
                name += random.Next(10);
        }

        newName = name;
    }
}

public static class RobotNames
{
    public static HashSet<string> Names = new HashSet<string>();
    static int maxNames = 26*26*10*10*10;

    public static bool CheckName(string name)
    {

        if (RobotNames.Names.Count == maxNames)
        {
            throw new Exception("No more names available");
        }

        if (RobotNames.Names.Add(name))
            return true;

        return false;                  
    }

}