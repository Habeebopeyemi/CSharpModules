/*
Exercise - Perform addition with implicit data conversion
*/

/*
Add two numeric values
*/
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

/*
Mix data types to force implicit type conversions
*/
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

/*
Attempt a more advanced case of adding numbers and concatenating strings
*/
string lastName = "Bob";
int widgetsSale = 7;
Console.WriteLine(lastName + " sold " + widgetsSale + 7 + " widgets.");

/*
Add parentheses to clarify your intention to the compiler
*/
string name = "Bob";
int widgetsSales = 7;
Console.WriteLine(name + " sold " + (widgetsSales + 7) + " widgets.");

/*
Write code to perform addition, subtraction, multiplication, 
and division with integers
+ is the addition operator
- is the subtraction operator
* is the multiplication operator
/ is the division operator
*/
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

/*
Add code to perform division using literal decimal data
NOTE:For this to work, the quotient (left of the assignment operator) 
must be of type decimal and at least one of numbers being divided must 
also be of type decimal (both numbers can also be a decimal type).
*/
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");
// decimal decimalQuotient = 7 / 5.0m;
// decimal decimalQuotient = 7.0m / 5.0m;

// However, the following lines of code won't work (or give inaccurate results):
/*
int Quotient1 = 7 / 5.0m;
int Quotient2 = 7.0m / 5;
int Quotient3 = 7.0m / 5.0m;
*/
decimal decimalQuotient1 = 7 / 5;
Console.WriteLine(decimalQuotient1);

/*
Add code to perform division using literal decimal data.
data type cast from int to decimal.
Note:You've seen three uses for the parenthesis operator:
    method invocation,
    order of operations
    and casting.
*/
int first = 7;
int second = 5;
decimal newquotient = (decimal)first / (decimal)second;
Console.WriteLine(newquotient);

/*
Write code to determine the remainder after integer division
*/
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

/*
Order of operations
In math, PEMDAS is an acronym that helps students remember the order of operations. The order is:
    Parentheses (whatever is inside the parenthesis is performed first)
    Exponents
    Multiplication and Division (from left to right)
    Addition and Subtraction (from left to right)

C# follows the same order as PEMDAS except for exponents. 
While there's no exponent operator in C#, you can use the "System.Math.Pow" 
*/
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

/*
Exercise - Increment and decrement values
NOTE: Operators like +=, -=, *=, ++, and -- are known as compound assignment 
operators because they compound some operation in addition to assigning the 
result to the variable. The += operator is specifically termed the addition 
assignment operator.
*/

int value = 0;     // value is now 0.
value = value + 5; // value is now 5.
value += 5;        // value is now 10.

int value3 = 0;     // value3 is now 0.
value3 = value3 + 1; // value3 is now 1.
value3++;           // value3 is now 2.

/*
Position the increment and decrement operators
*/
int value4 = 1;
value4++;
Console.WriteLine("First: " + value4);
Console.WriteLine($"Second: {value4++}");
Console.WriteLine("Third: " + value4);
Console.WriteLine("Fourth: " + (++value4));

/*
convert Fahrenheit to Celsius
solution1:

int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");

solution2: below
*/
int fahrenheit = 94;
decimal celcius = (fahrenheit - 32)*((decimal)5/9);
Console.Write("The temperature is ");
Console.Write($"{celcius}");
Console.Write(" ");
Console.WriteLine("Celcius.");