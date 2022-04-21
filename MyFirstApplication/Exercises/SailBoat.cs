
namespace MyFirstApplication;
/*
 This class contains examples from Lesson 11 Inheritance
 *
 This is the child class SailBoat of the parent class Boat
 * 
 Below are the instructions but modified for boat
 * 
 Create a child class based on your Boat object. Include 1 child attribute as 
Expression Body Definition Properties. Create 3 constructors. The first constructor should 
have 4 parameters with 3 of them from BOat and your child property. Using the keyword 
:base(),you will put the four boat parameters in the parenthesis. In the body of the 
constructor you will assign your child parameter to your property. The second constructor 
should have 2 parameters, 2 based on the boat and 1 from your child. Using the 
:this()keyword, you will pass 2 of the parent attributes and your child attribute 
information to the first constructor. Include default values to represent the 2 remaining 
boat parameters.For the last constructor, you will create the default constructor. 
Using the :this()keyword, you will pass 2 default values in that will pass to the 2nd 
constructor. Also include in the class, your method for your child class.
*/
internal class SailBoat : Boat
{
    // Attribute
    private string _sailMaterial;

    // Property
    public string SailMaterial
    {
        get => _sailMaterial;
        set => _sailMaterial = value;
    }

    // Constructor with 4 parameters
    public SailBoat(string woodColor, string woodType, int plankSize, string sailMaterial)
        : base(woodColor, woodType, plankSize)
    {
        SailMaterial = sailMaterial;
    }

    // Constructor with 3 parameters
    public SailBoat(string woodColor, string woodType, string sailMaterial)
        :this(woodColor, woodType, 15, sailMaterial) { }

    // Default Constructor
    public SailBoat()
        :this("Light Brown", "Oak", "Cloth") { }

    // Child Method
    public void  SailFurlUnfurl()
    {
        Console.WriteLine($"The {SailMaterial} sail unfurls");
    }


}// end class
