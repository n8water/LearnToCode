<Query Kind="Program" />

void Main()
{
	ILogger foo = new Logger();
	foo.Log (new Exception ("test"));	
}

class Logger : ILogger
{	
	public void Log (string message) => Console.WriteLine (message);
}

interface ILogger
{
	void Log (string message);	
	
	// Adding a new member to an interface need not break implementors:
	public void Log (Exception ex) => Log (ExceptionHeader + ex.Message);
		
	// The static modifier (and other modifiers) are now allowed:
	static string ExceptionHeader = "Exception: ";
}