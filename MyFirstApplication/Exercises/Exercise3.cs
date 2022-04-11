
namespace MyFirstApplication;

/* This class has my Lesson 3 examples covering operations and overflow checking */
public class Exercise3
{
    /*
     Write a method that takes 1 int argument and an int return type. Utilize the modulus 
    operator to complete this task. Assign the data values below to their own variables. 
    Use the Console WriteLine statement on the first 4 variables listed below and calculate 
    the modulus with the passed in argument parameter. Using the last variable below, 
    calculate the modulus with the passed in argument parameter and return it. 
    a.15 b.456 c.23 d.89 e.245
     */
    public int ModulusPractice(int value1)
    {
        // variable assignment
        int mymodulo = value1;
        int firstnum = 15;
        int secondnum = 456;
        int thirdnum = 23;
        int fourthnum = 89;
        int fifthnum = 245;
        // Console Writeline & modulus
        Console.WriteLine(firstnum % mymodulo);
        Console.WriteLine(secondnum % mymodulo);
        Console.WriteLine(thirdnum % mymodulo);
        Console.WriteLine(fourthnum % mymodulo);
        // Return & modulus
        return fifthnum % mymodulo;

    }

    /*
     Write a method that takes no arguments and a void return type. Utilizing the math 
    problem in this task, fill in any missing pieces to get the output. 10 + 32 * 12 / 3.
    Write a Console WriteLine to solve each output.
    a.Output: 138 b.Output: 168 c.Output: 131
     */
    public void MathProblem()
    {
        Console.WriteLine(10 + 32 * 12 / 3); // 138
        Console.WriteLine((10 + 32) * 12 / 3); // 168
        Console.WriteLine((10 + 32 * 12) / 3); // 131
    }

    /*
     Write a method that takes two short type arguments and a void return type. Using the 
    Compound Assignment operators below, use the first argument parameter as the left operand
    to get the result. Print each one using the Console WriteLine statement.
    a.+= b./= c.*= d.%=
     */
    public void CompoundPractice(short left, short right)
    {
        Console.WriteLine(left += right);
        Console.WriteLine(left /= right);
        Console.WriteLine(left *= right);
        Console.WriteLine(left %= right);
    }

    /*
     Write a method that takes two bool type arguments and a void return type. Using Boolean 
    Logical operators &, |, ^, and || to complete this task. Use a Console WriteLine 
    statement to calculate each result using the operators. The second argument is the left 
    operand. Use the below values when testing your method. Using comments, provide your 
    output results inside the method after your statements
    .a.Argument1= true, Argument2 = false b.Argument1= false, Argument2 = false
    c.Argument1= true, Argument2 = true d.Argument1= false, Argument2 = true
     */
    public void BooleanOperatorPractice(bool right, bool left)
    {
        // arg 1 = a, arg 1 on right side, description followed by execution
        // Logical And Operator, to return true, both must be true
        Console.WriteLine(left & right);
        // Logical Or Operator, to return True, one must be true
        Console.WriteLine(left | right);
        // Logical Exclusive Or Operator, only one can be true
        Console.WriteLine(left ^ right);
        // Conditional Logical Or Operator, checks the first and only continues
        // to check if the first is false
        Console.WriteLine(left || right);
        // inputing (true, false) returned "False True True True"
        // inputing (false, true) returned "False True True True"
        // inputing (true, true) returned "True True False True"
        // inputing (false, false) returned "False False False False"
    }

} // end class
