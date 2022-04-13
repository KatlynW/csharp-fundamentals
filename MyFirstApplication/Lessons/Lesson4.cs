﻿
namespace MyFirstApplication;

/* Lesson 4 - Control Flow Statements */
public class Lesson4
{
    // Basic If Statement
    public void BasicIfStatement(int value)
    {
        Console.WriteLine("Before if statement");
        if (value > 10){
            Console.WriteLine($"Our {value} is greater than 10");
        }
        Console.WriteLine("After if statement");
    }

    // Basic If Else Statement
    public void BasicIfElseStatement(int able)
    {
        if (able >= 15)
        {
            Console.WriteLine($"Our {able} is greater than or equal to 15");
        }
        else
        {
            Console.WriteLine($"Our {able} was less than 15");
        }
    }

    // Basic If Else Chain
    public void BasicIfElseChainStatement(int beta)
    {
        if (beta == 10)
        {
            Console.WriteLine($"Our {beta} is 10.");
        }
        else if (beta == 20)
        {
            Console.WriteLine($"Our {beta} is 20.");
        }
        else
        {
            Console.WriteLine($"Our {beta} is not the same.");
        }
    }

    // Basic If with Boolean Logical Operators
    public void BasicAndOrCondition(int charlie, int delta)
    {
        if (charlie > 15 & delta < 30){
            Console.WriteLine($"{charlie} and {delta}");
        }
        if (charlie == 18 || delta < 25)
        {
            Console.WriteLine($"{charlie} or {delta}");
        }
    }

    // Ternary Operator
    public bool BasicTernaryExample(int echo)
    {
        return  (echo > 30) ? true : false;
    }

    // Switch Statement
    public void BasicSwitchStatement(int able)
    {
        switch (able)
        {
            case 1:
            case 2:
                Console.WriteLine($"{able} is 1 or 2.");
                break;
            case 3:
                Console.WriteLine($"{able} is 3. ");
                break;
            case 4:
                Console.WriteLine($"{able} is 4.");
                break;
            default:
                Console.WriteLine($"{able} is not in the list.");
                break;
        }
    } // end method

    // While Statement
    public void BasicWhileStatement()
    {
        int fox = 0; // initialization
        while (fox < 10) // condition
        {
            Console.WriteLine($"Number = {fox}");
            fox++; // Increment
        }
    }

    // Do Statement
    public void BasicDoStatement()
    {
        int hotel = 0; // initializaiton
        do
        {
            Console.WriteLine($"Do Number = {hotel}.");
            hotel++; // Increment
        } while (hotel < 13); // condition
    }

    // for Statement
    public void BasicForStatement()
    {
        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine($"For Number = {i}");
        }
    }

    // foreach statement
    public void BasicForEachStatement()
    {
        foreach (char word in "Something")
        {
            Console.WriteLine($"Char value  = {word}");
        }
    }

    // Jump Statement
    public void BasicJumpStatement()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 2)
            {
                Console.WriteLine($"The {i} was skipped");
                continue;
            }
            if (i == 4)
            {
                Console.WriteLine($"The loop breaks at {i}");
                break;
            }
            Console.WriteLine($"Numbmer = {i}");
        }
    }

} // end class