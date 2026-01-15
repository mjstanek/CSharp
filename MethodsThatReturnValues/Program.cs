// Created while following along with the Microsoft Learn Course
// Create C# methods that return values
// in concurrence with the freeCodeCamp certification

// The previous files all used void methods which simply output the values
// that were calculated. Methods can, however, return the calculated value
// so that the program can continue

double total = 0;
double minimumSpend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

total -= TotalMeetsMinimum() ? 5.00 : 0.00;

Console.WriteLine($"Total: ${FormatDecimal(total)}");

// This method is a double return type becuase it returns a double
double GetDiscountedPrice(int itemIndex)
{
    double result = items[itemIndex] * (1 - discounts[itemIndex]);
    // using the return keyword with a variable indicates that the variable will 
    // be passed out of the method for usage externally
    return result;
}

bool TotalMeetsMinimum()
{
    // the return keyword can also be passed with an expression
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    return input.ToString().Substring(0, 5);
}

Console.WriteLine();
// Return Numbers

double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd)
{
    int rate = 23500;
    return (int) (usd * rate);
}

double VndToUsd (int  vnd)
{
    double rate = 23500;
    return vnd / rate;
}

Console.WriteLine();
// Return a string

string input = "snake";
Console.WriteLine (input);
Console.WriteLine(ReverseWord(input));

string ReverseWord (string word)
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i --)
    {
        result += word[i];
    }

    return result;
}

string sentence = "there are snakes at the zoo";
Console.WriteLine (sentence);
Console.WriteLine(ReverseSentence(sentence));
string ReverseSentence(string input)
{
    string result = "";
    string[] words = input.Split(" ");

    foreach (string word in words)
    {
        result += ReverseWord(word) + " ";
    }

    return result.Trim();
}

Console.WriteLine();
// Return booleans

string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

Console.WriteLine("Is it a palindrome?");
foreach (string word in words)
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word)
{
    int start = 0;
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

    return true;
}

Console.WriteLine();
// Return arrays

int target = 60;
int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
int[,] result = TwoCoins(coins, target);

if (result.Length == 0)
{
    Console.WriteLine("No two coins make exact change");
}
else
{
    Console.WriteLine("Change found at positions:");
    for (int i = 0; i < result.GetLength(0); i++)
    {
        if (result[i, 0] == -1)
        {
            break;
        }
        Console.WriteLine($"{result[i, 0]}, {result[i, 1]}");
    }
}

int[,] TwoCoins(int[] coins, int target)
{
    int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
    int count = 0;

    for (int curr = 0; curr < coins.Length; curr++)
    {
        for (int next  = curr + 1; next < coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
            if (count == result.GetLength(0))
            {
                return result;
            }
        }
    }
    return (count == 0) ? new int[0, 0] : result;
}

Console.WriteLine("\n==========Challenge - Dice Mini Game==========\n");
// Create a mini-game that picks a random number between 1 and 5 (inclusive)
// the user must roll a single six-sided die to get a number greater than the random number
// at the end of the round, the game will ask if the player wants to play again

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
        int target = random.Next(1,6);
        int roll = random.Next(1,7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    bool validInput = false;
    bool continueGame = true;
    while (validInput == false)
    {
        string? input;
        input = Console.ReadLine().Trim();
        if (input != null)
        {
            input = input.ToLower();
            if (input == "y")
            {
                validInput = true;
                continueGame = true;
            }
            else if (input == "n")
            {
                validInput = true;
                continueGame = false;
            }
            else
            {
                Console.WriteLine("Sorry, I didn't catch that. Please only enter either 'Y' or 'N' to continue or exit.");
            }
        }
    }
    return continueGame;
}

string WinOrLose(int target, int roll)
{
    string result = "";
    if (roll > target)
    {
        result = "You win!";
    }
    else
    {
        result = "You lose!";
    }
    return result;
}

