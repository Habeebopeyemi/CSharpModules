/*
 * ```Output
 * Signed integral types:
 * sbyte : -128 to 127
 * short : -32768 to 32767
 * int : -2147483648 to 2147483647
 * long : -9223372036854775808 to 9223372036854775807

 * Unsigned integral types:
 * byte   : 0 to 255
 * ushort : 0 to 65535
 * uint   : 0 to 4294967295
 * ulong  : 0 to 18446744073709551615
 * 
 * Floating point types:
 * float  : -3.402823E+38 to 3.402823E+38 (with ~6-9 digits of precision)
 * double : -1.79769313486232E+308 to 1.79769313486232E+308 (with ~15-17 digits of precision)
 * decimal: -79228162514264337593543950335 to 79228162514264337593543950335 (with 28-29 digits of precision)
 
 * When in doubt, stick with the basics
    While you've looked at several considerations, as you're getting started, for simplicity's sake you should prefer a subset of basic data types, including:

    int --> for most whole numbers
    decimal -->  for numbers representing money
    bool -->  for true or false values
    string -->  for alphanumeric value

 * Choose specialty complex types for special situations
    Don't reinvent data types if one or more data type already exists for a given purpose. The following examples identify where a specific .NET data types can be useful:

     -->  byte: working with encoded data that comes from other computer systems or using different character sets.
     -->  double: working with geometric or scientific purposes. double is used frequently when building games involving motion.
     -->  System.DateTime for a specific date and time value.
     -->  System.TimeSpan for a span of years / months / days / hours / minutes / seconds / milliseconds.
```

Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal totalNumber = 0;
string finalWord = "";
foreach(string value in values)
{
    decimal currentNumber = 0;
    if(decimal.TryParse(value, out currentNumber))
    {
        totalNumber += currentNumber;
    }
    else
    {
        finalWord += value;
    }
}

Console.WriteLine($"Message: {finalWord} \nTotal: {totalNumber}");
 */

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
//int result1 = value1 / (int)value2;
int result1 = Convert.ToInt32(value1/value2);
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / (decimal)value3;
//decimal new2 = Convert.ToDecimal(""+value3);
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / (float)value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");