
namespace MyFirstApplication;

/*
 A record is a reference type that provides built-in functionality 
for encapsulating data.
 */
internal record Person(string firstName, string lastName);

/*
 A record struct is a value type with a similar functionality as a record class
 */
public record struct Resolution(int width, int height)
{
    public void CalculateRes()
    {
        Console.WriteLine(width * height);
    }
} // end record
