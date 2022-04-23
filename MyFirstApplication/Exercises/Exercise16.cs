namespace MyFirstApplication;

/* This class contains examples of Lesson 16 Collections */
internal class Exercise16
{
    /*
     Write a method that has no parameters and a no return type. Create a List<T> of your 
    Horse objects. When creating your list, utilize all the constructors you created with 
    your Horse class. Using a foreach loop, printout the results of your collection using 
    a Console WriteLine statement.
     */

    public void HorseList()
    {
        List<Horse> horses = new List<Horse>();
        horses.Add(new Horse());
        horses.Add(new Horse(2, 35));
        horses.Add(new Horse(10, 40, 20));

        foreach (Horse horse in horses)
        {
            Console.WriteLine(horse);
        }

    }


    /*
     Write a method that has no parameters and no return type. Using only the data you used  
    when building your favorite movies from exercise 15, create a Dictionary collection that 
    takes an int key and string value. When adding Dictionary elements,pick an int value as 
    the key and use the favorite movies data as the string. Using a foreach loop, print out 
    the results of your collection using a Console WriteLine statement.
     */

    public void FavoriteMoviesDictionary()
    {
        Dictionary<int, string> movies = new Dictionary<int, string>();
        movies.Add(1, "Enola Holmes");
        movies.Add(2, "Avalon High");
        movies.Add(3, "Violet Evergarden");

        foreach (KeyValuePair<int, string> movie in movies)
        {
            Console.WriteLine(movie);
        }
    }

} // end class
