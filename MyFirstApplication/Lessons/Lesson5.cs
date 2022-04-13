
namespace MyFirstApplication;

/* This lesson goes over expressions and pattern matching. 
 It will also include an intro to delegates.
 */
internal class Lesson5
{
    // Delegate
    public delegate void Del(string message);

    /*
     The is operator checks if the result of an expression 
    is compatible with another type.
     */
    public void IsOperatorSample(int able)
    {
        object bravo = able;
        Console.WriteLine(bravo is int);
        Console.WriteLine(bravo is long);
    }

    // Create a method for delegate example
    public void DelegateMethod(string message)
    {
        Console.WriteLine(message);
    }

    /*
     Method for Func delegate
     */
    public int Sum(int beta)
    {
        return beta * 2;
    }

    /*
     Lambda Using the Func Delegate
     */
    public void LambdaSquare()
    {
        Func<int, int> square = able => able * able;

        Console.WriteLine(square(4));
    }

    /*
     Lambda Using the Action Delegate
     */
    public void LambdaGreeting()
    {
        Action<string> greet = name =>
        {
            string greeting = $"Hello {name}! We are learning.";
            Console.WriteLine(greeting);
        };

        greet("Lambda");
    }

    /* Basic Switch */
    public string BasicSwitch(string able)
    {
        switch (able)
        {
            case "blue":
                return "Favorite color is blue.";
            case "red":
                return "Favorite color is red.";
            case "green":
                return "Favorite color is green.";
            default:
                return "Not sure";
        }
    }

    /* Switch Expression Based on Above Switch */
    public string FavoriteColor(string charlie)
    {
        string result = charlie switch
        {
            "blue" => "Favorite color is blue.",
            "red" => "Favorite color is red.",
            "green" => "Favorite color is green.",
            _ => "Not sure."
        };
        return result;
    }

    /* Relational Pattern compares an expression result with the constant. */
    public void DrinkSize(int size)
    {
        string result = size switch
        {
            <= 20 => "Cup",
            <= 32 => "Bottle",
            <= 64 => "Big Gulp",
            _ => "We don't have that size."
        };
        Console.WriteLine(result);
    }

    /* Logical Pattern And matches an expression when both patterns match the expression. */
    public void TemperatureGuide(double temp)
    {
        string result = temp switch
        {
            < -10.0 and < 0 => "Negative Cold",
            >= 0 and < 32.0 => "Freezing Cold",
            >= 32.0 and < 49.0 => "Cold",
            >= 49.0 and < 60.0 => "Warm",
            >= 60.0 and < 90.0 => "Nice",
            >= 90.0 and < 105.0 => "Hot",
            _ => "Unknown"
        };
        Console.WriteLine(result);
    }

    /* Logical Pattern Or matches an expression when either pattern matches the expression */
    public void NumberChoice(int able)
    {
        string result = able switch
        {
            1 or 2 => $"{able} is 1 or 2.",
            3 or 4 => $"{able} is 3 or 4.",
            5 => $"{able} is 5.",
            _ => $"{able} was not on the list."
        };
        Console.WriteLine(result);
    }


} // end class
