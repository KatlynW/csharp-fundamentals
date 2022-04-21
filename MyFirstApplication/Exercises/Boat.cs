
namespace MyFirstApplication;

/*
 This class contains examples from Lesson 10 and Updated House 
 *
 Below are the instructions for boat, aka the same as horse but different attribute definition
 *
 Create a class based on your Boat object. Include your attributes as Expression Body 
Definition Properties. Create 3 constructors. The first constructor should have parameters 
equal to your properties. Assign each parameter to your properties. The second constructor 
should have 2 parameters. Using the :this()keyword, you will pass your information to the 
first constructor. This includes the 2 parameters and default values. For the last 
constructor, you will create the default constructor. Using the :this()keyword, you will 
pass 2 default values in that will pass to the 2nd constructor. Also include in the class, 
your method for Boat.
 */
internal class Boat
{
    // Attributes
    private string _woodColor;
    private string _woodType;
    private int _plankSize;

    // Attributes as Expression Bodied
    public string WoodColor
    {
        get => _woodColor;
        set => _woodColor = value;
    }

    public string WoodType
    {
        get => _woodType;
        set => _woodType = value;
    }

    public int PlankSize
    {
        get => _plankSize;
        set => _plankSize = value;
    }

    // Constructor with 3 parameters
    public Boat(string woodColor, string woodType, int plankSize)
    {
        _woodColor = woodColor;
        _woodType = woodType;
        _plankSize = plankSize;
    }

    // Constructor with 2 parameters
    public Boat(string woodColor, string woodType)
        :this(woodColor, woodType, 5) { }

    // Default Constructor
    public Boat()
        :this("Light Brown", "Oak") { }

    // Boat Method
    public void BoatDockUndock()
    {
        Console.WriteLine($"The {WoodColor} boat is docked");
    }

} // end class
