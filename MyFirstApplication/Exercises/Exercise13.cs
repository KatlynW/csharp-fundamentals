
namespace MyFirstApplication;

/* This class contains examples from Lesson 13 Abstracts and Interfaces */

/*
    In your Exercise13.cs file, change your class to an Interface and name it IMovement.This 
    interface will have 1 property. The property will an int and called Speed. It will have a 
    get and init.
 */
internal interface IMovement
{
    int Speed { get; init; }

} // end interface


/*
 Under the interface you will create an Abstract class called WaterBirds. This abstract class 
will implement the IMovement interface. The interface property should be implemented in the 
Abstract class as an abstract property. Create two abstract methods for the abstract class 
that is related to WaterBirds. Create a constructor that will take an int parameter and be 
assigned to the Speed property.
 */

internal abstract class WaterBirds : IMovement
{
    public abstract int Speed { get; init; }

    // Abstract Methods
    public abstract void WaterMovement();
    public abstract void EggHolding();

    // Constructor
    protected WaterBirds(int speed)
    {
        Speed = speed;
    }
}


/*
 Under the Abstract class Waterbirds, create a derived class that will extend the WaterBird 
class. Implement the abstract methods and property. Use Console Writeline statements in your 
methods that provide information related to the methods. One of them should use an 
Interpolation string and consume the Speed property. Create a constructor that will take an 
int parameter and use the :base() to pass that int value back to the base Abstract class.
 */

internal class Penguin : WaterBirds
{
    public override int Speed { get; init; } = 5;
    public override void WaterMovement()
    {
        Console.WriteLine($"A penguin is a waterbird with a water movement " +
            $"speed of about {Speed} mph.");
    }

    public override void EggHolding()
    {
        Console.WriteLine("The male penguins are the ones that hatch the egg after the" +
            " female lays them.");
    }

    // Constructor
    public Penguin(int speed)
        : base(speed) { }

}
