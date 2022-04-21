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
// Exercise4Example();
// Lesson5Example();
// Exercise5Example();
// Lesson6Examples();
// Exercise6Examples();
// Lesson7Examples();
// Exercise7Examples();
// Lesson8Examples();
Exercise8Examples();


// Exercise 8
void Exercise8Examples()
{
    Exercise8 myExercise8 = new Exercise8();
    myExercise8.FeetToInches(3);
    myExercise8.CalculateArea(4, 5);
}


// Lesson 8
void Lesson8Examples()
{
    Lesson8 myLesson8 = new Lesson8(3);
    // calling constant directly
    Console.WriteLine(Lesson8.DaysPerMonth);

    // Calculate Temperature
    Console.WriteLine(Lesson8Static.CelciusToFahrenheit(45.6));

    // Static Methods
    Lesson8.DayCount = 10;
    myLesson8.CalculateHours();
    Lesson8.CalculateDayCount();
    Console.WriteLine($"The calcualte has been done {Lesson8.DayCount} times");

    // Static Lambda
    myLesson8.CalculateHoursV2();
}

void Exercise7Examples()
{
    Employee employee = new Employee(10, "Tom");
    Console.WriteLine(employee);
    Console.WriteLine(employee.Name);
    myBoat firstBoat = new myBoat();
    firstBoat.BoatDockUndock();

}

// Lesson 7 Records and Structs
void Lesson7Examples()
{
    Location myLocation = new Location(34.5, 47.8);
    Console.WriteLine(myLocation.Latitude);
    Console.WriteLine(myLocation);

    // Readonly Struct
    Student myStudent = new Student(10, "Roger");
    Console.WriteLine(myStudent);
    Console.WriteLine(myStudent.StudentName);

    // Record
    Person person = new Person("Nancy", "Drew");
    Console.WriteLine(person);
    Console.WriteLine(person.lastName);

    // Struct Record
    Resolution res = new Resolution(1920, 1080);
    res.CalculateRes();
    Console.WriteLine(res);

}

// Exercise 6 Constructors, Methods, and More
void Exercise6Examples()
{
    Exercise6 myExercise6 = new Exercise6(9, "Tennis");
    Exercise6.TryOn theShoe = myExercise6.TryItOn;
    theShoe($"I tried on the {myExercise6.ShoeType} shoes in size {myExercise6.ShowSize}.");

}

// Lesson 6 Constrctors, Methods, and More
void Lesson6Examples()
{
    // default Constructor
    Lesson6 myLesson6 = new Lesson6();
    Lesson6 myLessonHats = new Lesson6("Cowboy", 7);
    Lesson6.TryOn theHat = myLessonHats.TryOnHat;
    theHat($"I tried on a {myLessonHats.HatType} hat that was size {myLessonHats.HatSize}");

    Console.WriteLine();

    // Constructor with 1 parameter
    Lesson6 myOther6 = new Lesson6(22);

    // Constructor with 2 parameters
    Lesson6 myHats = new Lesson6("Cowboy", 7);
    Console.WriteLine(myHats.HatSize); // getting value
    myHats.HatSize = 6; // setting value


    // Method Parameter Modifiers
    int able = 33, beta = 22, charlie;
    myLesson6.InExample(able);
    myLesson6.RefExample(ref beta);
    Console.WriteLine(beta);
    myLesson6.OutExample(out charlie);
    Console.WriteLine(charlie);

    Console.WriteLine();

    // Multicast Delegate
    Lesson6.TryOn theNewHat, hangTheHat, multiHat;
    theNewHat = myLesson6.TryOnHat;
    hangTheHat = myLesson6.HangUpHat;
    multiHat = theNewHat + hangTheHat;

    theNewHat($"Trying a {myLessonHats.HatType} hat");
    hangTheHat($"Hanging up my {myLessonHats.HatType} hat");
    multiHat($"My {myLessonHats.HatType} hat");

}


// Exercise 5 Expression and Pattern Matching
void Exercise5Example()
{
    Exercise5 myExercise5 = new Exercise5();
    Console.WriteLine(myExercise5.FunctPractice(4, 4));
    Console.WriteLine(myExercise5.GradeExpression('E'));
    myExercise5.PopcornSize(40);
}

// Lesson 5 Expression and Pattern Matching 
void Lesson5Example()
{
    Lesson5 myLesson5 = new Lesson5();

    // Call method of Lesson 5
    // myLesson5.IsOperatorSample(34);

    Lesson5.Del handler = myLesson5.DelegateMethod;
    // handler("Hello CSharp");

    // Funct Delegate
    Func<int, int> add = myLesson5.Sum;
    // Console.WriteLine($"funct example = {add(23)}");

    // Lambda Expression
    // myLesson5.LambdaSquare();
    // myLesson5.LambdaGreeting();

    // Switch Expression
    // Console.WriteLine(myLesson5.BasicSwitch("red"));
    string value1 = myLesson5.FavoriteColor("green");
    // Console.WriteLine(value1);

    // Relational Pattern
    // myLesson5.DrinkSize(33);

    // Logical Pattern And
    myLesson5.TemperatureGuide(48.6);

    // Logical Pattern Or
    myLesson5.NumberChoice(3);

}


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
