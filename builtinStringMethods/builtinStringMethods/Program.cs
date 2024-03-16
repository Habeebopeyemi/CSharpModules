/*
 ###########################
   IndexOf() and Substring()
 ###########################


string message = "Find what is (inside the parentheses)";
string message2 = "What is the value <span>between the tags</span>?";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition2 = message2.IndexOf(openSpan);
int closingPosition2 = message2.IndexOf(closeSpan);

//Console.WriteLine($"{openingPosition}\n{closingPosition}");
openingPosition++;
int length = closingPosition - openingPosition;

openingPosition2 += openSpan.Length;
int length2 = closingPosition2 - openingPosition2;

Console.WriteLine(message.Substring(openingPosition, length));
Console.WriteLine(message2.Substring(openingPosition2, length2));
 */

/*
 ###########################
 IndexOfAny() and LastIndexOf()
 ###########################

string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = message.LastIndexOf('(');

openingPosition += 1;
int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

string message2 = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition2 = message2.IndexOf('(');
    if (openingPosition2 == -1) break;

    openingPosition2 += 1;
    int closingPosition2 = message2.IndexOf(')');
    int length2 = closingPosition2 - openingPosition2;
    Console.WriteLine(message2.Substring(openingPosition2, length2));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message2 = message2.Substring(closingPosition2 + 1);
}
*/

/*
 ###########################
 IndexOfAny()
 ###########################

string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");

string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}
*/

/*
 ###########################
 Remove() and Replace()
 ###########################


string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);
*/

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
string openSpan = "<span>";
string closingSpan = "</span>";

int openingIndex = input.IndexOf(openSpan);
int closingIndex = input.IndexOf(closingSpan);

openingIndex += openSpan.Length;

int length = closingIndex - openingIndex;

quantity = input.Substring(openingIndex, length);
output = input.Replace("trade", "reg");

string openingTag = "<div>";
string closingTag = "</div>";

int openingTagIndex = output.IndexOf(openingTag);
int closingTagIndex = output.IndexOf(closingTag);

openingTagIndex += openingTag.Length;

int outputLength = closingTagIndex - openingTagIndex;

output = output.Substring(openingTagIndex, outputLength);
Console.WriteLine(quantity);
Console.WriteLine(output);