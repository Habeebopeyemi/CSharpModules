/*
 ##############################################
 ArrayTypeMismatchException
 ##############################################
 */
string[] names = { "Dog", "Cat", "Fish" };
Object[] objs = (Object[])names;

Object obj = (Object)13;
//objs[2] = "" + obj;
//objs[2] = obj; // ArrayTypeMismatchException occurs

//Console.WriteLine(objs[1]);

/*
 ##############################################
 DivideByZeroException
 ##############################################
 */
int number1 = 3000;
int number2 = 0;
//Console.WriteLine(number1 / number2); // DivideByZeroException occurs


/*
 ##############################################
 FormatException
 ##############################################
 */
int valueEntered;
string userValue = "two";
//valueEntered = int.Parse(userValue); // FormatException occurs

/*
 ##############################################
 IndexOutOfRangeException
 ##############################################
 */
int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
int[] values2 = new int[6];

//values2[values1.Length - 1] = values1[values1.Length - 1]; // IndexOutOfRangeException occurs
/*
 ##############################################
 InvalidCastException
 ##############################################
 */

object objj = "This is a string";
//int num = (int)objj; //Invalid cast operation

/*
 ##############################################
 NullReferenceException
 ##############################################
 */
int[] values = null;
for (int j = 0; j <= 9; j++) { 
    //values[j] = j * 2;
}
string? lowCaseString = null;
//Console.WriteLine(lowCaseString.ToUpper());

/*
 ##############################################
 OverflowException
 ##############################################
 */

decimal x = 400;
byte i;

//i = (byte)x; // OverflowException occurs
//Console.WriteLine(i);

/*
 ##############################################
 ##############################################
 */
/*
 ##############################################
 Access the properties of an exception object
 ##############################################
 */

try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
    try
    {
        //WriteMessage();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception caught in Process1: {ex.Message}");
    }
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;
    byte smallNumber;

    try
    {
        Console.WriteLine(float1 / float2);
        Console.WriteLine(number1 / number2);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
    }
    checked
    {
        try
        {
            smallNumber = (byte)number1;
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
        }
    }
}

/*
 ##############################################
 Catch separate exception types in a code block
 ##############################################
 */
// inputValues is used to store numeric values entered by a user
string[] inputValues = new string[] { "three", "9999999999", "0", "2" };

foreach (string inputValue in inputValues)
{
    int numValue = 0;
    try
    {
        numValue = int.Parse(inputValue);
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid readResult. Please enter a valid number.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("The number you entered is too large or too small.");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}