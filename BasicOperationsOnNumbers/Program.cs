// Course file for the Microsfot Learn Module:
// Perform basic operations on numbers in C#
// Done in concurrence with the freeCodeCamp certification


Console.WriteLine("========== Plus ==========");
// Addition is performed using the + operator
// The + operator can also be used to concatenate strings

int firstNumber = 12;
int secondNumber = 5;
int sum = firstNumber + secondNumber;
Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {sum}.");

string firstName = "Matt";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
// If we try and add a number in that string, it will be treated as a string and concatenate
Console.WriteLine(firstName + " sold " + widgetsSold + 3 + " widgets.");
// However, if we put the number and plus operator in parentheses,
// it will be treated as a number and added
Console.WriteLine(firstName + " sold " + (widgetsSold + 3) + " widgets.");
// It is generally recommended to not attempt concatenation and calculations in the same statement

Console.WriteLine("\n========== Math Operations ==========");

int x = 10;
int y = 3;
int addition = x + y;          // 13
int subtraction = x - y;       // 7
int multiplication = x * y;    // 30
decimal division = (decimal)x / y;        // 3.3333...
// Note: To get a decimal result, at least one operand must be a decimal

Console.WriteLine($"Addition: {addition}");
Console.WriteLine($"Subtraction: {subtraction}");
Console.WriteLine($"Multiplication: {multiplication}");
Console.WriteLine($"Division: {division}");

int modulus = x % y;          // 1
Console.WriteLine($"Modulus: {modulus}");

// There is no exponentiation operator in C#
// PEMDAS applies in C# as in standard mathematics
int value1 = 3 + 4 * 5;  
int value2 = (3 + 4) * 5;
Console.WriteLine($"Without parentheses: {value1}"); // 23
Console.WriteLine($"With parentheses: {value2}");    // 35

Console.WriteLine("\n========== Increment and Decrement ==========");
// Incrementing increases a number by 1
// Incrementing can be done using the ++ operator
// Incrementing by a value greater than 1 can be done using the += operator
int incrementNumber = 7;
Console.WriteLine($"Initial value: {incrementNumber}");
incrementNumber++;
Console.WriteLine($"After incrementing by 1: {incrementNumber}");
incrementNumber += 3;
Console.WriteLine($"After incrementing by 3: {incrementNumber}");

// Decrementing decreases a number by 1
// Decrementing can be done using the -- operator
// Decrementing by a value greater than 1 can be done using the -= operator
int decrementNumber = 10;
Console.WriteLine($"\nInitial value: {decrementNumber}");
decrementNumber--;
Console.WriteLine($"After decrementing by 1: {decrementNumber}");
decrementNumber -= 4;
Console.WriteLine($"After decrementing by 4: {decrementNumber}");

// The position of the increment/decrement operator matters
int a = 5;
Console.WriteLine($"\nInitial value of a: {a}");
Console.WriteLine($"Using postfix increment (a++): {a++}"); // Outputs 5, then increments
Console.WriteLine($"Value of a after postfix increment: {a}"); // Outputs 6
Console.WriteLine($"Using prefix increment (++a): {++a}"); // Increments to 7, then outputs 7

Console.WriteLine("\n========== Convert Farenheit to Celsius ==========");
// Formula: Celsius = (Farenheit - 32) * 5 / 9
int farenheit = 94;
decimal celsius = (farenheit - 32) * (5m / 9m);
Console.WriteLine($"{farenheit}°F is equal to {celsius:F2}°C.");
