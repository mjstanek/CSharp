// Created while following along with the Microsoft Learn Course:
// Modify the content of strings using built-in string data type methods in C#
// in concurrence with the freeCodeCamp certification

// Index Of and Substring
// Index Of finds the location of the first occurrence of a specified argument

using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);

openingPosition += 1;

int length = closingPosition - openingPosition;

// Substring can be called with one argument and returns all data after that position, inclusively
// If a second argument is passed, it will go that many characters from the start

Console.WriteLine(message.Substring(openingPosition, length));

string helloMessage = "hello there!";

int firstH = helloMessage.IndexOf('h');
int lastH = helloMessage.LastIndexOf('h');

Console.WriteLine($"The message: {helloMessage} has multiple \"H's\":\n" +
    $"The first at position {firstH} and the last at position {lastH}.");

string multiMessage = "(What if) I am (only interested) in the last (set of parentheses)?";

//int multiOpeningPosition = multiMessage.LastIndexOf('(');
//multiOpeningPosition += 1;

//int multiClosingPosition = multiMessage.LastIndexOf(')');
//int multiLength = multiClosingPosition - multiOpeningPosition;
//Console.WriteLine(multiMessage.Substring(multiOpeningPosition, multiLength));

while(true)
{
    int multiOpeningPosition = multiMessage.IndexOf('(');
    if (multiOpeningPosition == -1) 
        break;

    multiOpeningPosition += 1;
    int multiClosingPosition = multiMessage.IndexOf(')');
    int multiLength = multiClosingPosition - multiOpeningPosition;
    Console.WriteLine(multiMessage.Substring(multiOpeningPosition, multiLength));

    multiMessage = multiMessage.Substring(multiClosingPosition + 1);
}

// Index of Any returns the first index of the first character found
// i.e. there is no "a" in the helloMessage, so that is skipped. Then the program will
// search helloMessage for an "e" and will end execution when one is found at position 1
// and return the index 

char[] charsToFind = { 'a', 'e', 'i' };
int index = helloMessage.IndexOfAny(charsToFind);

Console.WriteLine($"Found '{helloMessage[index]}' in {helloMessage} at index {index}.");

string symbolMessage = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching this message: {symbolMessage}");

char[] openSymbols = { '[', '{', '(' };
int symbolStartPosition = 5;
int symbolOpening = symbolMessage.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using StartPosition: {symbolMessage.Substring(symbolOpening)}");

openingPosition = symbolMessage.IndexOfAny(openSymbols, symbolStartPosition);
Console.WriteLine($"Found WITH using StartPosition: {symbolMessage.Substring(symbolOpening)}");

// Remove and Replace
// Remove is used to remove data from a standard and consistent and known position

string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

// Replace is pretty self explanatory
string replaceMessage = "This--is--ex-amp-le--da-ta";
replaceMessage = replaceMessage.Replace("--", " ");
replaceMessage = replaceMessage.Replace("-", "");
Console.WriteLine(replaceMessage);

Console.WriteLine("\n========== Challenge ==========\n");
// This challenge is designed to test the ability of parsing strings, extracting data, and transforming data

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";
const string find = "trade";
const string replace = "reg";
const string openingTag = "<div>";
const string closingTag = "</div>";
const string openingQTag = "<span>";
const string closingQTag = "</span>";

output = input.Replace(openingTag, "");
output = output.Replace(closingTag, "");
output = output.Replace(find, replace);

int quantityOpening = output.IndexOf(openingQTag);
int quantityClosing = output.IndexOf(closingQTag);
quantityOpening += openingQTag.Length;
int quantityLength = quantityClosing - quantityOpening;

quantity = output.Substring(quantityOpening, quantityLength);

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");
