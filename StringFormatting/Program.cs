// Code built while following along with the Microsoft Learn Module:
// Perform basic string formatting in C#
// In concurrence with the FreeCodeCamp certification

// Learning Objectives:
// Create strings containing tabs, new lines, and other special characters
// Create string data containing Unicode Characters
// Combine String Data into a new string value via contactenation
// Combine String Data into a new string value via interpolation

Console.WriteLine("========== Escape Characters ==========");
//Unmodified String
Console.WriteLine("Hello World!");
// '\n' will create a new line while printing to terminal
Console.WriteLine("Hello \nWorld!");
// '\t' will insert a 'tab' spacing into the text
Console.WriteLine("Hello \tWorld!");
// If you need to use the double quotation mark in a string, you must "escape" it first:
// The escape character is the backslash --> \
// Console.WriteLine("Hello "World"!"); will produce an error
Console.WriteLine("Hello \"World\"!");
// In order to print a single backslash, you must escape it by using a double backslash
Console.WriteLine("C:\\source\\repos");

Console.WriteLine("\n========== Invoice Mockup ==========");
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.Write("\nOutput Directory:\t");

// Verbatim string literal
// Verbatim strings will keep all whitespace and characters without escaping
// Verbatim strings are identified but using the @ symbol before the quotations
//Console.WriteLine(@"   c:\source\repos
//(this is where your code goes)");

Console.Write(@"c:\invoices");

Console.WriteLine("\n\n========== Unicode and Kanji ==========");
// Unicode characters are identified as \u(character code)
// So to print Kanji "Konichiwa World" is
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059" +
    "\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

Console.WriteLine("\n========== Concatentation ==========");
// Concatenation is essentially "adding" strings together to make a new string
string firstName = "Matt";
string welcomeMessage = "Hello " + firstName;
Console.WriteLine(welcomeMessage);

string greeting = "Howdy";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message);
// we can also just concatenate directly into the WriteLine
Console.WriteLine(greeting + " " + firstName + "!");

Console.WriteLine("\n========== Interpolation ==========");
// Interpolation is an easier method than concatenation to display data
// that contains multiple variables. It is identified by using the "$"
// before the quotation marks. The variable names are then put into
// curly braces {} and their values are called.

string interpolatedMessage = $"{greeting} {firstName}!";
Console.WriteLine(interpolatedMessage);

// Again, you can interpolate right where you need the output
int windowsVersion = 11;
string updateText = "Upgrade to Windows";
Console.WriteLine($"{updateText} {windowsVersion}");

// Verbatim and Interpolated strings can be combined in one call
// Note: the order of $ and @ does not matter
string projectName = "First-Coding-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
Console.WriteLine(@$"C:\Output\{projectName}\Data");

Console.WriteLine("\n========== Challenge ==========");
// The challenge is to print instructions to a user to let them know where
// the application will output data files in English and Russian

string challengeProjectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c " +
    "\u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($@"View English Output:
   c:\Exercise\{challengeProjectName}\data.txt");
Console.WriteLine($@"{russianMessage}:
   c:\Exercise\{challengeProjectName}\ru-RU\data.txt");