using MyFirstApplication;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// The below statement calls a local function
// single line comment

// BottlesofBeer bottles = new BottlesofBeer();
// bottles.LetsSing();

/*
 Multi-line comment
The below statement is a local function. Local functions 
are inside of members and are private by default. This means 
they are specific to that member and can only be called
inside that member.
 */


// Lesson Examples
// HouseExample();
// MyLocalFunction();
// Lesson1Example();
// Exercise1();
Lesson2Example();



// Lesson 2 Strings
void Lesson2Example()
{
    Lesson2 mylesson2 = new Lesson2();
    mylesson2.MyTrimExample();
    int able = mylesson2.MyStringLength();
    Console.WriteLine(able);
    mylesson2.MyEqualsExample("Hello World");
    mylesson2.MyExampleChar();
    Console.WriteLine(mylesson2.MyEscapeExample());
    mylesson2.MyJoinedStrings("CSharp", "Rules");
    Console.WriteLine(mylesson2.MyInterpolationExample("pizza", 3));
    mylesson2.MyOtherInterpolation();

}

void HouseExample()
{
    House myHouse = new House();
    myHouse.DoorOpenClose();
}

// Lesson 1 Value Types
void Lesson1Example()
{
    Lesson1 myLesson = new Lesson1();
    myLesson.IntMinMax();
    myLesson.IntegralExample();
    myLesson.ConvertFloatToInt();
    myLesson.LongFromInt();
}

// Exercise1 Value Types
void Exercise1()
{
    Exercise1 myExercise = new Exercise1();
    myExercise.Number32();
    myExercise.ImpConversion3arg(2, 6, 25685);
    myExercise.ExpConversion3arg(12.34D, -123.6589F, 123456789L);
    myExercise.TypeAssignment();
}

/*
 This local function is for my first(intro) exercise lab.
 */
void MyLocalFunction()
{
    Console.WriteLine("This is my first sentence");
    Console.WriteLine("I am new to Csharp");
    Console.WriteLine("This Csharp course is cool");
    Console.WriteLine("I am learning stuff everyday.");
}
