// Created while following along with the Microsoft Learn Course
// Add looping logic to your code using the do-while and while statements in C#
// in concurrence with the freeCodeCamp certification

// Do While Loops
// The Do While loop will execute a block of code and then evaluate a Boolean
// expression to determine if the loop needs to continue. A key point is that
// the format of a Do-While loop means that the code block will always execute 
// at least one time.

bool flag = false;

do
{
    // Code to exectue
} while (flag);

// Since the flag is false, the code will execute, check if the flag is true, and continue to 
// execute if it is, or stop execution and move on if not

Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);
    // The continue statement means that the code will continue straight past all the other code
    // in the code block and immediately run the Boolean evaluation. In this instance, that means
    // that any random number greater than or equal to 8 will not be printed.
    // Another statement to be aware of is the break statement. Break in a loop will stop the loop
    // execution immediately. So if this statement was break, any number greater than or equal to
    // 8 would immedaitely end the execution of the loop.
    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);
/*
// A While loop, however, will evaluate the Boolean expression and then
// determine if the loop is needed

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/
// This means that if the variable current is initialized as 1 or 2, the code in
// the while loop will not execute ever.

Console.WriteLine("\n========== Challenge - Monster Hunter ==========\n");

Random damage = new Random();

int monsterHealth = 10;
int heroHealth = 10;
int attack = 0;
int counter = 1;

while (monsterHealth > 0 && heroHealth > 0)
{
    attack = damage.Next(1, 11);
    if (counter % 2 != 0)
    {
        monsterHealth -= attack;
        Console.WriteLine($"The monster was dealt {attack} damage and now has {monsterHealth} health.");
    }
    else
    {
        heroHealth -= attack;
        Console.WriteLine($"The hero was hit for {attack} damage and now has {heroHealth} health.");
    }
    counter++;
}
if (monsterHealth <= 0)
{
    Console.WriteLine($"The hero prevailed with {heroHealth} remaining!");
}
else
{
    Console.WriteLine($"Oh no! The monster has slain our hero! The monster had {monsterHealth} remaining.");
}

Console.WriteLine("\n========== Challenge - Validate Integer Input ==========\n");

// This challenge is to validate user input and ensure they are entering a number
// between 5 and 10.

string? inputResult;
Console.WriteLine("Please enter a number between 5 and 10:");
int numberOutput = 0;
bool validInput = false;
bool exitLoop = false;

do
{
    inputResult = Console.ReadLine();
    if (inputResult == null)
    {
        Console.WriteLine("C'mon homie, at least enter SOMETHING...");
    }
    else
    {
        validInput = int.TryParse(inputResult, out numberOutput);
        if (validInput)
        {
            if (numberOutput >= 5 && numberOutput <= 10)
            {
                Console.WriteLine($"Your input of '{numberOutput}' is accepted!");
                exitLoop = true;
            }
            else
            {
                Console.WriteLine("You are so close to following instructions. This time, enter a number" +
                    " between 5 and 10.");
            }
        }
        else
        {
            Console.WriteLine("You did not enter a number. Please try to enter a number this time.");
        }
    }
} while (exitLoop == false);

Console.WriteLine("\n========== Challenge - Validate String Input ==========\n");

// This challenge is to validate user input and ensure that they are
// entering a valid job title.

string[] roles = { "administrator", "manager", "user" };
Console.WriteLine("Please enter your Job Title: ");
string? roleInput;
bool invalidString = true;

while(invalidString)
{
    roleInput = Console.ReadLine().Trim();
    if (roleInput != null)
    {
        if (roles.Contains(roleInput.ToLower()))
        {
            Console.WriteLine($"Your Job Title - {roleInput} - is valid.");
            invalidString = false;
        }
        else
        {
            Console.WriteLine($"You entered the invalid Job Title '{roleInput}'. Please try again.");
        }
    }
}

Console.WriteLine("\n========== Challenge - Contents of String Array ==========");

// This challenge is to loop over items in a string array and to identify any
// instances of a period (.). If a period exists, the loop must remove it and print the next 
// sentence on its own line.

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", 
    "I like all three of the menu choices" };

string myString = "";
int periodLocation = 0;

for (int i = 0; i < myStrings.Length; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    while (periodLocation != -1)
    {

        mySentence = myString.Remove(periodLocation);
        myString = myString.Substring(periodLocation + 1);
        myString = myString.TrimStart();
        periodLocation = myString.IndexOf(".");
        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
