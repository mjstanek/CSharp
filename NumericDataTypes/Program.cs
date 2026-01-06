// Created while following along with the Microsoft Learn Course:
//Choose the correct data type in your C# code
// while completeing the freeCodeCamp certifiation

// Integers 
// Integer types can store whole numbers
// there are a few different types of integers:

Console.WriteLine("Signed Integral Types:");

Console.WriteLine($"sbyte: {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short: {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int: {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long: {long.MinValue} to {long.MaxValue}");

// In the vast majority of cases, int is sufficient

Console.WriteLine("\nUnsigned Integral Types:");

Console.WriteLine($"byte: {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort: {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint: {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong: {ulong.MinValue} to {ulong.MaxValue}");

// It is plain to see that the unsigned types have the same range,
// but start at 0, instead of being centered around 0

// Non-whole numbers
// These numbers all have varying levels of accuracy due to how
// they are stored and processed in the memory

Console.WriteLine("\nFloating Point Types:");

Console.WriteLine($"float: {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double: {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// Floats and Doubles are stored in binary, while Decimals are stored in base 10
// That means high precision events MUST be calculated in Decimal

// Reference Types
// Include Arrays, Classes, Strings
// typically identified with the "new" operator

int[] data = new int[3];

// This is a reference type because it creates a new object to reference
// using the variable data, we can access the array of 3 numbers
// Below will show more ideas of reference objects

int value1 = 2;
int value2 = value1;
value2 = 5;

Console.WriteLine("\n" + value1);
Console.WriteLine(value2);

// Above the variables are used to store values, so the reference is to the value

int[] reference1 = new int[1];
reference1[0] = 2;
int[] reference2 = reference1;
reference2[0] = 5;

Console.WriteLine("\nRefence Variables");
Console.WriteLine($"Reference 1 = {reference1[0]}");
Console.WriteLine($"Reference 2 = {reference2[0]}");

// This example shows that, while the value reassigment happened to Ref2, Ref2 is just 
// another name by which the system can identify the array created as Ref1
