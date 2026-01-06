// Created while following along with the Microsoft Learn Course:
// Convert data types using casting and conversion techniques in C#
// in conjunction with the freeCodeCamp certification

// Medical Intake Form Automation
// We want an application to collect patient data entered by a medical technician
// All data entered will be strings, but some may need to be converted to other types of data

// Exceptions when converting data types
using System.Security.Cryptography.X509Certificates;

int first = 2;
string second = "4";
// Int will throw an error because the data types are incompatible for the addition operations
// int result = first + second;
// String variable + operator is concatenation, so the result is "24"
string result = first + second;
Console.WriteLine(result);

// Widening and Narrowing
// Widening means converting from a value type that holds less data to one that holds more

int myInt = 3;
Console.WriteLine(myInt);
decimal myDecimal = myInt;
Console.WriteLine(myDecimal);

// Narrowing is the same but going from more data to less

decimal myDecimal2 = 3.14m;
Console.WriteLine(myDecimal2);
int myInt2 = (int)myDecimal2;
Console.WriteLine(myInt2);

decimal myDecimal3 = 1.23456789m;
Console.WriteLine(myDecimal3);

float myFloat = (float)myDecimal3;
Console.WriteLine(myFloat);

// Note the (dataType)variable structure
// this is known as CASTING because you are casting a new data type onto an existing variable
// and storing that result in a new variable (or maybe using it in a different line)

// Conversions
// Conversions between strings and integers do not happen using the casting methods
// They happen using the ToString() and Parse() functions

int firstInt = 2;
int secondInt = 3;
string messageInt = first.ToString() + second.ToString();
Console.WriteLine(messageInt);

string firstString = "5";
string secondString = "6";
int resultString = int.Parse(firstString) + int.Parse(secondString); 
Console.WriteLine(resultString);

// You can also use the Convert Class

int convertString = Convert.ToInt32(firstString) * Convert.ToInt32(secondString);
Console.WriteLine(convertString);

// Comparing Casting vs converting
// Casting truncates
// Converting Rounds

int value = (int)1.5m;
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.4m);
Console.WriteLine(value2);

// Parse vs TryParse
// Parse is good for converting data types that we know will convert

string name = "Bob";
// This will fail because the name is not able to be forced into an integer
// Console.WriteLine(int.Parse(name));

// TryParse is Parse with a built in error handling
// The input is passed like Parse, the returned value is a boolean to
// identify successful parsing (True) or failures (False)
// and the converted output is passed as an "out" variable

string temperature = "102";
int tryParseResult = 0;
if (int.TryParse(temperature, out tryParseResult))
{
    Console.WriteLine($"Measurement: {tryParseResult}");
}
else
{
    Console.WriteLine("Unable to report the measurement");
}
if (tryParseResult > 0)
{
    Console.WriteLine($"Offset Measurement: {50 + tryParseResult}");
}

Console.WriteLine("\n========== Challenge 1 ==========");
// Given an array of strings, we want to concatenate strings and return 
// the value of all numbers added up

string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string concatenatedStrings = "";
float addedNumbers = 0;

foreach(string item in  values)
{
    float output = 0;
    if (float.TryParse(item, out output))
    {
        addedNumbers += output; 
    }
    else
    {
        concatenatedStrings += item;
    }
}
Console.WriteLine($"Message: {concatenatedStrings}");
Console.WriteLine($"Total: {addedNumbers}");

Console.WriteLine("\n========== Challenge 2 ==========");
int cValue1 = 11;
decimal cValue2 = 6.2m;
float cValue3 = 4.3f;

decimal result1 = (decimal)cValue1 / cValue2;
result1 = Convert.ToInt32(result1);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = cValue2 / (decimal)cValue3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = cValue3 / (float)cValue1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
