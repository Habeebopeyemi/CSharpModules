string? userInput;
bool isValid = false;

Console.WriteLine("Enter your role name (Administrator, Manager, or User)\r\n");

do
{
    userInput = Console.ReadLine();
    if (userInput == null)
    {
        Console.WriteLine("Input a valid role");
        isValid = true;
    }
    else
    {
        switch (userInput.Trim().ToLower())
        {
            case "administrator":
            case "manager":
            case "user":
                isValid = false;
                Console.WriteLine($"Your input value ({userInput}) has been accepted.\r\n");
                break;
            default: 
                isValid = true;
                Console.WriteLine($"The role name that you entered, \"{userInput}\" is not valid. Enter your role name (Administrator, Manager, or User)\r\n");
                break;
        }
    }
}while (isValid);