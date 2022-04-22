namespace MyFirstApplication;

/*
 This class contains examples of Lesson 15 Enums and Tuples
 */

public enum FavoriteMovies { EnolaHolmes, AvalonHigh, VioletEvergarden}

internal class Exercise15
{
    /*
     Above the class, write an enum called Favorite Movies. Add your own favorite movies 
    to the enum. Write a method that has a string return type and an enum parameter. This 
    enum parameter will be your favorite movie enum. Write a switch expression that takes 
    the enum and prints out a string return. Use string interpolation in your return 
    message that includes the name of the movie chosen.
     */

    public string FavoriteMovies1(FavoriteMovies movie)
    {
        string message = movie switch
        {
            FavoriteMovies.AvalonHigh => $"My favorite movie is {FavoriteMovies.AvalonHigh}",
            FavoriteMovies.EnolaHolmes => $"My favorite movie is {FavoriteMovies.EnolaHolmes}",
            _ => $"My favorite movie is {FavoriteMovies.VioletEvergarden}"
        };
        return message;

    } // end method


    /*
     Write a method that takes an enum parameter. This enum will be your favorite movie 
    enum. The method will have a tuple return type (intnum, stringmovie). Using an explicit
    int cast on one of your enum, assign the value to an int variable. Create second variable
    of type string. Assign the same enum value you used and use the ToString() at the end
    of it. Return both variables as a tuple. See example below for clarity.
    a.Int value = (int)Enum.Value; b.string something = Enum.Value.ToString();
     */

    public (int num, string movie) FavoriteMovies2()
    {
        int value = (int)FavoriteMovies.VioletEvergarden;
        string answer = FavoriteMovies.VioletEvergarden.ToString();
        return (value, answer);
    }

} // end class
