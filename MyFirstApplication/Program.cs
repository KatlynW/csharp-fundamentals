using MyFirstApplication;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// The below statement calls a local function
// single line comment
HouseExample();

/*
 Multi-line comment
The below statement is a local function. Local functions 
are inside of members and are private by default. This means 
they are specific to that member and can only be called
inside that member.
 */
void HouseExample()
{
    House myHouse = new House();
    myHouse.DoorOpenClose();
}


/*
 This local function is for my first exercise lab.
 */
void MyLocalFunction()
{
    Console.WriteLine("This is my first sentence");
    Console.WriteLine("I am new to Csharp");
    Console.WriteLine("This Csharp course is cool");
    Console.WriteLine("I am learning stuff everyday.");
}

MyLocalFunction();
