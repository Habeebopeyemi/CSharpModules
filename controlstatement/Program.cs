/*
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if (total > 14)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}

string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}
*/

/*
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

if ((roll1 == roll2) && (roll2 == roll3)) 
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}
*/

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
if(daysUntilExpiration == 0){
    Console.WriteLine(daysUntilExpiration);
    Console.WriteLine("Your subscription has expired.");
}else if(daysUntilExpiration == 1){
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires within a day!");
}
else if(daysUntilExpiration <= 5){
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
}else if(daysUntilExpiration <= 10){
    Console.WriteLine(daysUntilExpiration);
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if(discountPercentage > 0){
    Console.Write($"Renew now and save {discountPercentage}%!\n");
}
//how to confirm the data type of a variable
Console.WriteLine("discountPercentage".GetType());

// Type your username and press enter
Console.WriteLine("Enter username:");

// Create a string variable and get user input from the keyboard and store it in the variable
string userName = Console.ReadLine();

// Print the value of the variable (userName), which will display the input value
Console.WriteLine("Username is: " + userName);

//reading the first char in the form of an integer input
// Console.WriteLine("Enter a char:");

// int newName = Console.Read();
// char newNameChar = (char)newName;
// Console.WriteLine($"{newName}, {newNameChar}");

Console.WriteLine("Enter your age:");
int ageInput = Convert.ToInt32(Console.ReadLine());
bool isAdult = ageInput >= 18 ? true : false;
Console.WriteLine($"You are {(isAdult ? "" : "not")} an adult.");

