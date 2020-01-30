using System;
using System.Reflection;
using System.Resources;
using Console.classes;

public class Animal : Creature
{
    #region Fields

    // commented lines are now located in Creature.cs
    //private string _name;
	private double _height;
	//private int _weight;
	private string _favFood;
	private double _speed;
	//private string _sound;

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
                System.Console.WriteLine("Weight must be bigger than 0");
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

    public override void SetName(string newName)
    {
        Name = newName;
    }

    public override void SetWeight(int newWeight)
    {
        Weight = newWeight;
    }
    public void SetSound(string newSound)
    {
        Sound = newSound;
    }

    /*a private method can only be accessed by other public methods
    that are in the same class */
    private void bePrivate()
    {        
        System.Console.WriteLine("Weight must be bigger than 0");
    }



    #endregion Methods
}
