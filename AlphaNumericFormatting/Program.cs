// Created while following along with the Microsoft Learn Course
// Format alphanumeric data for presentation in C#
// in conjunction with the freeCodeCamp certification

using System.Reflection.PortableExecutable;

Console.WriteLine("Composite formatting");
// Composite formatting is when we use numbers as placeholders in a string
// The numbers will then resolve into other values, based on their position

string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

// With composite formatting, we can dynamically personalize data and messages for the 
// data we are operating on while keeping thing simple and not using super long
// string interpolations

// Here are some more examples to identifty how composite formatting works
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);

Console.WriteLine("\nFormatting Currency");
// Formatting currency just requires the use of ":c" inside the composite
// formatted or string interpolated braces - This relies on the user's
// Windows Display Language

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:c}, a savings of {discount:c}!");

Console.WriteLine("\nFormatting Numbers and Percentages");
// Formatting numbers to add commas is done with ":N" - default only shows two decimal places
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N}");
// We can also truncate the number of decimals shown by adding a number after :N
Console.WriteLine($"Measurement: {measurement:N4}");
// Percentages are the same, but using a ":P" instead
decimal tax = .36785m;
Console.WriteLine($"Tax Rate: {tax:P}\n");

// All of these can be combined in one string

decimal originalPrice = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:c2} off of the regular {1:c2} price. ",
    (originalPrice - salePrice), originalPrice);

yourDiscount += $"A discount of {((originalPrice - salePrice) / originalPrice):P2}!";

Console.WriteLine(yourDiscount);

Console.WriteLine("\nString Interpolation\n");
// We already know about string interpolation at this point

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"    Shares: {productShares:n3} Product");
Console.WriteLine($"        Sub Total: {subtotal:c}");
Console.WriteLine($"            Tax Percentage: {taxPercentage:p2}");
Console.WriteLine($"        Total Billed: {total:c}");

Console.WriteLine("\nPadding and Alignment\n");
// Padding adds spaces (if called with one argument) or the input character in the second 
// argument so that the final character is at the space identified in the first argument

string input = "Pad This";

Console.WriteLine( input );
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);
Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);

Console.WriteLine("\n========== Challenge - Create a Letter ==========\n");
// The purpose of this challenge is to create a personalized letter using string interpolation

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

string intro = $"Dear {customerName},";
string lineOne = $"As a customer of our {currentProduct} offering we are excited to tell you " +
    "about a new financial product that would dramatically increase your return.\n";

string lineTwo = $"Currently you own {currentShares:N} shares at a return of {currentReturn:P2}\n";

string lineThree = $"Our new product, {newProduct} offers a return of {newReturn:p2}.  " +
    $"Given your current volume, your potential profit would be {newProfit:c}.\n";

Console.WriteLine(lineOne + "\n" + lineTwo + "\n" + lineThree);

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage += currentProduct.PadRight(21);
comparisonMessage += $"{ currentReturn:p2}".PadRight(9);
comparisonMessage += $"{currentProfit:c}".PadRight(20);

comparisonMessage += "\n" + newProduct.PadRight(21);
comparisonMessage += $"{newReturn:p2}".PadRight(9);
comparisonMessage += $"{newProfit:c}".PadRight(20);

Console.WriteLine(comparisonMessage);

// Product pad right 21
// Percent pad right 9
// Profit pad right 20
//Magic Yield         12.75%   $55,000,000.00      
