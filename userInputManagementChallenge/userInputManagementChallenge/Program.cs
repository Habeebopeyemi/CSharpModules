/*
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);
 */

string? readResult;
bool isValid = false;
int numericValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");
do
{
    readResult = Console.ReadLine();
    if(readResult != null)
    {
        validNumber = int.TryParse(readResult, out numericValue);
        isValid = true;

        if(validNumber)
        {
            if(numericValue < 5 || numericValue > 10)
            {
                Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
                continue;
            }
            else
            {
                Console.WriteLine($"Your input value ({numericValue}) has been accepted.\r\n");
                break;
            }
        }
        else
        {
            Console.WriteLine("Sorry, you entered an invalid number, please try again");
            continue;
        }

    }
    else
    {
        Console.WriteLine("Insert a valid input");
    }
}
while (isValid);
