
namespace MyFirstApplication;

/* This class contains Examples for Lesson 4 Control Flow. */
public class Exercise4
{
    /*
     Write a method that takes 2 string arguments and a void return type. Using an if-else 
    statement, compare the two strings to each other. Using a Console WriteLine statement, 
    print out the results of whether the strings are equal. Provide a comment inside the 
    method that says what strings you used during testing.
     */
    public void ComparingStrings(string string1, string string2)
    {
        if (string1 == string2)
        {
            Console.WriteLine("The two strings are equal");
        }
        else
        {
            Console.WriteLine("The two strings are not equal");
        }
        // I first used "Tom" and "Tommy" which returned not equal, and then I changed
        // Tommy to "Tom" which returned that they are equal.
    }

    /*
     Write a method that will take 1 char argument and a string return type. Using a switch
    and the table below, return the description given in table in lab instructions. If the 
    value does not match the grade, return the default message, “Not a valid grade”.
     */
    public string GradeDescriptions(char grade)
    {
        switch (grade)
        {
            case 'E':
                return "Excellent";
            case 'V':
                return "Very Good";
            case 'G':
                return "Good";
            case 'A':
                return "Average";
            case 'F':
                return "Failed";
            default:
                return "Not a valid grade.";
        }
    }

    /*
     Write a method that takes no arguments and a void return type. Using an iteration 
    statement, display all the numbers divisible by 3 from 0 to 30. Utilize a modulus to 
    obtain your results.
     */
    public void DivisibleBy3()
    {
        for (int i = 0; i < 31; i++)
        {
            if ((i % 3) == 0)
            {
                Console.WriteLine(i);
            } // end if
        } // end for
    } // end method

} // end class
