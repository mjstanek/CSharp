// Completed while following along with the Microsoft Learn Course:
// Perform operations on arrays using helper methods in C#
// in concurrence with the freeCodeCamp Certification

// The goal of this file is to practice with arrays and functions on arrays
// Sorting, Clearing, Resixing, splitting, joining

using System.Security.Authentication;

string[] pallets = ["B14", "A11", "B12", "A13"];

Console.WriteLine("Sorting...");
Array.Sort(pallets);
foreach (string pallet in pallets)
{
    Console.WriteLine(pallet);
}

Console.WriteLine("\nReversing...");
Array.Reverse(pallets);
foreach(string pallet in pallets)
{
    Console.WriteLine(pallet);
}

Console.WriteLine("\nClearing two pallets");
Array.Clear(pallets, 0, 2);
foreach (string pallet in pallets)
{
    Console.WriteLine(pallet);
}

Console.WriteLine("\nResizing to six pallets");
Array.Resize(ref pallets, 6);

pallets[4] = "C01";
pallets[5] = "C02";

foreach (string pallet in pallets)
{
    Console.WriteLine(pallet);
}

Console.WriteLine("\nResizing to three pallets");
Array.Resize (ref pallets, 3);

foreach( string pallet in pallets)
{
    Console.WriteLine(pallet);
}

Console.WriteLine("\nToCharArray()");

string value = "abc123";
Console.WriteLine(value);
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);
string joinedResult = String.Join(",", valueArray);
Console.WriteLine(joinedResult);

string[] items = joinedResult.Split(',');  
foreach (string item in items)
{
    Console.WriteLine(item); 
}

Console.WriteLine("\n========== Challenge - Reverse words in Message ==========");
// This challenge is to take a string and print the words in the same order
// but with the characters in the word reveresed --> "The" becomes "ehT"

string panagram = "The quick brown fox jumps over the lazy dog";
string outputPanagram = "";

string[] splitPanagram = panagram.Split(" ");
foreach (string item in splitPanagram)
{
    char[] itemArray = item.ToCharArray();
    Array.Reverse(itemArray);
    string itemString = new string(itemArray);
    if (outputPanagram == "")
    {
        outputPanagram += itemString;
    }
    else
    {
        outputPanagram += " " + itemString;
    }
}

Console.WriteLine(outputPanagram);

Console.WriteLine("\n========== Challenge - Parse String Array ==========");
// This challenge is designed to simulate an incoming data stream of Order IDs
// The goal is to parse the Order IDs, print them all separately, and tag any
// Order IDs that have potential errors

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderArray = orderStream.Split(",");
Array.Sort(orderArray);

foreach (string item in orderArray)
{
    string orderOutput = item;
    char[] singleOrder = item.ToCharArray();
    if (singleOrder.Length != 4)
    {
        orderOutput += "\t-\tError";
    }
    Console.WriteLine(orderOutput);
}
