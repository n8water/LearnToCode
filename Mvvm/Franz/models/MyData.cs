using System.Collections.Generic;

namespace Franz.models
{
  public class MyData
  {
    private List<string> _names;

    public MyData()
    {
      SetNames();
    }

    public List<string> Names
    {
      get => _names;
      set => _names = value;
    }

    private void SetNames()
    {
      var temp = new List<string>()
      {
        "Sabrina",
        "Franz",
        "Maria", 
        "Norbert",
        "Raphael",
        "Jessica"
      };

      _names = temp;
    }


  }
}
