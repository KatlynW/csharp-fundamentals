
namespace MyFirstApplication;

/* This class contains exmples of Lesson 17 Exception Handling */
internal class Exercise17
{
    /*
     Write a method that has two int parameters and no return type. You will use a try/catch 
    for this method. Create a division problem in the try block. The catch block will utilize 
    the DivideByZeroException. Provide a Console WriteLine message for both the try block and 
    the catch block. The one in the try block should display the answer to the division 
    problem. The one in the catch block should have a message using Interpolation along with 
    a variable.Messagesyntax. Test the method with different numbers, including 0 so you can 
    ensure the catch executes. 
     */

    public void DivisionException(int num1, int num2)
    {
        try
        {
            int answer = num1 / num2;
            Console.WriteLine(answer);
        }
        catch(DivideByZeroException de)
        {
            Console.WriteLine($"You cannot divide by zero. {de.Message}");
        }
    }

    /*
     Write a method that has a horse parameter and no return type. Using an if statement, 
    determine if your horse is null. If it is null, use the throw keyword and a message to 
    indicate it is null. If the horse is not null, use a Console WriteLine statement to 
    print out one of your horse properties.
     */

    public void HorseException(Horse horse)
    {
        if(horse == null)
        {
            throw new ArgumentNullException("Horse object is null");
        }
        else
        {
            Console.WriteLine(horse.Age);
        }
    }


} // end class
