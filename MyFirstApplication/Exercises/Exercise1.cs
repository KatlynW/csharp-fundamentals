
namespace MyFirstApplication;

/* This class has my Lesson 1 examples covering value types. */
public class Exercise1
{
    /*
     * Write out a method with no arguments and a void return type that will print the 
     * output of the number 35 based on the number systems below. The values should be 
     * assigned to a variable inside the method prior to printing them using 
     * Console WriteLine. Utilize the conversion document from your resources.
     * a.Decimal b.Hexadecimal c.Binary
     */
    public void Number35()
    {
        // Decimal
        int DecimalOutput = 35;
        Console.WriteLine(DecimalOutput);
        // Hexadecimal
        // Note: The 0x tells us and the computer that it is in hexadecimal.
        int HexadecimalOutput = 0x23;
        Console.WriteLine(HexadecimalOutput);
        // Binary
        // Note: the b replaces 2nd to the zero before the first one.
        int BinaryOutput = 0b100011;
        Console.WriteLine(BinaryOutput);
    }

    /*
     * Write a method that will accept 3 argument parameters and a void return type. 
     * The first argument should be of type byte. The second argument should be of type short. 
     * The third argument should be of type int. Using Implicit conversion, create variables 
     * to convert to using the below information. Use the argument parameters as the values 
     * to convert from. Print each converted variable using Console WriteLine.
     * a.From byte to int b.From short to long
     */
    public void ImpConversion3arg(byte valByte, short valShort, int valInt)
    {
        // Convert from byte to int
        int convert1 = valByte;
        Console.WriteLine(convert1);

        // Convert from short to long
        long convert2 = valShort;
        Console.WriteLine(convert2);

        // Convert from int to float
        float convert3 = valInt;
        Console.WriteLine(convert3);
    }

    /*
     * Write a method that will accept 3 argument parameters and a void return type. 
     * The first argument should be of type double. The second argument should be of 
     * type float. The third argument should be of type long. Using Explicit conversion, 
     * create variables to convert to using the below information. Use the argument
     * parameters as the values to convert from. Print each converted variable using 
     * Console WriteLine. a.From double to long b.From float to int c.From long to short.
     */
    public void ExpConversion3arg(double valDouble, float valFloat, long valLong)
    {
        // Convert double to long
        long convert4 = (long)valDouble;
        Console.WriteLine(convert4);

        // Convert float to int
        int convert5 = (int)valFloat;
        Console.WriteLine(convert5);

        // Convert long to short
        short convert6 = (short)valLong;
        Console.WriteLine(convert6);
    }

    /*
     * Write a method with no arguments and a void return type. Using the values below, 
     * assign them to a variable that best suits their value type. Utilize the digit 
     * separator when assigning them to your variables. Once you have defined your variables, 
     * print out each one using Console WriteLine. Do not use the same value type more than 
     * once. a.123456.987 b.-9516248 c.3500 d.988562486 e.-19733.14895
     */
    public void TypeAssignment()
    {
        // A) 123,456.987
        double val1 = 123_456.987;
        Console.WriteLine(val1);

        // B) -9,516,248
        int val2 = -9_516_248;
        Console.WriteLine(val2);

        // C) 3,500
        short val3 = 3_500;
        Console.WriteLine(val3);

        // D) 988,562,486
        uint val4 = 988_562_486U;
        Console.WriteLine(val4);

        // E) -19,733.14895
        decimal val5 = -19_744.14895M;
        Console.WriteLine(val5);

    }

} // end class
