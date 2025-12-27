// See https://aka.ms/new-console-template for more information

int a = 10;
int b = 20;
int c = a + b;
Console.WriteLine($"The sum of {a} and {b} is {c}");

Console.WriteLine(a * b);
int biggie = 2147483647;
Console.WriteLine($"The biggest integer we can store in an integer variable is {biggie}");

long biggerThanBiggie = 2147483648;
Console.WriteLine($"However, we can store a number bigger than that in a 'long' variable: " +
    $"{biggerThanBiggie}");

// If the numbers are going to be bigger than integers, just cast them as longs from the start
// You can also do this by calling the variable as (long)variable if they are already defined
// You can also use the checked keyword to force an overflow exception --> checked(a+b)
// You can also use the checked keyword to force an overflow exception --> checked(a+b)
// Also Big Integer for really really big numbers. Called a "long long" in C++

// Floats are for decimal numbers

float floatPi = 3.14f; // f suffix is required for floats

// Doubles are for bigger decimal numbers
// Doubles are essentially the long of floats
// Doubles are the default for decimal numbers in C#
double doublePi = 3.141592653589793;

float d = 1.1f;
float e = 2.2f;
Console.WriteLine($"The sum of Float {d} and {e} is {d + e}");
double f = 1.1;
double g = 2.2;
Console.WriteLine($"The sum of Double {f} and {g} is {f + g}");

// These both provide slightly wierd results due to how they are stored in memory
// Use decimal for financial calculations to avoid these issues
// Since decimal has a higher precision and a smaller range than float and double
// it does take slightly more memory and is a bit slower to compute with

decimal h = 1.1m; // m suffix is required for decimals
decimal i = 2.2M; // Suffix can be upper or lower case
Console.WriteLine($"The sum of Decimal {h} and {i} is {h + i}");