/*
 character escape sequences
    \ \n \t \r \\ \u
*/

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"!");
Console.WriteLine("c:\\source\\repos");

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.WriteLine(@"c:\invoices");
/*
    Verbatim string literal
        A verbatim string literal will keep all whitespace and characters without the need to escape the backslash.
        To create a verbatim string, use the @ directive before the literal string.
*/
Console.WriteLine(@"\n    c:\source\repos    
        (this is where your code goes)");
/*
Unicode escape characters
*/
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

/*
string concatenation
*/
string firstName = "Bob";
string greeting = "Hello";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message);

string firstName = "Bob";
string greeting = "Hello";
string message = $"{greeting} {firstName}!";
Console.WriteLine(message);

/*
Use string interpolation with multiple variables and literal strings
*/
int version = 11;
string updateText = "Update to Windows";
string message1 = $"{updateText} {version}";
Console.WriteLine(message1);

/*
Avoid intermediate variables
*/
int version2 = 11;
string updateText2 = "Update to Windows";
Console.WriteLine($"{updateText2} {version2}!");

/*
Combine verbatim literals and string interpolation
*/
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

/*
Exercise
*/
string projectName = "ACME";
Console.WriteLine("View English output:\n\t"+$@"c:\Exercise\{projectName}\data.txt");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.Write("\n"+russianMessage+":\n\t"+$@"c:\Exercise\{projectName}\ru-RU\data.txt");