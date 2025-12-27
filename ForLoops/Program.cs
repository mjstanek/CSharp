// Created following along with the Microsoft Learn course:
// Iterate through a code block using for statement in C#
// in concurrence with the freeCodeCamp certification

// For loops have greater control over the looping capabilities
// For loops also only execute a set number of times


// Syntax: 
// "for" keyword 
// The parentheses to indicate the conditions of the looping
// the iterator variable --> "int i = 0;" which is also called the "initializer"
// The completion condition --> "i <= 10;"
//      The code will keep running until the completion condition is met
// The action for the code to take --> "i++"
//      The "iterator"
// Finally the Code Block - what happens each time the loop is run
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("");

// Counting backwards
for (int i = 10; i >= 0;  i--)
    Console.WriteLine(i);


Console.WriteLine("");

// Break condition
// We can use "break" to exit the loop conditionally

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7)
    {
        Console.WriteLine("Lucky 7s!");
        break;
    }
}

Console.WriteLine("");

// Looping through lists
string[] names = { "Ben", "Luke", "Han", "Leia", "Chewy" };
/*
for (int i = names.Length -1; i>=0; i--)
{
    Console.WriteLine(names[i]);
}
*/
// We cannot use a foreach loop to replace items in a list

/*
 * foreach (var name in names)
 * {
 *      if (name == "Ben")
 *      {
 *          name = "Obi-Wan";
 *      }
 * }
 */

// But we can use the for loop and indexing to replace the name
for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "Ben")
    {
        names[i] = "Obi Wan";
    }
}

foreach (string name in names) Console.WriteLine(name);

Console.WriteLine("\n========== Challenge ==========\n");

// FizzBuzz!
// Print numbers from 1 to 100
// If a number is divisible by 3, add " - Fizz"
// If a number is divisible by 5, add " - Buzz"
// If a number is divisible by both 3 and 5, add " - FizzBuzz"

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    else
    { 
        Console.WriteLine(i); 
    }
}