
namespace MyFirstApplication;

/* This class contains examples from Lesson 6 Constructors, Methods, and More */
internal class Exercise6
{
    /*
     Write a constructor for your exercise file that takes 2 parameters.The first parameter
    should have an int type and a variable name of showSize. The second parameter should have 
    a string type and a variable name of shoeType. Create private class variables for these 
    types and use and underscore when defining them. Inside the constructor associate the 
    class variables with the constructor parameters.
     */
    private int _showSize;
    private string _shoeType;

    public Exercise6(int showSize, string shoeType)
    {
        _showSize = showSize;
        _shoeType = shoeType;
    }

    /*
     Write the properties for the class variables defined in exercise 1. Ensure they are 
    labeled as public and are spelled using a capital letter.
     */
    public int ShowSize
    {
        get { return _showSize; }
        set { _showSize = value; }
    }
    public string ShoeType
    {
        get { return _shoeType; }
        set { _shoeType = value; }
    }

    /*
     Write a delegate that takes a string parameter. This delegate should be named TryOn. 
    Write a method that takes a string argument and void return type. In the method body
    include a Console WriteLine statement that will print the message. Test your delegate 
    in Program.cs to ensure everything works properly. Using a mult-line comment on your 
    Exercise6.cs file, provide the information you used to test the delegate.
     */
    public delegate void TryOn(string type);

    public void TryItOn(string message)
    {
        Console.WriteLine($"TryItOn = {message}");
    }

    /*
     To combine test all of them, I input the following into my Program.cs:
    Exercise6 myExercise6 = new Exercise6(9, "Tennis");
    Exercise6.TryOn theShoe = myExercise6.TryItOn;
    theShoe($"I tried on the {myExercise6.ShoeType} shoes in size {myExercise6.ShowSize}.");

    This uses the constructor to create  the object with properties, but it also takes those
    details and uses them for the delegate testing via interpolation. The result I got was:
    "I tried on the Tennis shoes in size 9."
     */

} // end class
