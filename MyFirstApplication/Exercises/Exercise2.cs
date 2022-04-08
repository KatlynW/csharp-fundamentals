
namespace MyFirstApplication;

public class Exercise2
{
    /*
     * Write a method that takes a string argument parameter and void return type. 
     * Using string concatenation and the below string methods, write a Console WriteLine
     * statement for each of them. Inside the string concatenation will be the name of each 
     * string method. When testing this method use the specified string.
     * a.Trim() b.ToLower() c.Contains(“tow”) d.Length() e.IndexOf(‘C’)
     */
    public void StringMethodExamples(string string1)
    {
        // A) Trim()
        Console.WriteLine(string1.Trim());
        // B) ToLower()
        Console.WriteLine(string1.ToLower());
        // C) Contains("tow")
        Console.WriteLine(string1.Contains("tow"));
        // D) Length()
        Console.WriteLine(string1.Length);
        // E) Index of('C')
        Console.WriteLine(string1.IndexOf('C'));
    }

    /*
     * Write a method that takes no arguments and a void return type. Using the 
     * Unicode table resource link, assign the Unicode value of the Pilcrow Sign to a 
     * variable. Use the Console WriteLine to print that variable. This variable should 
     * utilize the type that takes 1 character.
     */
    public void PilcrowSign()
    {
        char Psign = '\u00B6';
        Console.WriteLine(Psign);
    }

    /*
     Write a method that takes no arguments and a void return type. Use 1 string variable 
    and 1 Console WriteLine to complete this task. Use escape sequences to recite the
    Jack and Jill Poem.
     */
    public void JackAndJill()
    {
        string Poem = "Jack and Jill \nwent up the hill \nto fetch a pail of water.\n" +
            "Jack fell down and broke his crown \nand Jill came tumbling after.";
        Console.WriteLine(Poem);
    }

    /*
     Write a method that takes no arguments but does have a string return type. You will 
    utilize Interpolation to complete this task. Create variables for each provided data 
    below. Using Interpolation return a string that includes the variables in a sentence.
    a.Name b.Favorite movie c.Favorite movie snack d.Favorite movie drink
     */
    public string MovieFavorites()
    {
        string name = "Katlyn";
        string favMovie = "Enola Holmes";
        string favMovieSnack = "popcorn";
        string favMovieDrink = "Dr. Pepper";
        return $"{name} likes to watch {favMovie} while eating {favMovieSnack} and " +
            $"drinking {favMovieDrink}.";
    }

}
