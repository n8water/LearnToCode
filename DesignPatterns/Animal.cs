using System;

public class Animal
{
    #region Fields

    private string _name;
	private double _height;
	private int _weight;
	private string _favFood;
	private double _speed;
	private string _sound;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

	public double Height
    {
		get { return _height; }
		set { _height = value; }
    }

	public int Weight
    {
		get { return _weight; }
		set 
        {
            if (value > 0)
            {
                _weight = value;
            }
            else
            {
                Console.WriteLine("Weight must be bigger than 0");
            }
        }
    }

	public string FavFood
    {
		get { return _favFood; }
		set { _favFood = value; }
    }
    
	public double Speed
    {
		get { return _speed; }
		set { _speed = value; }
    }

	public string Sound
    {
		get { return _sound; }
        set { _sound = value; }
    }
    #endregion Fields

    #region C'tor
    public Animal()
    {
    }
    #endregion C'tor

    #region Methods

    /*a private method can only be accessed by other public methods
    that are in the same class */
    private void bePrivate()
    {
        Console.WriteLine("I'm a private method");
    }



    #endregion Methods
}
