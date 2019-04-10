using System;
using System.Collections.Generic;
using System.Linq;


public class Robot
{
    public Robot()
    {
        
    }

    public string Name { get; private set; }


    public void Reset()
    {
        var Name = new RobotNames();
        Name.GenerateName();
    }


}

public class RobotNames
{
    public List<string> robotNames = new List<string>();

    public string GenerateName()
    {
        string name = string.Empty;
        Random random = new Random();
        
        for (int i = 0; i < 3; i++)
        {
            if(i<2)
                name += (char) random.Next(65,91);
            else
                name += random.Next(100,1000);
        }

        if(!robotNames.Contains(name))
        {
            robotNames.Add(name);
            return name;
        }
            
        else               
            throw new Exception ("This Name already exists");    
    }
}