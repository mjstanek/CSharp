// Created while following along with the Microsoft Learn module
// Store and iterate through sequences of data using Arrays and the foreach statement in C#
// in conjunction with the freeCodeCamp certification

Console.WriteLine("========== Practice ==========");

// Create and initialize an array 

// Arrays in C# must have a defined type and size
// The square brackets [] indicate that the variable is an array
// The second square brackets indicate the size of the array
// in this case, 3 --> items 0, 1 and 2
// This is also an array of strings
string[] fraudulentOrderIDs = new string[3];

// Assign and retrieve values from an array

// Values can be assigned to the array using the index position
fraudulentOrderIDs[0] = "A123"; // the first item in the array is "A123"
fraudulentOrderIDs[1] = "B456"; // the second item in the array is "B456"
fraudulentOrderIDs[2] = "C789"; // the third item in the array is "C789"

// Values can be retrieved from the array the same way they are assigned
Console.WriteLine($"First Order: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second Order: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third Order: {fraudulentOrderIDs[2]}");

// Values can also be reassigned the same way they are assigned
fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"\nReassigned First Order: {fraudulentOrderIDs[0]}");

// If all data is known, the array can be initialized with data
string[] initializedOrderIds = ["A123", "B456", "C789"];

Console.WriteLine(initializedOrderIds[0] + " " + initializedOrderIds[1] 
    + " " + initializedOrderIds[2]);

// The Length method will reveal the number of elements in an array
Console.WriteLine($"\nThere are {fraudulentOrderIDs.Length} fraudulent orders to evaluate\n");

// Iterate through each element in an array using a foreach loop
// Syntax: foreach (datatype temporary variable "in" array) {code;}'

string[] names = ["Rowena", "Fergus", "Kevin"];
foreach (string name in names)
{
    Console.WriteLine(name);
}
// Arrays can use both square brackets and curly braces
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int item in inventory)
{
    sum += item;
    bin++;
    Console.WriteLine($"Bin number {bin} = {item} (Running Total: {sum})");
}
Console.WriteLine($"\nOur total inventory is {sum} items.");

Console.WriteLine("\n========== Challenge ==========\n");

/* Challenge: 
 * Order IDs that start with a "B" are 25x more likely to be fraudulent
 * Loop through a list of given order IDs to pull out the order IDs that start with "B"
 * This can be accomplished with the string method "StartsWith()"
*/

string[] ordersToParse = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
string fraudIndicator = "B";

foreach (string order in ordersToParse)
{
    if (order.StartsWith(fraudIndicator))
    {
        Console.WriteLine($"Potential Fraud! Order ID: {order}");
    }
}