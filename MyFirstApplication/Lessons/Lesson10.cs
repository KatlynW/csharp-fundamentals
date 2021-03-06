
namespace MyFirstApplication;
/*
 Encapsulation is the process of wrapping data and the code into a single unit.
 */
public class Lesson10
{
    private string _firstName;
    private string _address;
    protected int zipcode;

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    // auto-implemented property with init keyword
    public string LastName { get; init; }

    // auto-implemented property with a default value
    public int Id { get; set; } = 1000;

    // property with private set
    public long Phone { get; private set; }

    // expression bodied member property
    public string Address
    {
        get => _address;
        set => _address = value;
    }

    public int Zipcode
    {
        get => zipcode;
        set => zipcode = value;
    }


    // default constructor
    public Lesson10()
    :this("John", "Doe", 64082){ }

    // constructor using this with variables
    public Lesson10(string firstName, string lastName, int zipcode)
    {
        _firstName = firstName;
        LastName = lastName;
        this.zipcode = zipcode;
    }


    /*
     This method shows how ou can chane a private set property but not a property with init
     */
    private void ShowLastAndPhone()
    {
        // LastName = "Jon"; // Cannot use even here
        Phone = 12345678;
    }

} // end class
