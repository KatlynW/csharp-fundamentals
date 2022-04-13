
namespace MyFirstApplication;

/* This class contains examples from Lesson 5 Expression and Pattern Matching */
internal class Exercise5
{
    /*
     Write a method that takes 2 int parameters and an int return type. Using the formula 
    below from Ohm’s law, determine the voltage. The first method parameter will represent 
    current and the second parameter will represent resistance. Using the Func<int, int, int> 
    and a lambda expression, determine the voltage calculation and return the value.
    a.Voltage = Current x Resistance
     */
    public int FunctPractice(int current, int resistance)
    {

        Func<int, int, int> voltage = (current, resistance) => current * resistance;
        return voltage(current, resistance);
    }

    /*
     Write a method that will take 1 char parameter and a string return type. Using a switch
    expression and the table given in the lab instuctions, return the description. If the 
    value does not match the grade, return the default message, “Not a valid grade”.
     */
    public string GradeExpression(char grade)
    {
        string gradedescription = grade switch
        {
            'E' => "Excellent",
            'V' => "Very Good",
            'G' => "Good",
            'A' => "Average",
            'F' => "Failed",
            _ => "Not a valid grade."
        };
        return gradedescription;
    }

    /*
     Write a method that takes 1 argument and a void return type. Using a Relational Pattern
    and switch expression determine a size of popcorn based on the table given in the lab 
    instructions and using a Console WriteLine, print the popcorn size.
     */
    public void PopcornSize(int size)
    {
        string result = size switch
        {
            <= 3 => "Microwave Bag",
            <= 16 => "Movie Sack",
            <= 32 => "Movie Cup",
            <= 64 => "Movie Tub",
            _ => "We don't have that size."
        };
        Console.WriteLine(result);
    }

} // end class
