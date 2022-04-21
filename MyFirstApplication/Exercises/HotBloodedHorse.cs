
namespace MyFirstApplication;

/*
 This class contains examples from Lesson 11 Inheritance
 *
 This is the child class HotBloodedHorse of the parent class Horse
 * 
 Create a child class based on your Horse object. Include one child attribute as an auto 
property. Create 3 constructors. The first constructor should have 4 parameters with 3 of them 
from Horse and your child property. Using the keyword :base(),you will put the four horse 
parameters in the parenthesis. In the body of the constructor you will assign your child
parameter to your property. The second constructor should have 2 parameters, 2 based on the 
horse and 1 from your child. Using the :this()keyword, you will pass 2 of the parent 
attributes and your child attribute information to the first constructor. Include default 
values to represent the 2 remaining horse parameters.For the last constructor, you will 
create the default constructor. Using the :this()keyword, you will pass 2 default values 
in that will pass to the 2nd constructor. Also include in the class, your method for your 
child class.
*/
internal class HotBloodedHorse : Horse
{
    // Property
    public int Speed { get; set; }

    // Constructor with 4 parameters
    public HotBloodedHorse(int Age, int hoofAngle, int hairLength, int speed)
        : base(Age, hoofAngle, hairLength) 
    {
        Speed = speed;
    }

    // Constructor with 2 parameters
    public HotBloodedHorse(int Age, int hoofAngle, int speed) 
        :this(Age, hoofAngle, 30, speed) { }

    // Default Constructor
    public HotBloodedHorse()
        :this(5, 45, 20) { }


    // Child Method
    public void RacingNotRacing()
    {
        Console.WriteLine($"The {Age} year-old horse is racing");
    }


} // end class
