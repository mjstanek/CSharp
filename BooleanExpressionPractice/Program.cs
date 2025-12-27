// Created following along with the Microsoft Learn Course:
// Evaluate Boolean expressions to make decisions in C#
// In concurrence with the freeCodeCamp certification

// Boolean values are True or False
// Boolean values are used in the If-Else If-Else statements to determine
// Which block of code to execute next

//The equality operator is "=="
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

// Boolean expressions can combine variables and literals
string myValue = "a";
Console.WriteLine(myValue == "a");

// This will return false as the trailing space is counted
Console.WriteLine("a" == "a ");

// When accepting user or unsanitized input, it helps to format the 
// data so that comparisons are one to one

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Inequality is indicated as "!="
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

/* Other operators:
 * > is Greater Than
 * < is Less Than
 * >= is Greater Than or Equal To
 * <= is Less Than or Equal To
 */

// Some methods will retun a Boolean value

string panagram = "The quick brown fox jumped over the lazy dog.";
Console.WriteLine(panagram.Contains("fox"));
Console.WriteLine(panagram.Contains("cow"));

// These methods can also be utilized with the negation operator as such
Console.WriteLine(!panagram.Contains("fox"));
Console.WriteLine(!panagram.Contains("cow"));

/* Aside
 * Inequality is not the same as logical negation
 * "a" does not equal "b", so therefore the output of 
 * "a" != "b" and !("a" == "b") is functionally the same
 * these are two different operations
 */

// Conditional Operator --> ?:
// Essentially a one-line if-else
// Syntax:
// condition ? value returned if true : value returned if false

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

Console.WriteLine("\n========== Challenge ==========");

Random coinFlip = new Random();
Console.WriteLine($"The coin landed on {(coinFlip.Next(2) == 0 ? "heads" : "tails")}.");

string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    Console.WriteLine(level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.");
}
else if (permission.Contains("Manager"))
{
    Console.WriteLine(level >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.");
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}