// Created following along with the Microsoft Learn course:
// Control variable scope and logic using code blocks in C#
// In conjunction with the freeCodeCamp certification

/*
 * Variable scope refers to where the variable is visible
 * when a variable is initialized outside of a code block (a set of curly braces {})
 * the variable is visible inside the code block. Variables initialized inside 
 * of a code block are local and only accessible in the code block. It is also possible
 * to use if-else if-else statements without the curly braces, but choose a format
 * that improves readability and stick with one theme.
 */

bool flag = true;
int value = 0;
if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}
value = 10;
Console.WriteLine($"Outside the code block: {value}");

if  (flag) Console.WriteLine(flag);

string name = "steve";
if (name == "bob") 
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else 
    Console.WriteLine("Found Chuck");

Console.WriteLine("\n========== Challenge ==========");

// Update this Code:
/*
 * int[] numbers = { 4, 8, 15, 16, 23, 42 };

foreach (int number in numbers)
{
    int total;

    total += number;

    if (number == 42)
    {
       bool found = true;

    }

}

if (found) 
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");
 */

int[] numbers = { 4, 8, 15, 16, 23, 42 };
bool found = false;
int total = 0;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
    {
        found = true;
    }
}

if (found)
{
    Console.WriteLine("Set contains 42");
}

Console.WriteLine($"Total: {total}");