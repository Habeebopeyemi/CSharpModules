/*
 ##########################################
Exercise 1: Methods to calculate discounts
            on goods purchased and output
            formatted result to the console
 ##########################################
 */

using System.Runtime;

double total = 0;
double minimumSpend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

for (int i = 0; i < items.Length; i++)
{
    //total += GetDiscountedPrice(i);
}

//total -= TotalMeetsMinimum() ? 5.00 : 0.00;

//Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    return input.ToString().Substring(0, 5);
}

/*
 ##########################################
Exercise 2: currency converter
 ##########################################
 */

double usd = 23.73;
//int vnd = UsdToVnd(usd);

//Console.WriteLine($"${usd} USD = ${vnd} VND");
//Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd)
{
    int rate = 23500;
    return (int)(rate * usd);
}

double VndToUsd(int vnd)
{
    double rate = 23500;
    return vnd / rate;
}

/*
 ##########################################
Exercise 3: reversing a string method
 ##########################################
 */

//Console.WriteLine($"Life is reversed to:   {ReverseWord("Life")}");
string ReverseWord(string word)
{
    string result = "";
    
    for(int i = word.Length - 1; i >= 0; i-- ) { result += word[i]; }

    return result;
}

/*
 ##########################################
Exercise 4: reversing a sentence method
 ##########################################
 */

//Console.WriteLine($"Life is such a funny place: is reversed to: {ReverseSentence("Life is such a funny place")}");
string ReverseSentence(string input)
{
    string result = "";
    string[] words = input.Split(" ");

    for(int i = 0; i < words.Length; i++)
    {
        result += ReverseWord(words[i])+" ";
    }
    
    result = result.Trim();

    return result;
}

/*
 ##########################################
Exercise 5: method returning a boolean
 ##########################################
 */
string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

//Console.WriteLine("Is it a palindrome?");
foreach (string word in words)
{
   // Console.WriteLine($"{word}: {IsPalindrome(word)}");
}
bool IsPalindrome(string word)
{
    string reverseWord = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        reverseWord += word[i];
    }
    if (word != reverseWord) return false;

    /*
     * OR
     * 
     * int start = 0;
    int end = word.Length - 1;

    while (start < end)
    {
        if (word[start] != word[end])
        {
            return false;
        }
        start++;
        end--;
    }
    */

    return true;
}

/*
 ##########################################
 Exercise 6: method returning am array
 ##########################################
 */

int target = 60;
int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
/*int[] result = TwoCoins(coins, target);

if (result.Length == 0)
{
    Console.WriteLine("No two coins make change");
}
else
{
    Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
}*/
int[] TwoCoins(int[] coins, int target)
{
    for (int curr = 0; curr < coins.Length; curr++)
    {
        for (int next = curr + 1; next < coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                return new int[] { curr, next };
            }

        }
    }

    return new int[0];
}

/*
 ##########################################
 Exercise 6b: method returning am array
             Advanced number 6 exercise
 ##########################################
 */

int targetB = 60;
int[] coinsB = new int[] { 5, 55, 50, 25, 25, 10, 5 };

/*int[,] result = TwoCoinsB(coinsB, targetB);

if (result.Length == 0)
{
    Console.WriteLine("No two coins make change");
}
else
{
    for(int i = 0; i < result.GetLength(0); i++)
    {
        if (result[i, 0] == -1 && result[i, 1] == -1) break;

        Console.WriteLine($"Change found at positions {result[i,0]} and {result[i,1]}");
    }
}*/

int[,] TwoCoinsB(int[] coins, int target)
{
    int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } }; ;
    int resultIndex = 0;
    for (int curr = 0; curr < coins.Length; curr++)
    {
        for (int next = curr + 1; next < coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                result[resultIndex, 0] =  curr;
                result[resultIndex, 1] = next;

                resultIndex++;
            }

        }
    }
    if (result.Length > 0) return result;
    //return (count == 0) ? new int[0,0] : result;
    return new int[0,0];
}

/*
 ##########################################
 Challenge: Dice mini-game
 ##########################################
 */

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    string? readResult;

    readResult = Console.ReadLine();
    while (readResult == null)
    {
        Console.WriteLine("Invalid input: type either (Y/N)");
    }

    if (readResult.Length > 1)
    {
        Console.WriteLine("Invalid input: type either (Y/N)");
        while (readResult == null)
        {
            Console.WriteLine("Invalid input: type either (Y/N)");
        }
    }
    else
    {
        return readResult.ToLower() == "n" ? false : true;
    };

    return true;
}
int GetTarget()
{
    return random.Next(1, 6);
}

int RollDice()
{
    return random.Next(1, 7);
}
string WinOrLose(int roll, int target)
{
    return roll > target ? "You win!" : "You lose!";
}