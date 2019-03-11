using System;

  public static class TwoFer
  {
      public static string Name(string input = null)
      {
		  string name = "you";
		  string result = "One for " + name + ", one for me.";
		  
          if(input != null)
			  name = input;
		  
		  return result;
      }
  }
