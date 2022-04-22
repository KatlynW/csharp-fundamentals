
namespace MyFirstApplication;

/*
 This class contains examples from Lesson 10 and Updated House 
 *
 Create a class based on your Horse object. Include your attributes as auto properties. 
Create 3 constructors. The first constructor should have parameters equal to your properties. 
Assign each parameter to your properties. The second constructor should have 2 parameters. 
Using the :this()keyword, you will pass your information to the first constructor. This 
includes the 2 parameters and default values. For the last constructor, you will create the 
default constructor. Using the :this()keyword, you will pass 2 default values in that will 
pass to the 2nd constructor. Also include in the class, your method for Horse.
 */
internal class Horse
{
    // Attributes as Properties
    public int Age { get; set; }
    public int HoofAngle { get; set; }
    public int HairLength { get; set; }

    // Constructor with 3 parameters
    public Horse(int age, int hoofAngle, int hairLength)
    {
        Age = age;
        HoofAngle = hoofAngle;
        HairLength = hairLength;
    }

    // Constructor with 2 parameters
    public Horse(int age, int hoofAngle)
        :this(age, hoofAngle, 10) { }

    // Default Constructor
    public Horse()
        :this(5, 45) { }

    // Horse Method
    public virtual void HorseLayDownGetUp()
    {
        Console.WriteLine($"The {Age} year-old horse gets up.");
    }

    /*
     In your Horse class, add the virtual keyword to your method created in Lesson 10. Create 
    a second version of the same method and add a parameter. Include a Console WriteLine 
    method in the new method that uses the parameter. This parameter needs to be based on one 
    of your properties.
     */

    public void HorseLayDownGetUp(int hairLength)
    {
        Console.WriteLine($"The horse with {hairLength} inch long hair gets up.");
    }



} // end class
