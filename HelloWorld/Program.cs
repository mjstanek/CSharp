// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");

string firstFriend = "Alice";
string secondFriend = "Cooper";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}.");

Console.WriteLine($"{firstFriend} has {firstFriend.Length} letters in their name");
Console.WriteLine($"{secondFriend} has {secondFriend.Length} letters in their name");

if (firstFriend.Length > secondFriend.Length)
{
    Console.WriteLine($"{firstFriend} has a longer first name than {secondFriend}");
}
else if (firstFriend.Length < secondFriend.Length)
{
    Console.WriteLine($"{secondFriend} has a longer name than {firstFriend}");
}
else
{
    Console.WriteLine($"{firstFriend} and {secondFriend} have the same length first name");
}

string spacedGreeting = "   Bone Jaw    ";
Console.WriteLine($"Here is the spaced greeting: [{spacedGreeting}]");
string trimmedGreetingStart = spacedGreeting.TrimStart();
Console.WriteLine($"This is with Trim Start: [{trimmedGreetingStart}]");
string trimmedGreetingEnd = spacedGreeting.TrimEnd();
Console.WriteLine($"This is with Trim End: [{trimmedGreetingEnd}]");
string trimmedGreeting = spacedGreeting.Trim();
Console.WriteLine($"This is with full Trim: [{trimmedGreeting}]");

string excitedGreeting = "Hello World!";
Console.WriteLine(excitedGreeting);
// Replace only returns the modified string
Console.WriteLine(excitedGreeting.Replace("!", "!!!"));
// Replacing into a new variable will maintain the replaced message
string doctorNickGreeting = excitedGreeting.Replace("World", "Everybody").Replace("Hello", "Hi");
Console.WriteLine(doctorNickGreeting);
// This will return the same as the first print
Console.WriteLine(excitedGreeting);

string longPhrase = "This phrase is a long phrase to help show contains, starts, and ends with";
Console.WriteLine(longPhrase);
Console.WriteLine($"Does it begin with 'This'? \n{longPhrase.Contains("This")}");
Console.WriteLine($"Does it contain 'This'? \n{longPhrase.Contains("This")}");
Console.WriteLine($"Does it end with 'This'? \n{longPhrase.EndsWith("This")}");
