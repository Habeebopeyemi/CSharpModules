// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello World!");
Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code.");
Console.WriteLine('b');     //char literal
Console.WriteLine(123);     //integer literal
Console.WriteLine(0.25F);   //float literal
Console.WriteLine(2.625);   //double literal
Console.WriteLine(12.39816m);   //decimal literal
Console.WriteLine(true);
Console.WriteLine(false);       //bool literal

Console.WriteLine("123");
Console.WriteLine(123);

Console.WriteLine("true");
Console.WriteLine(true);
/*
in general here are few common data types in c#
    string
    char
    int
    decimal
    bool
*/

/*
 This section deals with declaring of variables.
 Rules guiding naming of variable:
    Variable names can contain alphanumeric characters and the underscore character. Special characters like the hash symbol # (also known as the number symbol or pound symbol) or dollar symbol $ are not allowed.
    Variable names must begin with an alphabetical letter or an underscore, not a number.
    Variable names are case-sensitive, meaning that string Value; and string value; are two different variables.
    Variable names must not be a C# keyword. For example, you cannot use the following variable declarations: decimal decimal; or string string;.

Here are some coding conventions for variables:
    Variable names should use camel case, which is a style of writing that uses a lower-case letter at the beginning of the first word and an upper-case letter at the beginning of each subsequent word. For example, string thisIsCamelCase;.
    Variable names should begin with an alphabetical letter. Developers use the underscore for a special purpose, so try to not use that for now.
    Variable names should be descriptive and meaningful in your app. Choose a name for your variable that represents the kind of data it will hold.
    Variable names should be one or more entire words appended together. Don't use contractions or abbreviations because the name of the variable (and therefore, its purpose) may be unclear to others who are reading your code.
    Variable names shouldn't include the data type of the variable. You might see some advice to use a style like string strValue;. That advice is no longer current.
*/

/*
string firstName;
char userOption;
int gameScore;
decimal particlesPerMillion;
bool processedCustomer;
*/

string firstName;
firstName = "Habeeb";
Console.WriteLine(firstName);
firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);

/*
    implicitly typed local variable
    NOTE: variable using the var keyword must be initialized instantly, else, you get error

    Why use the var keyword?
        The var keyword has an important use in C#. 
        Many times, the type of a variable is obvious from its initialization. 
        In those cases, it's simpler to use the var keyword. 
        The var keyword can also be useful when planning the code for an application. 
        When you begin developing code for a task, you may not immediately know what data type to use. 
        Using var can help you develop your solution more dynamically.
*/

var message = "Hello world!";
// message = 10.703m;

string lastName = "Bob";
int numberOfMessages = 3;
float temperature = 43.4F;

string newMessage1 = "Hello, "+lastName+"! You have "+numberOfMessages+" messages in your inbox.";
string newMessage2 = "The temperature is "+temperature+" celcius.";

Console.Write(newMessage1);
Console.Write(" ");
Console.WriteLine(newMessage2);
Console.WriteLine(34.40M);
