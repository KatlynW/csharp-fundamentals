
namespace MyFirstApplication;

/*
 This file contains examples for Lesson 7 Structs and Records
 */
internal struct Employee
{
    /*Change the type from class to struct. Change the name of the struct from Exercise7 to 
     Employee.The file name should not be changed. Create 2 struct variables. The first one 
    will be of type int and be named _id.The second variable should be of type string and be 
    named _name. Create a constructor that takes 2 arguments, with the first being an int 
    and the second a string. The struct variables should be assigned to the constructor 
    parameters. Create properties for these 2 variables.
     */
    private int _id;
    private string _name;

    public Employee(int EmployeeId, string EmployeeName)
    {
        _id = EmployeeId;
        _name = EmployeeName;
    }

    public int Id 
    { 
        get { return _id; } 
        set { _id = value; }
    }
    public string Name 
    {
        get { return _name; }
        set { _name = value; }
    }

} // end struct

/*
 Create a Record based on your Boat object from the Object Oriented Programming lesson. 
 In your record body, include the boat method that you defined. This record can being 
 the same file as exercise 1. Just put the code under it as seen in the lecture. Test 
 your record to ensure it is working correctly.
 */
public record myBoat()
{
    public void BoatDockUndock()
    {
        Console.WriteLine("The boat is docked");
    }
}
