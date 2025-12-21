// Coursework for Microsoft Learn Module:
// Store and retrieve data using literal and variable values in C#
// As part of the FreeCodeCamp curriculum

/* Note Block
 * Values that are hard-coded and non-changing are called literals.
 * Literals can also be called constants.
 * Variables are used to store data that can change during program execution.
 * Variables can be set, modified, and retrieved as needed throughout the execution.
 * Literals/Constants are snapshots of data that are fixed in the code.
 * Variables are drawers that can have different items put in and taken out as needed.
 */
Console.WriteLine("========== Literals ==========");

// A single alphanumeric character can be stored in a char literal by using single quotes.
Console.WriteLine('b');
// Any more than a single character in single quotes will cause a run time error
//Console.WriteLine('bc'); 
// Therefore, one quote = one character
// Double quotes = multiple characters (string literal)

// Whole numbers can be displayed as integers.
Console.WriteLine(1234);

// Numbers with a decimal point can be displayed in three different forms:
// As a float by using the suffix 'f'.
// As a double - which is the default and does not require a suffix.
// As a decimal by using the suffix 'm'.
// Each of these forms has different levels of precision and storage requirements.
// Float is precise to between 6-9 digits
// Double is precise to about 15-17 digits
// Decimal is precise to 28-29 digits.
// The difference may not be obvious when displaying literals,
// but it becomes very important when performing calculations

Console.WriteLine(12.34f);   // Float literal
Console.WriteLine(12.34);    // Double literal
Console.WriteLine(12.34m);   // Decimal literal

// Boolean literals represent true or false values.
Console.WriteLine(true);
Console.WriteLine(false);

// Data may look the same during presentation, but the way it is stored and handled
// by the program can be very different depending on its type.

Console.WriteLine("-----");
Console.WriteLine("123" + " --> String");
Console.WriteLine(123 + " --> Integer"); 
Console.WriteLine("True" + " --> String"); 
Console.WriteLine(true + " --> Boolean");

Console.WriteLine("\n========== Variables ==========");
// Variables have naming conventions to be aware of:
// 1. Variable names can only contain letters, numbers, and underscores.
// Special characters like spaces, hyphens, and punctuation are not allowed.
// 2. Variable names cannot start with a number. They can start with an underscore.
// 3. Variable names are case-sensitive. "myVariable" and "MyVariable" are different variables.
// 4. Variable names cannot be a reserved keyword in C# like "int", "class", or "return".
// There are some best practices for naming variables:
// 1. Use meaningful names that describe the purpose of the variable.
// 2. Use camelCase for local variables and parameters (e.g., myVariable).
// 3. Use PascalCase for class names and public properties (e.g., MyClass).
// 4. Beginning a variable name with an underscore is generally discouraged
// unless following a specific coding standard.
// 5. Avoid using single-character variable names except for loop counters
// or very short-lived variables in small scopes.
// 6. It is generally considered best practice to avoid using Hungarian notation
// (prefixing variable names with their type, like "strName" for a string variable).

// C# requires variables to be declared with a specific data type.
string firstName;
firstName = "Matt";

// Variables can be declared and initialized in a single statement.
string message = "Hello, World!";
Console.WriteLine(message);

// Data stored in a variable must match the variable's data type.
int age = 30;
// This will cause a compile-time error
// int invalidAge = "thirty"; 


// As stated earlier, variables can be modified after they are declared.
Console.WriteLine("Initial age: " + age);
age = 31;
Console.WriteLine("Updated age: " + age);

// Using the keyword 'var', the compiler can infer the data type
var city = "Tampa";
// This will cause a compile-time error because 'city' was created and set as a string
// city = 123;
// The 'var' keyword can only be used when the variable is declared and initialized in the same statement.
// This will cause a compile-time error
// var country;

Console.WriteLine("\n========== Challenge ==========");
// Create three variables to store a name, a number of emails
// in an inbox, and a decimal to display the temperature.
// Then display those variables in the console in a coherent message.

string name = "Bob";
int emailCount = 3;
float temperatureCelsius = 34.4f;

Console.WriteLine($"Hello {name}! You currently have {emailCount} unread emails" +
    $" in your inbox. The current temperature outside is {temperatureCelsius} Celsius.");