
namespace MyFirstApplication;

/*
 This class contaisn examples from Lesson 14 Arrays
 */
internal class Exercise14
{
    /*
     Write a method with no parameters and no return type. Write a single dimensional string 
    array of ice cream flavors. Using a foreach loop in your method, print out the results 
    of your array using a Console WriteLine statement.
     */

    public void IceCreamFlavors()
    {
        string[] icecream = { "chocolate", "vanilla", "strawberry", "Rocky Road" };

        foreach(string flavor in icecream)
        {
            Console.WriteLine(flavor);
        }
    }


    /*
     Write a method with no parameters and no return type. Write a two-dimensional array 
    using the int data type. Using the link in the instructions, fill in each dimension with 
    the KC Chiefs Regular season scores. The first dimension will be the home team, while the 
    second dimension will be the away team. Using a foreach loop, print out the results of 
    your array using a Console WriteLine statement. To determine which team is home and away, 
    the website includes the link to the box score. The link label shows both teams. The 
    first team in the label is the away team.
     */

    public void TeamScores()
    {
        // Array Setup
        int[,] teamScores = { { 34, 20}, {20, 23}, {20, 34}, {26, 10}, {32, 40}, {17, 26},
            {16, 43},{35, 9}, {33, 31}, {31, 35}, {24, 27}, {22, 16}, {27, 33}, {29, 32},
            {17, 14}, {21, 38} };

        // Array Usage
        foreach(int score in teamScores)
        {
            Console.WriteLine(score);
        }
    }

} // end class
