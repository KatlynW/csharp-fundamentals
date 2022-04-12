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
// Lesson2Example();
// Exercise2();
// Lesson3Example();
// Exercise3();
// Lesson4Example();
Exercise4Example();


// Exercise 4 Control Flow
void Exercise4Example()
{
    Exercise4 myExercise4 = new Exercise4();
    myExercise4.ComparingStrings("Tom", "Tom");
    Console.WriteLine(myExercise4.GradeDescriptions('E'));
    myExercise4.DivisibleBy3();
}

// Lesson 4 Control Flow 
void Lesson4Example()
{
    Lesson4 myLesson4 = new Lesson4();
    // myLesson4.BasicIfStatement(11);
    // myLesson4.BasicIfElseStatement(11);
    // myLesson4.BasicIfElseChainStatement(5);
    // myLesson4.BasicAndOrCondition(20, 20);
    // Console.WriteLine(myLesson4.BasicTernaryExample(35));
    // myLesson4.BasicSwitchStatement(3);
    // myLesson4.BasicWhileStatement();
    // myLesson4.BasicDoStatement();
    // myLesson4.BasicForStatement();
    // myLesson4.BasicForEachStatement();
    myLesson4.BasicJumpStatement();
}

// Exercise 3 Operators
void Exercise3()
{
    Exercise3 myExercise3 = new Exercise3();
    Console.WriteLine(myExercise3.ModulusPractice(2));
    myExercise3.MathProblem();
    myExercise3.CompoundPractice(20, 3);
    myExercise3.BooleanOperatorPractice(false, false);
}

// Lesson 3 Operators and Overflow Checking
void Lesson3Example()
{
    Lesson3 myLesson3 = new Lesson3();
    // myLesson3.BasicCheckedOperator(14);
    // myLesson3.BasicCheckedExample2();
    // myLesson3.BasicUncheckedExample();
    // myLesson3.BasicMath();
    // myLesson3.BasicModulus(783);
    // myLesson3.BasicBooleanLogical(true, false);
    // myLesson3.BasicCompundExample(12, 35, 9);
    // myLesson3.BasicRelationalExample("Tom", "Tim");
    myLesson3.MyIncrDecrExample();

}


// Exercise 2 Strings
void Exercise2()
{
    Exercise2 myExercise2 = new Exercise2();
    myExercise2.StringMethodExamples(" EXERCISE two Lab ");
    myExercise2.PilcrowSign();
    myExercise2.JackAndJill();
    Console.WriteLine(myExercise2.MovieFavorites());
}

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
    myExercise.Number35();
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
